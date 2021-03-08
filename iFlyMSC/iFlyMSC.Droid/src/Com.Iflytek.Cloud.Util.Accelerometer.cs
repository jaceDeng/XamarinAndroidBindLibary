using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/util/Accelerometer", DoNotGenerateAcw=true)]
	public partial class Accelerometer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']"
		[global::Android.Runtime.Register ("com/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE", DoNotGenerateAcw=true)]
		public sealed partial class CLOCKWISE_ANGLE : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/field[@name='Deg0']"
			[Register ("Deg0")]
			public static global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE Deg0 {
				get {
					const string __id = "Deg0.Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/field[@name='Deg180']"
			[Register ("Deg180")]
			public static global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE Deg180 {
				get {
					const string __id = "Deg180.Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/field[@name='Deg270']"
			[Register ("Deg270")]
			public static global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE Deg270 {
				get {
					const string __id = "Deg270.Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/field[@name='Deg90']"
			[Register ("Deg90")]
			public static global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE Deg90 {
				get {
					const string __id = "Deg90.Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE", typeof (CLOCKWISE_ANGLE));
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

			internal CLOCKWISE_ANGLE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer.CLOCKWISE_ANGLE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE[] Values ()
			{
				const string __id = "values.()[Lcom/iflytek/cloud/util/Accelerometer$CLOCKWISE_ANGLE;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Iflytek.Cloud.Util.Accelerometer.CLOCKWISE_ANGLE));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/Accelerometer", typeof (Accelerometer));
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

		protected Accelerometer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer']/constructor[@name='Accelerometer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Accelerometer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public static unsafe int Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()I", "")]
			get {
				const string __id = "getDirection.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.Accelerometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='Accelerometer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
