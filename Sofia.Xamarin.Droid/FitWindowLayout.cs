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
namespace Sofia.Xamarin.Droid
{
    using Context = Android.Content.Context;
    using View = Android.Views.View;
    using ViewGroup = Android.Views.ViewGroup;

    /// <summary>
    /// Created by YanZhenjie on 2017/12/13.
    /// </summary>
    public class FitWindowLayout : ViewGroup
    {

        public FitWindowLayout(Context context) : base(context)
        {
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            int contentViewHeight = 0;
            int childCount = ChildCount;
            int menuWidthSpec = MeasureSpec.MakeMeasureSpec(MeasureSpec.GetSize(widthMeasureSpec), MeasureSpec.GetMode(widthMeasureSpec));
            int menuHeightSpec = MeasureSpec.MakeMeasureSpec(MeasureSpec.GetSize(heightMeasureSpec), MeasureSpec.GetMode(heightMeasureSpec));
            for (int i = 0; i < childCount; i++)
            {
                View view = GetChildAt(i);
                view.Measure(menuWidthSpec, menuHeightSpec);
                contentViewHeight += view.MeasuredHeight;
            }
            SetMeasuredDimension(MeasureSpec.GetSize(widthMeasureSpec), contentViewHeight);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            int childCount = ChildCount;
            int allHeight = 0;
            for (int i = 0; i < childCount; i++)
            {
                View view = GetChildAt(i);
                int viewHeight = view.MeasuredHeight;
                view.Layout(l, allHeight, r, allHeight + viewHeight);
                allHeight += viewHeight;
            }
        }
    }
}