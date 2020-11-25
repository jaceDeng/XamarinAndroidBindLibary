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

namespace AppTBS.Droid
{
    [Application]
    public class MApplication : Android.App.Application
    { 
        protected MApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        public override void OnCreate()
        {
            Com.Tencent.Smtt.Sdk.QbSdk.InitX5Environment(this,null);
            //Com.Tencent.Bugly.Bugly.Init(this.ApplicationContext, APP_ID, false);
            base.OnCreate();
        }
    }

}