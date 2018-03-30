using Android.App;
using Android.Widget;
using Android.OS;
using Com.Tencent.Android.Tpush;
using Android.Util;

namespace XinGeDemo
{
    [Activity(Label = "XinGeDemo", Name = "com.mingx.xgdemo.MainActivity", MainLauncher = true)]
    public class MainActivity : Activity, Com.Tencent.Android.Tpush.IXGIOperateCallback
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            XGPushConfig.EnableDebug(this, true);
            XGPushManager.RegisterPush(ApplicationContext, this);
            XGPushManager.BindAccount(ApplicationContext, "XINGE");
            var str = XGPushConfig.GetToken(ApplicationContext);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        public void OnFail(Java.Lang.Object data, int flag, string message)
        {
            Log.Error("TPush", "注册识别，设备token为：" + data);
        }

        public void OnSuccess(Java.Lang.Object data, int flag)
        {
            Log.Debug("TPush", "注册成功，设备token为：" + data);
        }
    }
}

