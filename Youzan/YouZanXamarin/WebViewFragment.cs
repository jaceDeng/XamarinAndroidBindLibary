using Android.App;
using Android.OS;
using Android.Views;
using Com.Youzan.Androidsdk.Basic;

namespace YouZanXamarin
{
    public abstract class WebViewFragment : Android.Support.V4.App.Fragment
    {
        private YouzanBrowser mWebView;
        private bool mIsWebViewAvailable;

        public WebViewFragment()
        {
        }

        /**
         * Called to instantiate the view. Creates and returns the WebView.
         */

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (mWebView != null)
            {
                mWebView.Destroy();
            }
            View contentView = inflater.Inflate(getLayoutId(), container, false);
            mWebView = (YouzanBrowser)contentView.FindViewById(getWebViewId());
            mIsWebViewAvailable = true;
            return contentView;
        }

        /**
         * @return The id of WebView in layout
         */
        //  @IdRes
        protected abstract int getWebViewId();

        /**
         * @return the layout id for Fragment
         */
        //  @LayoutRes
        protected abstract int getLayoutId();

        /**
         * Called when the fragment is visible to the user and actively running. Resumes the WebView.
         */
        //  @Override
        public override void OnPause()
        {
            base.OnPause();
            mWebView.OnPause();
        }

        /**
         * Called when the fragment is no longer resumed. Pauses the WebView.
         */
        //  @Override
        public override void OnResume()
        {
            mWebView.OnResume();
            base.OnResume();
        }

        /**
         * Called when the WebView has been detached from the fragment.
         * The WebView is no longer available after this time.
         */
        // @Override
        public override void OnDestroyView()
        {
            mIsWebViewAvailable = false;
            base.OnDestroyView();
        }

        /**
         * Called when the fragment is no longer in use. Destroys the internal state of the WebView.
         */
        // @Override
        public override void OnDestroy()
        {
            if (mWebView != null)
            {
                mWebView.Destroy();
                mWebView = null;
            }
            base.OnDestroy();
        }

        /**
         * Take care of popping the fragment back stack or finishing the activity
         * as appropriate.
         *
         * @return True if the host application wants to handle back press by itself, otherwise return false.
         */
        public virtual bool OnBackPressed()
        {
            return false;
        }

        /**
         * Gets the WebView.
         */
        public YouzanBrowser getWebView()
        {
            return mIsWebViewAvailable ? mWebView : null;
        }
    }
}