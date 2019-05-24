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
using Android.OS;
using Android.Util;
using Android.Views;

namespace Sofia.Xamarin.Droid
{
 

	/// <summary>
	/// Created by YanZhenjie on 2017/8/1.
	/// </summary>
	public class StatusView : View
	{

		private int mBarSize;

		public StatusView(Context context) : this(context, null, 0)
		{
		}

		public StatusView(Context context, IAttributeSet attrs) : this(context, attrs, 0)
		{
		}

		public StatusView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
		{
			Resources resources = Resources;
            int resourceId = resources.GetIdentifier("status_bar_height", "dimen", "android");
			mBarSize = resources.GetDimensionPixelSize(resourceId);
		}

		protected   override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
			{
                SetMeasuredDimension(MeasureSpec.GetSize(widthMeasureSpec), mBarSize);
			}
			else
			{
				SetMeasuredDimension(0, 0);
			}
		}

		/// <summary>
		/// Get status bar height.
		/// </summary>
		public virtual int BarSize
		{
			get
			{
				return mBarSize;
			}
		}
	}
}