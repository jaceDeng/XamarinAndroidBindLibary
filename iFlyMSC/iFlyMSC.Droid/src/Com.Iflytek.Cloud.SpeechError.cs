using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechError", DoNotGenerateAcw=true)]
	public partial class SpeechError : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_ALREADY_EXIST']"
		[Register ("TIP_ERROR_ALREADY_EXIST")]
		public const int TipErrorAlreadyExist = (int) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_AUTHID_NOT_AVAILABLE']"
		[Register ("TIP_ERROR_AUTHID_NOT_AVAILABLE")]
		public const int TipErrorAuthidNotAvailable = (int) 71;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_GROUP_EMPTY']"
		[Register ("TIP_ERROR_GROUP_EMPTY")]
		public const int TipErrorGroupEmpty = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_EXTRA_RGN_SOPPORT']"
		[Register ("TIP_ERROR_IVP_EXTRA_RGN_SOPPORT")]
		public const int TipErrorIvpExtraRgnSopport = (int) 56;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_GENERAL']"
		[Register ("TIP_ERROR_IVP_GENERAL")]
		public const int TipErrorIvpGeneral = (int) 55;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_MUCH_NOISE']"
		[Register ("TIP_ERROR_IVP_MUCH_NOISE")]
		public const int TipErrorIvpMuchNoise = (int) 58;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_NO_ENOUGH_AUDIO']"
		[Register ("TIP_ERROR_IVP_NO_ENOUGH_AUDIO")]
		public const int TipErrorIvpNoEnoughAudio = (int) 63;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_TEXT_NOT_MATCH']"
		[Register ("TIP_ERROR_IVP_TEXT_NOT_MATCH")]
		public const int TipErrorIvpTextNotMatch = (int) 62;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_TOO_LOW']"
		[Register ("TIP_ERROR_IVP_TOO_LOW")]
		public const int TipErrorIvpTooLow = (int) 59;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_TRUNCATED']"
		[Register ("TIP_ERROR_IVP_TRUNCATED")]
		public const int TipErrorIvpTruncated = (int) 57;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_UTTER_TOO_SHORT']"
		[Register ("TIP_ERROR_IVP_UTTER_TOO_SHORT")]
		public const int TipErrorIvpUtterTooShort = (int) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_IVP_ZERO_AUDIO']"
		[Register ("TIP_ERROR_IVP_ZERO_AUDIO")]
		public const int TipErrorIvpZeroAudio = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_MODEL_IS_CREATING']"
		[Register ("TIP_ERROR_MODEL_IS_CREATING")]
		public const int TipErrorModelIsCreating = (int) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_MODEL_NOT_FOUND']"
		[Register ("TIP_ERROR_MODEL_NOT_FOUND")]
		public const int TipErrorModelNotFound = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_NO_GROUP']"
		[Register ("TIP_ERROR_NO_GROUP")]
		public const int TipErrorNoGroup = (int) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_NO_USER']"
		[Register ("TIP_ERROR_NO_USER")]
		public const int TipErrorNoUser = (int) 69;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/field[@name='TIP_ERROR_OVERFLOW_IN_GROUP']"
		[Register ("TIP_ERROR_OVERFLOW_IN_GROUP")]
		public const int TipErrorOverflowInGroup = (int) 70;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechError", typeof (SpeechError));
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

		protected SpeechError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/constructor[@name='SpeechError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SpeechError (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/constructor[@name='SpeechError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe SpeechError (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/constructor[@name='SpeechError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public unsafe SpeechError (global::Java.Lang.Exception p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Exception;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/constructor[@name='SpeechError' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/Throwable;I)V", "")]
		public unsafe SpeechError (global::Java.Lang.Throwable p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getErrorDescription;
#pragma warning disable 0169
		static Delegate GetGetErrorDescriptionHandler ()
		{
			if (cb_getErrorDescription == null)
				cb_getErrorDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorDescription);
			return cb_getErrorDescription;
		}

		static IntPtr n_GetErrorDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorDescription);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/method[@name='getErrorDescription' and count(parameter)=0]"
			[Register ("getErrorDescription", "()Ljava/lang/String;", "GetGetErrorDescriptionHandler")]
			get {
				const string __id = "getErrorDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHtmlDescription_Z;
#pragma warning disable 0169
		static Delegate GetGetHtmlDescription_ZHandler ()
		{
			if (cb_getHtmlDescription_Z == null)
				cb_getHtmlDescription_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_GetHtmlDescription_Z);
			return cb_getHtmlDescription_Z;
		}

		static IntPtr n_GetHtmlDescription_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetHtmlDescription (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/method[@name='getHtmlDescription' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getHtmlDescription", "(Z)Ljava/lang/String;", "GetGetHtmlDescription_ZHandler")]
		public virtual unsafe string GetHtmlDescription (bool p0)
		{
			const string __id = "getHtmlDescription.(Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPlainDescription_Z;
#pragma warning disable 0169
		static Delegate GetGetPlainDescription_ZHandler ()
		{
			if (cb_getPlainDescription_Z == null)
				cb_getPlainDescription_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_GetPlainDescription_Z);
			return cb_getPlainDescription_Z;
		}

		static IntPtr n_GetPlainDescription_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetPlainDescription (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/method[@name='getPlainDescription' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getPlainDescription", "(Z)Ljava/lang/String;", "GetGetPlainDescription_ZHandler")]
		public virtual unsafe string GetPlainDescription (bool p0)
		{
			const string __id = "getPlainDescription.(Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechError']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
