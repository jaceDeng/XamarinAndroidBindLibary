using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']"
	[global::Android.Runtime.Register ("com/iflytek/speech/UtilityConfig", DoNotGenerateAcw=true)]
	public partial class UtilityConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='ACTION_SPEAKER_VERIFIER']"
		[Register ("ACTION_SPEAKER_VERIFIER")]
		public const string ActionSpeakerVerifier = (string) "com.iflytek.vflynote.speakerverify";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='ACTION_SPEECH_RECOGNIZER']"
		[Register ("ACTION_SPEECH_RECOGNIZER")]
		public const string ActionSpeechRecognizer = (string) "com.iflytek.vflynote.recognize";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='ACTION_SPEECH_SYNTHESIZER']"
		[Register ("ACTION_SPEECH_SYNTHESIZER")]
		public const string ActionSpeechSynthesizer = (string) "com.iflytek.vflynote.synthesize";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='ACTION_SPEECH_UNDERSTANDER']"
		[Register ("ACTION_SPEECH_UNDERSTANDER")]
		public const string ActionSpeechUnderstander = (string) "com.iflytek.vflynote.speechunderstand";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='ACTION_SPEECH_WAKEUP']"
		[Register ("ACTION_SPEECH_WAKEUP")]
		public const string ActionSpeechWakeup = (string) "com.iflytek.vflynote.wakeup";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='ACTION_TEXT_UNDERSTANDER']"
		[Register ("ACTION_TEXT_UNDERSTANDER")]
		public const string ActionTextUnderstander = (string) "com.iflytek.vflynote.textunderstand";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='CHANNEL_ID']"
		[Register ("CHANNEL_ID")]
		public const string ChannelId = (string) "16010000";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='CHANNEL_NAME']"
		[Register ("CHANNEL_NAME")]
		public const string ChannelName = (string) "dev.voicecloud";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='COMPONENT_PKG']"
		[Register ("COMPONENT_PKG")]
		public const string ComponentPkg = (string) "com.iflytek.vflynote";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='COMPONENT_URL']"
		[Register ("COMPONENT_URL")]
		public const string ComponentUrl = (string) "http://iss.openspeech.cn/v?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CALLER_APPID']"
		[Register ("KEY_CALLER_APPID")]
		public const string KeyCallerAppid = (string) "caller.appid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CALLER_NAME']"
		[Register ("KEY_CALLER_NAME")]
		public const string KeyCallerName = (string) "caller.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CALLER_PKG_NAME']"
		[Register ("KEY_CALLER_PKG_NAME")]
		public const string KeyCallerPkgName = (string) "caller.pkg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CALLER_VER_CODE']"
		[Register ("KEY_CALLER_VER_CODE")]
		public const string KeyCallerVerCode = (string) "caller.ver.code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CALLER_VER_NAME']"
		[Register ("KEY_CALLER_VER_NAME")]
		public const string KeyCallerVerName = (string) "caller.ver.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CHANNEL_ID']"
		[Register ("KEY_CHANNEL_ID")]
		public const string KeyChannelId = (string) "channel.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_CHANNEL_NAME']"
		[Register ("KEY_CHANNEL_NAME")]
		public const string KeyChannelName = (string) "channel.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_DEVICE_INFO']"
		[Register ("KEY_DEVICE_INFO")]
		public const string KeyDeviceInfo = (string) "device";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='KEY_REQUEST_PACKAGE']"
		[Register ("KEY_REQUEST_PACKAGE")]
		public const string KeyRequestPackage = (string) "request.package";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='METADATA_KEY_ENGINE_TYPE']"
		[Register ("METADATA_KEY_ENGINE_TYPE")]
		public const string MetadataKeyEngineType = (string) "enginetype";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='SDK_VER_NAME']"
		[Register ("SDK_VER_NAME")]
		public const string SdkVerName = (string) "sdk.ver.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='SETTINGS_ACTION_ASR']"
		[Register ("SETTINGS_ACTION_ASR")]
		public const string SettingsActionAsr = (string) "com.iflytek.vflynote.settings.asr";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='SETTINGS_ACTION_MAIN']"
		[Register ("SETTINGS_ACTION_MAIN")]
		public const string SettingsActionMain = (string) "com.iflytek.vflynote.settings.main";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/field[@name='SETTINGS_ACTION_TTS']"
		[Register ("SETTINGS_ACTION_TTS")]
		public const string SettingsActionTts = (string) "com.iflytek.vflynote.activity.speaker.SpeakerSetting";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/UtilityConfig", typeof (UtilityConfig));
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

		protected UtilityConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/constructor[@name='UtilityConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UtilityConfig ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/method[@name='appendHttpParam' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("appendHttpParam", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AppendHttpParam (global::Java.Lang.StringBuffer p0, string p1, string p2)
		{
			const string __id = "appendHttpParam.(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/method[@name='getCallerInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCallerInfo", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCallerInfo (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getCallerInfo.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='UtilityConfig']/method[@name='getComponentUrlParam' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getComponentUrlParam", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetComponentUrlParam (global::Android.Content.Context p0)
		{
			const string __id = "getComponentUrlParam.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
