using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using CN.Jpush.Android.Api;
using static Android.App.ActionBar;

namespace yufeng.XST
{

    [Activity]
    public class TestActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            TextView tv = new TextView(this);
            tv.Text = "用户自定义打开的Activity";
            Intent intent = Intent;
            if (null != intent)
            {
                Bundle bundle = Intent.Extras;
                string title = null;
                string content = null;
                if (bundle != null)
                {
                    title = bundle.GetString(JPushInterface.ExtraNotificationTitle);
                    content = bundle.GetString(JPushInterface.ExtraAlert);
                }
                tv.Text = "Title : " + title + "  " + "Content : " + content;
            }
            AddContentView(tv, new LayoutParams(LayoutParams.FillParent, LayoutParams.FillParent));
        }

    }

}