using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']"
	[global::Android.Runtime.Register ("com/iflytek/speech/SpeechSynthesizerAidl", DoNotGenerateAcw=true)]
	public partial class SpeechSynthesizerAidl : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SpeechSynthesizerAidl", typeof (SpeechSynthesizerAidl));
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

		protected SpeechSynthesizerAidl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/constructor[@name='SpeechSynthesizerAidl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		public unsafe SpeechSynthesizerAidl (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
			get {
				const string __id = "getIntent.()Landroid/content/Intent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAvailable;
#pragma warning disable 0169
		static Delegate GetIsAvailableHandler ()
		{
			if (cb_isAvailable == null)
				cb_isAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAvailable);
			return cb_isAvailable;
		}

		static bool n_IsAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='isAvailable' and count(parameter)=0]"
			[Register ("isAvailable", "()Z", "GetIsAvailableHandler")]
			get {
				const string __id = "isAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSpeaking;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSpeaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='isSpeaking' and count(parameter)=0]"
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

		protected unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_destory;
#pragma warning disable 0169
		static Delegate GetDestoryHandler ()
		{
			if (cb_destory == null)
				cb_destory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Destory);
			return cb_destory;
		}

		static bool n_Destory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Destory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()Z", "GetDestoryHandler")]
		public virtual unsafe bool Destory ()
		{
			const string __id = "destory.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsActionInstalled_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IsActionInstalled_Landroid_content_Context_Ljava_lang_String_);
			return cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_IsActionInstalled_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsActionInstalled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='isActionInstalled' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isActionInstalled", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetIsActionInstalled_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsActionInstalled (global::Android.Content.Context p0, string p1)
		{
			const string __id = "isActionInstalled.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PauseSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='pauseSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResumeSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='resumeSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStartSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_StartSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_StartSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartSpeaking (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='startSpeaking' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("startSpeaking", "(Ljava/lang/String;Lcom/iflytek/speech/SynthesizerListener;)I", "GetStartSpeaking_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int StartSpeaking (string p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			const string __id = "startSpeaking.(Ljava/lang/String;Lcom/iflytek/speech/SynthesizerListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StopSpeaking (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='stopSpeaking' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SynthesizerListener']]"
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

		static Delegate cb_synthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetSynthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_Handler ()
		{
			if (cb_synthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_ == null)
				cb_synthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SynthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_);
			return cb_synthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_;
		}

		static int n_SynthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechSynthesizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SynthesizeToUrl (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechSynthesizerAidl']/method[@name='synthesizeToUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.speech.SynthesizerListener']]"
		[Register ("synthesizeToUrl", "(Ljava/lang/String;Lcom/iflytek/speech/SynthesizerListener;)I", "GetSynthesizeToUrl_Ljava_lang_String_Lcom_iflytek_speech_SynthesizerListener_Handler")]
		public virtual unsafe int SynthesizeToUrl (string p0, global::Com.Iflytek.Speech.ISynthesizerListener p1)
		{
			const string __id = "synthesizeToUrl.(Ljava/lang/String;Lcom/iflytek/speech/SynthesizerListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
