using Android.App;
using Android.Runtime;
using CN.Jpush.Android.Api;
using System;

namespace yufeng.XST
{
    //using Application = Android.app.Application;
    //using JPushInterface = cn.jpush.Android.api.JPushInterface;

    /// <summary>
    /// For developer startup JPush SDK
    /// 
    /// 一般建议在自定义 Application 类里初始化。也可以在主 Activity 里。
    /// </summary>
    [Application]
    public class ExampleApplication : Application
    {
        private const string TAG = "JIGUANG-Example";
        protected ExampleApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        public override void OnCreate()
        {
            Logger.d(TAG, "[ExampleApplication] onCreate");
            base.OnCreate();

            JPushInterface.SetDebugMode(true); // 设置开启日志,发布时请关闭日志
            JPushInterface.Init(this); // 初始化 JPush
        }
    }

}