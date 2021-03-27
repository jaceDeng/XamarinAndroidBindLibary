using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']"
	[global::Android.Runtime.Register ("com/iflytek/speech/SpeechRecognizerAidl", DoNotGenerateAcw=true)]
	public partial class SpeechRecognizerAidl : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SpeechRecognizerAidl", typeof (SpeechRecognizerAidl));
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

		protected SpeechRecognizerAidl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/constructor[@name='SpeechRecognizerAidl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		public unsafe SpeechRecognizerAidl (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='getIntent' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='isAvailable' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='isListening' and count(parameter)=0]"
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

		protected unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='getTag' and count(parameter)=0]"
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

		static Delegate cb_buildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_;
#pragma warning disable 0169
		static Delegate GetBuildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_Handler ()
		{
			if (cb_buildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_ == null)
				cb_buildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_BuildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_);
			return cb_buildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_;
		}

		static int n_BuildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IGrammarListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IGrammarListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.BuildGrammar (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='buildGrammar' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.GrammarListener']]"
		[Register ("buildGrammar", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/GrammarListener;)I", "GetBuildGrammar_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_GrammarListener_Handler")]
		public virtual unsafe int BuildGrammar (string p0, string p1, global::Com.Iflytek.Speech.IGrammarListener p2)
		{
			const string __id = "buildGrammar.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/GrammarListener;)I";
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

		static Delegate cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_cancel_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_Cancel_Lcom_iflytek_speech_RecognizerListener_);
			return cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
		}

		static int n_Cancel_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Cancel (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/RecognizerListener;)I", "GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public virtual unsafe int Cancel (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/RecognizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Destory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='destory' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsActionInstalled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='isActionInstalled' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_startListening_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_startListening_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_startListening_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StartListening_Lcom_iflytek_speech_RecognizerListener_);
			return cb_startListening_Lcom_iflytek_speech_RecognizerListener_;
		}

		static int n_StartListening_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartListening (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='startListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("startListening", "(Lcom/iflytek/speech/RecognizerListener;)I", "GetStartListening_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public virtual unsafe int StartListening (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "startListening.(Lcom/iflytek/speech/RecognizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StopListening_Lcom_iflytek_speech_RecognizerListener_);
			return cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
		}

		static int n_StopListening_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StopListening (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/RecognizerListener;)I", "GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public virtual unsafe int StopListening (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "stopListening.(Lcom/iflytek/speech/RecognizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_updateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_;
#pragma warning disable 0169
		static Delegate GetUpdateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_Handler ()
		{
			if (cb_updateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_ == null)
				cb_updateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_UpdateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_);
			return cb_updateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_;
		}

		static int n_UpdateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.ILexiconListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ILexiconListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateLexicon (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='updateLexicon' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.LexiconListener']]"
		[Register ("updateLexicon", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/LexiconListener;)I", "GetUpdateLexicon_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_LexiconListener_Handler")]
		public virtual unsafe int UpdateLexicon (string p0, string p1, global::Com.Iflytek.Speech.ILexiconListener p2)
		{
			const string __id = "updateLexicon.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/LexiconListener;)I";
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

		static Delegate cb_writeAudio_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_arrayBIIHandler ()
		{
			if (cb_writeAudio_arrayBII == null)
				cb_writeAudio_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_WriteAudio_arrayBII);
			return cb_writeAudio_arrayBII;
		}

		static int n_WriteAudio_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeechRecognizerAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteAudio (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeechRecognizerAidl']/method[@name='writeAudio' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeAudio", "([BII)I", "GetWriteAudio_arrayBIIHandler")]
		public virtual unsafe int WriteAudio (byte[] p0, int p1, int p2)
		{
			const string __id = "writeAudio.([BII)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
