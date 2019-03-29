using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace SerialPortDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05 };
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var serialttyS1 = new SerialPort(new Java.IO.File("/dev/ttyS0"), 115200, 0);
            serialttyS1.OutputStream.Write(bytes);
            serialttyS1.InputStream.Read(bytes);

        }
    }
}

