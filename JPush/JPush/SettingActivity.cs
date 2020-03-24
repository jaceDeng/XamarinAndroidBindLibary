using System;
using System.Collections.Generic;
using System.Text;

namespace yufeng.XST
{
	using Activity = Android.App.Activity;
	using SharedPreferences = Android.content.SharedPreferences;
	using Editor = Android.Content.SharedPreferences.Editor;
	using Bundle = Android.OS.Bundle;
	using TextUtils = Android.text.TextUtils;
	using DateFormat = Android.text.format.DateFormat;
	using KeyEvent = Android.view.KeyEvent;
	using View = Android.view.View;
	using OnClickListener = Android.view.View.OnClickListener;
	using Button = Android.widget.Button;
	using CheckBox = Android.widget.CheckBox;
	using TimePicker = Android.widget.TimePicker;
	using Toast = Android.widget.Toast;


	using JPushInterface = CN.Jpush.Android.Api.JPushInterface;

	public class SettingActivity : Activity, View.IOnClickListener
	{
		internal TimePicker startTime;
		internal TimePicker endTime;
		internal CheckBox mMonday;
		internal CheckBox mTuesday;
		internal CheckBox mWednesday;
		internal CheckBox mThursday;
		internal CheckBox mFriday;
		internal CheckBox mSaturday;
		internal CheckBox mSunday;
		internal Button mSetTime;
		internal SharedPreferences mSettings;
		internal SharedPreferences.Editor mEditor;

		public override void onCreate(Bundle icicle)
		{
			base.onCreate(icicle);
			ContentView = R.layout.set_push_time;
			init();
			initListener();
		}

	   public override void onStart()
	   {
			base.onStart();
			initData();
	   }

		private void init()
		{
			startTime = (TimePicker) findViewById(R.id.start_time);
			endTime = (TimePicker) findViewById(R.id.end_time);
			startTime.Is24HourView = DateFormat.is24HourFormat(this);
			endTime.Is24HourView = DateFormat.is24HourFormat(this);
			mSetTime = (Button)findViewById(R.id.bu_setTime);
			mMonday = (CheckBox)findViewById(R.id.cb_monday);
			mTuesday = (CheckBox)findViewById(R.id.cb_tuesday);
			mWednesday = (CheckBox)findViewById(R.id.cb_wednesday);
			mThursday = (CheckBox)findViewById(R.id.cb_thursday);
			mFriday = (CheckBox)findViewById(R.id.cb_friday);
			mSaturday = (CheckBox)findViewById(R.id.cb_saturday);
			mSunday = (CheckBox)findViewById(R.id.cb_sunday);
		}

		private void initListener()
		{
		   mSetTime.OnClickListener = this;
		}

		private void initData()
		{
		  mSettings = getSharedPreferences(ExampleUtil.PREFS_NAME, MODE_PRIVATE);
		  string days = mSettings.getString(ExampleUtil.PREFS_DAYS, "");
			if (!TextUtils.isEmpty(days))
			{
				initAllWeek(false);
				string[] sArray = days.Split(",", true);
				foreach (string day in sArray)
				{
					Week = day;
				}
			}
			else
			{
				initAllWeek(true);
			}

		  int startTimeStr = mSettings.getInt(ExampleUtil.PREFS_START_TIME, 0);
		  startTime.CurrentHour = startTimeStr;
		  int endTimeStr = mSettings.getInt(ExampleUtil.PREFS_END_TIME, 23);
		  endTime.CurrentHour = endTimeStr;
		}

		public override void onClick(View v)
		{
			switch (v.Id)
			{
			case R.id.bu_setTime:
				v.requestFocus();
				v.requestFocusFromTouch();
				setPushTime();
				break;
			}
		}

		/// <summary>
		/// 设置允许接收通知时间
		/// </summary>
		private void setPushTime()
		{
			int startime = startTime.CurrentHour;
			int endtime = endTime.CurrentHour;
			if (startime > endtime)
			{
				Toast.makeText(SettingActivity.this, "开始时间不能大于结束时间", Toast.LENGTH_SHORT).show();
				return;
			}
			StringBuilder daysSB = new StringBuilder();
			ISet<int> days = new HashSet<int>();
			if (mSunday.Checked)
			{
				days.Add(0);
				daysSB.Append("0,");
			}
			if (mMonday.Checked)
			{
				days.Add(1);
				daysSB.Append("1,");
			}
			if (mTuesday.Checked)
			{
				days.Add(2);
				daysSB.Append("2,");
			}
			if (mWednesday.Checked)
			{
				days.Add(3);
				daysSB.Append("3,");
			}
			if (mThursday.Checked)
			{
				days.Add(4);
				daysSB.Append("4,");
			}
			if (mFriday.Checked)
			{
				days.Add(5);
				daysSB.Append("5,");
			}
			if (mSaturday.Checked)
			{
				days.Add(6);
				daysSB.Append("6,");
			}


			//调用JPush api设置Push时间
			JPushInterface.setPushTime(ApplicationContext, days, startime, endtime);

			mEditor = mSettings.edit();
			mEditor.putString(ExampleUtil.PREFS_DAYS, daysSB.ToString());
			mEditor.putInt(ExampleUtil.PREFS_START_TIME, startime);
			mEditor.putInt(ExampleUtil.PREFS_END_TIME, endtime);
			mEditor.commit();
			Toast.makeText(SettingActivity.this, R.@string.setting_su, Toast.LENGTH_SHORT).show();
		}

		public override bool onKeyDown(int keyCode, KeyEvent @event)
		{
			if (keyCode == KeyEvent.KEYCODE_BACK)
			{
				finish();
			}
			return base.onKeyDown(keyCode, @event);
		}

		private string Week
		{
			set
			{
				   int dayId = Convert.ToInt32(value);
				   switch (dayId)
				   {
					case 0:
						mSunday.Checked = true;
						break;
					case 1:
						mMonday.Checked = true;
						break;
					case 2:
						mTuesday.Checked = true;
						break;
					case 3:
						mWednesday.Checked = true;
						break;
					case 4:
						mThursday.Checked = true;
						break;
					case 5:
						mFriday.Checked = true;
						break;
					case 6:
						mSaturday.Checked = true;
						break;
				   }
			}
		}

		private void initAllWeek(bool isChecked)
		{
			mSunday.Checked = isChecked;
			mMonday.Checked = isChecked;
			mTuesday.Checked = isChecked;
			mWednesday.Checked = isChecked;
			mThursday.Checked = isChecked;
			mFriday.Checked = isChecked;
			mSaturday.Checked = isChecked;
		}
	}
}