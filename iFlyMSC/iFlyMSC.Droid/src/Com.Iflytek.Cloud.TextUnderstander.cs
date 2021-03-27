using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/TextUnderstander", DoNotGenerateAcw=true)]
	public partial class TextUnderstander : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/TextUnderstander", typeof (TextUnderstander));
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

		protected TextUnderstander (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/constructor[@name='TextUnderstander' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		protected unsafe TextUnderstander (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/method[@name='isUnderstanding' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/method[@name='createTextUnderstander' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createTextUnderstander", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/TextUnderstander;", "")]
		public static unsafe global::Com.Iflytek.Cloud.TextUnderstander CreateTextUnderstander (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
		{
			const string __id = "createTextUnderstander.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/TextUnderstander;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TextUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/method[@name='getTextUnderstander' and count(parameter)=0]"
		[Register ("getTextUnderstander", "()Lcom/iflytek/cloud/TextUnderstander;", "")]
		public static unsafe global::Com.Iflytek.Cloud.TextUnderstander GetTextUnderstander ()
		{
			const string __id = "getTextUnderstander.()Lcom/iflytek/cloud/TextUnderstander;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TextUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_understandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetUnderstandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_Handler ()
		{
			if (cb_understandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_ == null)
				cb_understandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_UnderstandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_);
			return cb_understandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_;
		}

		static int n_UnderstandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TextUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Cloud.ITextUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITextUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UnderstandText (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='TextUnderstander']/method[@name='understandText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.cloud.TextUnderstanderListener']]"
		[Register ("understandText", "(Ljava/lang/String;Lcom/iflytek/cloud/TextUnderstanderListener;)I", "GetUnderstandText_Ljava_lang_String_Lcom_iflytek_cloud_TextUnderstanderListener_Handler")]
		public virtual unsafe int UnderstandText (string p0, global::Com.Iflytek.Cloud.ITextUnderstanderListener p1)
		{
			const string __id = "understandText.(Ljava/lang/String;Lcom/iflytek/cloud/TextUnderstanderListener;)I";
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
