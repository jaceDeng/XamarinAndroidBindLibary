using Android.Content;
using Android.Net;
using Android.OS;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace yufeng.XST
{
    //using BroadcastReceiver = Android.content.BroadcastReceiver;
    //using Context = Android.content.Context;
    //using Intent = Android.content.Intent;
    //using IntentFilter = Android.content.IntentFilter;
    //using Uri = Android.net.Uri;
    //using Handler = Android.os.Handler;
    //using Message = Android.os.Message;


    /// <summary>
    /// Created by efan on 2017/4/14.
    /// </summary>

    public sealed class LocalBroadcastManager
    {
        private const string TAG = "JIGUANG-Example";
        private const bool DEBUG = false;
        private readonly Context mAppContext;
        private readonly Dictionary<BroadcastReceiver, List<IntentFilter>> mReceivers = new Dictionary<BroadcastReceiver, List<IntentFilter>>();
        private readonly Dictionary<string, List<ReceiverRecord>> mActions = new Dictionary<string, List<ReceiverRecord>>();
        private readonly List<BroadcastRecord> mPendingBroadcasts = new List<BroadcastRecord>();
        internal const int MSG_EXEC_PENDING_BROADCASTS = 1;
        private readonly Handler mHandler;
        private static readonly object mLock = new object();
        private static LocalBroadcastManager mInstance;

        public static LocalBroadcastManager getInstance(Context context)
        {
            object var1 = mLock;
            lock (mLock)
            {
                if (mInstance == null)
                {
                    mInstance = new LocalBroadcastManager(context.ApplicationContext);
                }

                return mInstance;
            }
        }

        private LocalBroadcastManager(Context context)
        {
            this.mAppContext = context;
            this.mHandler = new HandlerAnonymousInnerClass(this, context.MainLooper);
        }

        private class HandlerAnonymousInnerClass : Handler
        {
            private readonly LocalBroadcastManager outerInstance;

            public HandlerAnonymousInnerClass(LocalBroadcastManager outerInstance, UnknownType getMainLooper) : base(getMainLooper)
            {
                this.outerInstance = outerInstance;
            }

            public void handleMessage(Message msg)
            {
                switch (msg.What)
                {
                    case 1:
                        outerInstance.executePendingBroadcasts();
                        break;
                    default:
                        base.HandleMessage(msg);
                        break;
                }

            }
        }

        public void registerReceiver(BroadcastReceiver receiver, IntentFilter filter)
        {
            Hashtable var3 = this.mReceivers;
            lock (this.mReceivers)
            {
                ReceiverRecord entry = new ReceiverRecord(filter, receiver);
                var filters = this.mReceivers[receiver];
                if (filters == null)
                {
                    filters = new List<IntentFilter>();
                    this.mReceivers[receiver] = filters;
                }

                filters.Add(filter);

                for (int i = 0; i < filter.CountActions(); ++i)
                {
                    string action = filter.GetAction(i);
                    var entries = this.mActions[action];
                    if (entries == null)
                    {
                        entries = new List<ReceiverRecord>();
                        this.mActions[action] = entries;
                    }

                    entries.Add(entry);
                }

            }
        }

        public void unregisterReceiver(BroadcastReceiver receiver)
        {
            Hashtable var2 = this.mReceivers;
            lock (this.mReceivers)
            {
                var filters = this.mReceivers.Remove(receiver);
                if (filters != null)
                {
                    for (int i = 0; i < filters.Count; ++i)
                    {
                        IntentFilter filter = (IntentFilter)filters[i];

                        for (int j = 0; j < filter.CountActions(); ++j)
                        {
                            string action = filter.GetAction(j);
                            var receivers = this.mActions[action];
                            if (receivers != null)
                            {
                                for (int k = 0; k < receivers.Count; ++k)
                                {
                                    if (((ReceiverRecord)receivers[k]).receiver == receiver)
                                    {
                                        receivers.RemoveAt(k);
                                        --k;
                                    }
                                }

                                if (receivers.Count <= 0)
                                {
                                    this.mActions.Remove(action);
                                }
                            }
                        }
                    }

                }
            }
        }

        public bool sendBroadcast(Intent intent)
        {
            Hashtable var2 = this.mReceivers;
            lock (this.mReceivers)
            {
                string action = intent.Action;
                string type = intent.ResolveTypeIfNeeded(this.mAppContext.ContentResolver);
                Uri data = intent.Data;
                string scheme = intent.Scheme;
                ISet<object> categories = intent.Categories;
                bool debug = (intent.Flags & 8) != 0;
                if (debug)
                {
                    Logger.v("LocalBroadcastManager", "Resolving type " + type + " scheme " + scheme + " of intent " + intent);
                }

                var entries = this.mActions[intent.Action];
                if (entries != null)
                {
                    if (debug)
                    {
                        Logger.v("LocalBroadcastManager", "Action list: " + entries);
                    }

                    List<object> receivers = null;

                    int i;
                    for (i = 0; i < entries.Count; ++i)
                    {
                        ReceiverRecord receiver = (ReceiverRecord)entries[i];
                        if (debug)
                        {
                            Logger.v("LocalBroadcastManager", "Matching against filter " + receiver.filter);
                        }

                        if (receiver.broadcasting)
                        {
                            if (debug)
                            {
                                Logger.v("LocalBroadcastManager", "  Filter\'s target already added");
                            }
                        }
                        else
                        {
                            int match = receiver.filter.Match(action, type, scheme, data,
                                categories, "LocalBroadcastManager");
                            if (match >= 0)
                            {
                                if (debug)
                                {
                                    Logger.v("LocalBroadcastManager", "  Filter matched!  match=0x" + match.ToString("x"));
                                }

                                if (receivers == null)
                                {
                                    receivers = new List<object>();
                                }

                                receivers.Add(receiver);
                                receiver.broadcasting = true;
                            }
                            else if (debug)
                            {
                                string reason;
                                switch (match)
                                {
                                    case -4:
                                        reason = "category";
                                        break;
                                    case -3:
                                        reason = "action";
                                        break;
                                    case -2:
                                        reason = "data";
                                        break;
                                    case -1:
                                        reason = "type";
                                        break;
                                    default:
                                        reason = "unknown reason";
                                        break;
                                }

                                Logger.v("LocalBroadcastManager", "  Filter did not match: " + reason);
                            }
                        }
                    }

                    if (receivers != null)
                    {
                        for (i = 0; i < receivers.Count; ++i)
                        {
                            ((ReceiverRecord)receivers[i]).broadcasting = false;
                        }

                        this.mPendingBroadcasts.Add(new BroadcastRecord(intent, receivers));
                        if (!this.mHandler.HasMessages(1))
                        {
                            this.mHandler.SendEmptyMessage(1);
                        }

                        return true;
                    }
                }

                return false;
            }
        }

        public void sendBroadcastSync(Intent intent)
        {
            if (this.sendBroadcast(intent))
            {
                this.executePendingBroadcasts();
            }

        }

        private void executePendingBroadcasts()
        {
            while (true)
            {
                BroadcastRecord[] brs = null;
                Hashtable i = this.mReceivers;
                lock (this.mReceivers)
                {
                    int br = this.mPendingBroadcasts.Count;
                    if (br <= 0)
                    {
                        return;
                    }

                    brs = new BroadcastRecord[br];
                    brs = this.mPendingBroadcasts.ToArray();
                    this.mPendingBroadcasts.Clear();
                }

                for (int var6 = 0; var6 < brs.Length; ++var6)
                {
                    BroadcastRecord var7 = brs[var6];

                    for (int j = 0; j < var7.receivers.Count; ++j)
                    {
                        ((ReceiverRecord)var7.receivers[j]).receiver.OnReceive(this.mAppContext, var7.intent);
                    }
                }
            }
        }

        private class BroadcastRecord
        {
            internal readonly Intent intent;
            internal readonly List<ReceiverRecord> receivers;

            internal BroadcastRecord(Intent _intent, List<ReceiverRecord> _receivers)
            {
                this.intent = _intent;
                this.receivers = _receivers;
            }
        }

        private class ReceiverRecord
        {
            internal readonly IntentFilter filter;
            internal readonly BroadcastReceiver receiver;
            internal bool broadcasting;

            internal ReceiverRecord(IntentFilter _filter, BroadcastReceiver _receiver)
            {
                this.filter = _filter;
                this.receiver = _receiver;
            }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder(128);
                builder.Append("Receiver{");
                builder.Append(this.receiver);
                builder.Append(" filter=");
                builder.Append(this.filter);
                builder.Append("}");
                return builder.ToString();
            }
        }
    }
}