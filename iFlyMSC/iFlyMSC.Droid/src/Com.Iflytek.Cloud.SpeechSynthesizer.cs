using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechSynthesizer", DoNotGenerateAcw=true)]
	public partial class SpeechSynthesizer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechSynthesizer", typeof (SpeechSynthesizer));
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

		protected SpeechSynthesizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/constructor[@name='SpeechSynthesizer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		protected unsafe SpeechSynthesizer (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSpeaking;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSpeaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='isSpeaking' and count(parameter)=0]"
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

		public static unsafe global::Com.Iflytek.Cloud.SpeechSynthesizer Synthesizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='getSynthesizer' and count(parameter)=0]"
			[Register ("getSynthesizer", "()Lcom/iflytek/cloud/SpeechSynthesizer;", "")]
			get {
				const string __id = "getSynthesizer.()Lcom/iflytek/cloud/SpeechSynthesizer;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_a_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Handler ()
		{
			if (cb_a_Landroid_content_Context_ == null)
				cb_a_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_Landroid_content_Context_);
			return cb_a_Landroid_content_Context_;
		}

		static void n_A_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "GetA_Landroid_content_Context_Handler")]
		protected virtual unsafe void A (global::Android.Content.Context p0)
		{
			const string __id = "a.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='createSynthesizer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createSynthesizer", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechSynthesizer;", "")]
		public static unsafe global::Com.Iflytek.Cloud.SpeechSynthesizer CreateSynthesizer (global::Android.Content.Context paramContext, global::Com.Iflytek.Cloud.IInitListener paramInitListener)
		{
			const string __id = "createSynthesizer.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechSynthesizer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paramContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramContext).Handle);
				__args [1] = new JniArgumentValue ((paramInitListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramInitListener).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (paramContext);
				global::System.GC.KeepAlive (paramInitListener);
			}
		}

		static Delegate cb_pauseSpeaking;
#pragma warning disable 0169
		static Delegate GetPauseSpeakingHandler ()
		{
			if (cb_pauseSpeaking == null)
				cb_pauseSpeaking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PauseSpeaking);
			return cb_pauseSpeaking;
		}

		static void n_PauseSpeaking (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseSpeaking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='pauseSpeaking' and count(parameter)=0]"
		[Register ("pauseSpeaking", "()V", "GetPauseSpeakingHandler")]
		public virtual unsafe void PauseSpeaking ()
		{
			const string __id = "pauseSpeaking.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resumeSpeaking;
#pragma warning disable 0169
		static Delegate GetResumeSpeakingHandler ()
		{
			if (cb_resumeSpeaking == null)
				cb_resumeSpeaking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResumeSpeaking);
			return cb_resumeSpeaking;
		}

		static void n_ResumeSpeaking (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeSpeaking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='resumeSpeaking' and count(parameter)=0]"
		[Register ("resumeSpeaking", "()V", "GetResumeSpeakingHandler")]
		public virtual unsafe void ResumeSpeaking ()
		{
			const string __id = "resumeSpeaking.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetStartSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_Handler ()
		{
			if (cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_ == null)
				cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_StartSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_);
			return cb_startSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_;
		}

		static int n_StartSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Cloud.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartSpeaking (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='startSpeaking' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.cloud.SynthesizerListener']]"
		[Register ("startSpeaking", "(Ljava/lang/String;Lcom/iflytek/cloud/SynthesizerListener;)I", "GetStartSpeaking_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_Handler")]
		public virtual unsafe int StartSpeaking (string p0, global::Com.Iflytek.Cloud.ISynthesizerListener p1)
		{
			const string __id = "startSpeaking.(Ljava/lang/String;Lcom/iflytek/cloud/SynthesizerListener;)I";
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

		static Delegate cb_stopSpeaking;
#pragma warning disable 0169
		static Delegate GetStopSpeakingHandler ()
		{
			if (cb_stopSpeaking == null)
				cb_stopSpeaking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopSpeaking);
			return cb_stopSpeaking;
		}

		static void n_StopSpeaking (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSpeaking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='stopSpeaking' and count(parameter)=0]"
		[Register ("stopSpeaking", "()V", "GetStopSpeakingHandler")]
		public virtual unsafe void StopSpeaking ()
		{
			const string __id = "stopSpeaking.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_synthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_;
#pragma warning disable 0169
		static Delegate GetSynthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_Handler ()
		{
			if (cb_synthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_ == null)
				cb_synthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_SynthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_);
			return cb_synthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_;
		}

		static int n_SynthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechSynthesizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Cloud.ISynthesizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SynthesizeToUri (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechSynthesizer']/method[@name='synthesizeToUri' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.cloud.SynthesizerListener']]"
		[Register ("synthesizeToUri", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/SynthesizerListener;)I", "GetSynthesizeToUri_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SynthesizerListener_Handler")]
		public virtual unsafe int SynthesizeToUri (string p0, string p1, global::Com.Iflytek.Cloud.ISynthesizerListener p2)
		{
			const string __id = "synthesizeToUri.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/SynthesizerListener;)I";
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
}
