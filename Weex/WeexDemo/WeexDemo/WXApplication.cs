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
using Com.Taobao.Weex.Dom;

namespace WeexDemo
{
    [Application]
    public class WXApplication : Application
    {

        public WXApplication(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {

        }


        public override void OnCreate()
        {

            base.OnCreate();
            Com.Taobao.Weex.InitConfig config = new Com.Taobao.Weex.InitConfig.Builder().SetImgAdapter(new ImageAdapter()).Build();
            Com.Taobao.Weex.WXSDKEngine.Initialize(this, config);
        }

    }

    public class ImageAdapter : Java.Lang.Object, Com.Taobao.Weex.Adapter.IWXImgLoaderAdapter
    {
        public void SetImage(string url, ImageView view,  WXImageQuality quality, Com.Taobao.Weex.Common.WXImageStrategy strategy)
        {

            Square.Picasso.Picasso.With(view.Context).Load(url).Into(view);
            //if (!TextUtils.isEmpty(url))
            //{
            //    if (url.startsWith("drawable://"))
            //    {
            //        getImageBydrawableName(view, url);//获取drawable图片
            //        return;
            //    }
            //}
            //Picasso.with(view.getContext()).load(url).into(view);//获取网络图片
        }
    }
};