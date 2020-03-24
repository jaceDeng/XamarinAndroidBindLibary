using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Text;

namespace yufeng.XST
{

    //using Activity = Android.app.Activity;
    //using BroadcastReceiver = Android.content.BroadcastReceiver;
    //using Context = Android.content.Context;
    //using Intent = Android.content.Intent;
    //using IntentFilter = Android.content.IntentFilter;
    //using Bundle = Android.os.Bundle;
    //using View = Android.view.View;
    //using OnClickListener = Android.view.View.OnClickListener;
    //using Button = Android.widget.Button;
    //using EditText = Android.widget.EditText;
    //using TextView = Android.widget.TextView;
    //using Toast = Android.widget.Toast;

    using JPushInterface = CN.Jpush.Android.Api.JPushInterface;


    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private Button mInit;
        private Button mSetting;
        private Button mStopPush;
        private Button mResumePush;
        private Button mGetRid;
        private TextView mRegId;
        private EditText msgText;

        public static bool isForeground = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(JPush.Resource.Layout.main);
            initView();
            registerMessageReceiver(); // used for receive msg
        }

        private void initView()
        {
            TextView mImei = (TextView)FindViewById(JPush.Resource.Id.tv_imei);
            string udid = ExampleUtil.getImei(ApplicationContext, "");
            if (null != udid)
            {
                mImei.Text = "IMEI: " + udid;
            }

            TextView mAppKey = (TextView)FindViewById(JPush.Resource.Id.tv_appkey);
            string appKey = ExampleUtil.getAppKey(ApplicationContext);
            if (null == appKey)
            {
                appKey = "AppKey异常";
            }
            mAppKey.Text = "AppKey: " + appKey;

            mRegId = (TextView)FindViewById(JPush.Resource.Id.tv_regId);
            mRegId.Text = "RegId:";

            string packageName = PackageName;
            TextView mPackage = (TextView)FindViewById(JPush.Resource.Id.tv_package);
            mPackage.Text = "PackageName: " + packageName;

            string deviceId = ExampleUtil.getDeviceId(ApplicationContext);
            TextView mDeviceId = (TextView)FindViewById(JPush.Resource.Id.tv_device_id);
            mDeviceId.Text = "deviceId: " + deviceId;

            string versionName = ExampleUtil.GetVersion(ApplicationContext);
            TextView mVersion = (TextView)FindViewById(JPush.Resource.Id.tv_version);
            mVersion.Text = "Version: " + versionName;

            mInit = (Button)FindViewById(JPush.Resource.Id.init);
            mInit.Click += OnClick;
            mStopPush = (Button)FindViewById(JPush.Resource.Id.stopPush);

            mStopPush.Click += OnClick;
            mResumePush = (Button)FindViewById(JPush.Resource.Id.resumePush);

            mResumePush.Click += OnClick;
            mGetRid = (Button)FindViewById(JPush.Resource.Id.getRegistrationId);

            mGetRid.Click += OnClick;
            mSetting = (Button)FindViewById(JPush.Resource.Id.setting);

            mSetting.Click += OnClick;
            msgText = (EditText)FindViewById(JPush.Resource.Id.msg_rec);
            
        }



        public void OnClick(object sender, System.EventArgs e)
        {
            View v = sender as View;
            switch (v.Id)
            {
                case JPush.Resource.Id.init:
                    init();
                    break;
                case JPush.Resource.Id.setting:
                    //Intent intent = new Intent(MainActivity.this, typeof(PushSetActivity));
                    //startActivity(intent);
                    break;
                case JPush.Resource.Id.stopPush:
                    JPushInterface.StopPush(ApplicationContext);
                    break;
                case JPush.Resource.Id.resumePush:
                    JPushInterface.ResumePush(ApplicationContext);
                    break;
                case JPush.Resource.Id.getRegistrationId:
                    string rid = JPushInterface.GetRegistrationID(ApplicationContext);
                    if (rid.Length > 0)
                    {
                        mRegId.Text = "RegId:" + rid;
                    }
                    else
                    {
                        Toast.MakeText(this, "Get registration fail, JPush init failed!", ToastLength.Short).Show();
                    }
                    break;
            }
        }

        // 初始化 JPush。如果已经初始化，但没有登录成功，则执行重新登录。
        private void init()
        {
            JPushInterface.Init(ApplicationContext);
        }


        protected override void OnResume()
        {
            isForeground = true;
            base.OnResume();
        }


        protected override void OnPause()
        {
            isForeground = false;
            base.OnPause();
        }


        protected override void OnDestroy()
        {
            //LocalBroadcastManager.getInstance(this).unregisterReceiver(mMessageReceiver);
            base.OnDestroy();
        }


        //for receive customer msg from jpush server
        private MessageReceiver mMessageReceiver;
        public const string MESSAGE_RECEIVED_ACTION = "yufeng.XST.MESSAGE_RECEIVED_ACTION";
        public const string KEY_TITLE = "title";
        public const string KEY_MESSAGE = "message";
        public const string KEY_EXTRAS = "extras";

        public virtual void registerMessageReceiver()
        {
            mMessageReceiver = new MessageReceiver(this);
            IntentFilter filter = new IntentFilter();
            filter.Priority = (int)IntentFilter.SystemHighPriority;
            filter.AddAction(MESSAGE_RECEIVED_ACTION);
            //  LocalBroadcastManager.getInstance(this).registerReceiver(mMessageReceiver, filter);
        }

        public class MessageReceiver : BroadcastReceiver
        {
            private readonly MainActivity outerInstance;

            public MessageReceiver(MainActivity outerInstance)
            {
                this.outerInstance = outerInstance;
            }


            public override void OnReceive(Context context, Intent intent)
            {
                try
                {
                    if (MESSAGE_RECEIVED_ACTION.Equals(intent.Action))
                    {
                        string messge = intent.GetStringExtra(KEY_MESSAGE);
                        string extras = intent.GetStringExtra(KEY_EXTRAS);
                        StringBuilder showMsg = new StringBuilder();
                        showMsg.Append(KEY_MESSAGE + " : " + messge + "\n");
                        if (!ExampleUtil.isEmpty(extras))
                        {
                            showMsg.Append(KEY_EXTRAS + " : " + extras + "\n");
                        }
                        outerInstance.CostomMsg = showMsg.ToString();
                    }
                }
                catch (System.Exception ex)
                {
                }
            }
        }

        private string CostomMsg
        {
            set
            {
                if (null != msgText)
                {
                    msgText.Text = value;
                    msgText.Visibility = ViewStates.Visible;// View.VISIBLE;
                }
            }
        }

    }
}