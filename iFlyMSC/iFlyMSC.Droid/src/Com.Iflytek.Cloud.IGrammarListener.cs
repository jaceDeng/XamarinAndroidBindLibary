using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='GrammarListener']"
	[Register ("com/iflytek/cloud/GrammarListener", "", "Com.Iflytek.Cloud.IGrammarListenerInvoker")]
	public partial interface IGrammarListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='GrammarListener']/method[@name='onBuildFinish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onBuildFinish", "(Ljava/lang/String;Lcom/iflytek/cloud/SpeechError;)V", "GetOnBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.IGrammarListenerInvoker, iFlyMSC.Droid")]
		void OnBuildFinish (string p0, global::Com.Iflytek.Cloud.SpeechError p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/GrammarListener", DoNotGenerateAcw=true)]
	internal partial class IGrammarListenerInvoker : global::Java.Lang.Object, IGrammarListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/GrammarListener", typeof (IGrammarListenerInvoker));

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

		public static IGrammarListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGrammarListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.GrammarListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGrammarListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_);
			return cb_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IGrammarListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBuildFinish (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
		public unsafe void OnBuildFinish (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			if (id_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ == IntPtr.Zero)
				id_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ = JNIEnv.GetMethodID (class_ref, "onBuildFinish", "(Ljava/lang/String;Lcom/iflytek/cloud/SpeechError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBuildFinish_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.iflytek.cloud.GrammarListener.onBuildFinish
	public partial class GrammarEventArgs : global::System.EventArgs {

		public GrammarEventArgs (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
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

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/GrammarListenerImplementor")]
	internal sealed partial class IGrammarListenerImplementor : global::Java.Lang.Object, IGrammarListener {

		object sender;

		public IGrammarListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/GrammarListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GrammarEventArgs> Handler;
#pragma warning restore 0649

		public void OnBuildFinish (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GrammarEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IGrammarListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
