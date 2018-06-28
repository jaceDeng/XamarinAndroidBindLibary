using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Com.Alivc.Player;
using System;
using Android.Graphics;
using Android.Runtime;

namespace AlivecDemo
{
    [Activity(Label = "AlivecDemo", MainLauncher = true,Exported =true,WindowSoftInputMode = SoftInput.StateHidden)]
    public class MainActivity : Activity, ISurfaceHolderCallback
    {
        private string mUrl;
        private SurfaceView mSurfaceView;
        private RadioGroup muteGroup;
        private RadioButton muteOnBtn;
        private RadioButton muteOffBtn;
        private Button playBtn;
        private Button stopBtn;

        private bool mMute = false;
        private SeekBar brightnessBar;
        private SeekBar volumeBar;
        private AliVcMediaPlayer mPlayer;

        private RadioGroup scaleModeGroup;
        private RadioButton scaleModeFit;
        private RadioButton scaleModeFill;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            mSurfaceView = (SurfaceView)FindViewById(Resource.Id.surfaceView);
            AliVcMediaPlayer.Init(ApplicationContext ,"");

            playBtn = (Button)FindViewById(Resource.Id.play);
            stopBtn = (Button)FindViewById(Resource.Id.stop);

            muteGroup = (RadioGroup)FindViewById(Resource.Id.mute);
            muteOnBtn = (RadioButton)FindViewById(Resource.Id.muteOn);
            muteOffBtn = (RadioButton)FindViewById(Resource.Id.muteOff);

            muteOffBtn.Checked = (true);

            brightnessBar = FindViewById<SeekBar>(Resource.Id.brightnessProgress);
            volumeBar = FindViewById<SeekBar>(Resource.Id.volumeProgress);
            scaleModeGroup = (RadioGroup)FindViewById(Resource.Id.scalingMode);
            scaleModeFit = (RadioButton)FindViewById(Resource.Id.fit);
            scaleModeFill = (RadioButton)FindViewById(Resource.Id.fill);

            playBtn.Click += (sender, e) =>
            {

                //  logStrs.add(format.format(new Date()) + getString(R.string.log_start_get_data));

                setMaxBufferDuration();

                replay();

                if (mMute)
                {
                    mPlayer.SetMuteMode(mMute);
                }
                brightnessBar.Progress = (mPlayer.ScreenBrightness);
                // logStrs.add(format.format(new Date()) + getString(R.string.log_strart_play));
                volumeBar.Progress = (mPlayer.Volume);
            };

            stopBtn.Click += (sender, e) =>
            {
                stop();
            };

          mSurfaceView.Holder.AddCallback(this);

            initVodPlayer();
            setPlaySource();
        }

        private void stop()
        {
            if (mPlayer != null)
            {
                mPlayer.Stop();
            }
        }
        private void start()
        {

            if (mPlayer != null)
            {
                mPlayer.PrepareAndPlay(mUrl);
            }
        }

        private void setPlaySource()
        {

            mUrl = "rtmp://live.hkstv.hk.lxdns.com/live/hks";
            }

        private void replay()
        {
            stop();
            start();
        }

        private void setMaxBufferDuration()
        {
            //  String maxBufferDurationStr = maxBufDurationEdit.getText().toString();
            int maxBD = 10;
            //try
            //{
            //    maxBD = Integer.valueOf(maxBufferDurationStr);

            //}
            //catch (Exception e)
            //{
            //    maxBufDurationEdit.setText("0");
            //}
            //if (maxBD < 0)
            //{
            //    Toast.makeText(getApplicationContext(), R.string.max_buffer_duration_nagtive, Toast.LENGTH_SHORT).show();
            //    return;
            //}
            if (mPlayer != null)
            {
                mPlayer.SetMaxBufferDuration(maxBD);
            }
        }

        private void initVodPlayer()
        {
            mPlayer = new AliVcMediaPlayer(this, mSurfaceView);
            mPlayer.Prepared += (sender, e) =>
            {
                //    Toast.makeText(LiveModeActivity.this.getApplicationContext(), R.string.toast_prepare_success, Toast.LENGTH_SHORT).show();
                //  logStrs.add(format.format(new Date()) + getString(R.string.log_prepare_success));

                //      showVideoSizeInfo();
            };

            mPlayer.FrameInfo += (sender, e) => { };
            mPlayer.Error += (sender, e) => { };
            mPlayer.Completed+= (sender, e) => { };
            mPlayer.SeekComplete+= (sender, e) => { }; 
            mPlayer.Stoped+= (sender, e) => { }; 
            mPlayer.BufferingUpdate+= (sender, e) => { };

        }

        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
   //         Log.d(TAG, "onSurfaceChanged is valid ? " + holder.getSurface().isValid());
            if (mPlayer != null)
                mPlayer.SetSurfaceChanged();
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            holder.SetType( SurfaceType.Gpu);
            holder.SetKeepScreenOn(true);
            if (mPlayer != null)
            {
                mPlayer.SetVideoSurface(mSurfaceView.Holder.Surface);
            }
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
             
        }
    }
}

