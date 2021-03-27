using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Idata.Extension {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.idata.extension']/class[@name='IFlyCollectorExt']"
	[global::Android.Runtime.Register ("com/iflytek/idata/extension/IFlyCollectorExt", DoNotGenerateAcw=true)]
	public partial class IFlyCollectorExt : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/idata/extension/IFlyCollectorExt", typeof (IFlyCollectorExt));
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

		protected IFlyCollectorExt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Idata.Extension.IFlyCollectorExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Idata.Extension.IFlyCollectorExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.idata.extension']/class[@name='IFlyCollectorExt']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				const string __id = "getAppId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.idata.extension']/class[@name='IFlyCollectorExt']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSubId;
#pragma warning disable 0169
		static Delegate GetGetSubIdHandler ()
		{
			if (cb_getSubId == null)
				cb_getSubId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubId);
			return cb_getSubId;
		}

		static IntPtr n_GetSubId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Idata.Extension.IFlyCollectorExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubId);
		}
#pragma warning restore 0169

		static Delegate cb_setSubId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubId_Ljava_lang_String_Handler ()
		{
			if (cb_setSubId_Ljava_lang_String_ == null)
				cb_setSubId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubId_Ljava_lang_String_);
			return cb_setSubId_Ljava_lang_String_;
		}

		static void n_SetSubId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Idata.Extension.IFlyCollectorExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.idata.extension']/class[@name='IFlyCollectorExt']/method[@name='getSubId' and count(parameter)=0]"
			[Register ("getSubId", "()Ljava/lang/String;", "GetGetSubIdHandler")]
			get {
				const string __id = "getSubId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.idata.extension']/class[@name='IFlyCollectorExt']/method[@name='setSubId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubId", "(Ljava/lang/String;)V", "GetSetSubId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.idata.extension']/class[@name='IFlyCollectorExt']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/iflytek/idata/extension/IFlyCollectorExt;", "")]
		public static unsafe global::Com.Iflytek.Idata.Extension.IFlyCollectorExt GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/iflytek/idata/extension/IFlyCollectorExt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Idata.Extension.IFlyCollectorExt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
