using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.ui']/class[@name='RecognizerDialog']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/ui/RecognizerDialog", DoNotGenerateAcw=true)]
	public partial class RecognizerDialog : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/ui/RecognizerDialog", typeof (RecognizerDialog));
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

		protected RecognizerDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.ui']/class[@name='RecognizerDialog']/constructor[@name='RecognizerDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		public unsafe RecognizerDialog (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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

		static Delegate cb_setListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_Handler ()
		{
			if (cb_setListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_ == null)
				cb_setListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_);
			return cb_setListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_;
		}

		static void n_SetListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UI.RecognizerDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.UI.IRecognizerDialogListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UI.IRecognizerDialogListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.ui']/class[@name='RecognizerDialog']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.ui.RecognizerDialogListener']]"
		[Register ("setListener", "(Lcom/iflytek/cloud/ui/RecognizerDialogListener;)V", "GetSetListener_Lcom_iflytek_cloud_ui_RecognizerDialogListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Iflytek.Cloud.UI.IRecognizerDialogListener p0)
		{
			const string __id = "setListener.(Lcom/iflytek/cloud/ui/RecognizerDialogListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UI.RecognizerDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetParameter (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.ui']/class[@name='RecognizerDialog']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetParameter (string p0, string p1)
		{
			const string __id = "setParameter.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setUILanguage_Ljava_util_Locale_;
#pragma warning disable 0169
		static Delegate GetSetUILanguage_Ljava_util_Locale_Handler ()
		{
			if (cb_setUILanguage_Ljava_util_Locale_ == null)
				cb_setUILanguage_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUILanguage_Ljava_util_Locale_);
			return cb_setUILanguage_Ljava_util_Locale_;
		}

		static void n_SetUILanguage_Ljava_util_Locale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UI.RecognizerDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUILanguage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.ui']/class[@name='RecognizerDialog']/method[@name='setUILanguage' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("setUILanguage", "(Ljava/util/Locale;)V", "GetSetUILanguage_Ljava_util_Locale_Handler")]
		public virtual unsafe void SetUILanguage (global::Java.Util.Locale p0)
		{
			const string __id = "setUILanguage.(Ljava/util/Locale;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

#region "Event implementation for Com.Iflytek.Cloud.UI.IRecognizerDialogListener"

		global::Com.Iflytek.Cloud.UI.IRecognizerDialogListenerImplementor __CreateIRecognizerDialogListenerImplementor ()
		{
			return new global::Com.Iflytek.Cloud.UI.IRecognizerDialogListenerImplementor (this);
		}
#endregion
	}
}
