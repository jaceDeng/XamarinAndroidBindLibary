using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='VerifierUtil']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/util/VerifierUtil", DoNotGenerateAcw=true)]
	public partial class VerifierUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/VerifierUtil", typeof (VerifierUtil));
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

		protected VerifierUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='VerifierUtil']/constructor[@name='VerifierUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VerifierUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='VerifierUtil']/method[@name='ARGB2Gray' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("ARGB2Gray", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ARGB2Gray (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "ARGB2Gray.(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='VerifierUtil']/method[@name='generateNumberPassword' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("generateNumberPassword", "(I)Ljava/lang/String;", "")]
		public static unsafe string GenerateNumberPassword (int p0)
		{
			const string __id = "generateNumberPassword.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='VerifierUtil']/method[@name='getBitmapsize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getBitmapsize", "(Landroid/graphics/Bitmap;)I", "")]
		public static unsafe int GetBitmapsize (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "getBitmapsize.(Landroid/graphics/Bitmap;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
