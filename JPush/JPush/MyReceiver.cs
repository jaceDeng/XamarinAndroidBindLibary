using CN.Jpush.Android.Api;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace yufeng.XST
{
    using BroadcastReceiver = Android.Content.BroadcastReceiver;
    using Context = Android.Content.Context;
    using Intent = Android.Content.Intent;
    using Bundle = Android.OS.Bundle;
    using TextUtils = Android.Text.TextUtils;
    using Android.OS;

    //using JSONException = org.json.JSONException;
    //using JSONObject = org.json.JSONObject;

    // using JPushInterface = cn.jpush.Android.api.JPushInterface;

    /// <summary>
    /// 自定义接收器
    /// 
    /// 如果不定义这个 Receiver，则：
    /// 1) 默认用户会打开主界面
    /// 2) 接收不到自定义消息
    /// </summary>
    public class MyReceiver : BroadcastReceiver
    {
        private const string TAG = "JIGUANG-Example";

        public override void OnReceive(Context context, Intent intent)
        {
            try
            {
                Bundle bundle = intent.Extras;
                Logger.d(TAG, "[MyReceiver] onReceive - " + intent.Action + ", extras: " + printBundle(bundle));

                if (JPushInterface.ActionRegistrationId.Equals(intent.Action))
                {
                    string regId = bundle.GetString(JPushInterface.ExtraRegistrationId);
                    Logger.d(TAG, "[MyReceiver] 接收Registration Id : " + regId);
                    //send the Registration Id to your server...

                }
                else if (JPushInterface.ActionMessageReceived.Equals(intent.Action))
                {
                    Logger.d(TAG, "[MyReceiver] 接收到推送下来的自定义消息: " +
                        bundle.GetString(JPushInterface.ExtraMessage));
                    processCustomMessage(context, bundle);

                }
                else if (JPushInterface.ActionNotificationReceived.Equals(intent.Action))
                {
                    Logger.d(TAG, "[MyReceiver] 接收到推送下来的通知");
                    int notifactionId = bundle.GetInt(JPushInterface.ExtraNotificationId);
                    Logger.d(TAG, "[MyReceiver] 接收到推送下来的通知的ID: " + notifactionId);

                }
                else if (JPushInterface.ActionNotificationOpened.Equals(intent.Action))
                {
                    Logger.d(TAG, "[MyReceiver] 用户点击打开了通知");

                    //打开自定义的Activity
                    Intent i = new Intent(context, typeof(TestActivity));
                    i.PutExtras(bundle);
                    //i.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    i.SetFlags(Android.Content.ActivityFlags.NewTask | Android.Content.ActivityFlags.ClearTop);
                    context.StartActivity(i);

                }
                else if (JPushInterface.ActionConnectionChange.Equals(intent.Action))
                {
                    bool connected = intent.GetBooleanExtra(JPushInterface.ExtraConnectionChange, false);
                    Logger.w(TAG, "[MyReceiver]" + intent.Action + " connected state change to " + connected);
                }
                else
                {
                    Logger.d(TAG, "[MyReceiver] Unhandled intent - " + intent.Action);
                }
            }
            catch (Exception)
            {

            }

        }


        // 打印所有的 intent extra 数据
        private static string printBundle(Bundle bundle)
        {
            StringBuilder sb = new StringBuilder();
            //foreach (string key in bundle.KeySet)
            //{
            //    if (key.Equals(JPushInterface.EXTRA_NOTIFICATION_ID))
            //    {
            //        sb.Append("\nkey:" + key + ", value:" + bundle.getInt(key));
            //    }
            //    else if (key.Equals(JPushInterface.EXTRA_CONNECTION_CHANGE))
            //    {
            //        sb.Append("\nkey:" + key + ", value:" + bundle.getBoolean(key));
            //    }
            //    else if (key.Equals(JPushInterface.EXTRA_EXTRA))
            //    {
            //        if (TextUtils.isEmpty(bundle.getString(JPushInterface.EXTRA_EXTRA)))
            //        {
            //            Logger.i(TAG, "This message has no Extra data");
            //            continue;
            //        }

            //        try
            //        {
            //            Newtonsoft.Json.Linq.JObject json = JObject.Parse(bundle.GetString(JPushInterface.EXTRA_EXTRA));
            //            IEnumerator<string> it = json.keys();

            //            while (it.MoveNext())
            //            {
            //                string myKey = it.Current;
            //                sb.Append("\nkey:" + key + ", value: [" + myKey + " - " + json.optString(myKey) + "]");
            //            }
            //        }
            //        catch (JSONException e)
            //        {
            //            Logger.e(TAG, "Get message extra JSON error!");
            //        }

            //    }
            //    else
            //    {
            //        sb.Append("\nkey:" + key + ", value:" + bundle.Get(key));
            //    }
            //}
            return sb.ToString();
        }

        //send msg to MainActivity
        private void processCustomMessage(Context context, Bundle bundle)
        {
            if (MainActivity.isForeground)
            {
                string message = bundle.GetString(JPushInterface.EXTRA_MESSAGE);
                string extras = bundle.GetString(JPushInterface.EXTRA_EXTRA);
                Intent msgIntent = new Intent(MainActivity.MESSAGE_RECEIVED_ACTION);
                msgIntent.PutExtra(MainActivity.KEY_MESSAGE, message);
                if (!ExampleUtil.isEmpty(extras))
                {
                    try
                    {
                        JSONObject extraJson = new JSONObject(extras);
                        if (extraJson.length() > 0)
                        {
                            msgIntent.PutExtra(MainActivity.KEY_EXTRAS, extras);
                        }
                    }
                    catch (JSONException)
                    {

                    }

                }
                //LocalBroadcastManager.getInstance(context).sendBroadcast(msgIntent);
            }
        }
    }

}