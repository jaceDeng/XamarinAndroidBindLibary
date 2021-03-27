using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ITextUnderstander$Default", DoNotGenerateAcw=true)]
	public partial class TextUnderstanderDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.Aidl.ITextUnderstander {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ITextUnderstander$Default", typeof (TextUnderstanderDefault));
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

		protected TextUnderstanderDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Default']/constructor[@name='ITextUnderstander.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextUnderstanderDefault ()
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

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Default']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")]
			get {
				const string __id = "isUnderstanding.()Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ == null)
				cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_TextUnderstanderListener_);
			return cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Default']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler")]
		public virtual unsafe void Cancel (global::Com.Iflytek.Speech.ITextUnderstanderListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/TextUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler ()
		{
			if (cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ == null)
				cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_);
			return cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
		}

		static void n_UnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnderstandText (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Default']/method[@name='understandText' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("understandText", "(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler")]
		public virtual unsafe void UnderstandText (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ITextUnderstanderListener p1)
		{
			const string __id = "understandText.(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V";
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

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ITextUnderstander$Stub", DoNotGenerateAcw=true)]
	public abstract partial class TextUnderstanderStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.Aidl.ITextUnderstander {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ITextUnderstander$Stub", typeof (TextUnderstanderStub));
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

		protected TextUnderstanderStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/constructor[@name='ITextUnderstander.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextUnderstanderStub ()
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

		public static unsafe global::Com.Iflytek.Speech.Aidl.ITextUnderstander DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/aidl/ITextUnderstander;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/aidl/ITextUnderstander;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ITextUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ITextUnderstander;", "")]
		public static unsafe global::Com.Iflytek.Speech.Aidl.ITextUnderstander AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ITextUnderstander;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ITextUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.aidl.ITextUnderstander']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/aidl/ITextUnderstander;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.Aidl.ITextUnderstander p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/aidl/ITextUnderstander;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ == null)
				cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_TextUnderstanderListener_);
			return cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler")]
		public abstract void Cancel (global::Com.Iflytek.Speech.ITextUnderstanderListener p0);

		static Delegate cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler ()
		{
			if (cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ == null)
				cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_);
			return cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
		}

		static void n_UnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnderstandText (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='understandText' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("understandText", "(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler")]
		public abstract void UnderstandText (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ITextUnderstanderListener p1);

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.TextUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		public abstract bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ITextUnderstander$Stub", DoNotGenerateAcw=true)]
	internal partial class TextUnderstanderStubInvoker : TextUnderstanderStub {

		public TextUnderstanderStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ITextUnderstander$Stub", typeof (TextUnderstanderStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ITextUnderstander.Stub']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")]
			get {
				const string __id = "isUnderstanding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler")]
		public override unsafe void Cancel (global::Com.Iflytek.Speech.ITextUnderstanderListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/TextUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='understandText' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("understandText", "(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler")]
		public override unsafe void UnderstandText (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ITextUnderstanderListener p1)
		{
			const string __id = "understandText.(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V";
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

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']"
	[Register ("com/iflytek/speech/aidl/ITextUnderstander", "", "Com.Iflytek.Speech.Aidl.ITextUnderstanderInvoker")]
	public partial interface ITextUnderstander : global::Android.OS.IInterface {

		bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler:Com.Iflytek.Speech.Aidl.ITextUnderstanderInvoker, iFlyMSC.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler:Com.Iflytek.Speech.Aidl.ITextUnderstanderInvoker, iFlyMSC.Droid")]
		void Cancel (global::Com.Iflytek.Speech.ITextUnderstanderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ITextUnderstander']/method[@name='understandText' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.TextUnderstanderListener']]"
		[Register ("understandText", "(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V", "GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler:Com.Iflytek.Speech.Aidl.ITextUnderstanderInvoker, iFlyMSC.Droid")]
		void UnderstandText (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ITextUnderstanderListener p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ITextUnderstander", DoNotGenerateAcw=true)]
	internal partial class ITextUnderstanderInvoker : global::Java.Lang.Object, ITextUnderstander {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ITextUnderstander", typeof (ITextUnderstanderInvoker));

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

		public static ITextUnderstander GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITextUnderstander> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.aidl.ITextUnderstander"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITextUnderstanderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ITextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		IntPtr id_isUnderstanding;
		public unsafe bool IsUnderstanding {
			get {
				if (id_isUnderstanding == IntPtr.Zero)
					id_isUnderstanding = JNIEnv.GetMethodID (class_ref, "isUnderstanding", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnderstanding);
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_TextUnderstanderListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ == null)
				cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_TextUnderstanderListener_);
			return cb_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ITextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Lcom_iflytek_speech_TextUnderstanderListener_;
		public unsafe void Cancel (global::Com.Iflytek.Speech.ITextUnderstanderListener p0)
		{
			if (id_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ == IntPtr.Zero)
				id_cancel_Lcom_iflytek_speech_TextUnderstanderListener_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Lcom/iflytek/speech/TextUnderstanderListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Lcom_iflytek_speech_TextUnderstanderListener_, __args);
		}

		static Delegate cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetUnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_Handler ()
		{
			if (cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ == null)
				cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_);
			return cb_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
		}

		static void n_UnderstandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ITextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ITextUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnderstandText (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_;
		public unsafe void UnderstandText (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ITextUnderstanderListener p1)
		{
			if (id_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ == IntPtr.Zero)
				id_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_ = JNIEnv.GetMethodID (class_ref, "understandText", "(Landroid/content/Intent;Lcom/iflytek/speech/TextUnderstanderListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_understandText_Landroid_content_Intent_Lcom_iflytek_speech_TextUnderstanderListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ITextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
