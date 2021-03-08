using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/VerifierListener$Default", DoNotGenerateAcw=true)]
	public partial class VerifierListenerDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.IVerifierListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/VerifierListener$Default", typeof (VerifierListenerDefault));
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

		protected VerifierListenerDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/constructor[@name='VerifierListener.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VerifierListenerDefault ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_onBeginOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnBeginOfSpeechHandler ()
		{
			if (cb_onBeginOfSpeech == null)
				cb_onBeginOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBeginOfSpeech);
			return cb_onBeginOfSpeech;
		}

		static void n_OnBeginOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler")]
		public virtual unsafe void OnBeginOfSpeech ()
		{
			const string __id = "onBeginOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler")]
		public virtual unsafe void OnCancel ()
		{
			const string __id = "onCancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onEnd_Lcom_iflytek_speech_VerifierResult_I;
#pragma warning disable 0169
		static Delegate GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler ()
		{
			if (cb_onEnd_Lcom_iflytek_speech_VerifierResult_I == null)
				cb_onEnd_Lcom_iflytek_speech_VerifierResult_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnEnd_Lcom_iflytek_speech_VerifierResult_I);
			return cb_onEnd_Lcom_iflytek_speech_VerifierResult_I;
		}

		static void n_OnEnd_Lcom_iflytek_speech_VerifierResult_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEnd (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onEnd' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.VerifierResult'] and parameter[2][@type='int']]"
		[Register ("onEnd", "(Lcom/iflytek/speech/VerifierResult;I)V", "GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler")]
		public virtual unsafe void OnEnd (global::Com.Iflytek.Speech.VerifierResult p0, int p1)
		{
			const string __id = "onEnd.(Lcom/iflytek/speech/VerifierResult;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onEndOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnEndOfSpeechHandler ()
		{
			if (cb_onEndOfSpeech == null)
				cb_onEndOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnEndOfSpeech);
			return cb_onEndOfSpeech;
		}

		static void n_OnEndOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler")]
		public virtual unsafe void OnEndOfSpeech ()
		{
			const string __id = "onEndOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public virtual unsafe void OnError (int p0)
		{
			const string __id = "onError.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRegister_Lcom_iflytek_speech_VerifierResult_;
#pragma warning disable 0169
		static Delegate GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler ()
		{
			if (cb_onRegister_Lcom_iflytek_speech_VerifierResult_ == null)
				cb_onRegister_Lcom_iflytek_speech_VerifierResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRegister_Lcom_iflytek_speech_VerifierResult_);
			return cb_onRegister_Lcom_iflytek_speech_VerifierResult_;
		}

		static void n_OnRegister_Lcom_iflytek_speech_VerifierResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRegister (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onRegister' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.VerifierResult']]"
		[Register ("onRegister", "(Lcom/iflytek/speech/VerifierResult;)V", "GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler")]
		public virtual unsafe void OnRegister (global::Com.Iflytek.Speech.VerifierResult p0)
		{
			const string __id = "onRegister.(Lcom/iflytek/speech/VerifierResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onVolumeChanged_I;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IHandler ()
		{
			if (cb_onVolumeChanged_I == null)
				cb_onVolumeChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnVolumeChanged_I);
			return cb_onVolumeChanged_I;
		}

		static void n_OnVolumeChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVolumeChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Default']/method[@name='onVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler")]
		public virtual unsafe void OnVolumeChanged (int p0)
		{
			const string __id = "onVolumeChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/VerifierListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class VerifierListenerStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.IVerifierListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/VerifierListener$Stub", typeof (VerifierListenerStub));
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

		protected VerifierListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']/constructor[@name='VerifierListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VerifierListenerStub ()
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

		public static unsafe global::Com.Iflytek.Speech.IVerifierListener DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/VerifierListener;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/VerifierListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/VerifierListener;", "")]
		public static unsafe global::Com.Iflytek.Speech.IVerifierListener AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/VerifierListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='VerifierListener.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/VerifierListener;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.IVerifierListener p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/VerifierListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onBeginOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnBeginOfSpeechHandler ()
		{
			if (cb_onBeginOfSpeech == null)
				cb_onBeginOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBeginOfSpeech);
			return cb_onBeginOfSpeech;
		}

		static void n_OnBeginOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler")]
		public abstract void OnBeginOfSpeech ();

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler")]
		public abstract void OnCancel ();

		static Delegate cb_onEnd_Lcom_iflytek_speech_VerifierResult_I;
#pragma warning disable 0169
		static Delegate GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler ()
		{
			if (cb_onEnd_Lcom_iflytek_speech_VerifierResult_I == null)
				cb_onEnd_Lcom_iflytek_speech_VerifierResult_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnEnd_Lcom_iflytek_speech_VerifierResult_I);
			return cb_onEnd_Lcom_iflytek_speech_VerifierResult_I;
		}

		static void n_OnEnd_Lcom_iflytek_speech_VerifierResult_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEnd (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onEnd' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.VerifierResult'] and parameter[2][@type='int']]"
		[Register ("onEnd", "(Lcom/iflytek/speech/VerifierResult;I)V", "GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler")]
		public abstract void OnEnd (global::Com.Iflytek.Speech.VerifierResult p0, int p1);

		static Delegate cb_onEndOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnEndOfSpeechHandler ()
		{
			if (cb_onEndOfSpeech == null)
				cb_onEndOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnEndOfSpeech);
			return cb_onEndOfSpeech;
		}

		static void n_OnEndOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler")]
		public abstract void OnEndOfSpeech ();

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onRegister_Lcom_iflytek_speech_VerifierResult_;
#pragma warning disable 0169
		static Delegate GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler ()
		{
			if (cb_onRegister_Lcom_iflytek_speech_VerifierResult_ == null)
				cb_onRegister_Lcom_iflytek_speech_VerifierResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRegister_Lcom_iflytek_speech_VerifierResult_);
			return cb_onRegister_Lcom_iflytek_speech_VerifierResult_;
		}

		static void n_OnRegister_Lcom_iflytek_speech_VerifierResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRegister (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onRegister' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.VerifierResult']]"
		[Register ("onRegister", "(Lcom/iflytek/speech/VerifierResult;)V", "GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler")]
		public abstract void OnRegister (global::Com.Iflytek.Speech.VerifierResult p0);

		static Delegate cb_onVolumeChanged_I;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IHandler ()
		{
			if (cb_onVolumeChanged_I == null)
				cb_onVolumeChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnVolumeChanged_I);
			return cb_onVolumeChanged_I;
		}

		static void n_OnVolumeChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVolumeChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler")]
		public abstract void OnVolumeChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/VerifierListener$Stub", DoNotGenerateAcw=true)]
	internal partial class VerifierListenerStubInvoker : VerifierListenerStub {

		public VerifierListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/VerifierListener$Stub", typeof (VerifierListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler")]
		public override unsafe void OnBeginOfSpeech ()
		{
			const string __id = "onBeginOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler")]
		public override unsafe void OnCancel ()
		{
			const string __id = "onCancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onEnd' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.VerifierResult'] and parameter[2][@type='int']]"
		[Register ("onEnd", "(Lcom/iflytek/speech/VerifierResult;I)V", "GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler")]
		public override unsafe void OnEnd (global::Com.Iflytek.Speech.VerifierResult p0, int p1)
		{
			const string __id = "onEnd.(Lcom/iflytek/speech/VerifierResult;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler")]
		public override unsafe void OnEndOfSpeech ()
		{
			const string __id = "onEndOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public override unsafe void OnError (int p0)
		{
			const string __id = "onError.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onRegister' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.VerifierResult']]"
		[Register ("onRegister", "(Lcom/iflytek/speech/VerifierResult;)V", "GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler")]
		public override unsafe void OnRegister (global::Com.Iflytek.Speech.VerifierResult p0)
		{
			const string __id = "onRegister.(Lcom/iflytek/speech/VerifierResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler")]
		public override unsafe void OnVolumeChanged (int p0)
		{
			const string __id = "onVolumeChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']"
	[Register ("com/iflytek/speech/VerifierListener", "", "Com.Iflytek.Speech.IVerifierListenerInvoker")]
	public partial interface IVerifierListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnBeginOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onEnd' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.VerifierResult'] and parameter[2][@type='int']]"
		[Register ("onEnd", "(Lcom/iflytek/speech/VerifierResult;I)V", "GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnEnd (global::Com.Iflytek.Speech.VerifierResult p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnEndOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onRegister' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.VerifierResult']]"
		[Register ("onRegister", "(Lcom/iflytek/speech/VerifierResult;)V", "GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnRegister (global::Com.Iflytek.Speech.VerifierResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='VerifierListener']/method[@name='onVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler:Com.Iflytek.Speech.IVerifierListenerInvoker, iFlyMSC.Droid")]
		void OnVolumeChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/VerifierListener", DoNotGenerateAcw=true)]
	internal partial class IVerifierListenerInvoker : global::Java.Lang.Object, IVerifierListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/VerifierListener", typeof (IVerifierListenerInvoker));

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

		public static IVerifierListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVerifierListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.VerifierListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVerifierListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeginOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnBeginOfSpeechHandler ()
		{
			if (cb_onBeginOfSpeech == null)
				cb_onBeginOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBeginOfSpeech);
			return cb_onBeginOfSpeech;
		}

		static void n_OnBeginOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfSpeech ();
		}
#pragma warning restore 0169

		IntPtr id_onBeginOfSpeech;
		public unsafe void OnBeginOfSpeech ()
		{
			if (id_onBeginOfSpeech == IntPtr.Zero)
				id_onBeginOfSpeech = JNIEnv.GetMethodID (class_ref, "onBeginOfSpeech", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeginOfSpeech);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate cb_onEnd_Lcom_iflytek_speech_VerifierResult_I;
#pragma warning disable 0169
		static Delegate GetOnEnd_Lcom_iflytek_speech_VerifierResult_IHandler ()
		{
			if (cb_onEnd_Lcom_iflytek_speech_VerifierResult_I == null)
				cb_onEnd_Lcom_iflytek_speech_VerifierResult_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnEnd_Lcom_iflytek_speech_VerifierResult_I);
			return cb_onEnd_Lcom_iflytek_speech_VerifierResult_I;
		}

		static void n_OnEnd_Lcom_iflytek_speech_VerifierResult_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEnd (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onEnd_Lcom_iflytek_speech_VerifierResult_I;
		public unsafe void OnEnd (global::Com.Iflytek.Speech.VerifierResult p0, int p1)
		{
			if (id_onEnd_Lcom_iflytek_speech_VerifierResult_I == IntPtr.Zero)
				id_onEnd_Lcom_iflytek_speech_VerifierResult_I = JNIEnv.GetMethodID (class_ref, "onEnd", "(Lcom/iflytek/speech/VerifierResult;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEnd_Lcom_iflytek_speech_VerifierResult_I, __args);
		}

		static Delegate cb_onEndOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnEndOfSpeechHandler ()
		{
			if (cb_onEndOfSpeech == null)
				cb_onEndOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnEndOfSpeech);
			return cb_onEndOfSpeech;
		}

		static void n_OnEndOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndOfSpeech ();
		}
#pragma warning restore 0169

		IntPtr id_onEndOfSpeech;
		public unsafe void OnEndOfSpeech ()
		{
			if (id_onEndOfSpeech == IntPtr.Zero)
				id_onEndOfSpeech = JNIEnv.GetMethodID (class_ref, "onEndOfSpeech", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEndOfSpeech);
		}

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_I;
		public unsafe void OnError (int p0)
		{
			if (id_onError_I == IntPtr.Zero)
				id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
		}

		static Delegate cb_onRegister_Lcom_iflytek_speech_VerifierResult_;
#pragma warning disable 0169
		static Delegate GetOnRegister_Lcom_iflytek_speech_VerifierResult_Handler ()
		{
			if (cb_onRegister_Lcom_iflytek_speech_VerifierResult_ == null)
				cb_onRegister_Lcom_iflytek_speech_VerifierResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRegister_Lcom_iflytek_speech_VerifierResult_);
			return cb_onRegister_Lcom_iflytek_speech_VerifierResult_;
		}

		static void n_OnRegister_Lcom_iflytek_speech_VerifierResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.VerifierResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRegister (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRegister_Lcom_iflytek_speech_VerifierResult_;
		public unsafe void OnRegister (global::Com.Iflytek.Speech.VerifierResult p0)
		{
			if (id_onRegister_Lcom_iflytek_speech_VerifierResult_ == IntPtr.Zero)
				id_onRegister_Lcom_iflytek_speech_VerifierResult_ = JNIEnv.GetMethodID (class_ref, "onRegister", "(Lcom/iflytek/speech/VerifierResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRegister_Lcom_iflytek_speech_VerifierResult_, __args);
		}

		static Delegate cb_onVolumeChanged_I;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IHandler ()
		{
			if (cb_onVolumeChanged_I == null)
				cb_onVolumeChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnVolumeChanged_I);
			return cb_onVolumeChanged_I;
		}

		static void n_OnVolumeChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVolumeChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVolumeChanged_I;
		public unsafe void OnVolumeChanged (int p0)
		{
			if (id_onVolumeChanged_I == IntPtr.Zero)
				id_onVolumeChanged_I = JNIEnv.GetMethodID (class_ref, "onVolumeChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVolumeChanged_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
