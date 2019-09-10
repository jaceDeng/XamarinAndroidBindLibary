using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Lljjcoder.Style.Cityjd;
using Com.Lljjcoder.Interface;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public JDCityConfig.ShowType mWheelType = JDCityConfig.ShowType.ProCity;
        JDCityPicker cityPicker;
        private JDCityConfig jdCityConfig = new JDCityConfig.Builder().Build();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            FindViewById<Button>(Resource.Id.btn).Click += MainActivity_Click;
            //显示省
            jdCityConfig.SetShowType(JDCityConfig.ShowType.ProCityDis);
            cityPicker = new JDCityPicker();
            CityItemClickListener clickListener = new CityItemClickListener();
            clickListener.OnCancelEvent += (sender, e) =>
            {
            };
            clickListener.OnSelectedEvent += (sender, e) => {
                var city = e.City;
            };

            cityPicker.SetOnCityItemClickListener(clickListener);
            //初始化数据
            cityPicker.Init(this);
        }

        private void MainActivity_Click(object sender, System.EventArgs e)
        {
            cityPicker.ShowCityPicker();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}