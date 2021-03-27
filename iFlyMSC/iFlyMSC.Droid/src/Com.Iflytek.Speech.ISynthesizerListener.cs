using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/SynthesizerListener$Default", DoNotGenerateAcw=true)]
	public partial class SynthesizerListenerDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.ISynthesizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SynthesizerListener$Default", typeof (SynthesizerListenerDefault));
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

		protected SynthesizerListenerDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/constructor[@name='SynthesizerListener.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SynthesizerListenerDefault ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_onBufferProgress_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBufferProgress_IIILjava_lang_String_Handler ()
		{
			if (cb_onBufferProgress_IIILjava_lang_String_ == null)
				cb_onBufferProgress_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnBufferProgress_IIILjava_lang_String_);
			return cb_onBufferProgress_IIILjava_lang_String_;
		}

		static void n_OnBufferProgress_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferProgress (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onBufferProgress' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onBufferProgress", "(IIILjava/lang/String;)V", "GetOnBufferProgress_IIILjava_lang_String_Handler")]
		public virtual unsafe void OnBufferProgress (int p0, int p1, int p2, string p3)
		{
			const string __id = "onBufferProgress.(IIILjava/lang/String;)V";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onCompleted_I;
#pragma warning disable 0169
		static Delegate GetOnCompleted_IHandler ()
		{
			if (cb_onCompleted_I == null)
				cb_onCompleted_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnCompleted_I);
			return cb_onCompleted_I;
		}

		static void n_OnCompleted_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCompleted", "(I)V", "GetOnCompleted_IHandler")]
		public virtual unsafe void OnCompleted (int p0)
		{
			const string __id = "onCompleted.(I)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
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

		static Delegate cb_onSpeakBegin;
#pragma warning disable 0169
		static Delegate GetOnSpeakBeginHandler ()
		{
			if (cb_onSpeakBegin == null)
				cb_onSpeakBegin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakBegin);
			return cb_onSpeakBegin;
		}

		static void n_OnSpeakBegin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakBegin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onSpeakBegin' and count(parameter)=0]"
		[Register ("onSpeakBegin", "()V", "GetOnSpeakBeginHandler")]
		public virtual unsafe void OnSpeakBegin ()
		{
			const string __id = "onSpeakBegin.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSpeakPaused;
#pragma warning disable 0169
		static Delegate GetOnSpeakPausedHandler ()
		{
			if (cb_onSpeakPaused == null)
				cb_onSpeakPaused = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakPaused);
			return cb_onSpeakPaused;
		}

		static void n_OnSpeakPaused (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakPaused ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onSpeakPaused' and count(parameter)=0]"
		[Register ("onSpeakPaused", "()V", "GetOnSpeakPausedHandler")]
		public virtual unsafe void OnSpeakPaused ()
		{
			const string __id = "onSpeakPaused.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSpeakProgress_III;
#pragma warning disable 0169
		static Delegate GetOnSpeakProgress_IIIHandler ()
		{
			if (cb_onSpeakProgress_III == null)
				cb_onSpeakProgress_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnSpeakProgress_III);
			return cb_onSpeakProgress_III;
		}

		static void n_OnSpeakProgress_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onSpeakProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSpeakProgress", "(III)V", "GetOnSpeakProgress_IIIHandler")]
		public virtual unsafe void OnSpeakProgress (int p0, int p1, int p2)
		{
			const string __id = "onSpeakProgress.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSpeakResumed;
#pragma warning disable 0169
		static Delegate GetOnSpeakResumedHandler ()
		{
			if (cb_onSpeakResumed == null)
				cb_onSpeakResumed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakResumed);
			return cb_onSpeakResumed;
		}

		static void n_OnSpeakResumed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakResumed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Default']/method[@name='onSpeakResumed' and count(parameter)=0]"
		[Register ("onSpeakResumed", "()V", "GetOnSpeakResumedHandler")]
		public virtual unsafe void OnSpeakResumed ()
		{
			const string __id = "onSpeakResumed.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/SynthesizerListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class SynthesizerListenerStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.ISynthesizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SynthesizerListener$Stub", typeof (SynthesizerListenerStub));
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

		protected SynthesizerListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']/constructor[@name='SynthesizerListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SynthesizerListenerStub ()
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

		public static unsafe global::Com.Iflytek.Speech.ISynthesizerListener DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/SynthesizerListener;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/SynthesizerListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/SynthesizerListener;", "")]
		public static unsafe global::Com.Iflytek.Speech.ISynthesizerListener AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/SynthesizerListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SynthesizerListener.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/SynthesizerListener;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/SynthesizerListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onBufferProgress_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBufferProgress_IIILjava_lang_String_Handler ()
		{
			if (cb_onBufferProgress_IIILjava_lang_String_ == null)
				cb_onBufferProgress_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnBufferProgress_IIILjava_lang_String_);
			return cb_onBufferProgress_IIILjava_lang_String_;
		}

		static void n_OnBufferProgress_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferProgress (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onBufferProgress' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onBufferProgress", "(IIILjava/lang/String;)V", "GetOnBufferProgress_IIILjava_lang_String_Handler")]
		public abstract void OnBufferProgress (int p0, int p1, int p2, string p3);

		static Delegate cb_onCompleted_I;
#pragma warning disable 0169
		static Delegate GetOnCompleted_IHandler ()
		{
			if (cb_onCompleted_I == null)
				cb_onCompleted_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnCompleted_I);
			return cb_onCompleted_I;
		}

		static void n_OnCompleted_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCompleted", "(I)V", "GetOnCompleted_IHandler")]
		public abstract void OnCompleted (int p0);

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler")]
		public abstract void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		static Delegate cb_onSpeakBegin;
#pragma warning disable 0169
		static Delegate GetOnSpeakBeginHandler ()
		{
			if (cb_onSpeakBegin == null)
				cb_onSpeakBegin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakBegin);
			return cb_onSpeakBegin;
		}

		static void n_OnSpeakBegin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakBegin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakBegin' and count(parameter)=0]"
		[Register ("onSpeakBegin", "()V", "GetOnSpeakBeginHandler")]
		public abstract void OnSpeakBegin ();

		static Delegate cb_onSpeakPaused;
#pragma warning disable 0169
		static Delegate GetOnSpeakPausedHandler ()
		{
			if (cb_onSpeakPaused == null)
				cb_onSpeakPaused = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakPaused);
			return cb_onSpeakPaused;
		}

		static void n_OnSpeakPaused (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakPaused ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakPaused' and count(parameter)=0]"
		[Register ("onSpeakPaused", "()V", "GetOnSpeakPausedHandler")]
		public abstract void OnSpeakPaused ();

		static Delegate cb_onSpeakProgress_III;
#pragma warning disable 0169
		static Delegate GetOnSpeakProgress_IIIHandler ()
		{
			if (cb_onSpeakProgress_III == null)
				cb_onSpeakProgress_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnSpeakProgress_III);
			return cb_onSpeakProgress_III;
		}

		static void n_OnSpeakProgress_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSpeakProgress", "(III)V", "GetOnSpeakProgress_IIIHandler")]
		public abstract void OnSpeakProgress (int p0, int p1, int p2);

		static Delegate cb_onSpeakResumed;
#pragma warning disable 0169
		static Delegate GetOnSpeakResumedHandler ()
		{
			if (cb_onSpeakResumed == null)
				cb_onSpeakResumed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakResumed);
			return cb_onSpeakResumed;
		}

		static void n_OnSpeakResumed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SynthesizerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakResumed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakResumed' and count(parameter)=0]"
		[Register ("onSpeakResumed", "()V", "GetOnSpeakResumedHandler")]
		public abstract void OnSpeakResumed ();

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/SynthesizerListener$Stub", DoNotGenerateAcw=true)]
	internal partial class SynthesizerListenerStubInvoker : SynthesizerListenerStub {

		public SynthesizerListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SynthesizerListener$Stub", typeof (SynthesizerListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onBufferProgress' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onBufferProgress", "(IIILjava/lang/String;)V", "GetOnBufferProgress_IIILjava_lang_String_Handler")]
		public override unsafe void OnBufferProgress (int p0, int p1, int p2, string p3)
		{
			const string __id = "onBufferProgress.(IIILjava/lang/String;)V";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCompleted", "(I)V", "GetOnCompleted_IHandler")]
		public override unsafe void OnCompleted (int p0)
		{
			const string __id = "onCompleted.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakBegin' and count(parameter)=0]"
		[Register ("onSpeakBegin", "()V", "GetOnSpeakBeginHandler")]
		public override unsafe void OnSpeakBegin ()
		{
			const string __id = "onSpeakBegin.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakPaused' and count(parameter)=0]"
		[Register ("onSpeakPaused", "()V", "GetOnSpeakPausedHandler")]
		public override unsafe void OnSpeakPaused ()
		{
			const string __id = "onSpeakPaused.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSpeakProgress", "(III)V", "GetOnSpeakProgress_IIIHandler")]
		public override unsafe void OnSpeakProgress (int p0, int p1, int p2)
		{
			const string __id = "onSpeakProgress.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakResumed' and count(parameter)=0]"
		[Register ("onSpeakResumed", "()V", "GetOnSpeakResumedHandler")]
		public override unsafe void OnSpeakResumed ()
		{
			const string __id = "onSpeakResumed.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']"
	[Register ("com/iflytek/speech/SynthesizerListener", "", "Com.Iflytek.Speech.ISynthesizerListenerInvoker")]
	public partial interface ISynthesizerListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onBufferProgress' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onBufferProgress", "(IIILjava/lang/String;)V", "GetOnBufferProgress_IIILjava_lang_String_Handler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnBufferProgress (int p0, int p1, int p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCompleted", "(I)V", "GetOnCompleted_IHandler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnCompleted (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakBegin' and count(parameter)=0]"
		[Register ("onSpeakBegin", "()V", "GetOnSpeakBeginHandler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakBegin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakPaused' and count(parameter)=0]"
		[Register ("onSpeakPaused", "()V", "GetOnSpeakPausedHandler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakPaused ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSpeakProgress", "(III)V", "GetOnSpeakProgress_IIIHandler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakProgress (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SynthesizerListener']/method[@name='onSpeakResumed' and count(parameter)=0]"
		[Register ("onSpeakResumed", "()V", "GetOnSpeakResumedHandler:Com.Iflytek.Speech.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakResumed ();

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/SynthesizerListener", DoNotGenerateAcw=true)]
	internal partial class ISynthesizerListenerInvoker : global::Java.Lang.Object, ISynthesizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SynthesizerListener", typeof (ISynthesizerListenerInvoker));

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

		public static ISynthesizerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISynthesizerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.SynthesizerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISynthesizerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBufferProgress_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBufferProgress_IIILjava_lang_String_Handler ()
		{
			if (cb_onBufferProgress_IIILjava_lang_String_ == null)
				cb_onBufferProgress_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnBufferProgress_IIILjava_lang_String_);
			return cb_onBufferProgress_IIILjava_lang_String_;
		}

		static void n_OnBufferProgress_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferProgress (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onBufferProgress_IIILjava_lang_String_;
		public unsafe void OnBufferProgress (int p0, int p1, int p2, string p3)
		{
			if (id_onBufferProgress_IIILjava_lang_String_ == IntPtr.Zero)
				id_onBufferProgress_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBufferProgress", "(IIILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferProgress_IIILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_onCompleted_I;
#pragma warning disable 0169
		static Delegate GetOnCompleted_IHandler ()
		{
			if (cb_onCompleted_I == null)
				cb_onCompleted_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnCompleted_I);
			return cb_onCompleted_I;
		}

		static void n_OnCompleted_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_I;
		public unsafe void OnCompleted (int p0)
		{
			if (id_onCompleted_I == IntPtr.Zero)
				id_onCompleted_I = JNIEnv.GetMethodID (class_ref, "onCompleted", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSpeakBegin;
#pragma warning disable 0169
		static Delegate GetOnSpeakBeginHandler ()
		{
			if (cb_onSpeakBegin == null)
				cb_onSpeakBegin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakBegin);
			return cb_onSpeakBegin;
		}

		static void n_OnSpeakBegin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakBegin ();
		}
#pragma warning restore 0169

		IntPtr id_onSpeakBegin;
		public unsafe void OnSpeakBegin ()
		{
			if (id_onSpeakBegin == IntPtr.Zero)
				id_onSpeakBegin = JNIEnv.GetMethodID (class_ref, "onSpeakBegin", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakBegin);
		}

		static Delegate cb_onSpeakPaused;
#pragma warning disable 0169
		static Delegate GetOnSpeakPausedHandler ()
		{
			if (cb_onSpeakPaused == null)
				cb_onSpeakPaused = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakPaused);
			return cb_onSpeakPaused;
		}

		static void n_OnSpeakPaused (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakPaused ();
		}
#pragma warning restore 0169

		IntPtr id_onSpeakPaused;
		public unsafe void OnSpeakPaused ()
		{
			if (id_onSpeakPaused == IntPtr.Zero)
				id_onSpeakPaused = JNIEnv.GetMethodID (class_ref, "onSpeakPaused", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakPaused);
		}

		static Delegate cb_onSpeakProgress_III;
#pragma warning disable 0169
		static Delegate GetOnSpeakProgress_IIIHandler ()
		{
			if (cb_onSpeakProgress_III == null)
				cb_onSpeakProgress_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnSpeakProgress_III);
			return cb_onSpeakProgress_III;
		}

		static void n_OnSpeakProgress_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onSpeakProgress_III;
		public unsafe void OnSpeakProgress (int p0, int p1, int p2)
		{
			if (id_onSpeakProgress_III == IntPtr.Zero)
				id_onSpeakProgress_III = JNIEnv.GetMethodID (class_ref, "onSpeakProgress", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakProgress_III, __args);
		}

		static Delegate cb_onSpeakResumed;
#pragma warning disable 0169
		static Delegate GetOnSpeakResumedHandler ()
		{
			if (cb_onSpeakResumed == null)
				cb_onSpeakResumed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakResumed);
			return cb_onSpeakResumed;
		}

		static void n_OnSpeakResumed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakResumed ();
		}
#pragma warning restore 0169

		IntPtr id_onSpeakResumed;
		public unsafe void OnSpeakResumed ()
		{
			if (id_onSpeakResumed == IntPtr.Zero)
				id_onSpeakResumed = JNIEnv.GetMethodID (class_ref, "onSpeakResumed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakResumed);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
