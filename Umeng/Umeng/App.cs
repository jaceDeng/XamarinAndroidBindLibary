using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Com.Umeng.Commonsdk;
using Com.Umeng.Message;

namespace Umeng
{
    [Application]
    public class App : Application
    {
        public App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
            throw new Exception("请拷贝 Appkey  Umeng Message Secret");
            //友盟组件初始化
            UMConfigure.Init(this, "Appkey", "Umeng",
                UMConfigure.DeviceTypePhone,
                     "Umeng Message Secret");
            InitUpush();
        }

        private void InitUpush()
        {
            PushAgent mPushAgent = PushAgent.GetInstance(this);
            mPushAgent.Register(new UmengRegisterCallback());

        }

        public class UmengRegisterCallback : Java.Lang.Object, IUmengRegisterCallback
        {

            public void OnFailure(string p0, string p1)
            {

            }

            public void OnSuccess(string deviceToken)
            {
                string mDeviceToken = deviceToken;
            }
        }
    }
}