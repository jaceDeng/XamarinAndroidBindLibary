using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='DataDownloader']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/DataDownloader", DoNotGenerateAcw=true)]
	public partial class DataDownloader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/DataDownloader", typeof (DataDownloader));
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

		protected DataDownloader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='DataDownloader']/constructor[@name='DataDownloader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DataDownloader (global::Android.Content.Context p0)
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

		static Delegate cb_downloadData_Lcom_iflytek_cloud_SpeechListener_;
#pragma warning disable 0169
		static Delegate GetDownloadData_Lcom_iflytek_cloud_SpeechListener_Handler ()
		{
			if (cb_downloadData_Lcom_iflytek_cloud_SpeechListener_ == null)
				cb_downloadData_Lcom_iflytek_cloud_SpeechListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_DownloadData_Lcom_iflytek_cloud_SpeechListener_);
			return cb_downloadData_Lcom_iflytek_cloud_SpeechListener_;
		}

		static int n_DownloadData_Lcom_iflytek_cloud_SpeechListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.DataDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.ISpeechListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DownloadData (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='DataDownloader']/method[@name='downloadData' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechListener']]"
		[Register ("downloadData", "(Lcom/iflytek/cloud/SpeechListener;)I", "GetDownloadData_Lcom_iflytek_cloud_SpeechListener_Handler")]
		public virtual unsafe int DownloadData (global::Com.Iflytek.Cloud.ISpeechListener p0)
		{
			const string __id = "downloadData.(Lcom/iflytek/cloud/SpeechListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
