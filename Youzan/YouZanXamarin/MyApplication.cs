using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Youzan.Androidsdk;
using Com.Youzan.Androidsdk.Basic;

namespace YouZanXamarin
{
    [Application]
    public class MyApplication : Application
    {
        protected MyApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        public override void OnCreate()
        {
            base.OnCreate();

            // 初始化SDK
            YouzanSDK.Init(this, "client_id", new YouzanBasicSDKAdapter());

            // 预取html，注：当发生重定向时，预取不生效
            YouzanPreloader.PreloadHtml(this, "https://h5.youzan.com/v2/showcase/homepage?alias=kewr19e1");
        }
    }

}