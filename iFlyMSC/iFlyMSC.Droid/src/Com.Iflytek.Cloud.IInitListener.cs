using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='InitListener']"
	[Register ("com/iflytek/cloud/InitListener", "", "Com.Iflytek.Cloud.IInitListenerInvoker")]
	public partial interface IInitListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='InitListener']/method[@name='onInit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onInit", "(I)V", "GetOnInit_IHandler:Com.Iflytek.Cloud.IInitListenerInvoker, iFlyMSC.Droid")]
		void OnInit (int p0);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/InitListener", DoNotGenerateAcw=true)]
	internal partial class IInitListenerInvoker : global::Java.Lang.Object, IInitListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/InitListener", typeof (IInitListenerInvoker));

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

		public static IInitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInitListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.InitListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInit_I;
#pragma warning disable 0169
		static Delegate GetOnInit_IHandler ()
		{
			if (cb_onInit_I == null)
				cb_onInit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnInit_I);
			return cb_onInit_I;
		}

		static void n_OnInit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IInitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInit (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInit_I;
		public unsafe void OnInit (int p0)
		{
			if (id_onInit_I == IntPtr.Zero)
				id_onInit_I = JNIEnv.GetMethodID (class_ref, "onInit", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInit_I, __args);
		}

	}

	// event args for com.iflytek.cloud.InitListener.onInit
	public partial class InitEventArgs : global::System.EventArgs {

		public InitEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/InitListenerImplementor")]
	internal sealed partial class IInitListenerImplementor : global::Java.Lang.Object, IInitListener {

		object sender;

		public IInitListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/InitListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InitEventArgs> Handler;
#pragma warning restore 0649

		public void OnInit (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new InitEventArgs (p0));
		}

		internal static bool __IsEmpty (IInitListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
