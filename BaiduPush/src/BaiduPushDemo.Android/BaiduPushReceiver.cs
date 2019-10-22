using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Baidu.Android.Pushservice;
using static Android.Provider.MediaStore;

namespace BaiduPushDemo.Droid
{
    //[BroadcastReceiver(Name = "com.baidu.push.app.MyPushMessageReceiver")]
    //[IntentFilter(new string[] {
    //    "com.baidu.android.pushservice.action.MESSAGE",
    //    "com.baidu.android.pushservice.action.RECEIVE",
    //    "com.baidu.android.pushservice.action.notification.CLICK"
    //})]
    
    public class BaiduPushReceiver : PushMessageReceiver
    {
        public static string mChannelId, mUserId;
        public BaiduPushReceiver() : base()
        {

        }
        /// <summary>
        /// Call this to initialize Baidu's push notification service for this device.
        /// 调用此功能开启百度推送通知服务。
        /// </summary>
        //public static void InitializeBaiduPushManager(Context context)
        //{
        //    string baiduPushApiKey = GetMetaDataValueByName("baidu_api_key");

        //    if (!string.IsNullOrWhiteSpace(baiduPushApiKey))
        //    {
        //        PushManager.StartWork(context, PushConstants.LoginTypeApiKey, baiduPushApiKey);
        //    }
        //}

        /// <summary>
        /// Gets the value of meta data from AndroidManifest.xml, based on the given name.
        /// 获取AndroidManifest.xml的对应meta data name的值。
        /// </summary>
        /// <param name="metaDataName"></param>
        /// <returns></returns>
        //private static string GetMetaDataValueByName(string metaDataName)
        //{
        //    Bundle metaData = null;
        //    string metaDataValue = "";
        //    Context context = Application.Context;
        //    Android.Content.PM.ApplicationInfo ai = context.PackageManager.GetApplicationInfo(context.PackageName, Android.Content.PM.PackageInfoFlags.MetaData);

        //    if (ai != null)
        //        metaData = ai.MetaData;

        //    if (metaData != null)
        //        metaDataValue = metaData.GetString(metaDataName);

        //    return metaDataValue;
        //}

        /// <summary>
        /// Sends the push notification channel id to the server.
        /// 把channel id发送到服务器。
        /// </summary>
        /// <param name="channelId">User's push token/用户的推送通知token。</param>
        private async void SendRegistrationToAppServer(string userId, string channelId)
        {
            // Here you should send channelId to your server and save it.
            // 这里应该把channelId发送到服务器并保存一下。
            await Task.Run(() =>
            {
                // Register with your preferred middleware such as Amazon SNS & Azure NotificationHub

                // In this sample, we're registering with Azure Notification Hub
                try
                {

                    System.Diagnostics.Debug.WriteLine($"registation successful: userid: {userId}, channelId: {channelId}");
                }
                catch (Exception ex)
                {

                }
            });
        }

        /// <summary>
        /// This method will be called after calling PushManager.StarWork(). The channelId should be sent to your
        /// server; this value can be used to send push notifictions to this user.
        /// 调用PushManager.StartWork()以后，此功能要提供channelId。因为channelId让你发送本用户给通知，所以你应该把channelId
        /// 保存在服务器里。
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCode"></param>
        /// <param name="appid"></param>
        /// <param name="userId"></param>
        /// <param name="channelId"></param>
        /// <param name="requestId"></param>
        public override void OnBind(Context context, int errorCode, string appid, string userId, string channelId, string requestId)
        {

            System.Diagnostics.Debug.WriteLine(string.Format(" OnBind === errorCode: {0} ---- appid: {1} userId: {2} channelId: {3}", errorCode, appid, userId, channelId));
            PushManager.SetTags(context, new List<string> { "aaa" });
            SendRegistrationToAppServer(userId, channelId);
            PushManager.ListTags(context);
        }

        public override void OnDelTags(Context context, int errorCode, IList<string> successTags, IList<string> failedTags, string requestId)
        {
        }

        public override void OnListTags(Context context, int errorCode, IList<string> tags, string requestId)
        {
            System.Diagnostics.Debug.WriteLine(" === tags start === ");
            foreach (var tag in tags)
            {
                System.Diagnostics.Debug.WriteLine(tag);
            }
            System.Diagnostics.Debug.WriteLine(" === tags end === ");
        }

        public override void OnMessage(Context context, string message, string customContent)
        {
        }

        public override void OnNotificationArrived(Context context, string title, string description, string customContent)
        {
            if (string.IsNullOrEmpty(customContent))
            {
            }
            else
            {

            }
            //ProcessNotification(context,"");
            System.Diagnostics.Debug.WriteLine(" === OnNotificationArrived === {0} {1} {2}", title, description, customContent);
        }

        public override void OnNotificationClicked(Context context, string title, string description, string customContent)
        {
        }

        public override void OnSetTags(Context context, int errorCode, IList<string> successTags, IList<string> failedTags, string requestId)
        {
        }

        public override void OnUnbind(Context context, int errorCode, string requestId)
        {
        }

        private void ProcessNotification(Context context, string content)
        {
            Intent intent = new Intent();
            intent.SetClass(context.ApplicationContext, typeof(MainActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            context.ApplicationContext.StartActivity(intent);
        }
    }
}