using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechEvent", DoNotGenerateAcw=true)]
	public partial class SpeechEvent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_AUDIO_URL']"
		[Register ("EVENT_AUDIO_URL")]
		public const int EventAudioUrl = (int) 23001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_IST_AUDIO_FILE']"
		[Register ("EVENT_IST_AUDIO_FILE")]
		public const int EventIstAudioFile = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_IST_CACHE_LEFT']"
		[Register ("EVENT_IST_CACHE_LEFT")]
		public const int EventIstCacheLeft = (int) 10007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_IST_RESULT_TIME']"
		[Register ("EVENT_IST_RESULT_TIME")]
		public const int EventIstResultTime = (int) 10008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_IST_SYNC_ID']"
		[Register ("EVENT_IST_SYNC_ID")]
		public const int EventIstSyncId = (int) 10009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_IST_UPLOAD_BYTES']"
		[Register ("EVENT_IST_UPLOAD_BYTES")]
		public const int EventIstUploadBytes = (int) 10006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_IVW_RESULT']"
		[Register ("EVENT_IVW_RESULT")]
		public const int EventIvwResult = (int) 22001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_NETPREF']"
		[Register ("EVENT_NETPREF")]
		public const int EventNetpref = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_RECORD_DATA']"
		[Register ("EVENT_RECORD_DATA")]
		public const int EventRecordData = (int) 21003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_RECORD_STOP']"
		[Register ("EVENT_RECORD_STOP")]
		public const int EventRecordStop = (int) 22003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_SESSION_BEGIN']"
		[Register ("EVENT_SESSION_BEGIN")]
		public const int EventSessionBegin = (int) 10010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_SESSION_END']"
		[Register ("EVENT_SESSION_END")]
		public const int EventSessionEnd = (int) 10011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_SESSION_ID']"
		[Register ("EVENT_SESSION_ID")]
		public const int EventSessionId = (int) 20001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_SPEECH_START']"
		[Register ("EVENT_SPEECH_START")]
		public const int EventSpeechStart = (int) 22002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_TTS_BUFFER']"
		[Register ("EVENT_TTS_BUFFER")]
		public const int EventTtsBuffer = (int) 21001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_TTS_CANCEL']"
		[Register ("EVENT_TTS_CANCEL")]
		public const int EventTtsCancel = (int) 21002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_VAD_EOS']"
		[Register ("EVENT_VAD_EOS")]
		public const int EventVadEos = (int) 10013;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='EVENT_VOLUME']"
		[Register ("EVENT_VOLUME")]
		public const int EventVolume = (int) 10012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='KEY_EVENT_AUDIO_URL']"
		[Register ("KEY_EVENT_AUDIO_URL")]
		public const string KeyEventAudioUrl = (string) "audio_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='KEY_EVENT_IST_UPLOAD_COMPLETE']"
		[Register ("KEY_EVENT_IST_UPLOAD_COMPLETE")]
		public const string KeyEventIstUploadComplete = (string) "ist_upload_complete";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='KEY_EVENT_IVW_RESULT']"
		[Register ("KEY_EVENT_IVW_RESULT")]
		public const string KeyEventIvwResult = (string) "rec_result";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='KEY_EVENT_RECORD_DATA']"
		[Register ("KEY_EVENT_RECORD_DATA")]
		public const string KeyEventRecordData = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='KEY_EVENT_SESSION_ID']"
		[Register ("KEY_EVENT_SESSION_ID")]
		public const string KeyEventSessionId = (string) "session_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/field[@name='KEY_EVENT_TTS_BUFFER']"
		[Register ("KEY_EVENT_TTS_BUFFER")]
		public const string KeyEventTtsBuffer = (string) "buffer";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechEvent", typeof (SpeechEvent));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SpeechEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvent']/constructor[@name='SpeechEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
