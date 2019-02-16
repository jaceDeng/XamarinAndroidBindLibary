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
            // this.web.  http://m.sijibaobao.com/articles.html 
            // AppTBS.Droid
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.WebBrowser.Source = new UrlWebViewSource
            {
                Url = "https://www.olexe.cn/inde.html"
            };
        }
    }
}
