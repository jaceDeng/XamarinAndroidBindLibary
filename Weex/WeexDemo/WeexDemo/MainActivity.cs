using Android.App;
using Android.Widget;
using Android.OS;
using Com.Taobao.Weex;
using Com.Taobao.Weex.Utils;
using Android.Views;

namespace WeexDemo
{
    [Activity(Label = "WeexDemo", MainLauncher = true)]
    public class MainActivity : Activity, IWXRenderListener
    {
        WXSDKInstance mWXSDKInstance;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mWXSDKInstance = new WXSDKInstance(this);
            mWXSDKInstance.RegisterRenderListener(this); 
            mWXSDKInstance.Render(WXFileUtils.LoadAsset("index.weex.js", this), -1, -1);
        }

        public void OnException(WXSDKInstance instance, string errCode, string msg)
        {

        }

        public void OnRefreshSuccess(WXSDKInstance instance, int width, int height)
        {

        }

        public void OnRenderSuccess(WXSDKInstance instance, int width, int height)
        {

        }

        public void OnViewCreated(WXSDKInstance instance, View view)
        {
            SetContentView(view);
        }
    }
}

