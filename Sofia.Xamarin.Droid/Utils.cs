using Android.App;
using Android.Graphics;
using Android.Views;
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


    using Build = Android.OS.Build;
    using View = Android.Views.View;
    using Window = Android.Views.Window;
    using WindowManager = Android.Views.IWindowManager;


    /// <summary>
    /// Created by YanZhenjie on 2017/6/27.
    /// </summary>
    public class Utils
    {

        /// <summary>
        /// Set the status bar color.
        /// </summary>
        public static void setStatusBarColor(Activity activity, Color statusBarColor)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
            {
                Window window = activity.Window;
                window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                window.SetStatusBarColor(statusBarColor);
            }
        }

        /// <summary>
        /// Set the navigation bar color.
        /// </summary>
        public static void setNavigationBarColor(Activity activity, Color navigationBarColor)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
            {
                Window window = activity.Window;
                window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                window.SetNavigationBarColor(navigationBarColor);
            }
        }

        /// <summary>
        /// Set the content layout full the StatusBar, but do not hide StatusBar.
        /// </summary>
        public static void invasionStatusBar(Activity activity)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
            {
                Window window = activity.Window;
                View decorView = window.DecorView;
                decorView.SystemUiVisibility = (StatusBarVisibility)((int)decorView.SystemUiVisibility
                    | (int)Android.Views.SystemUiFlags.LayoutFullscreen
                    | (int)Android.Views.SystemUiFlags.LayoutStable);
                window.SetStatusBarColor(Color.Transparent);
            }
        }

        /// <summary>
        /// Set the content layout full the NavigationBar, but do not hide NavigationBar.
        /// </summary>
        public static void invasionNavigationBar(Activity activity)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
            {
                Window window = activity.Window;
                View decorView = window.DecorView;
                decorView.SystemUiVisibility = (StatusBarVisibility)((int)decorView.SystemUiVisibility
                    | (int)Android.Views.SystemUiFlags.HideNavigation
                    | (int)Android.Views.SystemUiFlags.LayoutStable);

                //StatusBarVisibilitydecorView.SystemUiVisibility 
                //    | View.SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION 
                //    | View.SYSTEM_UI_FLAG_LAYOUT_STABLE;
                window.SetNavigationBarColor(Color.Transparent);
            }
        }

        /// <summary>
        /// Set the status bar to dark.
        /// </summary>
        public static bool setStatusBarDarkFont(Activity activity, bool darkFont)
        {
            if (setMIUIStatusBarFont(activity, darkFont))
            {
                setDefaultStatusBarFont(activity, darkFont);
                return true;
            }
            else if (setMeizuStatusBarFont(activity, darkFont))
            {
                setDefaultStatusBarFont(activity, darkFont);
                return true;
            }
            else
            {
                return setDefaultStatusBarFont(activity, darkFont);
            }
        }

        private static bool setMeizuStatusBarFont(Activity activity, bool darkFont)
        {
            try
            {
                WindowManagerLayoutParams lp = activity.Window.Attributes;
                var darkFlag = Java.Lang.Class.FromType(typeof(WindowManagerLayoutParams)).GetField("MEIZU_FLAG_DARK_STATUS_BAR_ICON");
                var meizuFlags = Java.Lang.Class.FromType(typeof(WindowManagerLayoutParams)).GetField("meizuFlags");
                darkFlag.Accessible = true;
                meizuFlags.Accessible = true;
                int bit = darkFlag.GetInt(null);
                int value = meizuFlags.GetInt(lp);
                if (darkFont)
                {
                    value |= bit;
                }
                else
                {
                    value &= ~bit;
                }
                meizuFlags.SetInt(lp, value);
                activity.Window.Attributes = lp;
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        private static bool setMIUIStatusBarFont(Activity activity, bool dark)
        {
            Window window = activity.Window;
            var clazz = Java.Lang.Class.FromType(window.GetType());
            try
            {
                var layoutParams = Java.Lang.Class.FromType(Type.GetType("Android.Views.MiuiWindowManager$LayoutParams"));
                var field = layoutParams.GetField("EXTRA_FLAG_STATUS_BAR_DARK_MODE");
                int darkModeFlag = field.GetInt(layoutParams);
                var extraFlagField = clazz.GetMethod("setExtraFlags", Java.Lang.Class.FromType(typeof(int)), Java.Lang.Class.FromType(typeof(int)));
                if (dark)
                {
                    extraFlagField.Invoke(window, darkModeFlag, darkModeFlag);
                }
                else
                {
                    extraFlagField.Invoke(window, 0, darkModeFlag);
                }
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        private static bool setDefaultStatusBarFont(Activity activity, bool dark)
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.M)
            {
                Window window = activity.Window;
                View decorView = window.DecorView;
                if (dark)
                {
                    decorView.SystemUiVisibility =
                        (Android.Views.StatusBarVisibility)
                       ((int)decorView.SystemUiVisibility | (int)Android.Views.SystemUiFlags.LightStatusBar);
                }
                else
                {

                    decorView.SystemUiVisibility = (Android.Views.StatusBarVisibility)((int)decorView.SystemUiVisibility & ~(int)Android.Views.SystemUiFlags.LightStatusBar);
                }
                return true;
            }
            return false;
        }

    }
}