using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;

namespace YouZanXamarin
{
    public class YouzanFragment : WebViewFragment, SwipeRefreshLayout.IOnRefreshListener
    {
        private Com.Youzan.Androidsdk.Basic.YouzanBrowser mView;
        private SwipeRefreshLayout mRefreshLayout;
        private Toolbar mToolbar;



        //@Override
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            setupViews(view);
            setupYouzan();

            String url = Arguments.GetString(YouzanActivity.KEY_URL);
            mView.LoadUrl(url);
        }


        private void setupViews(View contentView)
        {
            //WebView
            mView = getWebView();

            // mToolbar = contentView.FindViewById<Toolbar>(Resource.Id.toolbar);
            mRefreshLayout = (SwipeRefreshLayout)contentView.FindViewById(Resource.Id.swipe);

            //分享按钮
            //  mToolbar.SetTitle(Resource.String.loading_page);
            //  mToolbar.InflateMenu(Resource.Menu.menu_youzan_share);
            //    mToolbar.setOnMenuItemClickListener(new Toolbar.OnMenuItemClickListener()
            //    {
            //    //@Override
            //    public boolean onMenuItemClick(MenuItem item)
            //    {
            //        switch (item.getItemId())
            //        {
            //            case R.id.action_share:
            //                mView.sharePage();
            //                return true;
            //            default:
            //                return false;
            //        }
            //    }
            //}); 

            //刷新
            //  mRefreshLayout.SetOnRefreshListener(this);
            //  mRefreshLayout.SetColorSchemeColors(Android.Graphics.Color.Blue, Android.Graphics.Color.Red);
            //  mRefreshLayout.SetEnabled(false);
        }

        private void setupYouzan()
        {
            //认证事件, 回调表示: 需要需要新的认证信息传入
            //    mView.subscribe(new AbsAuthEvent()
            //    {

            //    //@Override
            //    public void call(Context context, boolean needLogin)
            //    {
            //        /**
            //         * 建议实现逻辑:
            //         *
            //         *     判断App内的用户是否登录?
            //         *       => 已登录: 请求带用户角色的认证信息(login接口);
            //         *       => 未登录: needLogin为true, 唤起App内登录界面, 请求带用户角色的认证信息(login接口);
            //         *       => 未登录: needLogin为false, 请求不带用户角色的认证信息(initToken接口).
            //         *
            //         *      服务端接入文档: https://www.youzanyun.com/docs/guide/appsdk/683
            //         */
            //        //TODO 自行编码实现. 具体可参考开发文档中的伪代码实现
            //    }
            //});

            ////文件选择事件, 回调表示: 发起文件选择. (如果app内使用的是系统默认的文件选择器, 该事件可以直接删除)
            //mView.subscribe(new AbsChooserEvent()
            //{
            //    //@Override
            //    public void call(Context context, Intent intent, int requestCode) throws ActivityNotFoundException {
            //        startActivityForResult(intent, requestCode);
            //    }
            //});

            ////页面状态事件, 回调表示: 页面加载完成
            //mView.subscribe(new AbsStateEvent()
            //{
            //    //@Override
            //    public void call(Context context)
            //    {
            //        mToolbar.setTitle(mView.getTitle());

            //        //停止刷新
            //        mRefreshLayout.setRefreshing(false);
            //        mRefreshLayout.setEnabled(true);
            //    }
            //});

            ////分享事件, 回调表示: 获取到当前页面的分享信息数据
            //mView.subscribe(new AbsShareEvent()
            //{
            //    //@Override
            //    public void call(Context context, GoodsShareModel data)
            //    {
            //        /**
            //         * 在获取数据后, 可以使用其他分享SDK来提高分享体验.
            //         * 这里调用系统分享来简单演示分享的过程.
            //         */
            //        String content = data.getDesc() + data.getLink();
            //        Intent sendIntent = new Intent();
            //        sendIntent.setAction(Intent.ACTION_SEND);
            //        sendIntent.putExtra(Intent.EXTRA_TEXT, content);
            //        sendIntent.putExtra(Intent.EXTRA_SUBJECT, data.getTitle());
            //        sendIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            //        sendIntent.setType("text/plain");
            //        startActivity(sendIntent);
            //    }
            //});

        }


        //@Override
        protected override int getWebViewId()
        {
            //YouzanBrowser在布局文件中的id
            return Resource.Id.view;//.id.view;
        }


        //@Override

        protected override int getLayoutId()
        {
            //布局文件
            return Resource.Layout.fragment_youzan;//.layout.fragment_youzan;
        }

        //@Override
        public override bool OnBackPressed()
        {
            //页面回退
            return getWebView().PageGoBack();
        }

        //@Override
        public void OnRefresh()
        {
            //重新加载页面
            mView.Reload();
        }
        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == (int)Result.Ok)
            {

                //另需处理认证等...

                mView.ReceiveFile(requestCode, data);
            }
        }


    }
}