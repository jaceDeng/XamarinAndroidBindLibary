using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/IWakeuper$Default", DoNotGenerateAcw=true)]
	public partial class WakeuperDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.Aidl.IWakeuper {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/IWakeuper$Default", typeof (WakeuperDefault));
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

		protected WakeuperDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/constructor[@name='IWakeuper.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WakeuperDefault ()
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

		static Delegate cb_isListening;
#pragma warning disable 0169
		static Delegate GetIsListeningHandler ()
		{
			if (cb_isListening == null)
				cb_isListening = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsListening);
			return cb_isListening;
		}

		static bool n_IsListening (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler")]
			get {
				const string __id = "isListening.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_cancel_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_cancel_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_WakeuperListener_);
			return cb_cancel_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public virtual unsafe void Cancel (global::Com.Iflytek.Speech.IWakeuperListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/WakeuperListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_);
			return cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public virtual unsafe void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IWakeuperListener p1)
		{
			const string __id = "startListening.(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_stopListening_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopListening_Lcom_iflytek_speech_WakeuperListener_);
			return cb_stopListening_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_StopListening_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListening (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Default']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public virtual unsafe void StopListening (global::Com.Iflytek.Speech.IWakeuperListener p0)
		{
			const string __id = "stopListening.(Lcom/iflytek/speech/WakeuperListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/IWakeuper$Stub", DoNotGenerateAcw=true)]
	public abstract partial class WakeuperStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.Aidl.IWakeuper {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/IWakeuper$Stub", typeof (WakeuperStub));
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

		protected WakeuperStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/constructor[@name='IWakeuper.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WakeuperStub ()
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

		public static unsafe global::Com.Iflytek.Speech.Aidl.IWakeuper DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/aidl/IWakeuper;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/aidl/IWakeuper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/IWakeuper;", "")]
		public static unsafe global::Com.Iflytek.Speech.Aidl.IWakeuper AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/IWakeuper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.aidl.IWakeuper']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/aidl/IWakeuper;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.Aidl.IWakeuper p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/aidl/IWakeuper;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_cancel_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_WakeuperListener_);
			return cb_cancel_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public abstract void Cancel (global::Com.Iflytek.Speech.IWakeuperListener p0);

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public abstract void Destroy ();

		static Delegate cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_);
			return cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public abstract void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IWakeuperListener p1);

		static Delegate cb_stopListening_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopListening_Lcom_iflytek_speech_WakeuperListener_);
			return cb_stopListening_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_StopListening_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListening (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public abstract void StopListening (global::Com.Iflytek.Speech.IWakeuperListener p0);

		static Delegate cb_isListening;
#pragma warning disable 0169
		static Delegate GetIsListeningHandler ()
		{
			if (cb_isListening == null)
				cb_isListening = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsListening);
			return cb_isListening;
		}

		static bool n_IsListening (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.WakeuperStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public abstract bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/IWakeuper$Stub", DoNotGenerateAcw=true)]
	internal partial class WakeuperStubInvoker : WakeuperStub {

		public WakeuperStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/IWakeuper$Stub", typeof (WakeuperStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='IWakeuper.Stub']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler")]
			get {
				const string __id = "isListening.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public override unsafe void Cancel (global::Com.Iflytek.Speech.IWakeuperListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/WakeuperListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public override unsafe void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IWakeuperListener p1)
		{
			const string __id = "startListening.(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler")]
		public override unsafe void StopListening (global::Com.Iflytek.Speech.IWakeuperListener p0)
		{
			const string __id = "stopListening.(Lcom/iflytek/speech/WakeuperListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']"
	[Register ("com/iflytek/speech/aidl/IWakeuper", "", "Com.Iflytek.Speech.Aidl.IWakeuperInvoker")]
	public partial interface IWakeuper : global::Android.OS.IInterface {

		bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler:Com.Iflytek.Speech.Aidl.IWakeuperInvoker, iFlyMSC.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler:Com.Iflytek.Speech.Aidl.IWakeuperInvoker, iFlyMSC.Droid")]
		void Cancel (global::Com.Iflytek.Speech.IWakeuperListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Iflytek.Speech.Aidl.IWakeuperInvoker, iFlyMSC.Droid")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler:Com.Iflytek.Speech.Aidl.IWakeuperInvoker, iFlyMSC.Droid")]
		void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IWakeuperListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='IWakeuper']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.WakeuperListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/WakeuperListener;)V", "GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler:Com.Iflytek.Speech.Aidl.IWakeuperInvoker, iFlyMSC.Droid")]
		void StopListening (global::Com.Iflytek.Speech.IWakeuperListener p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/IWakeuper", DoNotGenerateAcw=true)]
	internal partial class IWakeuperInvoker : global::Java.Lang.Object, IWakeuper {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/IWakeuper", typeof (IWakeuperInvoker));

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

		public static IWakeuper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWakeuper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.aidl.IWakeuper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWakeuperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isListening;
#pragma warning disable 0169
		static Delegate GetIsListeningHandler ()
		{
			if (cb_isListening == null)
				cb_isListening = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsListening);
			return cb_isListening;
		}

		static bool n_IsListening (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		IntPtr id_isListening;
		public unsafe bool IsListening {
			get {
				if (id_isListening == IntPtr.Zero)
					id_isListening = JNIEnv.GetMethodID (class_ref, "isListening", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isListening);
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_cancel_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_WakeuperListener_);
			return cb_cancel_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Lcom_iflytek_speech_WakeuperListener_;
		public unsafe void Cancel (global::Com.Iflytek.Speech.IWakeuperListener p0)
		{
			if (id_cancel_Lcom_iflytek_speech_WakeuperListener_ == IntPtr.Zero)
				id_cancel_Lcom_iflytek_speech_WakeuperListener_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Lcom/iflytek/speech/WakeuperListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Lcom_iflytek_speech_WakeuperListener_, __args);
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_);
			return cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_;
		public unsafe void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IWakeuperListener p1)
		{
			if (id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ == IntPtr.Zero)
				id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_ = JNIEnv.GetMethodID (class_ref, "startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/WakeuperListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_WakeuperListener_, __args);
		}

		static Delegate cb_stopListening_Lcom_iflytek_speech_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_WakeuperListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_WakeuperListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopListening_Lcom_iflytek_speech_WakeuperListener_);
			return cb_stopListening_Lcom_iflytek_speech_WakeuperListener_;
		}

		static void n_StopListening_Lcom_iflytek_speech_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListening (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopListening_Lcom_iflytek_speech_WakeuperListener_;
		public unsafe void StopListening (global::Com.Iflytek.Speech.IWakeuperListener p0)
		{
			if (id_stopListening_Lcom_iflytek_speech_WakeuperListener_ == IntPtr.Zero)
				id_stopListening_Lcom_iflytek_speech_WakeuperListener_ = JNIEnv.GetMethodID (class_ref, "stopListening", "(Lcom/iflytek/speech/WakeuperListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopListening_Lcom_iflytek_speech_WakeuperListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.IWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
