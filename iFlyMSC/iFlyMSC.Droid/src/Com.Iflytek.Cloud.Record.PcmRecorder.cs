using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Record {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/record/PcmRecorder", DoNotGenerateAcw=true)]
	public partial class PcmRecorder : global::Java.Lang.Thread {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/field[@name='RATE16K']"
		[Register ("RATE16K")]
		public const int Rate16k = (int) 16000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/field[@name='READ_INTERVAL40MS']"
		[Register ("READ_INTERVAL40MS")]
		public const int ReadInterval40ms = (int) 40;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud.record']/interface[@name='PcmRecorder.PcmRecordListener']"
		[Register ("com/iflytek/cloud/record/PcmRecorder$PcmRecordListener", "", "Com.Iflytek.Cloud.Record.PcmRecorder/IPcmRecordListenerInvoker")]
		public partial interface IPcmRecordListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/interface[@name='PcmRecorder.PcmRecordListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
			[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.Record.PcmRecorder/IPcmRecordListenerInvoker, iFlyMSC.Droid")]
			void OnError (global::Com.Iflytek.Cloud.SpeechError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/interface[@name='PcmRecorder.PcmRecordListener']/method[@name='onRecordBuffer' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onRecordBuffer", "([BII)V", "GetOnRecordBuffer_arrayBIIHandler:Com.Iflytek.Cloud.Record.PcmRecorder/IPcmRecordListenerInvoker, iFlyMSC.Droid")]
			void OnRecordBuffer (byte[] p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/interface[@name='PcmRecorder.PcmRecordListener']/method[@name='onRecordReleased' and count(parameter)=0]"
			[Register ("onRecordReleased", "()V", "GetOnRecordReleasedHandler:Com.Iflytek.Cloud.Record.PcmRecorder/IPcmRecordListenerInvoker, iFlyMSC.Droid")]
			void OnRecordReleased ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/interface[@name='PcmRecorder.PcmRecordListener']/method[@name='onRecordStarted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onRecordStarted", "(Z)V", "GetOnRecordStarted_ZHandler:Com.Iflytek.Cloud.Record.PcmRecorder/IPcmRecordListenerInvoker, iFlyMSC.Droid")]
			void OnRecordStarted (bool p0);

		}

		[global::Android.Runtime.Register ("com/iflytek/cloud/record/PcmRecorder$PcmRecordListener", DoNotGenerateAcw=true)]
		internal partial class IPcmRecordListenerInvoker : global::Java.Lang.Object, IPcmRecordListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/record/PcmRecorder$PcmRecordListener", typeof (IPcmRecordListenerInvoker));

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

			public static IPcmRecordListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPcmRecordListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.record.PcmRecorder.PcmRecordListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPcmRecordListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onRecordBuffer_arrayBII;
#pragma warning disable 0169
			static Delegate GetOnRecordBuffer_arrayBIIHandler ()
			{
				if (cb_onRecordBuffer_arrayBII == null)
					cb_onRecordBuffer_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnRecordBuffer_arrayBII);
				return cb_onRecordBuffer_arrayBII;
			}

			static void n_OnRecordBuffer_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnRecordBuffer (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onRecordBuffer_arrayBII;
			public unsafe void OnRecordBuffer (byte[] p0, int p1, int p2)
			{
				if (id_onRecordBuffer_arrayBII == IntPtr.Zero)
					id_onRecordBuffer_arrayBII = JNIEnv.GetMethodID (class_ref, "onRecordBuffer", "([BII)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecordBuffer_arrayBII, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onRecordReleased;
#pragma warning disable 0169
			static Delegate GetOnRecordReleasedHandler ()
			{
				if (cb_onRecordReleased == null)
					cb_onRecordReleased = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRecordReleased);
				return cb_onRecordReleased;
			}

			static void n_OnRecordReleased (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecordReleased ();
			}
#pragma warning restore 0169

			IntPtr id_onRecordReleased;
			public unsafe void OnRecordReleased ()
			{
				if (id_onRecordReleased == IntPtr.Zero)
					id_onRecordReleased = JNIEnv.GetMethodID (class_ref, "onRecordReleased", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecordReleased);
			}

			static Delegate cb_onRecordStarted_Z;
#pragma warning disable 0169
			static Delegate GetOnRecordStarted_ZHandler ()
			{
				if (cb_onRecordStarted_Z == null)
					cb_onRecordStarted_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnRecordStarted_Z);
				return cb_onRecordStarted_Z;
			}

			static void n_OnRecordStarted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecordStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRecordStarted_Z;
			public unsafe void OnRecordStarted (bool p0)
			{
				if (id_onRecordStarted_Z == IntPtr.Zero)
					id_onRecordStarted_Z = JNIEnv.GetMethodID (class_ref, "onRecordStarted", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecordStarted_Z, __args);
			}

		}

		// event args for com.iflytek.cloud.record.PcmRecorder.PcmRecordListener.onError
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

		// event args for com.iflytek.cloud.record.PcmRecorder.PcmRecordListener.onRecordBuffer
		public partial class RecordBufferEventArgs : global::System.EventArgs {

			public RecordBufferEventArgs (byte[] p0, int p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			byte[] p0;
			public byte[] P0 {
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

		// event args for com.iflytek.cloud.record.PcmRecorder.PcmRecordListener.onRecordStarted
		public partial class RecordStartedEventArgs : global::System.EventArgs {

			public RecordStartedEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/iflytek/cloud/record/PcmRecorder_PcmRecordListenerImplementor")]
		internal sealed partial class IPcmRecordListenerImplementor : global::Java.Lang.Object, IPcmRecordListener {

			object sender;

			public IPcmRecordListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/record/PcmRecorder_PcmRecordListenerImplementor", "()V"),
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
			public EventHandler<RecordBufferEventArgs> OnRecordBufferHandler;
#pragma warning restore 0649

			public void OnRecordBuffer (byte[] p0, int p1, int p2)
			{
				var __h = OnRecordBufferHandler;
				if (__h != null)
					__h (sender, new RecordBufferEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler OnRecordReleasedHandler;
#pragma warning restore 0649

			public void OnRecordReleased ()
			{
				var __h = OnRecordReleasedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<RecordStartedEventArgs> OnRecordStartedHandler;
#pragma warning restore 0649

			public void OnRecordStarted (bool p0)
			{
				var __h = OnRecordStartedHandler;
				if (__h != null)
					__h (sender, new RecordStartedEventArgs (p0));
			}

			internal static bool __IsEmpty (IPcmRecordListenerImplementor value)
			{
				return value.OnErrorHandler == null && value.OnRecordBufferHandler == null && value.OnRecordReleasedHandler == null && value.OnRecordStartedHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/record/PcmRecorder", typeof (PcmRecorder));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected PcmRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/constructor[@name='PcmRecorder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe PcmRecorder (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/constructor[@name='PcmRecorder' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe PcmRecorder (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_SII;
#pragma warning disable 0169
		static Delegate GetA_SIIHandler ()
		{
			if (cb_a_SII == null)
				cb_a_SII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPSII_V) n_A_SII);
			return cb_a_SII;
		}

		static void n_A_SII (IntPtr jnienv, IntPtr native__this, short p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/method[@name='a' and count(parameter)=3 and parameter[1][@type='short'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("a", "(SII)V", "GetA_SIIHandler")]
		protected virtual unsafe void A (short p0, int p1, int p2)
		{
			const string __id = "a.(SII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_;
#pragma warning disable 0169
		static Delegate GetStartRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_Handler ()
		{
			if (cb_startRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_ == null)
				cb_startRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StartRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_);
			return cb_startRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_;
		}

		static void n_StartRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartRecording (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/method[@name='startRecording' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.record.PcmRecorder.PcmRecordListener']]"
		[Register ("startRecording", "(Lcom/iflytek/cloud/record/PcmRecorder$PcmRecordListener;)V", "GetStartRecording_Lcom_iflytek_cloud_record_PcmRecorder_PcmRecordListener_Handler")]
		public virtual unsafe void StartRecording (global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener p0)
		{
			const string __id = "startRecording.(Lcom/iflytek/cloud/record/PcmRecorder$PcmRecordListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_stopRecord_Z;
#pragma warning disable 0169
		static Delegate GetStopRecord_ZHandler ()
		{
			if (cb_stopRecord_Z == null)
				cb_stopRecord_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_StopRecord_Z);
			return cb_stopRecord_Z;
		}

		static void n_StopRecord_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecord (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.record']/class[@name='PcmRecorder']/method[@name='stopRecord' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stopRecord", "(Z)V", "GetStopRecord_ZHandler")]
		public virtual unsafe void StopRecord (bool p0)
		{
			const string __id = "stopRecord.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
