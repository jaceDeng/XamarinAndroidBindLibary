using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']"
	[Register ("com/iflytek/cloud/SynthesizerListener", "", "Com.Iflytek.Cloud.ISynthesizerListenerInvoker")]
	public partial interface ISynthesizerListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onBufferProgress' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onBufferProgress", "(IIILjava/lang/String;)V", "GetOnBufferProgress_IIILjava_lang_String_Handler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnBufferProgress (int p0, int p1, int p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onCompleted", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnCompleted_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnCompleted (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onSpeakBegin' and count(parameter)=0]"
		[Register ("onSpeakBegin", "()V", "GetOnSpeakBeginHandler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakBegin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onSpeakPaused' and count(parameter)=0]"
		[Register ("onSpeakPaused", "()V", "GetOnSpeakPausedHandler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakPaused ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onSpeakProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSpeakProgress", "(III)V", "GetOnSpeakProgress_IIIHandler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakProgress (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='SynthesizerListener']/method[@name='onSpeakResumed' and count(parameter)=0]"
		[Register ("onSpeakResumed", "()V", "GetOnSpeakResumedHandler:Com.Iflytek.Cloud.ISynthesizerListenerInvoker, iFlyMSC.Droid")]
		void OnSpeakResumed ();

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/SynthesizerListener", DoNotGenerateAcw=true)]
	internal partial class ISynthesizerListenerInvoker : global::Java.Lang.Object, ISynthesizerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SynthesizerListener", typeof (ISynthesizerListenerInvoker));

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

		public static ISynthesizerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISynthesizerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.SynthesizerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISynthesizerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBufferProgress_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBufferProgress_IIILjava_lang_String_Handler ()
		{
			if (cb_onBufferProgress_IIILjava_lang_String_ == null)
				cb_onBufferProgress_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnBufferProgress_IIILjava_lang_String_);
			return cb_onBufferProgress_IIILjava_lang_String_;
		}

		static void n_OnBufferProgress_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferProgress (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onBufferProgress_IIILjava_lang_String_;
		public unsafe void OnBufferProgress (int p0, int p1, int p2, string p3)
		{
			if (id_onBufferProgress_IIILjava_lang_String_ == IntPtr.Zero)
				id_onBufferProgress_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBufferProgress", "(IIILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferProgress_IIILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSpeakBegin;
#pragma warning disable 0169
		static Delegate GetOnSpeakBeginHandler ()
		{
			if (cb_onSpeakBegin == null)
				cb_onSpeakBegin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakBegin);
			return cb_onSpeakBegin;
		}

		static void n_OnSpeakBegin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakBegin ();
		}
#pragma warning restore 0169

		IntPtr id_onSpeakBegin;
		public unsafe void OnSpeakBegin ()
		{
			if (id_onSpeakBegin == IntPtr.Zero)
				id_onSpeakBegin = JNIEnv.GetMethodID (class_ref, "onSpeakBegin", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakBegin);
		}

		static Delegate cb_onSpeakPaused;
#pragma warning disable 0169
		static Delegate GetOnSpeakPausedHandler ()
		{
			if (cb_onSpeakPaused == null)
				cb_onSpeakPaused = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakPaused);
			return cb_onSpeakPaused;
		}

		static void n_OnSpeakPaused (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakPaused ();
		}
#pragma warning restore 0169

		IntPtr id_onSpeakPaused;
		public unsafe void OnSpeakPaused ()
		{
			if (id_onSpeakPaused == IntPtr.Zero)
				id_onSpeakPaused = JNIEnv.GetMethodID (class_ref, "onSpeakPaused", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakPaused);
		}

		static Delegate cb_onSpeakProgress_III;
#pragma warning disable 0169
		static Delegate GetOnSpeakProgress_IIIHandler ()
		{
			if (cb_onSpeakProgress_III == null)
				cb_onSpeakProgress_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnSpeakProgress_III);
			return cb_onSpeakProgress_III;
		}

		static void n_OnSpeakProgress_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onSpeakProgress_III;
		public unsafe void OnSpeakProgress (int p0, int p1, int p2)
		{
			if (id_onSpeakProgress_III == IntPtr.Zero)
				id_onSpeakProgress_III = JNIEnv.GetMethodID (class_ref, "onSpeakProgress", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakProgress_III, __args);
		}

		static Delegate cb_onSpeakResumed;
#pragma warning disable 0169
		static Delegate GetOnSpeakResumedHandler ()
		{
			if (cb_onSpeakResumed == null)
				cb_onSpeakResumed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpeakResumed);
			return cb_onSpeakResumed;
		}

		static void n_OnSpeakResumed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISynthesizerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSpeakResumed ();
		}
#pragma warning restore 0169

		IntPtr id_onSpeakResumed;
		public unsafe void OnSpeakResumed ()
		{
			if (id_onSpeakResumed == IntPtr.Zero)
				id_onSpeakResumed = JNIEnv.GetMethodID (class_ref, "onSpeakResumed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpeakResumed);
		}

	}

	// event args for com.iflytek.cloud.SynthesizerListener.onBufferProgress
	public partial class BufferProgressEventArgs : global::System.EventArgs {

		public BufferProgressEventArgs (int p0, int p1, int p2, string p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}
	}

	// event args for com.iflytek.cloud.SynthesizerListener.onCompleted
	public partial class CompletedEventArgs : global::System.EventArgs {

		public CompletedEventArgs (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			this.p0 = p0;
		}

		global::Com.Iflytek.Cloud.SpeechError p0;
		public global::Com.Iflytek.Cloud.SpeechError P0 {
			get { return p0; }
		}
	}

	// event args for com.iflytek.cloud.SynthesizerListener.onEvent
	 

	// event args for com.iflytek.cloud.SynthesizerListener.onSpeakProgress
	public partial class SpeakProgressEventArgs : global::System.EventArgs {

		public SpeakProgressEventArgs (int p0, int p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/SynthesizerListenerImplementor")]
	internal sealed partial class ISynthesizerListenerImplementor : global::Java.Lang.Object, ISynthesizerListener {

		object sender;

		public ISynthesizerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/SynthesizerListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BufferProgressEventArgs> OnBufferProgressHandler;
#pragma warning restore 0649

		public void OnBufferProgress (int p0, int p1, int p2, string p3)
		{
			var __h = OnBufferProgressHandler;
			if (__h != null)
				__h (sender, new BufferProgressEventArgs (p0, p1, p2, p3));
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

		public void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			var __h = OnEventHandler;
			if (__h != null)
				__h (sender, new EventEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler OnSpeakBeginHandler;
#pragma warning restore 0649

		public void OnSpeakBegin ()
		{
			var __h = OnSpeakBeginHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnSpeakPausedHandler;
#pragma warning restore 0649

		public void OnSpeakPaused ()
		{
			var __h = OnSpeakPausedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<SpeakProgressEventArgs> OnSpeakProgressHandler;
#pragma warning restore 0649

		public void OnSpeakProgress (int p0, int p1, int p2)
		{
			var __h = OnSpeakProgressHandler;
			if (__h != null)
				__h (sender, new SpeakProgressEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler OnSpeakResumedHandler;
#pragma warning restore 0649

		public void OnSpeakResumed ()
		{
			var __h = OnSpeakResumedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ISynthesizerListenerImplementor value)
		{
			return value.OnBufferProgressHandler == null && value.OnCompletedHandler == null && value.OnEventHandler == null && value.OnSpeakBeginHandler == null && value.OnSpeakPausedHandler == null && value.OnSpeakProgressHandler == null && value.OnSpeakResumedHandler == null;
		}
	}

}
