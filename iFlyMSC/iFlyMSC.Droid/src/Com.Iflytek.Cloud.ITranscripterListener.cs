using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']"
	[Register ("com/iflytek/cloud/TranscripterListener", "", "Com.Iflytek.Cloud.ITranscripterListenerInvoker")]
	public partial interface ITranscripterListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler:Com.Iflytek.Cloud.ITranscripterListenerInvoker, iFlyMSC.Droid")]
		void OnBeginOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']/method[@name='onEndOfSpeech' and count(parameter)=0]"
		[Register ("onEndOfSpeech", "()V", "GetOnEndOfSpeechHandler:Com.Iflytek.Cloud.ITranscripterListenerInvoker, iFlyMSC.Droid")]
		void OnEndOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.ITranscripterListenerInvoker, iFlyMSC.Droid")]
		void OnError (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler:Com.Iflytek.Cloud.ITranscripterListenerInvoker, iFlyMSC.Droid")]
		void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.cloud.TranscripterResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/cloud/TranscripterResult;Z)V", "GetOnResult_Lcom_iflytek_cloud_TranscripterResult_ZHandler:Com.Iflytek.Cloud.ITranscripterListenerInvoker, iFlyMSC.Droid")]
		void OnResult (global::Com.Iflytek.Cloud.TranscripterResult p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='TranscripterListener']/method[@name='onVolumeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("onVolumeChanged", "(I[B)V", "GetOnVolumeChanged_IarrayBHandler:Com.Iflytek.Cloud.ITranscripterListenerInvoker, iFlyMSC.Droid")]
		void OnVolumeChanged (int p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/TranscripterListener", DoNotGenerateAcw=true)]
	internal partial class ITranscripterListenerInvoker : global::Java.Lang.Object, ITranscripterListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/TranscripterListener", typeof (ITranscripterListenerInvoker));

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

		public static ITranscripterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITranscripterListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.TranscripterListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITranscripterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeginOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnBeginOfSpeechHandler ()
		{
			if (cb_onBeginOfSpeech == null)
				cb_onBeginOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBeginOfSpeech);
			return cb_onBeginOfSpeech;
		}

		static void n_OnBeginOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfSpeech ();
		}
#pragma warning restore 0169

		IntPtr id_onBeginOfSpeech;
		public unsafe void OnBeginOfSpeech ()
		{
			if (id_onBeginOfSpeech == IntPtr.Zero)
				id_onBeginOfSpeech = JNIEnv.GetMethodID (class_ref, "onBeginOfSpeech", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeginOfSpeech);
		}

		static Delegate cb_onEndOfSpeech;
#pragma warning disable 0169
		static Delegate GetOnEndOfSpeechHandler ()
		{
			if (cb_onEndOfSpeech == null)
				cb_onEndOfSpeech = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnEndOfSpeech);
			return cb_onEndOfSpeech;
		}

		static void n_OnEndOfSpeech (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndOfSpeech ();
		}
#pragma warning restore 0169

		IntPtr id_onEndOfSpeech;
		public unsafe void OnEndOfSpeech ()
		{
			if (id_onEndOfSpeech == IntPtr.Zero)
				id_onEndOfSpeech = JNIEnv.GetMethodID (class_ref, "onEndOfSpeech", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEndOfSpeech);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onEvent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnEvent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_onEvent_IIILandroid_os_Bundle_ == null)
				cb_onEvent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnEvent_IIILandroid_os_Bundle_);
			return cb_onEvent_IIILandroid_os_Bundle_;
		}

		static void n_OnEvent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_IIILandroid_os_Bundle_;
		public unsafe void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			if (id_onEvent_IIILandroid_os_Bundle_ == IntPtr.Zero)
				id_onEvent_IIILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(IIILandroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_IIILandroid_os_Bundle_, __args);
		}

		static Delegate cb_onResult_Lcom_iflytek_cloud_TranscripterResult_Z;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_cloud_TranscripterResult_ZHandler ()
		{
			if (cb_onResult_Lcom_iflytek_cloud_TranscripterResult_Z == null)
				cb_onResult_Lcom_iflytek_cloud_TranscripterResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnResult_Lcom_iflytek_cloud_TranscripterResult_Z);
			return cb_onResult_Lcom_iflytek_cloud_TranscripterResult_Z;
		}

		static void n_OnResult_Lcom_iflytek_cloud_TranscripterResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TranscripterResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_cloud_TranscripterResult_Z;
		public unsafe void OnResult (global::Com.Iflytek.Cloud.TranscripterResult p0, bool p1)
		{
			if (id_onResult_Lcom_iflytek_cloud_TranscripterResult_Z == IntPtr.Zero)
				id_onResult_Lcom_iflytek_cloud_TranscripterResult_Z = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/cloud/TranscripterResult;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_cloud_TranscripterResult_Z, __args);
		}

		static Delegate cb_onVolumeChanged_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IarrayBHandler ()
		{
			if (cb_onVolumeChanged_IarrayB == null)
				cb_onVolumeChanged_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnVolumeChanged_IarrayB);
			return cb_onVolumeChanged_IarrayB;
		}

		static void n_OnVolumeChanged_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnVolumeChanged (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onVolumeChanged_IarrayB;
		public unsafe void OnVolumeChanged (int p0, byte[] p1)
		{
			if (id_onVolumeChanged_IarrayB == IntPtr.Zero)
				id_onVolumeChanged_IarrayB = JNIEnv.GetMethodID (class_ref, "onVolumeChanged", "(I[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVolumeChanged_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.iflytek.cloud.TranscripterListener.onError
 

	// event args for com.iflytek.cloud.TranscripterListener.onEvent
	 
	// event args for com.iflytek.cloud.TranscripterListener.onResult
	 
	// event args for com.iflytek.cloud.TranscripterListener.onVolumeChanged
 
	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/TranscripterListenerImplementor")]
	internal sealed partial class ITranscripterListenerImplementor : global::Java.Lang.Object, ITranscripterListener {

		object sender;

		public ITranscripterListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/TranscripterListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnBeginOfSpeechHandler;
#pragma warning restore 0649

		public void OnBeginOfSpeech ()
		{
			var __h = OnBeginOfSpeechHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnEndOfSpeechHandler;
#pragma warning restore 0649

		public void OnEndOfSpeech ()
		{
			var __h = OnEndOfSpeechHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
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
		public EventHandler<EventEventArgs> OnEventHandler;
#pragma warning restore 0649

		public void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			var __h = OnEventHandler;
			if (__h != null)
				__h (sender, new EventEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<ResultEventArgs> OnResultHandler;
#pragma warning restore 0649

		public void OnResult (global::Com.Iflytek.Cloud.TranscripterResult p0, bool p1)
		{
			var __h = OnResultHandler;
			if (__h != null)
				__h (sender, new ResultEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<VolumeChangedEventArgs> OnVolumeChangedHandler;
#pragma warning restore 0649

		public void OnVolumeChanged (int p0, byte[] p1)
		{
			var __h = OnVolumeChangedHandler;
			if (__h != null)
				__h (sender, new VolumeChangedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ITranscripterListenerImplementor value)
		{
			return value.OnBeginOfSpeechHandler == null && value.OnEndOfSpeechHandler == null && value.OnErrorHandler == null && value.OnEventHandler == null && value.OnResultHandler == null && value.OnVolumeChangedHandler == null;
		}
	}

}
