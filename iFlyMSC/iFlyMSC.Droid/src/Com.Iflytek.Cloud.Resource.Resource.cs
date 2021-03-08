using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/resource/Resource", DoNotGenerateAcw=true)]
	public partial class Resource : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TAG_ERROR_CODE']"
		[Register ("TAG_ERROR_CODE")]
		public const int TagErrorCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TAG_ERROR_UNKNOWN']"
		[Register ("TAG_ERROR_UNKNOWN")]
		public const int TagErrorUnknown = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_AGAIN']"
		[Register ("TEXT_AGAIN")]
		public const int TextAgain = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_CANCEL']"
		[Register ("TEXT_CANCEL")]
		public const int TextCancel = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_DETAIL']"
		[Register ("TEXT_DETAIL")]
		public const int TextDetail = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_HELP_LINK']"
		[Register ("TEXT_HELP_LINK")]
		public const int TextHelpLink = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_HELP_RECO']"
		[Register ("TEXT_HELP_RECO")]
		public const int TextHelpReco = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_HELP_SMS']"
		[Register ("TEXT_HELP_SMS")]
		public const int TextHelpSms = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_KNOW']"
		[Register ("TEXT_KNOW")]
		public const int TextKnow = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_MORE']"
		[Register ("TEXT_MORE")]
		public const int TextMore = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_PLAYBACK']"
		[Register ("TEXT_PLAYBACK")]
		public const int TextPlayback = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_POWER_LINK']"
		[Register ("TEXT_POWER_LINK")]
		public const int TextPowerLink = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_RETRIEVE']"
		[Register ("TEXT_RETRIEVE")]
		public const int TextRetrieve = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_RETRY']"
		[Register ("TEXT_RETRY")]
		public const int TextRetry = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_SET']"
		[Register ("TEXT_SET")]
		public const int TextSet = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TEXT_STOP']"
		[Register ("TEXT_STOP")]
		public const int TextStop = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_AUDIO_PLAYING']"
		[Register ("TITLE_AUDIO_PLAYING")]
		public const int TitleAudioPlaying = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_AUDIO_REQUEST']"
		[Register ("TITLE_AUDIO_REQUEST")]
		public const int TitleAudioRequest = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_CONNECTING']"
		[Register ("TITLE_CONNECTING")]
		public const int TitleConnecting = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_DATA_UPLOAD']"
		[Register ("TITLE_DATA_UPLOAD")]
		public const int TitleDataUpload = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_ERROR']"
		[Register ("TITLE_ERROR")]
		public const int TitleError = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_HELP']"
		[Register ("TITLE_HELP")]
		public const int TitleHelp = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_RECOGNIZE_WAITING']"
		[Register ("TITLE_RECOGNIZE_WAITING")]
		public const int TitleRecognizeWaiting = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/field[@name='TITLE_RECORDING']"
		[Register ("TITLE_RECORDING")]
		public const int TitleRecording = (int) 2;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/resource/Resource", typeof (Resource));
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

		protected Resource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='getErrorDescription' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorDescription", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorDescription (int p0)
		{
			const string __id = "getErrorDescription.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='getErrorTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorTag", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorTag (int p0)
		{
			const string __id = "getErrorTag.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='getText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getText", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetText (int p0)
		{
			const string __id = "getText.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='getTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitle", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetTitle (int p0)
		{
			const string __id = "getTitle.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='matchLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("matchLanguage", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MatchLanguage (string p0)
		{
			const string __id = "matchLanguage.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='setErrorDescription' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setErrorDescription", "(ILjava/lang/String;)V", "")]
		public static unsafe void SetErrorDescription (int p0, string p1)
		{
			const string __id = "setErrorDescription.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='setText' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setText", "(ILjava/lang/String;)V", "")]
		public static unsafe void SetText (int p0, string p1)
		{
			const string __id = "setText.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='setTitle' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTitle", "(ILjava/lang/String;)V", "")]
		public static unsafe void SetTitle (int p0, string p1)
		{
			const string __id = "setTitle.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.resource']/class[@name='Resource']/method[@name='setUILanguage' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("setUILanguage", "(Ljava/util/Locale;)V", "")]
		public static unsafe void SetUILanguage (global::Java.Util.Locale p0)
		{
			const string __id = "setUILanguage.(Ljava/util/Locale;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
