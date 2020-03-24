using Android.Content;
using Android.OS;
using Android.Util;
using CN.Jpush.Android.Api;
using CN.Jpush.Android.Service;
using System;

namespace yufeng.XST
{
    //using Context = Android.content.Context;
    //using Intent = Android.content.Intent;
    //using Bundle = Android.os.Bundle;
    //using Log = Android.util.Log;

    //using JSONException = org.json.JSONException;
    //using JSONObject = org.json.JSONObject;

    //using CmdMessage = cn.jpush.Android.api.CmdMessage;
    //using CustomMessage = cn.jpush.Android.api.CustomMessage;
    //using JPushInterface = cn.jpush.Android.api.JPushInterface;
    //using JPushMessage = cn.jpush.Android.api.JPushMessage;
    //using NotificationMessage = cn.jpush.Android.api.NotificationMessage;
    //using JPushMessageReceiver = cn.jpush.Android.service.JPushMessageReceiver;
    [BroadcastReceiver(Name = "com.XST.PushMessageReceiver")]
    public class PushMessageReceiver : JPushMessageReceiver
    {
        private const string TAG = "PushMessageReceiver";
        public override void OnMessage(Context context, CustomMessage customMessage)
        {
            Log.Error(TAG, "[onMessage] " + customMessage);
            processCustomMessage(context, customMessage);
        }

        public override void OnNotifyMessageOpened(Context context, NotificationMessage message)
        {
            Log.Error(TAG, "[onNotifyMessageOpened] " + message);
            try
            {
                //打开自定义的Activity
                Intent i = new Intent(context, typeof(TestActivity));
                Bundle bundle = new Bundle();
                bundle.PutString(JPushInterface.ExtraNotificationTitle, message.NotificationTitle);
                bundle.PutString(JPushInterface.ExtraAlert, message.NotificationContent);
                i.PutExtras(bundle);
                //i.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                i.SetFlags(ActivityFlags.NewTask | ActivityFlags.ClearTop);
                context.StartActivity(i);
            }
            catch (Exception)
            {

            }
        }

        public override void OnMultiActionClicked(Context context, Intent intent)
        {
            Log.Error(TAG, "[onMultiActionClicked] 用户点击了通知栏按钮");
            string nActionExtra = intent.Extras.GetString(JPushInterface.ExtraNotificationActionExtra);

            //开发者根据不同 Action 携带的 extra 字段来分配不同的动作。
            if (string.ReferenceEquals(nActionExtra, null))
            {
                Log.Debug(TAG, "ACTION_NOTIFICATION_CLICK_ACTION nActionExtra is null");
                return;
            }
            if (nActionExtra.Equals("my_extra1"))
            {
                Log.Error(TAG, "[onMultiActionClicked] 用户点击通知栏按钮一");
            }
            else if (nActionExtra.Equals("my_extra2"))
            {
                Log.Error(TAG, "[onMultiActionClicked] 用户点击通知栏按钮二");
            }
            else if (nActionExtra.Equals("my_extra3"))
            {
                Log.Error(TAG, "[onMultiActionClicked] 用户点击通知栏按钮三");
            }
            else
            {
                Log.Error(TAG, "[onMultiActionClicked] 用户点击通知栏按钮未定义");
            }
        }

        public override void OnNotifyMessageArrived(Context context, NotificationMessage message)
        {
            Log.Error(TAG, "[onNotifyMessageArrived] " + message);
        }

        public override void OnNotifyMessageDismiss(Context context, NotificationMessage message)
        {
            Log.Error(TAG, "[onNotifyMessageDismiss] " + message);
        }

        public override void OnRegister(Context context, string registrationId)
        {
            Log.Error(TAG, "[onRegister] " + registrationId);
        }

        public override void OnConnected(Context context, bool isConnected)
        {
            Log.Error(TAG, "[onConnected] " + isConnected);
        }

        public override void OnCommandResult(Context context, CmdMessage cmdMessage)
        {
            Log.Error(TAG, "[onCommandResult] " + cmdMessage);
        }

        public override void OnTagOperatorResult(Context context, JPushMessage jPushMessage)
        {
            TagAliasOperatorHelper.Instance.onTagOperatorResult(context, jPushMessage);
            base.OnTagOperatorResult(context, jPushMessage);
        }
        public override void OnCheckTagOperatorResult(Context context, JPushMessage jPushMessage)
        {
            TagAliasOperatorHelper.Instance.onCheckTagOperatorResult(context, jPushMessage);
            base.OnCheckTagOperatorResult(context, jPushMessage);
        }
        public override void OnAliasOperatorResult(Context context, JPushMessage jPushMessage)
        {
            TagAliasOperatorHelper.Instance.onAliasOperatorResult(context, jPushMessage);
            base.OnAliasOperatorResult(context, jPushMessage);
        }

        public override void OnMobileNumberOperatorResult(Context context, JPushMessage jPushMessage)
        {
            TagAliasOperatorHelper.Instance.onMobileNumberOperatorResult(context, jPushMessage);
            base.OnMobileNumberOperatorResult(context, jPushMessage);
        }

        //send msg to MainActivity
        private void processCustomMessage(Context context, CustomMessage customMessage)
        {
            if (MainActivity.isForeground)
            {
                string message = customMessage.Message;
                string extras = customMessage.Extra;
                Intent msgIntent = new Intent(MainActivity.MESSAGE_RECEIVED_ACTION);
                msgIntent.PutExtra(MainActivity.KEY_MESSAGE, message);
                if (!ExampleUtil.isEmpty(extras))
                {
                    try
                    {
                        Newtonsoft.Json.Linq.JObject extraJson = Newtonsoft.Json.Linq.JObject.Parse(extras);
                        if (extraJson != null)
                        {
                            msgIntent.PutExtra(MainActivity.KEY_EXTRAS, extras);
                        }
                    }
                    catch (Newtonsoft.Json.JsonException ex)
                    {

                    }

                }
                // LocalBroadcastManager.getInstance(context).sendBroadcast(msgIntent);
            }
        }

        public override void OnNotificationSettingsCheck(Context context, bool isOn, int source)
        {
            base.OnNotificationSettingsCheck(context, isOn, source);
            Log.Error(TAG, "[onNotificationSettingsCheck] isOn:" + isOn + ",source:" + source);
        }

    }

}