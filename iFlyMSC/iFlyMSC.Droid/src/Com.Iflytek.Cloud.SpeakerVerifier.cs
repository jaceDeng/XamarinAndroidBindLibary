using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeakerVerifier", DoNotGenerateAcw=true)]
	public partial class SpeakerVerifier : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeakerVerifier", typeof (SpeakerVerifier));
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

		protected SpeakerVerifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/constructor[@name='SpeakerVerifier' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		protected unsafe SpeakerVerifier (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='isListening' and count(parameter)=0]"
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

		public static unsafe global::Com.Iflytek.Cloud.SpeakerVerifier Verifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='getVerifier' and count(parameter)=0]"
			[Register ("getVerifier", "()Lcom/iflytek/cloud/SpeakerVerifier;", "")]
			get {
				const string __id = "getVerifier.()Lcom/iflytek/cloud/SpeakerVerifier;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='createVerifier' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createVerifier", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeakerVerifier;", "")]
		public static unsafe global::Com.Iflytek.Cloud.SpeakerVerifier CreateVerifier (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
		{
			const string __id = "createVerifier.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeakerVerifier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_generatePassword_I;
#pragma warning disable 0169
		static Delegate GetGeneratePassword_IHandler ()
		{
			if (cb_generatePassword_I == null)
				cb_generatePassword_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GeneratePassword_I);
			return cb_generatePassword_I;
		}

		static IntPtr n_GeneratePassword_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GeneratePassword (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='generatePassword' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("generatePassword", "(I)Ljava/lang/String;", "GetGeneratePassword_IHandler")]
		public virtual unsafe string GeneratePassword (int p0)
		{
			const string __id = "generatePassword.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPasswordList_Lcom_iflytek_cloud_SpeechListener_;
#pragma warning disable 0169
		static Delegate GetGetPasswordList_Lcom_iflytek_cloud_SpeechListener_Handler ()
		{
			if (cb_getPasswordList_Lcom_iflytek_cloud_SpeechListener_ == null)
				cb_getPasswordList_Lcom_iflytek_cloud_SpeechListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetPasswordList_Lcom_iflytek_cloud_SpeechListener_);
			return cb_getPasswordList_Lcom_iflytek_cloud_SpeechListener_;
		}

		static void n_GetPasswordList_Lcom_iflytek_cloud_SpeechListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.ISpeechListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetPasswordList (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='getPasswordList' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechListener']]"
		[Register ("getPasswordList", "(Lcom/iflytek/cloud/SpeechListener;)V", "GetGetPasswordList_Lcom_iflytek_cloud_SpeechListener_Handler")]
		public virtual unsafe void GetPasswordList (global::Com.Iflytek.Cloud.ISpeechListener p0)
		{
			const string __id = "getPasswordList.(Lcom/iflytek/cloud/SpeechListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_sendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_Handler ()
		{
			if (cb_sendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_ == null)
				cb_sendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_SendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_);
			return cb_sendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_;
		}

		static int n_SendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Cloud.ISpeechListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SendRequest (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='sendRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.cloud.SpeechListener']]"
		[Register ("sendRequest", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/SpeechListener;)I", "GetSendRequest_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_SpeechListener_Handler")]
		public virtual unsafe int SendRequest (string p0, string p1, global::Com.Iflytek.Cloud.ISpeechListener p2)
		{
			const string __id = "sendRequest.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/SpeechListener;)I";
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

		static Delegate cb_startListening_Lcom_iflytek_cloud_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Lcom_iflytek_cloud_VerifierListener_Handler ()
		{
			if (cb_startListening_Lcom_iflytek_cloud_VerifierListener_ == null)
				cb_startListening_Lcom_iflytek_cloud_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StartListening_Lcom_iflytek_cloud_VerifierListener_);
			return cb_startListening_Lcom_iflytek_cloud_VerifierListener_;
		}

		static int n_StartListening_Lcom_iflytek_cloud_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IVerifierListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartListening (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='startListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.VerifierListener']]"
		[Register ("startListening", "(Lcom/iflytek/cloud/VerifierListener;)I", "GetStartListening_Lcom_iflytek_cloud_VerifierListener_Handler")]
		public virtual unsafe int StartListening (global::Com.Iflytek.Cloud.IVerifierListener p0)
		{
			const string __id = "startListening.(Lcom/iflytek/cloud/VerifierListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_stopListening;
#pragma warning disable 0169
		static Delegate GetStopListeningHandler ()
		{
			if (cb_stopListening == null)
				cb_stopListening = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopListening);
			return cb_stopListening;
		}

		static void n_StopListening (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopListening ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='stopListening' and count(parameter)=0]"
		[Register ("stopListening", "()V", "GetStopListeningHandler")]
		public virtual unsafe void StopListening ()
		{
			const string __id = "stopListening.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeakerVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteAudio (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeakerVerifier']/method[@name='writeAudio' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
