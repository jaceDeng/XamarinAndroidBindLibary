using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

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
    

    /// <summary>
    /// Created by YanZhenjie on 2017/8/30.
    /// </summary>
    internal class HostLayout : RelativeLayout, IBar
    {

        private const int FLAG_NOT_INVASION = 0x0;
        private const int FLAG_INVASION_STATUS = 0x1;
        private const int FLAG_INVASION_NAVIGATION = 0x2;
        private const int FLAG_INVASION_STATUS_AND_NAVIGATION = FLAG_INVASION_STATUS | FLAG_INVASION_NAVIGATION;

        private Activity mActivity;
        private int mInvasionFlag = FLAG_NOT_INVASION;

        private StatusView mStatusView;
        private NavigationView mNavigationView;
        private FrameLayout mContentLayout;

        internal HostLayout(Activity activity) : base(activity)
        {
            this.mActivity = activity;

            loadView();
            replaceContentView();

            Utils.invasionStatusBar(mActivity);
            Utils.invasionNavigationBar(mActivity);
            Utils.setStatusBarColor(mActivity, Color.Transparent);
            Utils.setNavigationBarColor(mActivity, Color.Transparent);
        }

        public override WindowInsets OnApplyWindowInsets(WindowInsets insets)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
            {
                int paddingSize = insets.SystemWindowInsetBottom;
                int barSize = mNavigationView.DefaultBarSize;
                paddingSize = paddingSize == barSize ? 0 : paddingSize;
                mContentLayout.SetPaddingRelative(0, 0, 0, paddingSize);
                RelativeLayout.LayoutParams layoutParams = (LayoutParams)mContentLayout.LayoutParameters;
                if (paddingSize > 0 && !mNavigationView.Landscape)
                {
                    layoutParams.BottomMargin = -barSize;
                }
                else
                {
                    layoutParams.BottomMargin = 0;
                }
                return base.OnApplyWindowInsets(insets.ReplaceSystemWindowInsets(0, 0, 0, 0));
            }
            else
            {
                return insets;
            }
        }

        private void loadView()
        {
            Inflate(mActivity, Resource.Layout.sofia_host_layout, this);
            mStatusView = FindViewById<StatusView>(Resource.Id.status_view);
            mNavigationView = FindViewById<NavigationView>(Resource.Id.navigation_view);
            mContentLayout = FindViewById<FrameLayout>(Resource.Id.content);
        }

        private void replaceContentView()
        {
            Window window = mActivity.Window;
            ViewGroup contentLayout = window.DecorView.FindViewById<ViewGroup>(Window.IdAndroidContent);
            if (contentLayout.ChildCount > 0)
            {
                View contentView = contentLayout.GetChildAt(0);
                contentLayout.RemoveView(contentView);
                ViewGroup.LayoutParams contentParams = contentView.LayoutParameters;
                mContentLayout.AddView(contentView, contentParams.Width, contentParams.Height);
            }
            contentLayout.AddView(this, -1, -1);
        }

        public virtual IBar StatusBarDarkFont()
        {
            Utils.setStatusBarDarkFont(mActivity, true);
            return this;
        }

        public virtual IBar StatusBarLightFont()
        {
            Utils.setStatusBarDarkFont(mActivity, false);
            return this;
        }

        public virtual IBar StatusBarBackground(Color color)
        {
            mStatusView.SetBackgroundColor(color);
            return this;
        }

        public virtual IBar StatusBarBackground(Drawable drawable)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.JellyBean)
            {
                mStatusView.Background = drawable;
            }
            else
            {
                mStatusView.SetBackgroundDrawable(drawable);
            }
            return this;
        }

        public virtual IBar StatusBarBackgroundAlpha(int alpha)
        {
            //JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
            //ORIGINAL LINE: final Android.graphics.drawable.Drawable background = mStatusView.getBackground();
            Drawable background = mStatusView.Background;
            if (background != null)
            {
                background.Mutate().Alpha = alpha;
            }
            return this;
        }

        public virtual IBar NavigationBarBackground(Color color)
        {
            mNavigationView.SetBackgroundColor(color);
            return this;
        }

        public virtual IBar NavigationBarBackground(Drawable drawable)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.JellyBean)
            {
                mNavigationView.Background = drawable;
            }
            else
            {
                mNavigationView.SetBackgroundDrawable(drawable);
            }
            return this;
        }

        public virtual IBar NavigationBarBackgroundAlpha(int alpha)
        {
            //JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
            //ORIGINAL LINE: final Android.graphics.drawable.Drawable background = mNavigationView.getBackground();
            Drawable background = mNavigationView.Background;
            if (background != null)
            {
                background.Mutate().Alpha = alpha;
            }
            return this;
        }

        public virtual IBar InvasionStatusBar()
        {
            mInvasionFlag |= FLAG_INVASION_STATUS;
            layoutInvasion();
            return this;
        }

        public virtual IBar InvasionNavigationBar()
        {
            mInvasionFlag |= FLAG_INVASION_NAVIGATION;
            layoutInvasion();
            return this;
        }

        /// @deprecated use <seealso cref="#fitsStatusBarView(int)"/> instead. 
        [Obsolete("use <seealso cref=\"#fitsStatusBarView(int)\"/> instead.")]
        public virtual IBar FitsSystemWindowView(int viewId)
        {
            return FitsStatusBarView(FindViewById(viewId));
        }

        /// @deprecated use <seealso cref="#fitsStatusBarView(View)"/> instead. 
        [Obsolete("use <seealso cref=\"#fitsStatusBarView(Android.Views.View)\"/> instead.")]
        public virtual IBar FitsSystemWindowView(View view)
        {
            return FitsStatusBarView(view);
        }

        public virtual IBar FitsStatusBarView(int viewId)
        {
            return FitsStatusBarView(FindViewById(viewId));
        }

        public virtual IBar FitsStatusBarView(View view)
        {
            IViewParent fitParent = view.Parent;
            if (fitParent != null && !(fitParent is FitWindowLayout))
            {
                FitWindowLayout fitLayout = new FitWindowLayout(mActivity);
                ViewGroup fitGroup = (ViewGroup)fitParent;
                fitGroup.RemoveView(view);
                fitGroup.AddView(fitLayout);

                StatusView statusView = new StatusView(mActivity);
                fitLayout.AddView(statusView);

                ViewGroup.LayoutParams fitViewParams = view.LayoutParameters;
                fitLayout.AddView(view, fitViewParams.Width, fitViewParams.Height);
            }
            return this;
        }

        public virtual IBar FitsNavigationBarView(int viewId)
        {
            return FitsNavigationBarView(FindViewById(viewId));
        }

        public virtual IBar FitsNavigationBarView(View view)
        {
            IViewParent fitParent = view.Parent;
            if (fitParent != null && !(fitParent is FitWindowLayout))
            {
                FitWindowLayout fitLayout = new FitWindowLayout(mActivity);
                ViewGroup fitGroup = (ViewGroup)fitParent;
                fitGroup.RemoveView(view);
                fitGroup.AddView(fitLayout);

                ViewGroup.LayoutParams fitViewParams = view.LayoutParameters;
                fitLayout.AddView(view, fitViewParams.Width, fitViewParams.Height);

                NavigationView navigationView = new NavigationViewAnonymousInnerClass(this, mActivity);
                fitLayout.AddView(navigationView);
            }
            return this;
        }

        private class NavigationViewAnonymousInnerClass : NavigationView
        {
            private readonly HostLayout outerInstance;

            public NavigationViewAnonymousInnerClass(HostLayout outerInstance, Activity mActivity) : base(mActivity as Context)
            {
                this.outerInstance = outerInstance;
            }

            protected   override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
            {
                if (Landscape)
                {
                    this.SetMeasuredDimension(0, 0);
                }
                else
                {
                    base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
                }
            }
        }

        protected override void OnConfigurationChanged(Configuration newConfig)
        {
            if (mNavigationView.Landscape)
            {
                LayoutParams navigationParams = (LayoutParams)mNavigationView.LayoutParameters;
                navigationParams.AddRule(Android.Widget.LayoutRules.AlignParentRight);

                LayoutParams statusParams = (LayoutParams)mStatusView.LayoutParameters;
                statusParams.AddRule(Android.Widget.LayoutRules.AlignParentTop);
                statusParams.AddRule(Android.Widget.LayoutRules.LeftOf, Resource.Id.navigation_view);
            }
            else
            {
                LayoutParams statusParams = (LayoutParams)mStatusView.LayoutParameters;
                statusParams.AddRule(Android.Widget.LayoutRules.AlignParentTop);

                LayoutParams navigationParams = (LayoutParams)mNavigationView.LayoutParameters;
                navigationParams.AddRule(Android.Widget.LayoutRules.AlignParentBottom);
            }
            layoutInvasion();
        }

        private void layoutInvasion()
        {
            LayoutParams layoutParams = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            if (mNavigationView.Landscape)
            {
                switch (mInvasionFlag)
                {
                    case FLAG_INVASION_STATUS:
                        layoutParams.AddRule(Android.Widget.LayoutRules.LeftOf, Resource.Id.navigation_view);
                        BringChildToFront(mStatusView);
                        break;
                    case FLAG_INVASION_NAVIGATION:
                        layoutParams.AddRule(Android.Widget.LayoutRules.Below, Resource.Id.status_view);
                        layoutParams.AddRule(Android.Widget.LayoutRules.LeftOf, Resource.Id.navigation_view);
                        BringChildToFront(mNavigationView);
                        break;
                    case FLAG_INVASION_STATUS_AND_NAVIGATION:
                        layoutParams.AddRule(Android.Widget.LayoutRules.LeftOf, Resource.Id.navigation_view);
                        BringChildToFront(mStatusView);
                        BringChildToFront(mNavigationView);
                        break;
                    case FLAG_NOT_INVASION:
                        layoutParams.AddRule(Android.Widget.LayoutRules.Below, Resource.Id.status_view);
                        layoutParams.AddRule(Android.Widget.LayoutRules.LeftOf, Resource.Id.navigation_view);
                        break;
                }
            }
            else
            {
                switch (mInvasionFlag)
                {
                    case FLAG_INVASION_STATUS:
                        layoutParams.AddRule(Android.Widget.LayoutRules.Above, Resource.Id.navigation_view);
                        BringChildToFront(mStatusView);
                        break;
                    case FLAG_INVASION_NAVIGATION:
                        layoutParams.AddRule(Android.Widget.LayoutRules.Below, Resource.Id.status_view);
                        BringChildToFront(mNavigationView);
                        break;
                    case FLAG_INVASION_STATUS_AND_NAVIGATION:
                        BringChildToFront(mStatusView);
                        BringChildToFront(mNavigationView);
                        break;
                    case FLAG_NOT_INVASION:
                        layoutParams.AddRule(Android.Widget.LayoutRules.Below, Resource.Id.status_view);
                        layoutParams.AddRule(Android.Widget.LayoutRules.Above, Resource.Id.navigation_view);
                        break;
                }
            }
            mContentLayout.LayoutParameters = layoutParams;
        }
    }
}