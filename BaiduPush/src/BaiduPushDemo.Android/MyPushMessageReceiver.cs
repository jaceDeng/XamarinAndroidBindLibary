using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Baidu.Android.Pushservice;

namespace BaiduPushDemo.Droid
{
    [Register("com.baidu.push.app.MyPushMessageReceiver")]
    public class MyPushMessageReceiver : PushMessageReceiver
    {
        public override void OnBind(Context context, int errorCode, String appid,
                       String userId, String channelId, String requestId)
        {
            String responseString = "onBind errorCode=" + errorCode + " appid="
                    + appid + " userId=" + userId + " channelId=" + channelId
                    + " requestId=" + requestId;
            Log.Debug("MyPushMessageReceiver", responseString);

            if (errorCode == 0)
            {
                // 绑定成功
                Log.Debug("MyPushMessageReceiver", "绑定成功");
            }
        }

        public override void OnDelTags(Context p0, int p1, IList<string> p2, IList<string> p3, string p4)
        {

        }

        public override void OnListTags(Context p0, int p1, IList<string> p2, string p3)
        {

        }

        public override void OnMessage(Context p0, string p1, string p2)
        {

        }

        public override void OnNotificationArrived(Context context, String title,
                                      String description, String customContentString)
        {
            String notifyString = "通知到达 onNotificationArrived  title=\"" + title
               + "\" description=\"" + description + "\" customContent="
               + customContentString;
            Log.Debug("MyPushMessageReceiver", notifyString);

            //// 自定义内容获取方式，mykey和myvalue对应通知推送时自定义内容中设置的键和值
            //if (!TextUtils.isEmpty(customContentString))
            //{
            //    JSONObject customJson = null;
            //    try
            //    {
            //        customJson = new JSONObject(customContentString);
            //        String myvalue = null;
            //        if (!customJson.isNull("mykey"))
            //        {
            //            myvalue = customJson.getString("mykey");
            //        }
            //    }
            //    catch (JSONException e)
            //    {
            //        // TODO Auto-generated catch block
            //        e.printStackTrace();
            //    }
            //}
        }

        public override void OnNotificationClicked(Context p0, string p1, string p2, string p3)
        {

        }

        public override void OnSetTags(Context p0, int p1, IList<string> p2, IList<string> p3, string p4)
        {

        }

        public override void OnUnbind(Context p0, int p1, string p2)
        {

        }
    }
}