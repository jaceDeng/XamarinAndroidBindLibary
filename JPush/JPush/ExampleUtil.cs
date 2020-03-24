using Android.Content;
using Android.Content.PM;
using Android.Net;
using Android.OS;
using Android.Telephony;
using Android.Text;
using Android.Widget;
using System;
using System.Threading;

namespace yufeng.XST
{
    //using Context = Android.content.Context;
    //using ApplicationInfo = Android.content.pm.ApplicationInfo;
    //using PackageInfo = Android.content.pm.PackageInfo;
    //using PackageManager = Android.content.pm.PackageManager;
    //using NameNotFoundException = Android.content.pm.PackageManager.NameNotFoundException;
    //using ConnectivityManager = Android.net.ConnectivityManager;
    //using NetworkInfo = Android.net.NetworkInfo;
    //using Bundle = Android.os.Bundle;
    //using Looper = Android.os.Looper;
    //using TelephonyManager = Android.telephony.TelephonyManager;
    //using TextUtils = Android.text.TextUtils;
    //using Toast = Android.widget.Toast;


    using JPushInterface = CN.Jpush.Android.Api.JPushInterface;

    public class ExampleUtil
    {
        public const string PREFS_NAME = "JPUSH_EXAMPLE";
        public const string PREFS_DAYS = "JPUSH_EXAMPLE_DAYS";
        public const string PREFS_START_TIME = "PREFS_START_TIME";
        public const string PREFS_END_TIME = "PREFS_END_TIME";
        public const string KEY_APP_KEY = "JPUSH_APPKEY";

        public static bool isEmpty(string s)
        {
            if (null == s)
            {
                return true;
            }
            if (s.Length == 0)
            {
                return true;
            }
            if (s.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 只能以 "+" 或者 数字开头；后面的内容只能包含 "-" 和 数字。
        /// 
        /// </summary>
        private const string MOBILE_NUMBER_CHARS = "^[+0-9][-0-9]{1,}$";
        public static bool isValidMobileNumber(string s)
        {
            if (TextUtils.IsEmpty(s))
            {
                return true;
            }
            System.Text.RegularExpressions.Regex p = new System.Text.RegularExpressions.Regex(MOBILE_NUMBER_CHARS);

            return p.IsMatch(s);
        }
        // 校验Tag Alias 只能是数字,英文字母和中文
        public static bool isValidTagAndAlias(string s)
        {
            System.Text.RegularExpressions.Regex p = new System.Text.RegularExpressions.Regex("^[\u4E00-\u9FA50-9a-zA-Z_!@#$&*+=.|]+$");

            return p.IsMatch(s);
        }

        // 取得AppKey
        public static string getAppKey(Context context)
        {
            Bundle metaData = null;
            string appKey = null;
            try
            {
                ApplicationInfo ai = context.PackageManager.GetApplicationInfo(context.PackageName,
                PackageInfoFlags.MetaData);
                if (null != ai)
                {
                    metaData = ai.MetaData;
                }
                if (null != metaData)
                {
                    appKey = metaData.GetString(KEY_APP_KEY);
                    if ((null == appKey) || appKey.Length != 24)
                    {
                        appKey = null;
                    }
                }
            }
            catch (PackageManager.NameNotFoundException)
            {

            }
            return appKey;
        }

        // 取得版本号
        public static string GetVersion(Context context)
        {
            try
            {
                PackageInfo manager = context.PackageManager.GetPackageInfo(context.PackageName, 0);
                return manager.VersionName;
            }
            catch (PackageManager.NameNotFoundException)
            {
                return "Unknown";
            }
        }

        public static void showToast(string toast, Context context)
        {
            (new Thread(() =>
            {

                Looper.Prepare();
                Toast.MakeText(context, toast, ToastLength.Short).Show();
                Looper.Loop();
            })).Start();
        }

        public static bool isConnected(Context context)
        {
            ConnectivityManager conn = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
            NetworkInfo info = conn.ActiveNetworkInfo;
            return (info != null && info.IsConnected);
        }

        public static string getImei(Context context, string imei)
        {
            string ret = null;
            try
            {
                TelephonyManager telephonyManager = (TelephonyManager)context.GetSystemService(Context.TelephonyService);
                ret = telephonyManager.DeviceId;
            }
            catch (Exception e)
            {
                Logger.e(typeof(ExampleUtil).Name, e.Message);
            }
            if (isReadableASCII(ret))
            {
                return ret;
            }
            else
            {
                return imei;
            }
        }

        private static bool isReadableASCII(string @string)
        {
            if (TextUtils.IsEmpty(@string))
            {
                return false;
            }
            try
            {
                System.Text.RegularExpressions.Regex p = new System.Text.RegularExpressions.Regex("[\\x20-\\x7E]+");
                return p.IsMatch(@string);
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static string getDeviceId(Context context)
        {
            return JPushInterface.GetUdid(context);
        }
    }

}