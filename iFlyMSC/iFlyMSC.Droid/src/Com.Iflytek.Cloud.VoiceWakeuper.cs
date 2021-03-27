using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/VoiceWakeuper", DoNotGenerateAcw=true)]
	public partial class VoiceWakeuper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/VoiceWakeuper", typeof (VoiceWakeuper));
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

		protected VoiceWakeuper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='isListening' and count(parameter)=0]"
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

		public static unsafe global::Com.Iflytek.Cloud.VoiceWakeuper Wakeuper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='getWakeuper' and count(parameter)=0]"
			[Register ("getWakeuper", "()Lcom/iflytek/cloud/VoiceWakeuper;", "")]
			get {
				const string __id = "getWakeuper.()Lcom/iflytek/cloud/VoiceWakeuper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='createWakeuper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createWakeuper", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/VoiceWakeuper;", "")]
		public static unsafe global::Com.Iflytek.Cloud.VoiceWakeuper CreateWakeuper (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
		{
			const string __id = "createWakeuper.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/VoiceWakeuper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_downloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_;
#pragma warning disable 0169
		static Delegate GetDownloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_Handler ()
		{
			if (cb_downloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_ == null)
				cb_downloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_I) n_DownloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_);
			return cb_downloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_;
		}

		static int n_DownloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Iflytek.Cloud.Util.IFileDownloadListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.IFileDownloadListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DownloadResource (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='downloadResource' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.iflytek.cloud.util.FileDownloadListener']]"
		[Register ("downloadResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/util/FileDownloadListener;)I", "GetDownloadResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_util_FileDownloadListener_Handler")]
		public virtual unsafe int DownloadResource (string p0, string p1, string p2, global::Com.Iflytek.Cloud.Util.IFileDownloadListener p3)
		{
			const string __id = "downloadResource.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/util/FileDownloadListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_queryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_;
#pragma warning disable 0169
		static Delegate GetQueryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_Handler ()
		{
			if (cb_queryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_ == null)
				cb_queryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_QueryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_);
			return cb_queryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_;
		}

		static int n_QueryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Cloud.IRequestListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.QueryResource (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='queryResource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.cloud.RequestListener']]"
		[Register ("queryResource", "(Ljava/lang/String;Lcom/iflytek/cloud/RequestListener;)I", "GetQueryResource_Ljava_lang_String_Lcom_iflytek_cloud_RequestListener_Handler")]
		public virtual unsafe int QueryResource (string p0, global::Com.Iflytek.Cloud.IRequestListener p1)
		{
			const string __id = "queryResource.(Ljava/lang/String;Lcom/iflytek/cloud/RequestListener;)I";
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

		static Delegate cb_startListening_Lcom_iflytek_cloud_WakeuperListener_;
#pragma warning disable 0169
		static Delegate GetStartListening_Lcom_iflytek_cloud_WakeuperListener_Handler ()
		{
			if (cb_startListening_Lcom_iflytek_cloud_WakeuperListener_ == null)
				cb_startListening_Lcom_iflytek_cloud_WakeuperListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StartListening_Lcom_iflytek_cloud_WakeuperListener_);
			return cb_startListening_Lcom_iflytek_cloud_WakeuperListener_;
		}

		static int n_StartListening_Lcom_iflytek_cloud_WakeuperListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.IWakeuperListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IWakeuperListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartListening (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='startListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.WakeuperListener']]"
		[Register ("startListening", "(Lcom/iflytek/cloud/WakeuperListener;)I", "GetStartListening_Lcom_iflytek_cloud_WakeuperListener_Handler")]
		public virtual unsafe int StartListening (global::Com.Iflytek.Cloud.IWakeuperListener p0)
		{
			const string __id = "startListening.(Lcom/iflytek/cloud/WakeuperListener;)I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopListening ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='stopListening' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.VoiceWakeuper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteAudio (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VoiceWakeuper']/method[@name='writeAudio' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
