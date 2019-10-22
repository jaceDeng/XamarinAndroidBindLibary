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
using Com.Baidu.Android.Pushservice;

namespace BaiduPushDemo.Droid
{
    [Application(Name = "com.baidu.push.app.MainApplication")]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
            // Log.d(TAG, "onCreate");
            PushManager.StartWork(ApplicationContext, PushConstants.LoginTypeApiKey,
                    "hhN9CFi3gZPpm9LD5szBT8hn");
        }
    }
}