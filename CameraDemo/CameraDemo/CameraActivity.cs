using Android.App;
using Android.Widget;
using Android.OS;

namespace CameraDemo
{
    [Activity(Label = "摄像头预览测试", MainLauncher = true)]
    //[Android.Runtime.Register("com.example.android.tflitecamerademo.CameraActivity")]
    public class CameraActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_camera);

            if (null == savedInstanceState)
            {
                FragmentManager
                    .BeginTransaction()
                    .Replace(Resource.Id.container, Camera2BasicFragment.newInstance())
                    .Commit();
            }
        }
    }
}

