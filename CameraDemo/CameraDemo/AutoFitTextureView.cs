using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Lang;

namespace CameraDemo
{
    [Register("ca.droid.AutoFitTextureView")]
    public class AutoFitTextureView : TextureView
    {
        private int ratioWidth = 0;
        private int ratioHeight = 0;

        public AutoFitTextureView(Context context) : this(context, null)
        {

        }

        public AutoFitTextureView(Context context, IAttributeSet attrs) : this(context, attrs, 0)
        {

        }

        public AutoFitTextureView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {

        }

        /**
         * Sets the aspect ratio for this view. The size of the view will be measured based on the ratio
         * calculated from the parameters. Note that the actual sizes of parameters don't matter, that
         * is, calling setAspectRatio(2, 3) and setAspectRatio(4, 6) make the same result.
         *
         * @param width  Relative horizontal size
         * @param height Relative vertical size
         */
        public void setAspectRatio(int width, int height)
        {
            if (width < 0 || height < 0)
            {
                throw new IllegalArgumentException("Size cannot be negative.");
            }
            ratioWidth = width;
            ratioHeight = height;
            RequestLayout();
        }

        // @Override
        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            int width = MeasureSpec.GetSize(widthMeasureSpec);
            int height = MeasureSpec.GetSize(heightMeasureSpec);
            if (0 == ratioWidth || 0 == ratioHeight)
            {
                SetMeasuredDimension(width, height);
            }
            else
            {
                if (width < height * ratioWidth / ratioHeight)
                {
                    SetMeasuredDimension(width, width * ratioHeight / ratioWidth);
                }
                else
                {
                    SetMeasuredDimension(height * ratioWidth / ratioHeight, height);
                }
            }
        }
    }
}