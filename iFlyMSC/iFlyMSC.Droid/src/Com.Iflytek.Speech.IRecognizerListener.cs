using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/RecognizerListener$Default", DoNotGenerateAcw=true)]
	public partial class RecognizerListenerDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.IRecognizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/RecognizerListener$Default", typeof (RecognizerListenerDefault));
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

		protected RecognizerListenerDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/constructor[@name='RecognizerListener.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecognizerListenerDefault ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='asBinder' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler")]
		public virtual unsafe void OnBeginOfSpeech ()
		{
			const string __id = "onBeginOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='onEndOfSpeech' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_onEvent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnEvent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_onEvent_IIILandroid_os_Bundle_ == null)
				cb_onEvent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnEvent_IIILandroid_os_Bundle_);
			return cb_onEvent_IIILandroid_os_Bundle_;
		}

		static void n_OnEvent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler")]
		public virtual unsafe void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			const string __id = "onEvent.(IIILandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler ()
		{
			if (cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z == null)
				cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnResult_Lcom_iflytek_speech_RecognizerResult_Z);
			return cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
		}

		static void n_OnResult_Lcom_iflytek_speech_RecognizerResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.RecognizerResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/speech/RecognizerResult;Z)V", "GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler")]
		public virtual unsafe void OnResult (global::Com.Iflytek.Speech.RecognizerResult p0, bool p1)
		{
			const string __id = "onResult.(Lcom/iflytek/speech/RecognizerResult;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onVolumeChanged_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IarrayBHandler ()
		{
			if (cb_onVolumeChanged_IarrayB == null)
				cb_onVolumeChanged_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnVolumeChanged_IarrayB);
			return cb_onVolumeChanged_IarrayB;
		}

		static void n_OnVolumeChanged_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnVolumeChanged (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Default']/method[@name='onVolumeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("onVolumeChanged", "(I[B)V", "GetOnVolumeChanged_IarrayBHandler")]
		public virtual unsafe void OnVolumeChanged (int p0, byte[] p1)
		{
			const string __id = "onVolumeChanged.(I[B)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/RecognizerListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class RecognizerListenerStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.IRecognizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/RecognizerListener$Stub", typeof (RecognizerListenerStub));
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

		protected RecognizerListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']/constructor[@name='RecognizerListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecognizerListenerStub ()
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

		public static unsafe global::Com.Iflytek.Speech.IRecognizerListener DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/RecognizerListener;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/RecognizerListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/RecognizerListener;", "")]
		public static unsafe global::Com.Iflytek.Speech.IRecognizerListener AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/RecognizerListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='RecognizerListener.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/RecognizerListener;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/RecognizerListener;)Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler")]
		public abstract void OnBeginOfSpeech ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndOfSpeech ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onEvent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnEvent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_onEvent_IIILandroid_os_Bundle_ == null)
				cb_onEvent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnEvent_IIILandroid_os_Bundle_);
			return cb_onEvent_IIILandroid_os_Bundle_;
		}

		static void n_OnEvent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler")]
		public abstract void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		static Delegate cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler ()
		{
			if (cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z == null)
				cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnResult_Lcom_iflytek_speech_RecognizerResult_Z);
			return cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
		}

		static void n_OnResult_Lcom_iflytek_speech_RecognizerResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.RecognizerResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/speech/RecognizerResult;Z)V", "GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler")]
		public abstract void OnResult (global::Com.Iflytek.Speech.RecognizerResult p0, bool p1);

		static Delegate cb_onVolumeChanged_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IarrayBHandler ()
		{
			if (cb_onVolumeChanged_IarrayB == null)
				cb_onVolumeChanged_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnVolumeChanged_IarrayB);
			return cb_onVolumeChanged_IarrayB;
		}

		static void n_OnVolumeChanged_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnVolumeChanged (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onVolumeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("onVolumeChanged", "(I[B)V", "GetOnVolumeChanged_IarrayBHandler")]
		public abstract void OnVolumeChanged (int p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/RecognizerListener$Stub", DoNotGenerateAcw=true)]
	internal partial class RecognizerListenerStubInvoker : RecognizerListenerStub {

		public RecognizerListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/RecognizerListener$Stub", typeof (RecognizerListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler")]
		public override unsafe void OnBeginOfSpeech ()
		{
			const string __id = "onBeginOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler")]
		public override unsafe void OnEndOfSpeech ()
		{
			const string __id = "onEndOfSpeech.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler")]
		public override unsafe void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			const string __id = "onEvent.(IIILandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.RecognizerResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/speech/RecognizerResult;Z)V", "GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler")]
		public override unsafe void OnResult (global::Com.Iflytek.Speech.RecognizerResult p0, bool p1)
		{
			const string __id = "onResult.(Lcom/iflytek/speech/RecognizerResult;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onVolumeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("onVolumeChanged", "(I[B)V", "GetOnVolumeChanged_IarrayBHandler")]
		public override unsafe void OnVolumeChanged (int p0, byte[] p1)
		{
			const string __id = "onVolumeChanged.(I[B)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']"
	[Register ("com/iflytek/speech/RecognizerListener", "", "Com.Iflytek.Speech.IRecognizerListenerInvoker")]
	public partial interface IRecognizerListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler:Com.Iflytek.Speech.IRecognizerListenerInvoker, iFlyMSC.Droid")]
		void OnBeginOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler:Com.Iflytek.Speech.IRecognizerListenerInvoker, iFlyMSC.Droid")]
		void OnEndOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Iflytek.Speech.IRecognizerListenerInvoker, iFlyMSC.Droid")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler:Com.Iflytek.Speech.IRecognizerListenerInvoker, iFlyMSC.Droid")]
		void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.speech.RecognizerResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/speech/RecognizerResult;Z)V", "GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler:Com.Iflytek.Speech.IRecognizerListenerInvoker, iFlyMSC.Droid")]
		void OnResult (global::Com.Iflytek.Speech.RecognizerResult p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='RecognizerListener']/method[@name='onVolumeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("onVolumeChanged", "(I[B)V", "GetOnVolumeChanged_IarrayBHandler:Com.Iflytek.Speech.IRecognizerListenerInvoker, iFlyMSC.Droid")]
		void OnVolumeChanged (int p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/RecognizerListener", DoNotGenerateAcw=true)]
	internal partial class IRecognizerListenerInvoker : global::Java.Lang.Object, IRecognizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/RecognizerListener", typeof (IRecognizerListenerInvoker));

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

		public static IRecognizerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRecognizerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.RecognizerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRecognizerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onEvent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnEvent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_onEvent_IIILandroid_os_Bundle_ == null)
				cb_onEvent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnEvent_IIILandroid_os_Bundle_);
			return cb_onEvent_IIILandroid_os_Bundle_;
		}

		static void n_OnEvent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_IIILandroid_os_Bundle_;
		public unsafe void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			if (id_onEvent_IIILandroid_os_Bundle_ == IntPtr.Zero)
				id_onEvent_IIILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(IIILandroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_IIILandroid_os_Bundle_, __args);
		}

		static Delegate cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_speech_RecognizerResult_ZHandler ()
		{
			if (cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z == null)
				cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnResult_Lcom_iflytek_speech_RecognizerResult_Z);
			return cb_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
		}

		static void n_OnResult_Lcom_iflytek_speech_RecognizerResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.RecognizerResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_speech_RecognizerResult_Z;
		public unsafe void OnResult (global::Com.Iflytek.Speech.RecognizerResult p0, bool p1)
		{
			if (id_onResult_Lcom_iflytek_speech_RecognizerResult_Z == IntPtr.Zero)
				id_onResult_Lcom_iflytek_speech_RecognizerResult_Z = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/speech/RecognizerResult;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_speech_RecognizerResult_Z, __args);
		}

		static Delegate cb_onVolumeChanged_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IarrayBHandler ()
		{
			if (cb_onVolumeChanged_IarrayB == null)
				cb_onVolumeChanged_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnVolumeChanged_IarrayB);
			return cb_onVolumeChanged_IarrayB;
		}

		static void n_OnVolumeChanged_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnVolumeChanged (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onVolumeChanged_IarrayB;
		public unsafe void OnVolumeChanged (int p0, byte[] p1)
		{
			if (id_onVolumeChanged_IarrayB == IntPtr.Zero)
				id_onVolumeChanged_IarrayB = JNIEnv.GetMethodID (class_ref, "onVolumeChanged", "(I[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVolumeChanged_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
