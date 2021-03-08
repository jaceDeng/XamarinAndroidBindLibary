using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Msc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']"
	[global::Android.Runtime.Register ("com/iflytek/msc/AIMIC", DoNotGenerateAcw=true)]
	public partial class AIMIC : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/field[@name='DEF_LIBNAME_C']"
		[Register ("DEF_LIBNAME_C")]
		public const string DefLibnameC = (string) "aimic";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/field[@name='INVALID_HANDLER']"
		[Register ("INVALID_HANDLER")]
		public const long InvalidHandler = (long) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.msc']/interface[@name='AIMIC.Listener']"
		[Register ("com/iflytek/msc/AIMIC$Listener", "", "Com.Iflytek.Msc.AIMIC/IListenerInvoker")]
		public partial interface IListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/interface[@name='AIMIC.Listener']/method[@name='onRecogAudio' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object']]"
			[Register ("onRecogAudio", "([BIILjava/lang/Object;)V", "GetOnRecogAudio_arrayBIILjava_lang_Object_Handler:Com.Iflytek.Msc.AIMIC/IListenerInvoker, iFlyMSC.Droid")]
			void OnRecogAudio (byte[] p0, int p1, int p2, global::Java.Lang.Object p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/interface[@name='AIMIC.Listener']/method[@name='onWakeupAudio' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object']]"
			[Register ("onWakeupAudio", "([BIILjava/lang/Object;)V", "GetOnWakeupAudio_arrayBIILjava_lang_Object_Handler:Com.Iflytek.Msc.AIMIC/IListenerInvoker, iFlyMSC.Droid")]
			void OnWakeupAudio (byte[] p0, int p1, int p2, global::Java.Lang.Object p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/interface[@name='AIMIC.Listener']/method[@name='onWakeupMsg' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int'] and parameter[8][@type='byte[]'] and parameter[9][@type='int']]"
			[Register ("onWakeupMsg", "(III[BI[BI[BI)V", "GetOnWakeupMsg_IIIarrayBIarrayBIarrayBIHandler:Com.Iflytek.Msc.AIMIC/IListenerInvoker, iFlyMSC.Droid")]
			void OnWakeupMsg (int p0, int p1, int p2, byte[] p3, int p4, byte[] p5, int p6, byte[] p7, int p8);

		}

		[global::Android.Runtime.Register ("com/iflytek/msc/AIMIC$Listener", DoNotGenerateAcw=true)]
		internal partial class IListenerInvoker : global::Java.Lang.Object, IListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/AIMIC$Listener", typeof (IListenerInvoker));

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

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.msc.AIMIC.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRecogAudio_arrayBIILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnRecogAudio_arrayBIILjava_lang_Object_Handler ()
			{
				if (cb_onRecogAudio_arrayBIILjava_lang_Object_ == null)
					cb_onRecogAudio_arrayBIILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_OnRecogAudio_arrayBIILjava_lang_Object_);
				return cb_onRecogAudio_arrayBIILjava_lang_Object_;
			}

			static void n_OnRecogAudio_arrayBIILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Msc.AIMIC.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnRecogAudio (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onRecogAudio_arrayBIILjava_lang_Object_;
			public unsafe void OnRecogAudio (byte[] p0, int p1, int p2, global::Java.Lang.Object p3)
			{
				if (id_onRecogAudio_arrayBIILjava_lang_Object_ == IntPtr.Zero)
					id_onRecogAudio_arrayBIILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onRecogAudio", "([BIILjava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecogAudio_arrayBIILjava_lang_Object_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onWakeupAudio_arrayBIILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnWakeupAudio_arrayBIILjava_lang_Object_Handler ()
			{
				if (cb_onWakeupAudio_arrayBIILjava_lang_Object_ == null)
					cb_onWakeupAudio_arrayBIILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_OnWakeupAudio_arrayBIILjava_lang_Object_);
				return cb_onWakeupAudio_arrayBIILjava_lang_Object_;
			}

			static void n_OnWakeupAudio_arrayBIILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Msc.AIMIC.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnWakeupAudio (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onWakeupAudio_arrayBIILjava_lang_Object_;
			public unsafe void OnWakeupAudio (byte[] p0, int p1, int p2, global::Java.Lang.Object p3)
			{
				if (id_onWakeupAudio_arrayBIILjava_lang_Object_ == IntPtr.Zero)
					id_onWakeupAudio_arrayBIILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onWakeupAudio", "([BIILjava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWakeupAudio_arrayBIILjava_lang_Object_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onWakeupMsg_IIIarrayBIarrayBIarrayBI;
#pragma warning disable 0169
			static Delegate GetOnWakeupMsg_IIIarrayBIarrayBIarrayBIHandler ()
			{
				if (cb_onWakeupMsg_IIIarrayBIarrayBIarrayBI == null)
					cb_onWakeupMsg_IIIarrayBIarrayBIarrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIILILILI_V) n_OnWakeupMsg_IIIarrayBIarrayBIarrayBI);
				return cb_onWakeupMsg_IIIarrayBIarrayBIarrayBI;
			}

			static void n_OnWakeupMsg_IIIarrayBIarrayBIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, int p4, IntPtr native_p5, int p6, IntPtr native_p7, int p8)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Msc.AIMIC.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p5 = (byte[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p7 = (byte[]) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnWakeupMsg (p0, p1, p2, p3, p4, p5, p6, p7, p8);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				if (p5 != null)
					JNIEnv.CopyArray (p5, native_p5);
				if (p7 != null)
					JNIEnv.CopyArray (p7, native_p7);
			}
#pragma warning restore 0169

			IntPtr id_onWakeupMsg_IIIarrayBIarrayBIarrayBI;
			public unsafe void OnWakeupMsg (int p0, int p1, int p2, byte[] p3, int p4, byte[] p5, int p6, byte[] p7, int p8)
			{
				if (id_onWakeupMsg_IIIarrayBIarrayBIarrayBI == IntPtr.Zero)
					id_onWakeupMsg_IIIarrayBIarrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "onWakeupMsg", "(III[BI[BI[BI)V");
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p5 = JNIEnv.NewArray (p5);
				IntPtr native_p7 = JNIEnv.NewArray (p7);
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWakeupMsg_IIIarrayBIarrayBIarrayBI, __args);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}

		}

		// event args for com.iflytek.msc.AIMIC.Listener.onRecogAudio
		public partial class RecogAudioEventArgs : global::System.EventArgs {

			public RecogAudioEventArgs (byte[] p0, int p1, int p2, global::Java.Lang.Object p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
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

			global::Java.Lang.Object p3;
			public global::Java.Lang.Object P3 {
				get { return p3; }
			}
		}

		// event args for com.iflytek.msc.AIMIC.Listener.onWakeupAudio
		public partial class WakeupAudioEventArgs : global::System.EventArgs {

			public WakeupAudioEventArgs (byte[] p0, int p1, int p2, global::Java.Lang.Object p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
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

			global::Java.Lang.Object p3;
			public global::Java.Lang.Object P3 {
				get { return p3; }
			}
		}

		// event args for com.iflytek.msc.AIMIC.Listener.onWakeupMsg
		public partial class WakeupMsgEventArgs : global::System.EventArgs {

			public WakeupMsgEventArgs (int p0, int p1, int p2, byte[] p3, int p4, byte[] p5, int p6, byte[] p7, int p8)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
				this.p5 = p5;
				this.p6 = p6;
				this.p7 = p7;
				this.p8 = p8;
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

			byte[] p3;
			public byte[] P3 {
				get { return p3; }
			}

			int p4;
			public int P4 {
				get { return p4; }
			}

			byte[] p5;
			public byte[] P5 {
				get { return p5; }
			}

			int p6;
			public int P6 {
				get { return p6; }
			}

			byte[] p7;
			public byte[] P7 {
				get { return p7; }
			}

			int p8;
			public int P8 {
				get { return p8; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/iflytek/msc/AIMIC_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/msc/AIMIC_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RecogAudioEventArgs> OnRecogAudioHandler;
#pragma warning restore 0649

			public void OnRecogAudio (byte[] p0, int p1, int p2, global::Java.Lang.Object p3)
			{
				var __h = OnRecogAudioHandler;
				if (__h != null)
					__h (sender, new RecogAudioEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<WakeupAudioEventArgs> OnWakeupAudioHandler;
#pragma warning restore 0649

			public void OnWakeupAudio (byte[] p0, int p1, int p2, global::Java.Lang.Object p3)
			{
				var __h = OnWakeupAudioHandler;
				if (__h != null)
					__h (sender, new WakeupAudioEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<WakeupMsgEventArgs> OnWakeupMsgHandler;
#pragma warning restore 0649

			public void OnWakeupMsg (int p0, int p1, int p2, byte[] p3, int p4, byte[] p5, int p6, byte[] p7, int p8)
			{
				var __h = OnWakeupMsgHandler;
				if (__h != null)
					__h (sender, new WakeupMsgEventArgs (p0, p1, p2, p3, p4, p5, p6, p7, p8));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnRecogAudioHandler == null && value.OnWakeupAudioHandler == null && value.OnWakeupMsgHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/AIMIC", typeof (AIMIC));
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

		protected AIMIC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/constructor[@name='AIMIC' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AIMIC ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe long Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()J", "")]
			get {
				const string __id = "getHandler.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='isLoaded' and count(parameter)=0]"
			[Register ("isLoaded", "()Z", "")]
			get {
				const string __id = "isLoaded.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICAudioWrite' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("AIMICAudioWrite", "(J[BII)I", "")]
		public static unsafe int AIMICAudioWrite (long p0, byte[] p1, int p2, int p3)
		{
			const string __id = "AIMICAudioWrite.(J[BII)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICDebugLog' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("AIMICDebugLog", "(ZI)V", "")]
		public static unsafe void AIMICDebugLog (bool p0, int p1)
		{
			const string __id = "AIMICDebugLog.(ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICDestroy' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("AIMICDestroy", "(J)I", "")]
		public static unsafe int AIMICDestroy (long p0)
		{
			const string __id = "AIMICDestroy.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICGetChannel' and count(parameter)=0]"
		[Register ("AIMICGetChannel", "()I", "")]
		public static unsafe int AIMICGetChannel ()
		{
			const string __id = "AIMICGetChannel.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICGetParam' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("AIMICGetParam", "(J[B[B)I", "")]
		public static unsafe int AIMICGetParam (long p0, byte[] p1, byte[] p2)
		{
			const string __id = "AIMICGetParam.(J[B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICGetVersion' and count(parameter)=0]"
		[Register ("AIMICGetVersion", "()[B", "")]
		public static unsafe byte[] AIMICGetVersion ()
		{
			const string __id = "AIMICGetVersion.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICNew' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.AIMIC.Listener']]"
		[Register ("AIMICNew", "([BLcom/iflytek/msc/AIMIC$Listener;)I", "")]
		public static unsafe int AIMICNew (byte[] p0, global::Com.Iflytek.Msc.AIMIC.IListener p1)
		{
			const string __id = "AIMICNew.([BLcom/iflytek/msc/AIMIC$Listener;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICResetEng' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("AIMICResetEng", "(J)I", "")]
		public static unsafe int AIMICResetEng (long p0)
		{
			const string __id = "AIMICResetEng.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='AIMICSetParam' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("AIMICSetParam", "(J[B[B)I", "")]
		public static unsafe int AIMICSetParam (long p0, byte[] p1, byte[] p2)
		{
			const string __id = "AIMICSetParam.(J[B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='AIMIC']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)V", "")]
		public static unsafe void LoadLibrary (string p0)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
