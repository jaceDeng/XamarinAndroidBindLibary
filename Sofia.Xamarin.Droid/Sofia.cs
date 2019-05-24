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
using Android.App;
using Android.Views;

namespace Sofia.Xamarin.Droid
{


    /// <summary>
    /// Created by YanZhenjie on 2017/12/12.
    /// </summary>
    public class Sofia
    {

        private Sofia()
        {
        }

        public static IBar with(Activity activity)
        {
            Window window = activity.Window;
            ViewGroup contentLayout = window.DecorView.FindViewById<ViewGroup>(Window.IdAndroidContent);
            if (contentLayout.ChildCount > 0)
            {
                View contentView = contentLayout.GetChildAt(0);
                if (contentView is IBar)
                {
                    return (IBar)contentView;
                }
            }
            return new HostLayout(activity);
        }
    }
}