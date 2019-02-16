using System;
using System.ComponentModel;
using Android.App;
using Android.Content;
using Android.Widget;
using Xamarin.Forms.Internals;
using AWebView = Com.Tencent.Smtt.Sdk.WebView;
using Xamarin.Forms.Platform.Android;
using Com.Tencent.Smtt.Sdk;
using Com.Tencent.Smtt.Export.External.Interfaces;
using static Com.Tencent.Smtt.Sdk.WebSettings;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Xamarin.Forms.WebView), typeof(AppTBS.Droid.WebViewRenderer))]
namespace AppTBS.Droid
{
    public class WebViewRenderer : ViewRenderer<Xamarin.Forms.WebView, AWebView>, Xamarin.Forms.IWebViewDelegate
    {
        bool _ignoreSourceChanges;
        Com.Tencent.Smtt.Sdk.WebChromeClient _webChromeClient;

        Xamarin.Forms.IWebViewController ElementController => Element;

        public WebViewRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        [Obsolete("This constructor is obsolete as of version 2.5. Please use WebViewRenderer(Context) instead.")]
        public WebViewRenderer()
        {
            AutoPackage = false;
        }

        public void LoadHtml(string html, string baseUrl)
        {
            Control.LoadDataWithBaseURL(baseUrl == null ? "file:///android_asset/" : baseUrl, html, "text/html", "UTF-8", null);
        }

        public void LoadUrl(string url)
        {
            Control.LoadUrl(url);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Element != null)
                {
                    if (Control != null)
                        Control.StopLoading();
                    ElementController.EvalRequested -= OnEvalRequested;
                    ElementController.GoBackRequested -= OnGoBackRequested;
                    ElementController.GoForwardRequested -= OnGoForwardRequested;

                    _webChromeClient?.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        protected virtual Com.Tencent.Smtt.Sdk.WebChromeClient GetFormsWebChromeClient()
        {
            var client = new WebChromeClient(this);

            return client;
        }

        //protected override Size MinimumSize()
        //{
        //    return new Size(Context.ToPixels(40), Context.ToPixels(40));
        //}

        protected override AWebView CreateNativeControl()
        {
            var v = new AWebView(Context);
            return v;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var webView = CreateNativeControl();
#pragma warning disable 618 // This can probably be replaced with LinearLayout(LayoutParams.MatchParent, LayoutParams.MatchParent); just need to test that theory
                webView.LayoutParameters = new global::Android.Widget.AbsoluteLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent, 0, 0);
#pragma warning restore 618
                webView.WebViewClient = (new WebClient(this));

                _webChromeClient = GetFormsWebChromeClient();
                // _webChromeClient.SetContext(Context as Activity);
                webView.WebChromeClient = (_webChromeClient);
                /*
                 * 	webSetting.setAllowFileAccess(true);
		webSetting.setLayoutAlgorithm(LayoutAlgorithm.NARROW_COLUMNS);
		webSetting.setSupportZoom(true);
		webSetting.setBuiltInZoomControls(true);
		webSetting.setUseWideViewPort(true);
		webSetting.setSupportMultipleWindows(false);
		// webSetting.setLoadWithOverviewMode(true);
		webSetting.setAppCacheEnabled(true);
		// webSetting.setDatabaseEnabled(true);
		webSetting.setDomStorageEnabled(true);
		webSetting.setJavaScriptEnabled(true);
		webSetting.setGeolocationEnabled(true);
		webSetting.setAppCacheMaxSize(Long.MAX_VALUE);
		webSetting.setAppCachePath(this.getDir("appcache", 0).getPath());
		webSetting.setDatabasePath(this.getDir("databases", 0).getPath());
		webSetting.setGeolocationDatabasePath(this.getDir("geolocation", 0)
				.getPath());
		// webSetting.setPageCacheCapacity(IX5WebSettings.DEFAULT_CACHE_CAPACITY);
		webSetting.setPluginState(WebSettings.PluginState.ON_DEMAND);
                 */

                webView.Settings.AllowFileAccess = true;
                webView.Settings.SetLayoutAlgorithm(LayoutAlgorithm.NarrowColumns);
                // webView.Settings.SetSupportZoom(true);
                //  webView.Settings.BuiltInZoomControls = true;
                webView.Settings.UseWideViewPort = true;
                webView.Settings.SetSupportMultipleWindows(false);
                //  webView.Settings.SetAppCacheEnabled(true);
                webView.Settings.SetGeolocationEnabled(true);
                //webView.Settings.SetAppCacheMaxSize(long.MaxValue);
                //webView.Settings.SetAppCachePath(this.Dir("appcache", 0).getPath());
                //webView.Settings.DatabasePath=(this.getDir("databases", 0).getPath());
                //webView.Settings.SetGeolocationDatabasePath(this.getDir("geolocation", 0)
                //        .getPath()); 

                webView.Settings.JavaScriptEnabled = true;
                webView.Settings.DomStorageEnabled = true;
                SetNativeControl(webView);

                //if (Control.View is global::Android.Views.ViewGroup)
                //{
                //    var process = new global::Android.Widget.ProgressBar(Context, null, global::Android.Resource.Attribute.ProgressBarStyleHorizontal);
                //    var draw = Context.Resources.GetDrawable(Resource.Drawable.color_progressbar);
                //    process.ProgressDrawable = draw;
                //    process.Max = 100;
                //    process.Tag = ("pro");
                //    process.LayoutParameters = new global::Android.Widget.AbsoluteLayout.LayoutParams(LayoutParams.MatchParent, 5, 0, 0);
                //    var vg = Control.View as global::Android.Views.ViewGroup;
                //    vg.AddView(process);
                //    process.BringToFront();
                //}
            }

            if (e.OldElement != null)
            {
                var oldElementController = e.OldElement as Xamarin.Forms.IWebViewController;
                oldElementController.EvalRequested -= OnEvalRequested;
                oldElementController.GoBackRequested -= OnGoBackRequested;
                oldElementController.GoForwardRequested -= OnGoForwardRequested;
            }

            if (e.NewElement != null)
            {
                var newElementController = e.NewElement as Xamarin.Forms.IWebViewController;
                newElementController.EvalRequested += OnEvalRequested;
                newElementController.GoBackRequested += OnGoBackRequested;
                newElementController.GoForwardRequested += OnGoForwardRequested;
            }

            Load();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            switch (e.PropertyName)
            {
                case "Source":
                    Load();
                    break;
            }
        }

        void Load()
        {
            if (_ignoreSourceChanges)
                return;

            if (Element.Source != null)
                Element.Source.Load(this);

            UpdateCanGoBackForward();
        }

        void OnEvalRequested(object sender, EvalRequested eventArg)
        {
            LoadUrl("javascript:" + eventArg.Script);
        }

        void OnGoBackRequested(object sender, EventArgs eventArgs)
        {
            if (Control.CanGoBack())
                Control.GoBack();

            UpdateCanGoBackForward();
        }

        void OnGoForwardRequested(object sender, EventArgs eventArgs)
        {
            if (Control.CanGoForward())
                Control.GoForward();

            UpdateCanGoBackForward();
        }

        void UpdateCanGoBackForward()
        {
            if (Element == null || Control == null)
                return;
            ElementController.CanGoBack = Control.CanGoBack();
            ElementController.CanGoForward = Control.CanGoForward();
        }

        class WebChromeClient : Com.Tencent.Smtt.Sdk.WebChromeClient
        {
            WebViewRenderer _renderer;
            public WebChromeClient(WebViewRenderer renderer)
            {
                if (renderer == null)
                    throw new ArgumentNullException("renderer");
                _renderer = renderer;
            }

            //private global::Android.Widget.ProgressBar GetProcessBar(AWebView view)
            //{

            //    //获取进度条
            //    if (view.View is global::Android.Views.ViewGroup)
            //    {
            //        global::Android.Views.ViewGroup vg = view.View as Android.Views.ViewGroup;
            //        var pro = vg.FindViewWithTag("pro") as global::Android.Widget.ProgressBar;
            //        return pro;
            //    }
            //    return null;
            //}



            protected override void Dispose(bool disposing)
            {
                // this.UnregisterFromRuntime();
                base.Dispose(disposing);

            }
            public override void OnProgressChanged(AWebView view, int process)
            {

                //var pro = GetProcessBar(view);
                //if (pro != null)
                //{
                //    if (process == 100)
                //    {
                //        pro.Visibility = Android.Views.ViewStates.Gone;
                //        return;
                //    }
                //    pro.Visibility = Android.Views.ViewStates.Visible;
                //    pro.BringToFront();
                //    pro.Progress = process;

                //}

            }

        }

        class WebClient : Com.Tencent.Smtt.Sdk.WebViewClient
        {
            Xamarin.Forms.WebNavigationResult _navigationResult = Xamarin.Forms.WebNavigationResult.Success;
            WebViewRenderer _renderer;
            public WebClient(IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            public WebClient(WebViewRenderer renderer)
            {
                if (renderer == null)
                    throw new ArgumentNullException("renderer");
                _renderer = renderer;
            }

            public override void OnPageFinished(AWebView view, string url)
            {
                if (_renderer.Element == null || url == "file:///android_asset/")
                    return;

                var source = new Xamarin.Forms.UrlWebViewSource { Url = url };
                _renderer._ignoreSourceChanges = true;
                _renderer.ElementController.SetValueFromRenderer(Xamarin.Forms.WebView.SourceProperty, source);
                _renderer._ignoreSourceChanges = false;

                var args = new Xamarin.Forms.WebNavigatedEventArgs(Xamarin.Forms.WebNavigationEvent.NewPage, source, url, _navigationResult);

                _renderer.ElementController.SendNavigated(args);

                _renderer.UpdateCanGoBackForward();

                base.OnPageFinished(view, url);
            }

            //[Obsolete("OnReceivedError is obsolete as of version 2.3.0. This method was deprecated in API level 23.")]
            //public override void OnReceivedError(AWebView view, ClientError errorCode, string description, string failingUrl)
            //{

            //}

            public override void OnReceivedError(AWebView view, Com.Tencent.Smtt.Export.External.Interfaces.IWebResourceRequest request, Com.Tencent.Smtt.Export.External.Interfaces.WebResourceError error)
            {
                _navigationResult = Xamarin.Forms.WebNavigationResult.Failure;
                if (error.ErrorCode == (int)Android.Webkit.ClientError.Timeout)
                    _navigationResult = Xamarin.Forms.WebNavigationResult.Timeout;
                base.OnReceivedError(view, request, error);
            }

            public override void OnReceivedError(AWebView view, int errorCode, string description, string failingUrl)
            {
                _navigationResult = Xamarin.Forms.WebNavigationResult.Failure;
                if (errorCode == (int)Android.Webkit.ClientError.Timeout)
                    _navigationResult = Xamarin.Forms.WebNavigationResult.Timeout;
#pragma warning disable 618
                base.OnReceivedError(view, errorCode, description, failingUrl);
#pragma warning restore 618
            }



            [Obsolete]
            public override bool ShouldOverrideUrlLoading(AWebView view, string url)
            {
                if (_renderer.Element == null)
                    return true;
                if (url.StartsWith("weixin://wap/pay?"))
                {
                    Intent intent = new Intent() { };
                    intent.SetAction(Intent.ActionView);
                    intent.SetData(Android.Net.Uri.Parse(url));
                    _renderer.Context.StartActivity(intent);
                    return true;
                }
                 
                var args = new Xamarin.Forms.WebNavigatingEventArgs(Xamarin.Forms.WebNavigationEvent.NewPage, new Xamarin.Forms.UrlWebViewSource { Url = url }, url);

                _renderer.ElementController.SendNavigating(args);
                _navigationResult = Xamarin.Forms.WebNavigationResult.Success;

                _renderer.UpdateCanGoBackForward();
                return args.Cancel;
            }

            protected override void Dispose(bool disposing)
            {
                base.Dispose(disposing);
                if (disposing)
                    _renderer = null;
            }
        }
    }
}