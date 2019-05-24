using Android.Graphics;
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
    using Drawable = Android.Graphics.Drawables.Drawable;
	using View = Android.Views.View;

	/// <summary>
	/// Created by YanZhenjie on 2017/12/13.
	/// </summary>
	public interface IBar
	{

		IBar StatusBarDarkFont();

		IBar StatusBarLightFont();

		IBar StatusBarBackground(Color statusBarColor);

		IBar StatusBarBackground(Drawable drawable);

		IBar StatusBarBackgroundAlpha(int alpha);

		IBar NavigationBarBackground(Color navigationBarColor);

		IBar NavigationBarBackground(Drawable drawable);

		IBar NavigationBarBackgroundAlpha(int alpha);

		IBar InvasionStatusBar();

		IBar InvasionNavigationBar();

		/// @deprecated use <seealso cref="#fitsStatusBarView(int)"/> instead. 
		[Obsolete("use <seealso cref=\"#fitsStatusBarView(int)\"/> instead.")]
		IBar FitsSystemWindowView(int viewId);

		/// @deprecated use <seealso cref="#fitsStatusBarView(View)"/> instead. 
		[Obsolete("use <seealso cref=\"#fitsStatusBarView(Android.Views.View)\"/> instead.")]
		IBar FitsSystemWindowView(View view);

		IBar FitsStatusBarView(int viewId);

		IBar FitsStatusBarView(View view);

		IBar FitsNavigationBarView(int viewId);

		IBar FitsNavigationBarView(View view);
	}
}