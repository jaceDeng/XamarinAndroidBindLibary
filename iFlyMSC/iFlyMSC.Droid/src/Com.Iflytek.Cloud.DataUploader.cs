using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='DataUploader']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/DataUploader", DoNotGenerateAcw=true)]
	public partial class DataUploader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/DataUploader", typeof (DataUploader));
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

		protected DataUploader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='DataUploader']/constructor[@name='DataUploader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DataUploader (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_uploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetUploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_uploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayB == null)
				cb_uploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_UploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayB);
			return cb_uploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayB;
		}

		static int n_UploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.DataUploader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.ISpeechListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.UploadData (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='DataUploader']/method[@name='uploadData' and count(parameter)=3 and parameter[1][@type='com.iflytek.cloud.SpeechListener'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("uploadData", "(Lcom/iflytek/cloud/SpeechListener;Ljava/lang/String;[B)I", "GetUploadData_Lcom_iflytek_cloud_SpeechListener_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe int UploadData (global::Com.Iflytek.Cloud.ISpeechListener p0, string p1, byte[] p2)
		{
			const string __id = "uploadData.(Lcom/iflytek/cloud/SpeechListener;Ljava/lang/String;[B)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
