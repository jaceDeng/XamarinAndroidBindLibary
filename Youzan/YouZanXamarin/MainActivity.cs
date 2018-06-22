using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;
using Com.Youzan.Androidsdk;

namespace YouZanXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.btn_open:
                    //    店铺链接, 可以从有赞后台`店铺 => 店铺概况 => 访问店铺`复制到相应的链接
                    gotoActivity("https://h5.youzan.com/v2/showcase/homepage?alias=kewr19e1");
                    break;
                case Resource.Id.btn_clear:
                    YouzanSDK.UserLogout(this);
                    break;
                default:
                   

                    break;
            }
        }
        private void gotoActivity(System.String url)
        {
            Intent intent = new Intent(this, typeof(YouzanActivity));
            intent.PutExtra(YouzanActivity.KEY_URL, url);
            StartActivity(intent);
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            FindViewById(Resource.Id.btn_open).SetOnClickListener(this);
            FindViewById(Resource.Id.btn_clear).SetOnClickListener(this);
        }
    }
}

