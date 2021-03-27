using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechSynthesizer$Default", DoNotGenerateAcw=true)]
	public partial class SpeechSynthesizerDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechSynthesizer$Default", typeof (SpeechSynthesizerDefault));
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

		protected SpeechSynthesizerDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/constructor[@name='ISpeechSynthesizer.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechSynthesizerDefault ()
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

		static Delegate cb_isSpeaking;
#pragma warning disable 0169
		static Delegate GetIsSpeakingHandler ()
		{
			if (cb_isSpeaking == null)
				cb_isSpeaking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSpeaking);
			return cb_isSpeaking;
		}

		static bool n_IsSpeaking (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSpeaking;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSpeaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='isSpeaking' and count(parameter)=0]"
			[Register ("isSpeaking", "()Z", "GetIsSpeakingHandler")]
			get {
				const string __id = "isSpeaking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocalSpeakerList;
#pragma warning disable 0169
		static Delegate GetGetLocalSpeakerListHandler ()
		{
			if (cb_getLocalSpeakerList == null)
				cb_getLocalSpeakerList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalSpeakerList);
			return cb_getLocalSpeakerList;
		}

		static IntPtr n_GetLocalSpeakerList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalSpeakerList);
		}
#pragma warning restore 0169

		public virtual unsafe string LocalSpeakerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='getLocalSpeakerList' and count(parameter)=0]"
			[Register ("getLocalSpeakerList", "()Ljava/lang/String;", "GetGetLocalSpeakerListHandler")]
			get {
				const string __id = "getLocalSpeakerList.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_PauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PauseSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='pauseSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("pauseSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int PauseSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "pauseSpeaking.(Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_ResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResumeSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='resumeSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("resumeSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int ResumeSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "resumeSpeaking.(Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_StartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartSpeaking (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='startSpeaking' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("startSpeaking", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int StartSpeaking (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			const string __id = "startSpeaking.(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StopSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StopSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='stopSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("stopSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int StopSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "stopSpeaking.(Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_SynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SynthesizeToUrl (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Default']/method[@name='synthesizeToUrl' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("synthesizeToUrl", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int SynthesizeToUrl (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			const string __id = "synthesizeToUrl.(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechSynthesizer$Stub", DoNotGenerateAcw=true)]
	public abstract partial class SpeechSynthesizerStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechSynthesizer$Stub", typeof (SpeechSynthesizerStub));
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

		protected SpeechSynthesizerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/constructor[@name='ISpeechSynthesizer.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechSynthesizerStub ()
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

		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/aidl/ISpeechSynthesizer;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/aidl/ISpeechSynthesizer;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeechSynthesizer;", "")]
		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeechSynthesizer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.aidl.ISpeechSynthesizer']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/aidl/ISpeechSynthesizer;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/aidl/ISpeechSynthesizer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_PauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PauseSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='pauseSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("pauseSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public abstract int PauseSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0);

		static Delegate cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_ResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResumeSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='resumeSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("resumeSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public abstract int ResumeSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0);

		static Delegate cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_StartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartSpeaking (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='startSpeaking' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("startSpeaking", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public abstract int StartSpeaking (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1);

		static Delegate cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StopSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StopSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='stopSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("stopSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public abstract int StopSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0);

		static Delegate cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_SynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SynthesizeToUrl (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='synthesizeToUrl' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("synthesizeToUrl", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public abstract int SynthesizeToUrl (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1);

		static Delegate cb_isSpeaking;
#pragma warning disable 0169
		static Delegate GetIsSpeakingHandler ()
		{
			if (cb_isSpeaking == null)
				cb_isSpeaking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSpeaking);
			return cb_isSpeaking;
		}

		static bool n_IsSpeaking (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSpeaking;
		}
#pragma warning restore 0169

		public abstract bool IsSpeaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='isSpeaking' and count(parameter)=0]"
			[Register ("isSpeaking", "()Z", "GetIsSpeakingHandler")] get;
		}

		static Delegate cb_getLocalSpeakerList;
#pragma warning disable 0169
		static Delegate GetGetLocalSpeakerListHandler ()
		{
			if (cb_getLocalSpeakerList == null)
				cb_getLocalSpeakerList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalSpeakerList);
			return cb_getLocalSpeakerList;
		}

		static IntPtr n_GetLocalSpeakerList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalSpeakerList);
		}
#pragma warning restore 0169

		public abstract string LocalSpeakerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='getLocalSpeakerList' and count(parameter)=0]"
			[Register ("getLocalSpeakerList", "()Ljava/lang/String;", "GetGetLocalSpeakerListHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechSynthesizer$Stub", DoNotGenerateAcw=true)]
	internal partial class SpeechSynthesizerStubInvoker : SpeechSynthesizerStub {

		public SpeechSynthesizerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechSynthesizer$Stub", typeof (SpeechSynthesizerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsSpeaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='isSpeaking' and count(parameter)=0]"
			[Register ("isSpeaking", "()Z", "GetIsSpeakingHandler")]
			get {
				const string __id = "isSpeaking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string LocalSpeakerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechSynthesizer.Stub']/method[@name='getLocalSpeakerList' and count(parameter)=0]"
			[Register ("getLocalSpeakerList", "()Ljava/lang/String;", "GetGetLocalSpeakerListHandler")]
			get {
				const string __id = "getLocalSpeakerList.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='pauseSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("pauseSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public override unsafe int PauseSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "pauseSpeaking.(Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='resumeSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("resumeSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public override unsafe int ResumeSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "resumeSpeaking.(Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='startSpeaking' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("startSpeaking", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public override unsafe int StartSpeaking (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			const string __id = "startSpeaking.(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='stopSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("stopSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public override unsafe int StopSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			const string __id = "stopSpeaking.(Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='synthesizeToUrl' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("synthesizeToUrl", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public override unsafe int SynthesizeToUrl (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			const string __id = "synthesizeToUrl.(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']"
	[Register ("com/iflytek/speech/aidl/ISpeechSynthesizer", "", "Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker")]
	public partial interface ISpeechSynthesizer : global::Android.OS.IInterface {

		bool IsSpeaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='isSpeaking' and count(parameter)=0]"
			[Register ("isSpeaking", "()Z", "GetIsSpeakingHandler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")] get;
		}

		string LocalSpeakerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='getLocalSpeakerList' and count(parameter)=0]"
			[Register ("getLocalSpeakerList", "()Ljava/lang/String;", "GetGetLocalSpeakerListHandler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='pauseSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("pauseSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")]
		int PauseSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='resumeSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("resumeSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")]
		int ResumeSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='startSpeaking' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("startSpeaking", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")]
		int StartSpeaking (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='stopSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("stopSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I", "GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")]
		int StopSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechSynthesizer']/method[@name='synthesizeToUrl' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("synthesizeToUrl", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I", "GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechSynthesizerInvoker, iFlyMSC.Droid")]
		int SynthesizeToUrl (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechSynthesizer", DoNotGenerateAcw=true)]
	internal partial class ISpeechSynthesizerInvoker : global::Java.Lang.Object, ISpeechSynthesizer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechSynthesizer", typeof (ISpeechSynthesizerInvoker));

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

		public static ISpeechSynthesizer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpeechSynthesizer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.aidl.ISpeechSynthesizer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpeechSynthesizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isSpeaking;
#pragma warning disable 0169
		static Delegate GetIsSpeakingHandler ()
		{
			if (cb_isSpeaking == null)
				cb_isSpeaking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSpeaking);
			return cb_isSpeaking;
		}

		static bool n_IsSpeaking (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSpeaking;
		}
#pragma warning restore 0169

		IntPtr id_isSpeaking;
		public unsafe bool IsSpeaking {
			get {
				if (id_isSpeaking == IntPtr.Zero)
					id_isSpeaking = JNIEnv.GetMethodID (class_ref, "isSpeaking", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSpeaking);
			}
		}

		static Delegate cb_getLocalSpeakerList;
#pragma warning disable 0169
		static Delegate GetGetLocalSpeakerListHandler ()
		{
			if (cb_getLocalSpeakerList == null)
				cb_getLocalSpeakerList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalSpeakerList);
			return cb_getLocalSpeakerList;
		}

		static IntPtr n_GetLocalSpeakerList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalSpeakerList);
		}
#pragma warning restore 0169

		IntPtr id_getLocalSpeakerList;
		public unsafe string LocalSpeakerList {
			get {
				if (id_getLocalSpeakerList == IntPtr.Zero)
					id_getLocalSpeakerList = JNIEnv.GetMethodID (class_ref, "getLocalSpeakerList", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalSpeakerList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetPauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_PauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PauseSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		public unsafe int PauseSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			if (id_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == IntPtr.Zero)
				id_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNIEnv.GetMethodID (class_ref, "pauseSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_pauseSpeaking_Lcom_iflytek_speech_SynthesizerListener_, __args);
			return __ret;
		}

		static Delegate cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_ResumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResumeSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		public unsafe int ResumeSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			if (id_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == IntPtr.Zero)
				id_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNIEnv.GetMethodID (class_ref, "resumeSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resumeSpeaking_Lcom_iflytek_speech_SynthesizerListener_, __args);
			return __ret;
		}

		static Delegate cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_StartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StartSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartSpeaking (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		public unsafe int StartSpeaking (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			if (id_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == IntPtr.Zero)
				id_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNIEnv.GetMethodID (class_ref, "startSpeaking", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_startSpeaking_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_, __args);
			return __ret;
		}

		static Delegate cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStopSpeaking_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StopSpeaking_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StopSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_;
		public unsafe int StopSpeaking (global::Com.Iflytek.Speech.ISynthesizerListener p0)
		{
			if (id_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ == IntPtr.Zero)
				id_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_ = JNIEnv.GetMethodID (class_ref, "stopSpeaking", "(Lcom/iflytek/speech/SynthesizerListener;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_stopSpeaking_Lcom_iflytek_speech_SynthesizerListener_, __args);
			return __ret;
		}

		static Delegate cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetSynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_SynthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SynthesizeToUrl (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_;
		public unsafe int SynthesizeToUrl (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			if (id_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ == IntPtr.Zero)
				id_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_ = JNIEnv.GetMethodID (class_ref, "synthesizeToUrl", "(Landroid/content/Intent;Lcom/iflytek/speech/SynthesizerListener;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_synthesizeToUrl_Landroid_content_Intent_Lcom_iflytek_speech_SynthesizerListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
