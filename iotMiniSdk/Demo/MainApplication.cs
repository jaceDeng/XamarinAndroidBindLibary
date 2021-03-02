using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Alipay.Iot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class MyAppliction : Application
    {
        public MyAppliction(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        public override void OnCreate()
        {
            base.OnCreate();
            IotDefaultTinyApp.Init(this);
        }
    }
}