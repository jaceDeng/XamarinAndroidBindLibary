using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechRecognizer$Default", DoNotGenerateAcw=true)]
	public partial class SpeechRecognizerDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechRecognizer$Default", typeof (SpeechRecognizerDefault));
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

		protected SpeechRecognizerDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/constructor[@name='ISpeechRecognizer.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechRecognizerDefault ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='isListening' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
#pragma warning disable 0169
		static Delegate GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler ()
		{
			if (cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ == null)
				cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_BuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_);
			return cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
		}

		static void n_BuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IGrammarListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IGrammarListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BuildGrammar (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='buildGrammar' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.GrammarListener']]"
		[Register ("buildGrammar", "(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V", "GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler")]
		public virtual unsafe void BuildGrammar (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IGrammarListener p1)
		{
			const string __id = "buildGrammar.(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V";
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

		static Delegate cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_cancel_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_RecognizerListener_);
			return cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public virtual unsafe void Cancel (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/RecognizerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_);
			return cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public virtual unsafe void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IRecognizerListener p1)
		{
			const string __id = "startListening.(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V";
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

		static Delegate cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopListening_Lcom_iflytek_speech_RecognizerListener_);
			return cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_StopListening_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListening (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public virtual unsafe void StopListening (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "stopListening.(Lcom/iflytek/speech/RecognizerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
#pragma warning disable 0169
		static Delegate GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler ()
		{
			if (cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ == null)
				cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_);
			return cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
		}

		static void n_UpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ILexiconListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ILexiconListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLexicon (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='updateLexicon' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.LexiconListener']]"
		[Register ("updateLexicon", "(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V", "GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler")]
		public virtual unsafe void UpdateLexicon (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ILexiconListener p1)
		{
			const string __id = "updateLexicon.(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V";
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

		static Delegate cb_writeAudio_Landroid_content_Intent_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_Landroid_content_Intent_arrayBIIHandler ()
		{
			if (cb_writeAudio_Landroid_content_Intent_arrayBII == null)
				cb_writeAudio_Landroid_content_Intent_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_WriteAudio_Landroid_content_Intent_arrayBII);
			return cb_writeAudio_Landroid_content_Intent_arrayBII;
		}

		static void n_WriteAudio_Landroid_content_Intent_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAudio (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Default']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler")]
		public virtual unsafe void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3)
		{
			const string __id = "writeAudio.(Landroid/content/Intent;[BII)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechRecognizer$Stub", DoNotGenerateAcw=true)]
	public abstract partial class SpeechRecognizerStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechRecognizer$Stub", typeof (SpeechRecognizerStub));
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

		protected SpeechRecognizerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/constructor[@name='ISpeechRecognizer.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechRecognizerStub ()
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

		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/aidl/ISpeechRecognizer;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/aidl/ISpeechRecognizer;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeechRecognizer;", "")]
		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeechRecognizer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.aidl.ISpeechRecognizer']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/aidl/ISpeechRecognizer;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/aidl/ISpeechRecognizer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
#pragma warning disable 0169
		static Delegate GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler ()
		{
			if (cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ == null)
				cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_BuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_);
			return cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
		}

		static void n_BuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IGrammarListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IGrammarListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BuildGrammar (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='buildGrammar' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.GrammarListener']]"
		[Register ("buildGrammar", "(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V", "GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler")]
		public abstract void BuildGrammar (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IGrammarListener p1);

		static Delegate cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_cancel_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_RecognizerListener_);
			return cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public abstract void Cancel (global::Com.Iflytek.Speech.IRecognizerListener p0);

		static Delegate cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_);
			return cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public abstract void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IRecognizerListener p1);

		static Delegate cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopListening_Lcom_iflytek_speech_RecognizerListener_);
			return cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_StopListening_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListening (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public abstract void StopListening (global::Com.Iflytek.Speech.IRecognizerListener p0);

		static Delegate cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
#pragma warning disable 0169
		static Delegate GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler ()
		{
			if (cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ == null)
				cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_);
			return cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
		}

		static void n_UpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ILexiconListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ILexiconListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLexicon (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='updateLexicon' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.LexiconListener']]"
		[Register ("updateLexicon", "(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V", "GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler")]
		public abstract void UpdateLexicon (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ILexiconListener p1);

		static Delegate cb_writeAudio_Landroid_content_Intent_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_Landroid_content_Intent_arrayBIIHandler ()
		{
			if (cb_writeAudio_Landroid_content_Intent_arrayBII == null)
				cb_writeAudio_Landroid_content_Intent_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_WriteAudio_Landroid_content_Intent_arrayBII);
			return cb_writeAudio_Landroid_content_Intent_arrayBII;
		}

		static void n_WriteAudio_Landroid_content_Intent_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAudio (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler")]
		public abstract void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3);

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechRecognizerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public abstract bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechRecognizer$Stub", DoNotGenerateAcw=true)]
	internal partial class SpeechRecognizerStubInvoker : SpeechRecognizerStub {

		public SpeechRecognizerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechRecognizer$Stub", typeof (SpeechRecognizerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechRecognizer.Stub']/method[@name='isListening' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='buildGrammar' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.GrammarListener']]"
		[Register ("buildGrammar", "(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V", "GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler")]
		public override unsafe void BuildGrammar (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IGrammarListener p1)
		{
			const string __id = "buildGrammar.(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public override unsafe void Cancel (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/RecognizerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public override unsafe void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IRecognizerListener p1)
		{
			const string __id = "startListening.(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler")]
		public override unsafe void StopListening (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			const string __id = "stopListening.(Lcom/iflytek/speech/RecognizerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='updateLexicon' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.LexiconListener']]"
		[Register ("updateLexicon", "(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V", "GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler")]
		public override unsafe void UpdateLexicon (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ILexiconListener p1)
		{
			const string __id = "updateLexicon.(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler")]
		public override unsafe void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3)
		{
			const string __id = "writeAudio.(Landroid/content/Intent;[BII)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']"
	[Register ("com/iflytek/speech/aidl/ISpeechRecognizer", "", "Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker")]
	public partial interface ISpeechRecognizer : global::Android.OS.IInterface {

		bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='buildGrammar' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.GrammarListener']]"
		[Register ("buildGrammar", "(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V", "GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")]
		void BuildGrammar (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IGrammarListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")]
		void Cancel (global::Com.Iflytek.Speech.IRecognizerListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='startListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V", "GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")]
		void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IRecognizerListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='stopListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.RecognizerListener']]"
		[Register ("stopListening", "(Lcom/iflytek/speech/RecognizerListener;)V", "GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")]
		void StopListening (global::Com.Iflytek.Speech.IRecognizerListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='updateLexicon' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.LexiconListener']]"
		[Register ("updateLexicon", "(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V", "GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")]
		void UpdateLexicon (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ILexiconListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechRecognizer']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler:Com.Iflytek.Speech.Aidl.ISpeechRecognizerInvoker, iFlyMSC.Droid")]
		void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechRecognizer", DoNotGenerateAcw=true)]
	internal partial class ISpeechRecognizerInvoker : global::Java.Lang.Object, ISpeechRecognizer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechRecognizer", typeof (ISpeechRecognizerInvoker));

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

		public static ISpeechRecognizer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpeechRecognizer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.aidl.ISpeechRecognizer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpeechRecognizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
#pragma warning disable 0169
		static Delegate GetBuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_Handler ()
		{
			if (cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ == null)
				cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_BuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_);
			return cb_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
		}

		static void n_BuildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IGrammarListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IGrammarListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BuildGrammar (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_;
		public unsafe void BuildGrammar (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IGrammarListener p1)
		{
			if (id_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ == IntPtr.Zero)
				id_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_ = JNIEnv.GetMethodID (class_ref, "buildGrammar", "(Landroid/content/Intent;Lcom/iflytek/speech/GrammarListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_buildGrammar_Landroid_content_Intent_Lcom_iflytek_speech_GrammarListener_, __args);
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_cancel_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_RecognizerListener_);
			return cb_cancel_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Lcom_iflytek_speech_RecognizerListener_;
		public unsafe void Cancel (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			if (id_cancel_Lcom_iflytek_speech_RecognizerListener_ == IntPtr.Zero)
				id_cancel_Lcom_iflytek_speech_RecognizerListener_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Lcom/iflytek/speech/RecognizerListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Lcom_iflytek_speech_RecognizerListener_, __args);
		}

		static Delegate cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_);
			return cb_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_StartListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_;
		public unsafe void StartListening (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.IRecognizerListener p1)
		{
			if (id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ == IntPtr.Zero)
				id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_ = JNIEnv.GetMethodID (class_ref, "startListening", "(Landroid/content/Intent;Lcom/iflytek/speech/RecognizerListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startListening_Landroid_content_Intent_Lcom_iflytek_speech_RecognizerListener_, __args);
		}

		static Delegate cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
#pragma warning disable 0169
		static Delegate GetStopListening_Lcom_iflytek_speech_RecognizerListener_Handler ()
		{
			if (cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ == null)
				cb_stopListening_Lcom_iflytek_speech_RecognizerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopListening_Lcom_iflytek_speech_RecognizerListener_);
			return cb_stopListening_Lcom_iflytek_speech_RecognizerListener_;
		}

		static void n_StopListening_Lcom_iflytek_speech_RecognizerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.IRecognizerListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IRecognizerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListening (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopListening_Lcom_iflytek_speech_RecognizerListener_;
		public unsafe void StopListening (global::Com.Iflytek.Speech.IRecognizerListener p0)
		{
			if (id_stopListening_Lcom_iflytek_speech_RecognizerListener_ == IntPtr.Zero)
				id_stopListening_Lcom_iflytek_speech_RecognizerListener_ = JNIEnv.GetMethodID (class_ref, "stopListening", "(Lcom/iflytek/speech/RecognizerListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopListening_Lcom_iflytek_speech_RecognizerListener_, __args);
		}

		static Delegate cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
#pragma warning disable 0169
		static Delegate GetUpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_Handler ()
		{
			if (cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ == null)
				cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_);
			return cb_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
		}

		static void n_UpdateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ILexiconListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ILexiconListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLexicon (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_;
		public unsafe void UpdateLexicon (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ILexiconListener p1)
		{
			if (id_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ == IntPtr.Zero)
				id_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_ = JNIEnv.GetMethodID (class_ref, "updateLexicon", "(Landroid/content/Intent;Lcom/iflytek/speech/LexiconListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLexicon_Landroid_content_Intent_Lcom_iflytek_speech_LexiconListener_, __args);
		}

		static Delegate cb_writeAudio_Landroid_content_Intent_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_Landroid_content_Intent_arrayBIIHandler ()
		{
			if (cb_writeAudio_Landroid_content_Intent_arrayBII == null)
				cb_writeAudio_Landroid_content_Intent_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_WriteAudio_Landroid_content_Intent_arrayBII);
			return cb_writeAudio_Landroid_content_Intent_arrayBII;
		}

		static void n_WriteAudio_Landroid_content_Intent_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAudio (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_writeAudio_Landroid_content_Intent_arrayBII;
		public unsafe void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3)
		{
			if (id_writeAudio_Landroid_content_Intent_arrayBII == IntPtr.Zero)
				id_writeAudio_Landroid_content_Intent_arrayBII = JNIEnv.GetMethodID (class_ref, "writeAudio", "(Landroid/content/Intent;[BII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeAudio_Landroid_content_Intent_arrayBII, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechRecognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
