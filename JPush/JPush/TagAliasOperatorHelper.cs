using Android.Content;
using Android.OS;
using Android.Util;
using CN.Jpush.Android.Api;
using Java.Util;
using System.Collections.Generic;

namespace yufeng.XST
{
    //using Context = Android.content.Context;
    //using Handler = Android.os.Handler;
    //using Message = Android.os.Message;
    //using SparseArray = Android.util.SparseArray;


    //using JPushInterface = cn.jpush.Android.api.JPushInterface;
    //using JPushMessage = cn.jpush.Android.api.JPushMessage;

    /// <summary>
    /// 处理tagalias相关的逻辑
    /// 
    /// </summary>
    public class TagAliasOperatorHelper
    {
        private const string TAG = "JIGUANG-TagAliasHelper";
        public static int sequence = 1;
        /// <summary>
        ///增加 </summary>
        public const int ACTION_ADD = 1;
        /// <summary>
        ///覆盖 </summary>
        public const int ACTION_SET = 2;
        /// <summary>
        ///删除部分 </summary>
        public const int ACTION_DELETE = 3;
        /// <summary>
        ///删除所有 </summary>
        public const int ACTION_CLEAN = 4;
        /// <summary>
        ///查询 </summary>
        public const int ACTION_GET = 5;

        public const int ACTION_CHECK = 6;

        public const int DELAY_SEND_ACTION = 1;

        public const int DELAY_SET_MOBILE_NUMBER_ACTION = 2;

        private Context context;

        private static TagAliasOperatorHelper mInstance;
        private TagAliasOperatorHelper()
        {
        }
        public static TagAliasOperatorHelper Instance
        {
            get
            {
                if (mInstance == null)
                {
                    lock (typeof(TagAliasOperatorHelper))
                    {
                        if (mInstance == null)
                        {
                            mInstance = new TagAliasOperatorHelper();
                        }
                    }
                }
                return mInstance;
            }
        }
        public virtual void init(Context context)
        {
            if (context != null)
            {
                this.context = context.ApplicationContext;
            }

            delaySendHandler = new Handler((Message msg) =>
            {
                switch (msg.What)
                {
                    case DELAY_SEND_ACTION:
                        if (msg.Obj != null && msg.Obj is TagAliasBean)
                        {
                            Logger.i(TAG, "on delay time");
                            sequence++;
                            TagAliasBean tagAliasBean = (TagAliasBean)msg.Obj;
                            setActionCache.Put(sequence, tagAliasBean);
                            if (context != null)
                            {
                                handleAction(context, sequence, tagAliasBean);
                            }
                            else
                            {
                                Logger.e(TAG, "#unexcepted - context was null");
                            }
                        }
                        else
                        {
                            Logger.w(TAG, "#unexcepted - msg obj was incorrect");
                        }
                        break;
                    case DELAY_SET_MOBILE_NUMBER_ACTION:
                        if (msg.Obj != null && msg.Obj is string)
                        {
                            Logger.i(TAG, "retry set mobile number");
                            sequence++;
                            string mobileNumber = (string)msg.Obj;
                            setActionCache.Put(sequence, mobileNumber);
                            if (context != null)
                            {
                                handleAction(context, sequence, mobileNumber);
                            }
                            else
                            {
                                Logger.e(TAG, "#unexcepted - context was null");
                            }
                        }
                        else
                        {
                            Logger.w(TAG, "#unexcepted - msg obj was incorrect");
                        }
                        break;
                }

            });
        }
        private static SparseArray<object> setActionCache = new SparseArray<object>();

        public virtual object get(int sequence)
        {
            return setActionCache.Get(sequence);
        }
        public virtual object remove(int sequence)
        {
            return setActionCache.Get(sequence);
        }
        public virtual void put(int sequence, object tagAliasBean)
        {
            setActionCache.Put(sequence, tagAliasBean);
        }
        private Handler delaySendHandler;

        public virtual void handleAction(Context context, int sequence, string mobileNumber)
        {
            put(sequence, mobileNumber);
            Logger.d(TAG, "sequence:" + sequence + ",mobileNumber:" + mobileNumber);
            JPushInterface.SetMobileNumber(context, sequence, mobileNumber);
        }
        /// <summary>
        /// 处理设置tag
        /// 
        /// </summary>
        public virtual void handleAction(Context context, int sequence, TagAliasBean tagAliasBean)
        {
            init(context);
            if (tagAliasBean == null)
            {
                Logger.w(TAG, "tagAliasBean was null");
                return;
            }
            put(sequence, tagAliasBean);
            if (tagAliasBean.isAliasAction)
            {
                switch (tagAliasBean.action)
                {
                    case ACTION_GET:
                        JPushInterface.GetAlias(context, sequence);
                        break;
                    case ACTION_DELETE:
                        JPushInterface.DeleteAlias(context, sequence);
                        break;
                    case ACTION_SET:
                        JPushInterface.SetAlias(context, sequence, tagAliasBean.alias);
                        break;
                    default:
                        Logger.w(TAG, "unsupport alias action type");
                        return;
                }
            }
            else
            {
                switch (tagAliasBean.action)
                {
                    case ACTION_ADD:
                        JPushInterface.AddTags(context, sequence, tagAliasBean.tags);
                        break;
                    case ACTION_SET:
                        JPushInterface.SetTags(context, sequence, tagAliasBean.tags);
                        break;
                    case ACTION_DELETE:
                        JPushInterface.DeleteTags(context, sequence, tagAliasBean.tags);
                        break;
                    case ACTION_CHECK:
                        //一次只能check一个tag
                        string tag = (string)tagAliasBean.tags[0];
                        JPushInterface.CheckTagBindState(context, sequence, tag);
                        break;
                    case ACTION_GET:
                        JPushInterface.GetAllTags(context, sequence);
                        break;
                    case ACTION_CLEAN:
                        JPushInterface.CleanTags(context, sequence);
                        break;
                    default:
                        Logger.w(TAG, "unsupport tag action type");
                        return;
                }
            }
        }
        private bool RetryActionIfNeeded(int errorCode, TagAliasBean tagAliasBean)
        {
            if (!ExampleUtil.isConnected(context))
            {
                Logger.w(TAG, "no network");
                return false;
            }
            //返回的错误码为6002 超时,6014 服务器繁忙,都建议延迟重试
            if (errorCode == 6002 || errorCode == 6014)
            {
                Logger.d(TAG, "need retry");
                if (tagAliasBean != null)
                {
                    Message message = new Message();
                    message.What = DELAY_SEND_ACTION;
                    message.Obj = tagAliasBean;
                    delaySendHandler.SendMessageDelayed(message, 1000 * 60);
                    string logs = getRetryStr(tagAliasBean.isAliasAction, tagAliasBean.action, errorCode);
                    ExampleUtil.showToast(logs, context);
                    return true;
                }
            }
            return false;
        }
        private bool RetrySetMObileNumberActionIfNeeded(int errorCode, string mobileNumber)
        {
            if (!ExampleUtil.isConnected(context))
            {
                Logger.w(TAG, "no network");
                return false;
            }
            //返回的错误码为6002 超时,6024 服务器内部错误,建议稍后重试
            if (errorCode == 6002 || errorCode == 6024)
            {
                Logger.d(TAG, "need retry");
                Message message = new Message();
                message.What = DELAY_SET_MOBILE_NUMBER_ACTION;
                message.Obj = mobileNumber;
                delaySendHandler.SendMessageDelayed(message, 1000 * 60);
                string str = "Failed to set mobile number due to %s. Try again after 60s.";
                str = Java.Lang.String.Format(Locale.English, str, (errorCode == 6002 ? "timeout" : "server internal error”"));
                ExampleUtil.showToast(str, context);
                return true;
            }
            return false;

        }
        private string getRetryStr(bool isAliasAction, int actionType, int errorCode)
        {
            string str = "Failed to %s %s due to %s. Try again after 60s.";
            str = Java.Lang.String.Format(Locale.English, str, getActionStr(actionType), (isAliasAction ? "alias" : " tags"), (errorCode == 6002 ? "timeout" : "server too busy"));
            return str;
        }

        private string getActionStr(int actionType)
        {
            switch (actionType)
            {
                case ACTION_ADD:
                    return "add";
                case ACTION_SET:
                    return "set";
                case ACTION_DELETE:
                    return "delete";
                case ACTION_GET:
                    return "get";
                case ACTION_CLEAN:
                    return "clean";
                case ACTION_CHECK:
                    return "check";
            }
            return "unkonw operation";
        }
        public virtual void onTagOperatorResult(Context context, JPushMessage jPushMessage)
        {
            int sequence = jPushMessage.Sequence;
            Logger.i(TAG, "action - onTagOperatorResult, sequence:" + sequence + ",tags:" + jPushMessage.Tags);
            Logger.i(TAG, "tags size:" + jPushMessage.Tags.Count);
            init(context);
            //根据sequence从之前操作缓存中获取缓存记录
            TagAliasBean tagAliasBean = (TagAliasBean)setActionCache.Get(sequence);
            if (tagAliasBean == null)
            {
                ExampleUtil.showToast("获取缓存记录失败", context);
                return;
            }
            if (jPushMessage.ErrorCode == 0)
            {
                Logger.i(TAG, "action - modify tag Success,sequence:" + sequence);
                setActionCache.Remove(sequence);
                string logs = getActionStr(tagAliasBean.action) + " tags success";
                Logger.i(TAG, logs);
                ExampleUtil.showToast(logs, context);
            }
            else
            {
                string logs = "Failed to " + getActionStr(tagAliasBean.action) + " tags";
                if (jPushMessage.ErrorCode == 6018)
                {
                    //tag数量超过限制,需要先清除一部分再add
                    logs += ", tags is exceed limit need to clean";
                }
                logs += ", errorCode:" + jPushMessage.ErrorCode;
                Logger.e(TAG, logs);
                if (!RetryActionIfNeeded(jPushMessage.ErrorCode, tagAliasBean))
                {
                    ExampleUtil.showToast(logs, context);
                }
            }
        }
        public virtual void onCheckTagOperatorResult(Context context, JPushMessage jPushMessage)
        {
            int sequence = jPushMessage.Sequence;
            Logger.i(TAG, "action - onCheckTagOperatorResult, sequence:" + sequence + ",checktag:" + jPushMessage.CheckTag);
            init(context);
            //根据sequence从之前操作缓存中获取缓存记录
            TagAliasBean tagAliasBean = (TagAliasBean)setActionCache.Get(sequence);
            if (tagAliasBean == null)
            {
                ExampleUtil.showToast("获取缓存记录失败", context);
                return;
            }
            if (jPushMessage.ErrorCode == 0)
            {
                Logger.i(TAG, "tagBean:" + tagAliasBean);
                setActionCache.Remove(sequence);
                string logs = getActionStr(tagAliasBean.action) + " tag " + jPushMessage.CheckTag + " bind state success,state:" + jPushMessage.TagCheckStateResult;
                Logger.i(TAG, logs);
                ExampleUtil.showToast(logs, context);
            }
            else
            {
                string logs = "Failed to " + getActionStr(tagAliasBean.action) + " tags, errorCode:" + jPushMessage.ErrorCode;
                Logger.e(TAG, logs);
                if (!RetryActionIfNeeded(jPushMessage.ErrorCode, tagAliasBean))
                {
                    ExampleUtil.showToast(logs, context);
                }
            }
        }
        public virtual void onAliasOperatorResult(Context context, JPushMessage jPushMessage)
        {
            int sequence = jPushMessage.Sequence;
            Logger.i(TAG, "action - onAliasOperatorResult, sequence:" + sequence + ",alias:" + jPushMessage.Alias);
            init(context);
            //根据sequence从之前操作缓存中获取缓存记录
            TagAliasBean tagAliasBean = (TagAliasBean)setActionCache.Get(sequence);
            if (tagAliasBean == null)
            {
                ExampleUtil.showToast("获取缓存记录失败", context);
                return;
            }
            if (jPushMessage.ErrorCode == 0)
            {
                Logger.i(TAG, "action - modify alias Success,sequence:" + sequence);
                setActionCache.Remove(sequence);
                string logs = getActionStr(tagAliasBean.action) + " alias success";
                Logger.i(TAG, logs);
                ExampleUtil.showToast(logs, context);
            }
            else
            {
                string logs = "Failed to " + getActionStr(tagAliasBean.action) + " alias, errorCode:" + jPushMessage.ErrorCode;
                Logger.e(TAG, logs);
                if (!RetryActionIfNeeded(jPushMessage.ErrorCode, tagAliasBean))
                {
                    ExampleUtil.showToast(logs, context);
                }
            }
        }
        //设置手机号码回调
        public virtual void onMobileNumberOperatorResult(Context context, JPushMessage jPushMessage)
        {
            int sequence = jPushMessage.Sequence;
            Logger.i(TAG, "action - onMobileNumberOperatorResult, sequence:" + sequence + ",mobileNumber:" + jPushMessage.MobileNumber);
            init(context);
            if (jPushMessage.ErrorCode == 0)
            {
                Logger.i(TAG, "action - set mobile number Success,sequence:" + sequence);
                setActionCache.Remove(sequence);
            }
            else
            {
                string logs = "Failed to set mobile number, errorCode:" + jPushMessage.ErrorCode;
                Logger.e(TAG, logs);
                if (!RetrySetMObileNumberActionIfNeeded(jPushMessage.ErrorCode, jPushMessage.MobileNumber))
                {
                    ExampleUtil.showToast(logs, context);
                }
            }
        }
        public class TagAliasBean : Java.Lang.Object
        {
            internal int action;
            internal string[] tags;
            internal string alias;
            internal bool isAliasAction;

            public override string ToString()
            {
                return "TagAliasBean{" +
                        "action=" + action +
                        ", tags=" + tags +
                        ", alias='" + alias + '\'' +
                        ", isAliasAction=" + isAliasAction +
                        '}';
            }
        }


    }

}