using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace YouZanXamarin
{
    [Activity]
    public class YouzanActivity : AppCompatActivity
    {
        public static String KEY_URL = "url";
        private YouzanFragment mFragment;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_placeholder);
            mFragment = new YouzanFragment();
            mFragment.Arguments = (Intent.Extras);

            SupportFragmentManager.
                    BeginTransaction()
                    .Replace(Resource.Id.placeholder, mFragment)
                    .CommitAllowingStateLoss();
        }

        public override void OnBackPressed()
        {
            if (mFragment == null || !mFragment.OnBackPressed())
            {
                base.OnBackPressed();
            }
        }
    }
}