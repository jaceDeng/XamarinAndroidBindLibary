using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='WakeuperListener']"
	[Register ("com/iflytek/cloud/WakeuperListener", "", "Com.Iflytek.Cloud.IWakeuperListenerInvoker")]
	public partial interface IWakeuperListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='WakeuperListener']/method[@name='onBeginOfSpeech' and count(parameter)=0]"
		[Register ("onBeginOfSpeech", "()V", "GetOnBeginOfSpeechHandler:Com.Iflytek.Cloud.IWakeuperListenerInvoker, iFlyMSC.Droid")]
		void OnBeginOfSpeech ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='WakeuperListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.IWakeuperListenerInvoker, iFlyMSC.Droid")]
		void OnError (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='WakeuperListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler:Com.Iflytek.Cloud.IWakeuperListenerInvoker, iFlyMSC.Droid")]
		void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='WakeuperListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.WakeuperResult']]"
		[Register ("onResult", "(Lcom/iflytek/cloud/WakeuperResult;)V", "GetOnResult_Lcom_iflytek_cloud_WakeuperResult_Handler:Com.Iflytek.Cloud.IWakeuperListenerInvoker, iFlyMSC.Droid")]
		void OnResult (global::Com.Iflytek.Cloud.WakeuperResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='WakeuperListener']/method[@name='onVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler:Com.Iflytek.Cloud.IWakeuperListenerInvoker, iFlyMSC.Droid")]
		void OnVolumeChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/WakeuperListener", DoNotGenerateAcw=true)]
	internal partial class IWakeuperListenerInvoker : global::Java.Lang.Object, IWakeuperListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/WakeuperListener", typeof (IWakeuperListenerInvoker));

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

		public static IWakeuperListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWakeuperListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.WakeuperListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWakeuperListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IWakeuperListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IWakeuperListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IWakeuperListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onResult_Lcom_iflytek_cloud_WakeuperResult_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_cloud_WakeuperResult_Handler ()
		{
			if (cb_onResult_Lcom_iflytek_cloud_WakeuperResult_ == null)
				cb_onResult_Lcom_iflytek_cloud_WakeuperResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Lcom_iflytek_cloud_WakeuperResult_);
			return cb_onResult_Lcom_iflytek_cloud_WakeuperResult_;
		}

		static void n_OnResult_Lcom_iflytek_cloud_WakeuperResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IWakeuperListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.WakeuperResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_cloud_WakeuperResult_;
		public unsafe void OnResult (global::Com.Iflytek.Cloud.WakeuperResult p0)
		{
			if (id_onResult_Lcom_iflytek_cloud_WakeuperResult_ == IntPtr.Zero)
				id_onResult_Lcom_iflytek_cloud_WakeuperResult_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/cloud/WakeuperResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_cloud_WakeuperResult_, __args);
		}

		static Delegate cb_onVolumeChanged_I;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IHandler ()
		{
			if (cb_onVolumeChanged_I == null)
				cb_onVolumeChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnVolumeChanged_I);
			return cb_onVolumeChanged_I;
		}

		static void n_OnVolumeChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IWakeuperListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVolumeChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVolumeChanged_I;
		public unsafe void OnVolumeChanged (int p0)
		{
			if (id_onVolumeChanged_I == IntPtr.Zero)
				id_onVolumeChanged_I = JNIEnv.GetMethodID (class_ref, "onVolumeChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVolumeChanged_I, __args);
		}

	}

	 

	  
	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/WakeuperListenerImplementor")]
	internal sealed partial class IWakeuperListenerImplementor : global::Java.Lang.Object, IWakeuperListener {

		object sender;

		public IWakeuperListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/WakeuperListenerImplementor", "()V"),
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

		public void OnResult (global::Com.Iflytek.Cloud.WakeuperResult p0)
		{
			var __h = OnResultHandler;
			if (__h != null)
				__h (sender, new ResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<VolumeChangedEventArgs> OnVolumeChangedHandler;
#pragma warning restore 0649

		public void OnVolumeChanged (int p0)
		{
			var __h = OnVolumeChangedHandler;
			if (__h != null)
				__h (sender, new VolumeChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IWakeuperListenerImplementor value)
		{
			return value.OnBeginOfSpeechHandler == null && value.OnErrorHandler == null && value.OnEventHandler == null && value.OnResultHandler == null && value.OnVolumeChangedHandler == null;
		}
	}

}
