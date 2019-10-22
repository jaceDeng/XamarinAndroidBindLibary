using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using static Android.Provider.MediaStore;
using Com.Baidu.Android.Pushservice;

namespace BaiduPushDemo.Droid
{
    [Activity(Label = "BaiduPushDemo",     MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity :  Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            //  Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //LoadApplication(new App());
            //BaiduPushReceiver.InitializeBaiduPushManager(this);
            // InitBuilder(this);

        }



        
    }
}