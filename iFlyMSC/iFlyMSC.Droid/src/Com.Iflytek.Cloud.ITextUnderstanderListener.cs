using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TextUnderstanderListener']"
	[Register ("com/iflytek/cloud/TextUnderstanderListener", "", "Com.Iflytek.Cloud.ITextUnderstanderListenerInvoker")]
	public partial interface ITextUnderstanderListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TextUnderstanderListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.ITextUnderstanderListenerInvoker, iFlyMSC.Droid")]
		void OnError (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TextUnderstanderListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.UnderstanderResult']]"
		[Register ("onResult", "(Lcom/iflytek/cloud/UnderstanderResult;)V", "GetOnResult_Lcom_iflytek_cloud_UnderstanderResult_Handler:Com.Iflytek.Cloud.ITextUnderstanderListenerInvoker, iFlyMSC.Droid")]
		void OnResult (global::Com.Iflytek.Cloud.UnderstanderResult p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/TextUnderstanderListener", DoNotGenerateAcw=true)]
	internal partial class ITextUnderstanderListenerInvoker : global::Java.Lang.Object, ITextUnderstanderListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/TextUnderstanderListener", typeof (ITextUnderstanderListenerInvoker));

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

		public static ITextUnderstanderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITextUnderstanderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.TextUnderstanderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITextUnderstanderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITextUnderstanderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onResult_Lcom_iflytek_cloud_UnderstanderResult_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_cloud_UnderstanderResult_Handler ()
		{
			if (cb_onResult_Lcom_iflytek_cloud_UnderstanderResult_ == null)
				cb_onResult_Lcom_iflytek_cloud_UnderstanderResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Lcom_iflytek_cloud_UnderstanderResult_);
			return cb_onResult_Lcom_iflytek_cloud_UnderstanderResult_;
		}

		static void n_OnResult_Lcom_iflytek_cloud_UnderstanderResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITextUnderstanderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.UnderstanderResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_cloud_UnderstanderResult_;
		public unsafe void OnResult (global::Com.Iflytek.Cloud.UnderstanderResult p0)
		{
			if (id_onResult_Lcom_iflytek_cloud_UnderstanderResult_ == IntPtr.Zero)
				id_onResult_Lcom_iflytek_cloud_UnderstanderResult_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/cloud/UnderstanderResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_cloud_UnderstanderResult_, __args);
		}

	}

	// event args for com.iflytek.cloud.TextUnderstanderListener.onError
	 

	 

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/TextUnderstanderListenerImplementor")]
	internal sealed partial class ITextUnderstanderListenerImplementor : global::Java.Lang.Object, ITextUnderstanderListener {

		object sender;

		public ITextUnderstanderListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/TextUnderstanderListenerImplementor", "()V"),
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

		public void OnResult (global::Com.Iflytek.Cloud.UnderstanderResult p0)
		{
			var __h = OnResultHandler;
			if (__h != null)
				__h (sender, new ResultEventArgs (p0));
		}

		internal static bool __IsEmpty (ITextUnderstanderListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnResultHandler == null;
		}
	}

}
