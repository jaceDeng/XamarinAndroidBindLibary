using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechUtility", DoNotGenerateAcw=true)]
	public partial class SpeechUtility : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/field[@name='TAG_RESOURCE_CONTENT']"
		[Register ("TAG_RESOURCE_CONTENT")]
		public const string TagResourceContent = (string) "tag_rescontent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/field[@name='TAG_RESOURCE_RESULT']"
		[Register ("TAG_RESOURCE_RESULT")]
		public const string TagResourceResult = (string) "result";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/field[@name='TAG_RESOURCE_RET']"
		[Register ("TAG_RESOURCE_RET")]
		public const string TagResourceRet = (string) "ret";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechUtility", typeof (SpeechUtility));
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

		protected SpeechUtility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getComponentUrl;
#pragma warning disable 0169
		static Delegate GetGetComponentUrlHandler ()
		{
			if (cb_getComponentUrl == null)
				cb_getComponentUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetComponentUrl);
			return cb_getComponentUrl;
		}

		static IntPtr n_GetComponentUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ComponentUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string ComponentUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='getComponentUrl' and count(parameter)=0]"
			[Register ("getComponentUrl", "()Ljava/lang/String;", "GetGetComponentUrlHandler")]
			get {
				const string __id = "getComponentUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceVersion;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionHandler ()
		{
			if (cb_getServiceVersion == null)
				cb_getServiceVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetServiceVersion);
			return cb_getServiceVersion;
		}

		static int n_GetServiceVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServiceVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()I", "GetGetServiceVersionHandler")]
			get {
				const string __id = "getServiceVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Iflytek.Cloud.SpeechUtility Utility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='getUtility' and count(parameter)=0]"
			[Register ("getUtility", "()Lcom/iflytek/cloud/SpeechUtility;", "")]
			get {
				const string __id = "getUtility.()Lcom/iflytek/cloud/SpeechUtility;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_C);
			return cb_c;
		}

		static bool n_C (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "GetCHandler")]
		protected virtual unsafe bool C ()
		{
			const string __id = "c.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkServiceInstalled;
#pragma warning disable 0169
		static Delegate GetCheckServiceInstalledHandler ()
		{
			if (cb_checkServiceInstalled == null)
				cb_checkServiceInstalled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CheckServiceInstalled);
			return cb_checkServiceInstalled;
		}

		static bool n_CheckServiceInstalled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckServiceInstalled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='checkServiceInstalled' and count(parameter)=0]"
		[Register ("checkServiceInstalled", "()Z", "GetCheckServiceInstalledHandler")]
		public virtual unsafe bool CheckServiceInstalled ()
		{
			const string __id = "checkServiceInstalled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='createUtility' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createUtility", "(Landroid/content/Context;Ljava/lang/String;)Lcom/iflytek/cloud/SpeechUtility;", "")]
		public static unsafe global::Com.Iflytek.Cloud.SpeechUtility CreateUtility (global::Android.Content.Context p0, string p1)
		{
			const string __id = "createUtility.(Landroid/content/Context;Ljava/lang/String;)Lcom/iflytek/cloud/SpeechUtility;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getPlusLocalInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPlusLocalInfo_Ljava_lang_String_Handler ()
		{
			if (cb_getPlusLocalInfo_Ljava_lang_String_ == null)
				cb_getPlusLocalInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPlusLocalInfo_Ljava_lang_String_);
			return cb_getPlusLocalInfo_Ljava_lang_String_;
		}

		static IntPtr n_GetPlusLocalInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPlusLocalInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='getPlusLocalInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPlusLocalInfo", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetPlusLocalInfo_Ljava_lang_String_Handler")]
		public virtual unsafe string GetPlusLocalInfo (string p0)
		{
			const string __id = "getPlusLocalInfo.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_openEngineSettings_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenEngineSettings_Ljava_lang_String_Handler ()
		{
			if (cb_openEngineSettings_Ljava_lang_String_ == null)
				cb_openEngineSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_OpenEngineSettings_Ljava_lang_String_);
			return cb_openEngineSettings_Ljava_lang_String_;
		}

		static int n_OpenEngineSettings_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenEngineSettings (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='openEngineSettings' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openEngineSettings", "(Ljava/lang/String;)I", "GetOpenEngineSettings_Ljava_lang_String_Handler")]
		public virtual unsafe int OpenEngineSettings (string p0)
		{
			const string __id = "openEngineSettings.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_queryAvailableEngines;
#pragma warning disable 0169
		static Delegate GetQueryAvailableEnginesHandler ()
		{
			if (cb_queryAvailableEngines == null)
				cb_queryAvailableEngines = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryAvailableEngines);
			return cb_queryAvailableEngines;
		}

		static IntPtr n_QueryAvailableEngines (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.QueryAvailableEngines ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUtility']/method[@name='queryAvailableEngines' and count(parameter)=0]"
		[Register ("queryAvailableEngines", "()[Ljava/lang/String;", "GetQueryAvailableEnginesHandler")]
		public virtual unsafe string[] QueryAvailableEngines ()
		{
			const string __id = "queryAvailableEngines.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
