/*
 * Copyright 2017 Yan Zhenjie
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Util;
using Android.Views;

namespace Sofia.Xamarin.Droid
{


    /// <summary>
    /// Created by YanZhenjie on 2017/8/1.
    /// </summary>
    public class NavigationView : View
    {

        private Display mDisplay;
        private DisplayMetrics mDisplayMetrics;
        private Configuration mConfiguration;
        private int mDefaultBarSize;
        private int mBarSize;

        public NavigationView(Context context) : this(context, null, 0)
        {
        }

        public NavigationView(Context context, IAttributeSet attrs) : this(context, attrs, 0)
        {
        }

        public NavigationView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            IWindowManager windowManager = (IWindowManager)context.GetSystemService(Context.WindowService);
            mDisplay = windowManager.DefaultDisplay;
            mDisplayMetrics = new DisplayMetrics();
            Resources resources = Resources;
            mConfiguration = resources.Configuration;

            int resourceId = resources.GetIdentifier("navigation_bar_height", "dimen", "android");
            mDefaultBarSize = resources.GetDimensionPixelSize(resourceId);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
            {
                if (Landscape)
                {
                    mDisplay.GetRealMetrics(mDisplayMetrics);
                    mBarSize = mDisplayMetrics.WidthPixels - getDisplayWidth(mDisplay);
                    SetMeasuredDimension(mBarSize, MeasureSpec.GetSize(heightMeasureSpec));
                }
                else
                {
                    mDisplay.GetRealMetrics(mDisplayMetrics);
                    mBarSize = mDisplayMetrics.HeightPixels - getDisplayHeight(mDisplay);
                    SetMeasuredDimension(MeasureSpec.GetSize(widthMeasureSpec), mBarSize);
                }
            }
            else
            {
                SetMeasuredDimension(0, 0);
            }
        }

        private static int getDisplayWidth(Display display)
        {
            Point point = new Point();
            display.GetSize(point);
            return point.X;
        }

        private static int getDisplayHeight(Display display)
        {
            Point point = new Point();
            display.GetSize(point);
            return point.Y;
        }

        /// <summary>
        /// Get the default height of navigation bar.
        /// </summary>
        public virtual int DefaultBarSize
        {
            get
            {
                return mDefaultBarSize;
            }
        }

        /// <summary>
        /// Get the height of navigation bar.
        /// </summary>
        public virtual int BarSize
        {
            get
            {
                return mBarSize;
            }
        }

        /// <summary>
        /// Whether landscape screen.
        /// </summary>
        public virtual bool Landscape
        {
            get
            {
                switch (mConfiguration.Orientation)
                {
                    case Orientation.Landscape:
                        {
                            return true;
                        }
                    case Orientation.Undefined:
                    case Orientation.Portrait:
                    default:
                        {
                            return false;
                        }
                }
            }
        }
    }
}