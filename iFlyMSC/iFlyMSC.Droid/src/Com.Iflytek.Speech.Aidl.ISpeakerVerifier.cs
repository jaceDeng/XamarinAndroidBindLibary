using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeakerVerifier$Default", DoNotGenerateAcw=true)]
	public partial class SpeakerVerifierDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeakerVerifier$Default", typeof (SpeakerVerifierDefault));
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

		protected SpeakerVerifierDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/constructor[@name='ISpeakerVerifier.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeakerVerifierDefault ()
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_endSpeak;
#pragma warning disable 0169
		static Delegate GetEndSpeakHandler ()
		{
			if (cb_endSpeak == null)
				cb_endSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndSpeak);
			return cb_endSpeak;
		}

		static void n_EndSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndSpeak ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='endSpeak' and count(parameter)=0]"
		[Register ("endSpeak", "()V", "GetEndSpeakHandler")]
		public virtual unsafe void EndSpeak ()
		{
			const string __id = "endSpeak.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParameter_Ljava_lang_String_Handler ()
		{
			if (cb_getParameter_Ljava_lang_String_ == null)
				cb_getParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetParameter_Ljava_lang_String_);
			return cb_getParameter_Ljava_lang_String_;
		}

		static IntPtr n_GetParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParameter_Ljava_lang_String_Handler")]
		public virtual unsafe string GetParameter (string p0)
		{
			const string __id = "getParameter.(Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Register (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public virtual unsafe int Register (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "register.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)I", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int SetParameter (string p0, string p1)
		{
			const string __id = "setParameter.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_stopSpeak;
#pragma warning disable 0169
		static Delegate GetStopSpeakHandler ()
		{
			if (cb_stopSpeak == null)
				cb_stopSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopSpeak);
			return cb_stopSpeak;
		}

		static void n_StopSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSpeak ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='stopSpeak' and count(parameter)=0]"
		[Register ("stopSpeak", "()V", "GetStopSpeakHandler")]
		public virtual unsafe void StopSpeak ()
		{
			const string __id = "stopSpeak.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Verify (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Default']/method[@name='verify' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public virtual unsafe int Verify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "verify.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeakerVerifier$Stub", DoNotGenerateAcw=true)]
	public abstract partial class SpeakerVerifierStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeakerVerifier$Stub", typeof (SpeakerVerifierStub));
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

		protected SpeakerVerifierStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']/constructor[@name='ISpeakerVerifier.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeakerVerifierStub ()
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

		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/aidl/ISpeakerVerifier;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/aidl/ISpeakerVerifier;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeakerVerifier;", "")]
		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeakerVerifier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLI_Z) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeakerVerifier.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.aidl.ISpeakerVerifier']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/aidl/ISpeakerVerifier;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/aidl/ISpeakerVerifier;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_endSpeak;
#pragma warning disable 0169
		static Delegate GetEndSpeakHandler ()
		{
			if (cb_endSpeak == null)
				cb_endSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndSpeak);
			return cb_endSpeak;
		}

		static void n_EndSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndSpeak ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='endSpeak' and count(parameter)=0]"
		[Register ("endSpeak", "()V", "GetEndSpeakHandler")]
		public abstract void EndSpeak ();

		static Delegate cb_getParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParameter_Ljava_lang_String_Handler ()
		{
			if (cb_getParameter_Ljava_lang_String_ == null)
				cb_getParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetParameter_Ljava_lang_String_);
			return cb_getParameter_Ljava_lang_String_;
		}

		static IntPtr n_GetParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParameter_Ljava_lang_String_Handler")]
		public abstract string GetParameter (string p0);

		static Delegate cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Register (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public abstract int Register (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2);

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)I", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract int SetParameter (string p0, string p1);

		static Delegate cb_stopSpeak;
#pragma warning disable 0169
		static Delegate GetStopSpeakHandler ()
		{
			if (cb_stopSpeak == null)
				cb_stopSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopSpeak);
			return cb_stopSpeak;
		}

		static void n_StopSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSpeak ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='stopSpeak' and count(parameter)=0]"
		[Register ("stopSpeak", "()V", "GetStopSpeakHandler")]
		public abstract void StopSpeak ();

		static Delegate cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeakerVerifierStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Verify (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='verify' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public abstract int Verify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeakerVerifier$Stub", DoNotGenerateAcw=true)]
	internal partial class SpeakerVerifierStubInvoker : SpeakerVerifierStub {

		public SpeakerVerifierStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeakerVerifier$Stub", typeof (SpeakerVerifierStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='endSpeak' and count(parameter)=0]"
		[Register ("endSpeak", "()V", "GetEndSpeakHandler")]
		public override unsafe void EndSpeak ()
		{
			const string __id = "endSpeak.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParameter_Ljava_lang_String_Handler")]
		public override unsafe string GetParameter (string p0)
		{
			const string __id = "getParameter.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public override unsafe int Register (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "register.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)I", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe int SetParameter (string p0, string p1)
		{
			const string __id = "setParameter.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='stopSpeak' and count(parameter)=0]"
		[Register ("stopSpeak", "()V", "GetStopSpeakHandler")]
		public override unsafe void StopSpeak ()
		{
			const string __id = "stopSpeak.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='verify' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public override unsafe int Verify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "verify.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']"
	[Register ("com/iflytek/speech/aidl/ISpeakerVerifier", "", "Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker")]
	public partial interface ISpeakerVerifier : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='endSpeak' and count(parameter)=0]"
		[Register ("endSpeak", "()V", "GetEndSpeakHandler:Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker, iFlyMSC.Droid")]
		void EndSpeak ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParameter_Ljava_lang_String_Handler:Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker, iFlyMSC.Droid")]
		string GetParameter (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler:Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker, iFlyMSC.Droid")]
		int Register (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)I", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler:Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker, iFlyMSC.Droid")]
		int SetParameter (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='stopSpeak' and count(parameter)=0]"
		[Register ("stopSpeak", "()V", "GetStopSpeakHandler:Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker, iFlyMSC.Droid")]
		void StopSpeak ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeakerVerifier']/method[@name='verify' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler:Com.Iflytek.Speech.Aidl.ISpeakerVerifierInvoker, iFlyMSC.Droid")]
		int Verify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeakerVerifier", DoNotGenerateAcw=true)]
	internal partial class ISpeakerVerifierInvoker : global::Java.Lang.Object, ISpeakerVerifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeakerVerifier", typeof (ISpeakerVerifierInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ISpeakerVerifier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpeakerVerifier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.aidl.ISpeakerVerifier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpeakerVerifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_endSpeak;
#pragma warning disable 0169
		static Delegate GetEndSpeakHandler ()
		{
			if (cb_endSpeak == null)
				cb_endSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndSpeak);
			return cb_endSpeak;
		}

		static void n_EndSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndSpeak ();
		}
#pragma warning restore 0169

		IntPtr id_endSpeak;
		public unsafe void EndSpeak ()
		{
			if (id_endSpeak == IntPtr.Zero)
				id_endSpeak = JNIEnv.GetMethodID (class_ref, "endSpeak", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endSpeak);
		}

		static Delegate cb_getParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParameter_Ljava_lang_String_Handler ()
		{
			if (cb_getParameter_Ljava_lang_String_ == null)
				cb_getParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetParameter_Ljava_lang_String_);
			return cb_getParameter_Ljava_lang_String_;
		}

		static IntPtr n_GetParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParameter_Ljava_lang_String_;
		public unsafe string GetParameter (string p0)
		{
			if (id_getParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_getParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Register (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		public unsafe int Register (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setParameter_Ljava_lang_String_Ljava_lang_String_;
		public unsafe int SetParameter (string p0, string p1)
		{
			if (id_setParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setParameter", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setParameter_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_stopSpeak;
#pragma warning disable 0169
		static Delegate GetStopSpeakHandler ()
		{
			if (cb_stopSpeak == null)
				cb_stopSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopSpeak);
			return cb_stopSpeak;
		}

		static void n_StopSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSpeak ();
		}
#pragma warning restore 0169

		IntPtr id_stopSpeak;
		public unsafe void StopSpeak ()
		{
			if (id_stopSpeak == IntPtr.Zero)
				id_stopSpeak = JNIEnv.GetMethodID (class_ref, "stopSpeak", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopSpeak);
		}

		static Delegate cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Verify (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		public unsafe int Verify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			if (id_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == IntPtr.Zero)
				id_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
