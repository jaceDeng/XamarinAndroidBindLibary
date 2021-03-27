using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/TextUnderstanderListener$Default", DoNotGenerateAcw=true)]
	public partial class TextUnderstanderListenerDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.ITextUnderstanderListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/TextUnderstanderListener$Default", typeof (TextUnderstanderListenerDefault));
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

		protected TextUnderstanderListenerDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Default']/constructor[@name='TextUnderstanderListener.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextUnderstanderListenerDefault ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Default']/method[@name='asBinder' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Default']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_onResult_Lcom_iflytek_speech_UnderstanderResult_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler ()
		{
			if (cb_onResult_Lcom_iflytek_speech_UnderstanderResult_ == null)
				cb_onResult_Lcom_iflytek_speech_UnderstanderResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Lcom_iflytek_speech_UnderstanderResult_);
			return cb_onResult_Lcom_iflytek_speech_UnderstanderResult_;
		}

		static void n_OnResult_Lcom_iflytek_speech_UnderstanderResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.UnderstanderResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Default']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.UnderstanderResult']]"
		[Register ("onResult", "(Lcom/iflytek/speech/UnderstanderResult;)V", "GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler")]
		public virtual unsafe void OnResult (global::Com.Iflytek.Speech.UnderstanderResult p0)
		{
			const string __id = "onResult.(Lcom/iflytek/speech/UnderstanderResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/TextUnderstanderListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class TextUnderstanderListenerStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.ITextUnderstanderListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/TextUnderstanderListener$Stub", typeof (TextUnderstanderListenerStub));
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

		protected TextUnderstanderListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']/constructor[@name='TextUnderstanderListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextUnderstanderListenerStub ()
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

		public static unsafe global::Com.Iflytek.Speech.ITextUnderstanderListener DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/TextUnderstanderListener;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/TextUnderstanderListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/TextUnderstanderListener;", "")]
		public static unsafe global::Com.Iflytek.Speech.ITextUnderstanderListener AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/TextUnderstanderListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='TextUnderstanderListener.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/TextUnderstanderListener;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.ITextUnderstanderListener p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/TextUnderstanderListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onResult_Lcom_iflytek_speech_UnderstanderResult_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler ()
		{
			if (cb_onResult_Lcom_iflytek_speech_UnderstanderResult_ == null)
				cb_onResult_Lcom_iflytek_speech_UnderstanderResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Lcom_iflytek_speech_UnderstanderResult_);
			return cb_onResult_Lcom_iflytek_speech_UnderstanderResult_;
		}

		static void n_OnResult_Lcom_iflytek_speech_UnderstanderResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.TextUnderstanderListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.UnderstanderResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.UnderstanderResult']]"
		[Register ("onResult", "(Lcom/iflytek/speech/UnderstanderResult;)V", "GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler")]
		public abstract void OnResult (global::Com.Iflytek.Speech.UnderstanderResult p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/TextUnderstanderListener$Stub", DoNotGenerateAcw=true)]
	internal partial class TextUnderstanderListenerStubInvoker : TextUnderstanderListenerStub {

		public TextUnderstanderListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/TextUnderstanderListener$Stub", typeof (TextUnderstanderListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.UnderstanderResult']]"
		[Register ("onResult", "(Lcom/iflytek/speech/UnderstanderResult;)V", "GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler")]
		public override unsafe void OnResult (global::Com.Iflytek.Speech.UnderstanderResult p0)
		{
			const string __id = "onResult.(Lcom/iflytek/speech/UnderstanderResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']"
	[Register ("com/iflytek/speech/TextUnderstanderListener", "", "Com.Iflytek.Speech.ITextUnderstanderListenerInvoker")]
	public partial interface ITextUnderstanderListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Iflytek.Speech.ITextUnderstanderListenerInvoker, iFlyMSC.Droid")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='TextUnderstanderListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.UnderstanderResult']]"
		[Register ("onResult", "(Lcom/iflytek/speech/UnderstanderResult;)V", "GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler:Com.Iflytek.Speech.ITextUnderstanderListenerInvoker, iFlyMSC.Droid")]
		void OnResult (global::Com.Iflytek.Speech.UnderstanderResult p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/TextUnderstanderListener", DoNotGenerateAcw=true)]
	internal partial class ITextUnderstanderListenerInvoker : global::Java.Lang.Object, ITextUnderstanderListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/TextUnderstanderListener", typeof (ITextUnderstanderListenerInvoker));

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

		public static ITextUnderstanderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITextUnderstanderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.TextUnderstanderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITextUnderstanderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onResult_Lcom_iflytek_speech_UnderstanderResult_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_speech_UnderstanderResult_Handler ()
		{
			if (cb_onResult_Lcom_iflytek_speech_UnderstanderResult_ == null)
				cb_onResult_Lcom_iflytek_speech_UnderstanderResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Lcom_iflytek_speech_UnderstanderResult_);
			return cb_onResult_Lcom_iflytek_speech_UnderstanderResult_;
		}

		static void n_OnResult_Lcom_iflytek_speech_UnderstanderResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.UnderstanderResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_speech_UnderstanderResult_;
		public unsafe void OnResult (global::Com.Iflytek.Speech.UnderstanderResult p0)
		{
			if (id_onResult_Lcom_iflytek_speech_UnderstanderResult_ == IntPtr.Zero)
				id_onResult_Lcom_iflytek_speech_UnderstanderResult_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/speech/UnderstanderResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_speech_UnderstanderResult_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
