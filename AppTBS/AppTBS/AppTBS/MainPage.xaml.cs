using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTBS
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
          
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.WebBrowser.Source = new UrlWebViewSource
            {
                //http://debugtbs.qq.com/
                Url = "file:///android_asset/webpage/fullscreenVideo.html"
            };
        }
    }
}
