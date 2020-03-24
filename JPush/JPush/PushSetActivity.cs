using System.Collections.Generic;

namespace yufeng.XST
{
	using Activity = Android.app.Activity;
	using Notification = Android.app.Notification;
	using Intent = Android.content.Intent;
	using Bundle = Android.os.Bundle;
	using TextUtils = Android.text.TextUtils;
	using Log = Android.util.Log;
	using KeyEvent = Android.view.KeyEvent;
	using View = Android.view.View;
	using OnClickListener = Android.view.View.OnClickListener;
	using EditText = Android.widget.EditText;
	using Toast = Android.widget.Toast;


	using BasicPushNotificationBuilder = cn.jpush.Android.api.BasicPushNotificationBuilder;
	using CustomPushNotificationBuilder = cn.jpush.Android.api.CustomPushNotificationBuilder;
	using JPushInterface = cn.jpush.Android.api.JPushInterface;
	using MultiActionsNotificationBuilder = cn.jpush.Android.api.MultiActionsNotificationBuilder;
	using TagAliasCallback = cn.jpush.Android.api.TagAliasCallback;

//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.ACTION_ADD;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.ACTION_CHECK;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.ACTION_CLEAN;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.ACTION_DELETE;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.ACTION_GET;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.ACTION_SET;
	using static yufeng.XST.TagAliasOperatorHelper.TagAliasBean;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static yufeng.XST.TagAliasOperatorHelper.sequence;


	public class PushSetActivity : Activity, View.OnClickListener
	{
		private const string TAG = "JIGUANG-Example";

		public override void onCreate(Bundle icicle)
		{
			base.onCreate(icicle);
			ContentView = R.layout.push_set_dialog;
			initListener();
		}

		private void initListener()
		{
			//增加tag
			findViewById(R.id.bt_addtag).OnClickListener = this;
			//设置tag
			findViewById(R.id.bt_settag).setOnClickListener(this);
			//删除tag
			findViewById(R.id.bt_deletetag).OnClickListener = this;
			//获取所有tag
			findViewById(R.id.bt_getalltag).OnClickListener = this;
			//清除所有tag
			findViewById(R.id.bt_cleantag).OnClickListener = this;
			//查询tag绑定状态
			findViewById(R.id.bt_checktag).OnClickListener = this;

			//设置alias
			findViewById(R.id.bt_setalias).setOnClickListener(this);
			//获取alias
			findViewById(R.id.bt_getalias).OnClickListener = this;
			//删除alias
			findViewById(R.id.bt_deletealias).OnClickListener = this;
			//设置手机号码
			findViewById(R.id.bt_setmobileNumber).setOnClickListener(this);
			//StyleAddActions
			findViewById(R.id.setStyle0).setOnClickListener(this);
			//StyleBasic
			findViewById(R.id.setStyle1).setOnClickListener(this);
			//StyleCustom
			findViewById(R.id.setStyle2).setOnClickListener(this);
			//SetPushTime
			findViewById(R.id.bu_setTime).setOnClickListener(this);
		}

		public override void onClick(View view)
		{
			switch (view.Id)
			{
				case R.id.setStyle0:
					setAddActionsStyle();
					break;
				case R.id.setStyle1:
					setStyleBasic();
					break;
				case R.id.setStyle2:
					setStyleCustom();
					break;
				case R.id.bu_setTime:
					Intent intent = new Intent(PushSetActivity.this, typeof(SettingActivity));
					startActivity(intent);
					break;
				default:
					onTagAliasAction(view);
					break;
			}
		}

		internal TagAliasCallback tagAlias = new TagAliasCallbackAnonymousInnerClass();

		private class TagAliasCallbackAnonymousInnerClass : TagAliasCallback
		{
			public override void gotResult(int responseCode, string alias, ISet<string> tags)
			{
				Log.e(TAG,"responseCode:" + responseCode + ",alias:" + alias + ",tags:" + tags);
			}
		}


		/// <summary>
		/// 设置通知提示方式 - 基础属性
		/// </summary>
		private void setStyleBasic()
		{
			BasicPushNotificationBuilder builder = new BasicPushNotificationBuilder(PushSetActivity.this);
			builder.statusBarDrawable = R.drawable.ic_launcher;
			builder.notificationFlags = Notification.FLAG_AUTO_CANCEL; //设置为点击后自动消失
			builder.notificationDefaults = Notification.DEFAULT_SOUND; //设置为铃声（ Notification.DEFAULT_SOUND）或者震动（ Notification.DEFAULT_VIBRATE）
			JPushInterface.setPushNotificationBuilder(1, builder);
			Toast.makeText(PushSetActivity.this, "Basic Builder - 1", Toast.LENGTH_SHORT).show();
		}


		/// <summary>
		/// 设置通知栏样式 - 定义通知栏Layout
		/// </summary>
		private void setStyleCustom()
		{
			CustomPushNotificationBuilder builder = new CustomPushNotificationBuilder(PushSetActivity.this, R.layout.customer_notitfication_layout, R.id.icon, R.id.title, R.id.text);
			builder.layoutIconDrawable = R.drawable.ic_launcher;
			builder.developerArg0 = "developerArg2";
			JPushInterface.setPushNotificationBuilder(2, builder);
			Toast.makeText(PushSetActivity.this, "Custom Builder - 2", Toast.LENGTH_SHORT).show();
		}

		public override bool onKeyDown(int keyCode, KeyEvent @event)
		{
			if (keyCode == KeyEvent.KEYCODE_BACK)
			{
				finish();
			}
			return base.onKeyDown(keyCode, @event);
		}

		private void setAddActionsStyle()
		{
			MultiActionsNotificationBuilder builder = new MultiActionsNotificationBuilder(PushSetActivity.this);
			builder.addJPushAction(R.drawable.jpush_ic_richpush_actionbar_back, "first", "my_extra1");
			builder.addJPushAction(R.drawable.jpush_ic_richpush_actionbar_back, "second", "my_extra2");
			builder.addJPushAction(R.drawable.jpush_ic_richpush_actionbar_back, "third", "my_extra3");
			JPushInterface.setPushNotificationBuilder(10, builder);

			Toast.makeText(PushSetActivity.this, "AddActions Builder - 10", Toast.LENGTH_SHORT).show();
		}


		/// <summary>
		///===========================================================================* </summary>
		/// <summary>
		///=========================TAG/ALIAS 相关=====================================* </summary>
		/// <summary>
		///===========================================================================* </summary>

		/// <summary>
		/// 处理tag/alias相关操作的点击
		/// 
		/// </summary>
		public virtual void onTagAliasAction(View view)
		{
			ISet<string> tags = null;
			string alias = null;
			int action = -1;
			bool isAliasAction = false;
			switch (view.Id)
			{
				//设置手机号码:
				case R.id.bt_setmobileNumber:
					handleSetMobileNumber();
					return;
				//增加tag
				case R.id.bt_addtag:
					tags = InPutTags;
					if (tags == null)
					{
						return;
					}
					action = ACTION_ADD;
					break;
				//设置tag
				case R.id.bt_settag:
					tags = InPutTags;
					if (tags == null)
					{
						return;
					}
					action = ACTION_SET;
					break;
				//删除tag
				case R.id.bt_deletetag:
					tags = InPutTags;
					if (tags == null)
					{
						return;
					}
					action = ACTION_DELETE;
					break;
				//获取所有tag
				case R.id.bt_getalltag:
					action = ACTION_GET;
					break;
				//清除所有tag
				case R.id.bt_cleantag:
					action = ACTION_CLEAN;
					break;
				case R.id.bt_checktag:
					tags = InPutTags;
					if (tags == null)
					{
						return;
					}
					action = ACTION_CHECK;
					break;
				//设置alias
				case R.id.bt_setalias:
					alias = InPutAlias;
					if (TextUtils.isEmpty(alias))
					{
						return;
					}
					isAliasAction = true;
					action = ACTION_SET;
					break;
				//获取alias
				case R.id.bt_getalias:
					isAliasAction = true;
					action = ACTION_GET;
					break;
				//删除alias
				case R.id.bt_deletealias:
					isAliasAction = true;
					action = ACTION_DELETE;
					break;
				default:
					return;
			}
			TagAliasBean tagAliasBean = new TagAliasBean();
			tagAliasBean.action = action;
			sequence++;
			if (isAliasAction)
			{
				tagAliasBean.alias = alias;
			}
			else
			{
				tagAliasBean.tags = tags;
			}
			tagAliasBean.isAliasAction = isAliasAction;
			TagAliasOperatorHelper.Instance.handleAction(ApplicationContext,sequence,tagAliasBean);
		}

		private void handleSetMobileNumber()
		{
			EditText mobileEdit = (EditText) findViewById(R.id.et_mobilenumber);
			string mobileNumber = mobileEdit.Text.ToString().Trim();
			if (TextUtils.isEmpty(mobileNumber))
			{
				Toast.makeText(ApplicationContext, R.@string.mobilenumber_empty_guide, Toast.LENGTH_SHORT).show();
			}
			if (!ExampleUtil.isValidMobileNumber(mobileNumber))
			{
				Toast.makeText(ApplicationContext, R.@string.error_tag_gs_empty, Toast.LENGTH_SHORT).show();
				return;
			}
			sequence++;
			TagAliasOperatorHelper.Instance.handleAction(ApplicationContext,sequence,mobileNumber);
		}
		/// <summary>
		/// 获取输入的alias
		/// 
		/// </summary>
		private string InPutAlias
		{
			get
			{
				EditText aliasEdit = (EditText) findViewById(R.id.et_alias);
				string alias = aliasEdit.Text.ToString().Trim();
				if (TextUtils.isEmpty(alias))
				{
					Toast.makeText(ApplicationContext, R.@string.error_alias_empty, Toast.LENGTH_SHORT).show();
					return null;
				}
				if (!ExampleUtil.isValidTagAndAlias(alias))
				{
					Toast.makeText(ApplicationContext, R.@string.error_tag_gs_empty, Toast.LENGTH_SHORT).show();
					return null;
				}
				return alias;
			}
		}
		/// <summary>
		/// 获取输入的tags
		/// 
		/// </summary>
		private ISet<string> InPutTags
		{
			get
			{
				EditText tagEdit = (EditText) findViewById(R.id.et_tag);
				string tag = tagEdit.Text.ToString().Trim();
				// 检查 tag 的有效性
				if (TextUtils.isEmpty(tag))
				{
					Toast.makeText(ApplicationContext, R.@string.error_tag_empty, Toast.LENGTH_SHORT).show();
					return null;
				}
    
				// ","隔开的多个 转换成 Set
				string[] sArray = tag.Split(",", true);
				ISet<string> tagSet = new LinkedHashSet<string>();
				foreach (string sTagItme in sArray)
				{
					if (!ExampleUtil.isValidTagAndAlias(sTagItme))
					{
						Toast.makeText(ApplicationContext, R.@string.error_tag_gs_empty, Toast.LENGTH_SHORT).show();
						return null;
					}
					tagSet.Add(sTagItme);
				}
				if (tagSet.Count == 0)
				{
					Toast.makeText(ApplicationContext, R.@string.error_tag_empty, Toast.LENGTH_SHORT).show();
					return null;
				}
				return tagSet;
			}
		}
	}


}