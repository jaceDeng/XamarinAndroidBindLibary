using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='FaceDetector']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/FaceDetector", DoNotGenerateAcw=true)]
	public partial class FaceDetector : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/FaceDetector", typeof (FaceDetector));
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

		protected FaceDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Iflytek.Cloud.FaceDetector Detector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='FaceDetector']/method[@name='getDetector' and count(parameter)=0]"
			[Register ("getDetector", "()Lcom/iflytek/cloud/FaceDetector;", "")]
			get {
				const string __id = "getDetector.()Lcom/iflytek/cloud/FaceDetector;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.FaceDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='FaceDetector']/method[@name='createDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createDetector", "(Landroid/content/Context;Ljava/lang/String;)Lcom/iflytek/cloud/FaceDetector;", "")]
		public static unsafe global::Com.Iflytek.Cloud.FaceDetector CreateDetector (global::Android.Content.Context p0, string p1)
		{
			const string __id = "createDetector.(Landroid/content/Context;Ljava/lang/String;)Lcom/iflytek/cloud/FaceDetector;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.FaceDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_detectARGB_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetDetectARGB_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_detectARGB_Landroid_graphics_Bitmap_ == null)
				cb_detectARGB_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DetectARGB_Landroid_graphics_Bitmap_);
			return cb_detectARGB_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_DetectARGB_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.FaceDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DetectARGB (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='FaceDetector']/method[@name='detectARGB' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("detectARGB", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetDetectARGB_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe string DetectARGB (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "detectARGB.(Landroid/graphics/Bitmap;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_detectGray_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetDetectGray_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_detectGray_Landroid_graphics_Bitmap_ == null)
				cb_detectGray_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DetectGray_Landroid_graphics_Bitmap_);
			return cb_detectGray_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_DetectGray_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.FaceDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DetectGray (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='FaceDetector']/method[@name='detectGray' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("detectGray", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetDetectGray_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe string DetectGray (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "detectGray.(Landroid/graphics/Bitmap;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_trackNV21_arrayBIIII;
#pragma warning disable 0169
		static Delegate GetTrackNV21_arrayBIIIIHandler ()
		{
			if (cb_trackNV21_arrayBIIII == null)
				cb_trackNV21_arrayBIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIII_L) n_TrackNV21_arrayBIIII);
			return cb_trackNV21_arrayBIIII;
		}

		static IntPtr n_TrackNV21_arrayBIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.FaceDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.TrackNV21 (p0, p1, p2, p3, p4));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='FaceDetector']/method[@name='trackNV21' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("trackNV21", "([BIIII)Ljava/lang/String;", "GetTrackNV21_arrayBIIIIHandler")]
		public virtual unsafe string TrackNV21 (byte[] p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "trackNV21.([BIIII)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
