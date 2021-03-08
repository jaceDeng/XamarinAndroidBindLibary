using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud.util']/interface[@name='FileDownloadListener']"
	[Register ("com/iflytek/cloud/util/FileDownloadListener", "", "Com.Iflytek.Cloud.Util.IFileDownloadListenerInvoker")]
	public partial interface IFileDownloadListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/interface[@name='FileDownloadListener']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onCompleted", "(Ljava/lang/String;Lcom/iflytek/cloud/SpeechError;)V", "GetOnCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.Util.IFileDownloadListenerInvoker, iFlyMSC.Droid")]
		void OnCompleted (string p0, global::Com.Iflytek.Cloud.SpeechError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/interface[@name='FileDownloadListener']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Iflytek.Cloud.Util.IFileDownloadListenerInvoker, iFlyMSC.Droid")]
		void OnProgress (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/interface[@name='FileDownloadListener']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler:Com.Iflytek.Cloud.Util.IFileDownloadListenerInvoker, iFlyMSC.Droid")]
		void OnStart ();

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/util/FileDownloadListener", DoNotGenerateAcw=true)]
	internal partial class IFileDownloadListenerInvoker : global::Java.Lang.Object, IFileDownloadListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/FileDownloadListener", typeof (IFileDownloadListenerInvoker));

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

		public static IFileDownloadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFileDownloadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.util.FileDownloadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFileDownloadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_);
			return cb_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.IFileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
		public unsafe void OnCompleted (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			if (id_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/String;Lcom/iflytek/cloud/SpeechError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onProgress_I;
#pragma warning disable 0169
		static Delegate GetOnProgress_IHandler ()
		{
			if (cb_onProgress_I == null)
				cb_onProgress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnProgress_I);
			return cb_onProgress_I;
		}

		static void n_OnProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.IFileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_I;
		public unsafe void OnProgress (int p0)
		{
			if (id_onProgress_I == IntPtr.Zero)
				id_onProgress_I = JNIEnv.GetMethodID (class_ref, "onProgress", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_I, __args);
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.IFileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		IntPtr id_onStart;
		public unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart);
		}

	}

	// event args for com.iflytek.cloud.util.FileDownloadListener.onCompleted
	public partial class CompletedEventArgs : global::System.EventArgs {

		public CompletedEventArgs (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Iflytek.Cloud.SpeechError p1;
		public global::Com.Iflytek.Cloud.SpeechError P1 {
			get { return p1; }
		}
	}

	// event args for com.iflytek.cloud.util.FileDownloadListener.onProgress
	public partial class ProgressEventArgs : global::System.EventArgs {

		public ProgressEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/util/FileDownloadListenerImplementor")]
	internal sealed partial class IFileDownloadListenerImplementor : global::Java.Lang.Object, IFileDownloadListener {

		object sender;

		public IFileDownloadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/util/FileDownloadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CompletedEventArgs> OnCompletedHandler;
#pragma warning restore 0649

		public void OnCompleted (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			var __h = OnCompletedHandler;
			if (__h != null)
				__h (sender, new CompletedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ProgressEventArgs> OnProgressHandler;
#pragma warning restore 0649

		public void OnProgress (int p0)
		{
			var __h = OnProgressHandler;
			if (__h != null)
				__h (sender, new ProgressEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnStartHandler;
#pragma warning restore 0649

		public void OnStart ()
		{
			var __h = OnStartHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IFileDownloadListenerImplementor value)
		{
			return value.OnCompletedHandler == null && value.OnProgressHandler == null && value.OnStartHandler == null;
		}
	}

}
