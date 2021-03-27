using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.UI {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud.ui']/interface[@name='RecognizerDialogListener']"
	[Register ("com/iflytek/cloud/ui/RecognizerDialogListener", "", "Com.Iflytek.Cloud.UI.IRecognizerDialogListenerInvoker")]
	public partial interface IRecognizerDialogListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.ui']/interface[@name='RecognizerDialogListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.UI.IRecognizerDialogListenerInvoker, iFlyMSC.Droid")]
		void OnError (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.ui']/interface[@name='RecognizerDialogListener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.cloud.RecognizerResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/cloud/RecognizerResult;Z)V", "GetOnResult_Lcom_iflytek_cloud_RecognizerResult_ZHandler:Com.Iflytek.Cloud.UI.IRecognizerDialogListenerInvoker, iFlyMSC.Droid")]
		void OnResult (global::Com.Iflytek.Cloud.RecognizerResult p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/ui/RecognizerDialogListener", DoNotGenerateAcw=true)]
	internal partial class IRecognizerDialogListenerInvoker : global::Java.Lang.Object, IRecognizerDialogListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/ui/RecognizerDialogListener", typeof (IRecognizerDialogListenerInvoker));

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

		public static IRecognizerDialogListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRecognizerDialogListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.ui.RecognizerDialogListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRecognizerDialogListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onError_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onError_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_iflytek_cloud_SpeechError_);
			return cb_onError_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnError_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UI.IRecognizerDialogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_iflytek_cloud_SpeechError_;
		public unsafe void OnError (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			if (id_onError_Lcom_iflytek_cloud_SpeechError_ == IntPtr.Zero)
				id_onError_Lcom_iflytek_cloud_SpeechError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/iflytek/cloud/SpeechError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_iflytek_cloud_SpeechError_, __args);
		}

		static Delegate cb_onResult_Lcom_iflytek_cloud_RecognizerResult_Z;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_cloud_RecognizerResult_ZHandler ()
		{
			if (cb_onResult_Lcom_iflytek_cloud_RecognizerResult_Z == null)
				cb_onResult_Lcom_iflytek_cloud_RecognizerResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnResult_Lcom_iflytek_cloud_RecognizerResult_Z);
			return cb_onResult_Lcom_iflytek_cloud_RecognizerResult_Z;
		}

		static void n_OnResult_Lcom_iflytek_cloud_RecognizerResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UI.IRecognizerDialogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.RecognizerResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_cloud_RecognizerResult_Z;
		public unsafe void OnResult (global::Com.Iflytek.Cloud.RecognizerResult p0, bool p1)
		{
			if (id_onResult_Lcom_iflytek_cloud_RecognizerResult_Z == IntPtr.Zero)
				id_onResult_Lcom_iflytek_cloud_RecognizerResult_Z = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/cloud/RecognizerResult;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_cloud_RecognizerResult_Z, __args);
		}

	}

	// event args for com.iflytek.cloud.ui.RecognizerDialogListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			this.p0 = p0;
		}

		global::Com.Iflytek.Cloud.SpeechError p0;
		public global::Com.Iflytek.Cloud.SpeechError P0 {
			get { return p0; }
		}
	}

	// event args for com.iflytek.cloud.ui.RecognizerDialogListener.onResult
	public partial class ResultEventArgs : global::System.EventArgs {

		public ResultEventArgs (global::Com.Iflytek.Cloud.RecognizerResult p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Iflytek.Cloud.RecognizerResult p0;
		public global::Com.Iflytek.Cloud.RecognizerResult P0 {
			get { return p0; }
		}

		bool p1;
		public bool P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/ui/RecognizerDialogListenerImplementor")]
	internal sealed partial class IRecognizerDialogListenerImplementor : global::Java.Lang.Object, IRecognizerDialogListener {

		object sender;

		public IRecognizerDialogListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/ui/RecognizerDialogListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ResultEventArgs> OnResultHandler;
#pragma warning restore 0649

		public void OnResult (global::Com.Iflytek.Cloud.RecognizerResult p0, bool p1)
		{
			var __h = OnResultHandler;
			if (__h != null)
				__h (sender, new ResultEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IRecognizerDialogListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnResultHandler == null;
		}
	}

}
