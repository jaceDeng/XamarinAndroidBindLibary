using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Msc.Ist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/msc/ist/IstSession", DoNotGenerateAcw=true)]
	public partial class IstSession : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/msc/ist/IstSession", typeof (IstSession));
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

		protected IstSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/constructor[@name='IstSession' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IstSession ()
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

		static Delegate cb_getAudioUrl;
#pragma warning disable 0169
		static Delegate GetGetAudioUrlHandler ()
		{
			if (cb_getAudioUrl == null)
				cb_getAudioUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioUrl);
			return cb_getAudioUrl;
		}

		static IntPtr n_GetAudioUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AudioUrl);
		}
#pragma warning restore 0169

		protected virtual unsafe string AudioUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getAudioUrl' and count(parameter)=0]"
			[Register ("getAudioUrl", "()Ljava/lang/String;", "GetGetAudioUrlHandler")]
			get {
				const string __id = "getAudioUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioVolume;
#pragma warning disable 0169
		static Delegate GetGetAudioVolumeHandler ()
		{
			if (cb_getAudioVolume == null)
				cb_getAudioVolume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioVolume);
			return cb_getAudioVolume;
		}

		static int n_GetAudioVolume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioVolume;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioVolume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getAudioVolume' and count(parameter)=0]"
			[Register ("getAudioVolume", "()I", "GetGetAudioVolumeHandler")]
			get {
				const string __id = "getAudioVolume.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEpStatus;
#pragma warning disable 0169
		static Delegate GetGetEpStatusHandler ()
		{
			if (cb_getEpStatus == null)
				cb_getEpStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEpStatus);
			return cb_getEpStatus;
		}

		static int n_GetEpStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EpStatus;
		}
#pragma warning restore 0169

		public virtual unsafe int EpStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getEpStatus' and count(parameter)=0]"
			[Register ("getEpStatus", "()I", "GetGetEpStatusHandler")]
			get {
				const string __id = "getEpStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasResult;
#pragma warning disable 0169
		static Delegate GetHasResultHandler ()
		{
			if (cb_hasResult == null)
				cb_hasResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasResult);
			return cb_hasResult;
		}

		static bool n_HasResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasResult;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='hasResult' and count(parameter)=0]"
			[Register ("hasResult", "()Z", "GetHasResultHandler")]
			get {
				const string __id = "hasResult.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSessionID;
#pragma warning disable 0169
		static Delegate GetGetSessionIDHandler ()
		{
			if (cb_getSessionID == null)
				cb_getSessionID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSessionID);
			return cb_getSessionID;
		}

		static IntPtr n_GetSessionID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionID);
		}
#pragma warning restore 0169

		protected virtual unsafe string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "GetGetSessionIDHandler")]
			get {
				const string __id = "getSessionID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getIntByTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIntByTag", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetIntByTag (string p0)
		{
			const string __id = "getIntByTag.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getIntValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetIntValue_Ljava_lang_String_Handler ()
		{
			if (cb_getIntValue_Ljava_lang_String_ == null)
				cb_getIntValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetIntValue_Ljava_lang_String_);
			return cb_getIntValue_Ljava_lang_String_;
		}

		static int n_GetIntValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIntValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getIntValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIntValue", "(Ljava/lang/String;)I", "GetGetIntValue_Ljava_lang_String_Handler")]
		public virtual unsafe int GetIntValue (string p0)
		{
			const string __id = "getIntValue.(Ljava/lang/String;)I";
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

		static Delegate cb_getIntValue_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetIntValue_Ljava_lang_String_IHandler ()
		{
			if (cb_getIntValue_Ljava_lang_String_I == null)
				cb_getIntValue_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_GetIntValue_Ljava_lang_String_I);
			return cb_getIntValue_Ljava_lang_String_I;
		}

		static int n_GetIntValue_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIntValue (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getIntValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getIntValue", "(Ljava/lang/String;I)I", "GetGetIntValue_Ljava_lang_String_IHandler")]
		public virtual unsafe int GetIntValue (string p0, int p1)
		{
			const string __id = "getIntValue.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getResultData;
#pragma warning disable 0169
		static Delegate GetGetResultDataHandler ()
		{
			if (cb_getResultData == null)
				cb_getResultData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResultData);
			return cb_getResultData;
		}

		static IntPtr n_GetResultData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetResultData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getResultData' and count(parameter)=0]"
		[Register ("getResultData", "()[B", "GetGetResultDataHandler")]
		public virtual unsafe byte[] GetResultData ()
		{
			const string __id = "getResultData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getStringByTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringByTag", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetStringByTag (string p0)
		{
			const string __id = "getStringByTag.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getStringValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringValue_Ljava_lang_String_Handler ()
		{
			if (cb_getStringValue_Ljava_lang_String_ == null)
				cb_getStringValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStringValue_Ljava_lang_String_);
			return cb_getStringValue_Ljava_lang_String_;
		}

		static IntPtr n_GetStringValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='getStringValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetStringValue_Ljava_lang_String_Handler")]
		public virtual unsafe string GetStringValue (string p0)
		{
			const string __id = "getStringValue.(Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_pushAudioData_arrayBI;
#pragma warning disable 0169
		static Delegate GetPushAudioData_arrayBIHandler ()
		{
			if (cb_pushAudioData_arrayBI == null)
				cb_pushAudioData_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_PushAudioData_arrayBI);
			return cb_pushAudioData_arrayBI;
		}

		static void n_PushAudioData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PushAudioData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='pushAudioData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("pushAudioData", "([BI)V", "GetPushAudioData_arrayBIHandler")]
		public virtual unsafe void PushAudioData (byte[] p0, int p1)
		{
			const string __id = "pushAudioData.([BI)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_pushEndFlag;
#pragma warning disable 0169
		static Delegate GetPushEndFlagHandler ()
		{
			if (cb_pushEndFlag == null)
				cb_pushEndFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PushEndFlag);
			return cb_pushEndFlag;
		}

		static void n_PushEndFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PushEndFlag ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='pushEndFlag' and count(parameter)=0]"
		[Register ("pushEndFlag", "()V", "GetPushEndFlagHandler")]
		public virtual unsafe void PushEndFlag ()
		{
			const string __id = "pushEndFlag.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sessionEnd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSessionEnd_Ljava_lang_String_Handler ()
		{
			if (cb_sessionEnd_Ljava_lang_String_ == null)
				cb_sessionEnd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SessionEnd_Ljava_lang_String_);
			return cb_sessionEnd_Ljava_lang_String_;
		}

		static void n_SessionEnd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionEnd (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='sessionEnd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sessionEnd", "(Ljava/lang/String;)V", "GetSessionEnd_Ljava_lang_String_Handler")]
		public virtual unsafe void SessionEnd (string p0)
		{
			const string __id = "sessionEnd.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SetParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SetParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetParam (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='IstSession']/method[@name='setParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParam", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSetParam_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetParam (string p0, string p1)
		{
			const string __id = "setParam.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
