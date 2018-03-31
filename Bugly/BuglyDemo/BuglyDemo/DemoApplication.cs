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

namespace BuglyDemo
{
    public class DemoApplication : Android.App.Application
    {
        public const string APP_ID = "请输入你的ID";
        protected DemoApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        public override void OnCreate()
        { 
            Com.Tencent.Bugly.Bugly.Init(this.ApplicationContext, APP_ID, false);
            base.OnCreate();
            throw new Exception("APP_ID = \"请输入你的ID\";");
        }
    }
}