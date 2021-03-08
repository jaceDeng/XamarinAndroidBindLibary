using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SpeechListener']"
	[Register ("com/iflytek/cloud/SpeechListener", "", "Com.Iflytek.Cloud.ISpeechListenerInvoker")]
	public partial interface ISpeechListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SpeechListener']/method[@name='onBufferReceived' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onBufferReceived", "([B)V", "GetOnBufferReceived_arrayBHandler:Com.Iflytek.Cloud.ISpeechListenerInvoker, iFlyMSC.Droid")]
		void OnBufferReceived (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SpeechListener']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onCompleted", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnCompleted_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.ISpeechListenerInvoker, iFlyMSC.Droid")]
		void OnCompleted (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SpeechListener']/method[@name='onEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onEvent", "(ILandroid/os/Bundle;)V", "GetOnEvent_ILandroid_os_Bundle_Handler:Com.Iflytek.Cloud.ISpeechListenerInvoker, iFlyMSC.Droid")]
		void OnEvent (int p0, global::Android.OS.Bundle p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechListener", DoNotGenerateAcw=true)]
	internal partial class ISpeechListenerInvoker : global::Java.Lang.Object, ISpeechListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechListener", typeof (ISpeechListenerInvoker));

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

		public static ISpeechListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpeechListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.SpeechListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpeechListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBufferReceived_arrayB;
#pragma warning disable 0169
		static Delegate GetOnBufferReceived_arrayBHandler ()
		{
			if (cb_onBufferReceived_arrayB == null)
				cb_onBufferReceived_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBufferReceived_arrayB);
			return cb_onBufferReceived_arrayB;
		}

		static void n_OnBufferReceived_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnBufferReceived (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onBufferReceived_arrayB;
		public unsafe void OnBufferReceived (byte[] p0)
		{
			if (id_onBufferReceived_arrayB == IntPtr.Zero)
				id_onBufferReceived_arrayB = JNIEnv.GetMethodID (class_ref, "onBufferReceived", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferReceived_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onCompleted_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onCompleted_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onCompleted_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCompleted_Lcom_iflytek_cloud_SpeechError_);
			return cb_onCompleted_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnCompleted_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Lcom_iflytek_cloud_SpeechError_;
		public unsafe void OnCompleted (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			if (id_onCompleted_Lcom_iflytek_cloud_SpeechError_ == IntPtr.Zero)
				id_onCompleted_Lcom_iflytek_cloud_SpeechError_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Lcom/iflytek/cloud/SpeechError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted_Lcom_iflytek_cloud_SpeechError_, __args);
		}

		static Delegate cb_onEvent_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnEvent_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onEvent_ILandroid_os_Bundle_ == null)
				cb_onEvent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnEvent_ILandroid_os_Bundle_);
			return cb_onEvent_ILandroid_os_Bundle_;
		}

		static void n_OnEvent_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_ILandroid_os_Bundle_;
		public unsafe void OnEvent (int p0, global::Android.OS.Bundle p1)
		{
			if (id_onEvent_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onEvent_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(ILandroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_ILandroid_os_Bundle_, __args);
		}

	}

	// event args for com.iflytek.cloud.SpeechListener.onBufferReceived
	public partial class BufferReceivedEventArgs : global::System.EventArgs {

		public BufferReceivedEventArgs (byte[] p0)
		{
			this.p0 = p0;
		}

		byte[] p0;
		public byte[] P0 {
			get { return p0; }
		}
	}

	// event args for com.iflytek.cloud.SpeechListener.onCompleted
	 

	// event args for com.iflytek.cloud.SpeechListener.onEvent
 

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/SpeechListenerImplementor")]
	internal sealed partial class ISpeechListenerImplementor : global::Java.Lang.Object, ISpeechListener {

		object sender;

		public ISpeechListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/SpeechListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BufferReceivedEventArgs> OnBufferReceivedHandler;
#pragma warning restore 0649

		public void OnBufferReceived (byte[] p0)
		{
			var __h = OnBufferReceivedHandler;
			if (__h != null)
				__h (sender, new BufferReceivedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<CompletedEventArgs> OnCompletedHandler;
#pragma warning restore 0649

		public void OnCompleted (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			var __h = OnCompletedHandler;
			if (__h != null)
				__h (sender, new CompletedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<EventEventArgs> OnEventHandler;
#pragma warning restore 0649

		public void OnEvent (int p0, global::Android.OS.Bundle p1)
		{
			var __h = OnEventHandler;
			if (__h != null)
				__h (sender, new EventEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ISpeechListenerImplementor value)
		{
			return value.OnBufferReceivedHandler == null && value.OnCompletedHandler == null && value.OnEventHandler == null;
		}
	}

}
