using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='LexiconListener']"
	[Register ("com/iflytek/cloud/LexiconListener", "", "Com.Iflytek.Cloud.ILexiconListenerInvoker")]
	public partial interface ILexiconListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='LexiconListener']/method[@name='onLexiconUpdated' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onLexiconUpdated", "(Ljava/lang/String;Lcom/iflytek/cloud/SpeechError;)V", "GetOnLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.ILexiconListenerInvoker, iFlyMSC.Droid")]
		void OnLexiconUpdated (string p0, global::Com.Iflytek.Cloud.SpeechError p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/LexiconListener", DoNotGenerateAcw=true)]
	internal partial class ILexiconListenerInvoker : global::Java.Lang.Object, ILexiconListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/LexiconListener", typeof (ILexiconListenerInvoker));

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

		public static ILexiconListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILexiconListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.LexiconListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILexiconListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_);
			return cb_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ILexiconListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLexiconUpdated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_;
		public unsafe void OnLexiconUpdated (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			if (id_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ == IntPtr.Zero)
				id_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_ = JNIEnv.GetMethodID (class_ref, "onLexiconUpdated", "(Ljava/lang/String;Lcom/iflytek/cloud/SpeechError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLexiconUpdated_Ljava_lang_String_Lcom_iflytek_cloud_SpeechError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.iflytek.cloud.LexiconListener.onLexiconUpdated
	public partial class LexiconEventArgs : global::System.EventArgs {

		public LexiconEventArgs (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
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

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/LexiconListenerImplementor")]
	internal sealed partial class ILexiconListenerImplementor : global::Java.Lang.Object, ILexiconListener {

		object sender;

		public ILexiconListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/LexiconListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LexiconEventArgs> Handler;
#pragma warning restore 0649

		public void OnLexiconUpdated (string p0, global::Com.Iflytek.Cloud.SpeechError p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LexiconEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ILexiconListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
