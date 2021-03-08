using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Msc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']"
	[global::Android.Runtime.Register ("com/iflytek/msc/MSC", DoNotGenerateAcw=true)]
	public partial class MSC : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/MSC", typeof (MSC));
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

		protected MSC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/constructor[@name='MSC' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MSC ()
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

		public static unsafe bool IsIflyVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='isIflyVersion' and count(parameter)=0]"
			[Register ("isIflyVersion", "()Z", "")]
			get {
				const string __id = "isIflyVersion.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='isLoaded' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUIClear' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("AIUIClear", "([C)I", "")]
		public static unsafe int AIUIClear (char[] p0)
		{
			const string __id = "AIUIClear.([C)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUIDataWrite' and count(parameter)=6 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("AIUIDataWrite", "([C[B[B[BILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int AIUIDataWrite (char[] p0, byte[] p1, byte[] p2, byte[] p3, int p4, global::Com.Iflytek.Msc.MSCSessionInfo p5)
		{
			const string __id = "AIUIDataWrite.([C[B[B[BILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUIGetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("AIUIGetParam", "([C[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int AIUIGetParam (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "AIUIGetParam.([C[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUIRegisterNotify' and count(parameter)=7 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Object']]"
		[Register ("AIUIRegisterNotify", "([CLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I", "")]
		public static unsafe int AIUIRegisterNotify (char[] p0, string p1, string p2, string p3, string p4, string p5, global::Java.Lang.Object p6)
		{
			const string __id = "AIUIRegisterNotify.([CLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p6);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUISendLog' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("AIUISendLog", "([C[B[BILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int AIUISendLog (char[] p0, byte[] p1, byte[] p2, int p3, global::Com.Iflytek.Msc.MSCSessionInfo p4)
		{
			const string __id = "AIUISendLog.([C[B[BILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUISessionBegin' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("AIUISessionBegin", "([BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] AIUISessionBegin (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "AIUISessionBegin.([BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUISessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("AIUISessionEnd", "([C[B)I", "")]
		public static unsafe int AIUISessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "AIUISessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUISetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("AIUISetParam", "([C[B[B)I", "")]
		public static unsafe int AIUISetParam (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "AIUISetParam.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='AIUISyncData' and count(parameter)=6 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("AIUISyncData", "([C[B[BIILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int AIUISyncData (char[] p0, byte[] p1, byte[] p2, int p3, int p4, global::Com.Iflytek.Msc.MSCSessionInfo p5)
		{
			const string __id = "AIUISyncData.([C[B[BIILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='DebugLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("DebugLog", "(Z)I", "")]
		public static unsafe int DebugLog (bool p0)
		{
			const string __id = "DebugLog.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRDataWrite' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("QHCRDataWrite", "([C[B[BII)I", "")]
		public static unsafe int QHCRDataWrite (char[] p0, byte[] p1, byte[] p2, int p3, int p4)
		{
			const string __id = "QHCRDataWrite.([C[B[BII)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRFini' and count(parameter)=0]"
		[Register ("QHCRFini", "()I", "")]
		public static unsafe int QHCRFini ()
		{
			const string __id = "QHCRFini.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRGetResult' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QHCRGetResult", "([C[BLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QHCRGetResult (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QHCRGetResult.([C[BLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRInit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("QHCRInit", "([B)I", "")]
		public static unsafe int QHCRInit (byte[] p0)
		{
			const string __id = "QHCRInit.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRLogEvent' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QHCRLogEvent", "([C[B[B)I", "")]
		public static unsafe int QHCRLogEvent (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QHCRLogEvent.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRSessionBegin' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QHCRSessionBegin", "([BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QHCRSessionBegin (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QHCRSessionBegin.([BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QHCRSessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QHCRSessionEnd", "([C[B)I", "")]
		public static unsafe int QHCRSessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QHCRSessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIFDFacedetect' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("QIFDFacedetect", "(Landroid/graphics/Bitmap;ILjava/lang/Object;)[B", "")]
		public static unsafe byte[] QIFDFacedetect (global::Android.Graphics.Bitmap p0, int p1, global::Java.Lang.Object p2)
		{
			const string __id = "QIFDFacedetect.(Landroid/graphics/Bitmap;ILjava/lang/Object;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIFDFini' and count(parameter)=0]"
		[Register ("QIFDFini", "()I", "")]
		public static unsafe int QIFDFini ()
		{
			const string __id = "QIFDFini.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIFDInit' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("QIFDInit", "([BLjava/lang/Object;)V", "")]
		public static unsafe void QIFDInit (byte[] p0, global::Java.Lang.Object p1)
		{
			const string __id = "QIFDInit.([BLjava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIFDMultitracker' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.Object']]"
		[Register ("QIFDMultitracker", "([BIIIIILjava/lang/Object;)[B", "")]
		public static unsafe byte[] QIFDMultitracker (byte[] p0, int p1, int p2, int p3, int p4, int p5, global::Java.Lang.Object p6)
		{
			const string __id = "QIFDMultitracker.([BIIIIILjava/lang/Object;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p6);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISEAudioWrite' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISEAudioWrite", "([C[BIILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QISEAudioWrite (char[] p0, byte[] p1, int p2, int p3, global::Com.Iflytek.Msc.MSCSessionInfo p4)
		{
			const string __id = "QISEAudioWrite.([C[BIILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISEFini' and count(parameter)=0]"
		[Register ("QISEFini", "()I", "")]
		public static unsafe int QISEFini ()
		{
			const string __id = "QISEFini.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISEGetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISEGetParam", "([C[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QISEGetParam (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISEGetParam.([C[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISEGetResult' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISEGetResult", "([CLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QISEGetResult (char[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QISEGetResult.([CLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISEInit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("QISEInit", "([B)I", "")]
		public static unsafe int QISEInit (byte[] p0)
		{
			const string __id = "QISEInit.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISESessionBegin' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISESessionBegin", "([B[BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QISESessionBegin (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISESessionBegin.([B[BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISESessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QISESessionEnd", "([C[B)I", "")]
		public static unsafe int QISESessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QISESessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISETextPut' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QISETextPut", "([C[B[B)I", "")]
		public static unsafe int QISETextPut (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QISETextPut.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRAudioWrite' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISRAudioWrite", "([C[BIILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QISRAudioWrite (char[] p0, byte[] p1, int p2, int p3, global::Com.Iflytek.Msc.MSCSessionInfo p4)
		{
			const string __id = "QISRAudioWrite.([C[BIILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRBuildGrammar' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object']]"
		[Register ("QISRBuildGrammar", "([B[BI[BLjava/lang/String;Ljava/lang/Object;)I", "")]
		public static unsafe int QISRBuildGrammar (byte[] p0, byte[] p1, int p2, byte[] p3, string p4, global::Java.Lang.Object p5)
		{
			const string __id = "QISRBuildGrammar.([B[BI[BLjava/lang/String;Ljava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRFini' and count(parameter)=0]"
		[Register ("QISRFini", "()I", "")]
		public static unsafe int QISRFini ()
		{
			const string __id = "QISRFini.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRGetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISRGetParam", "([C[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QISRGetParam (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISRGetParam.([C[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRGetResult' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISRGetResult", "([CLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QISRGetResult (char[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QISRGetResult.([CLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRGrammarActivate' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QISRGrammarActivate", "([C[B[B)I", "")]
		public static unsafe int QISRGrammarActivate (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QISRGrammarActivate.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRInit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("QISRInit", "([B)I", "")]
		public static unsafe int QISRInit (byte[] p0)
		{
			const string __id = "QISRInit.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRLogEvent' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QISRLogEvent", "([C[B[B)I", "")]
		public static unsafe int QISRLogEvent (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QISRLogEvent.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRRegisterNotify' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object']]"
		[Register ("QISRRegisterNotify", "([CLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I", "")]
		public static unsafe int QISRRegisterNotify (char[] p0, string p1, string p2, string p3, global::Java.Lang.Object p4)
		{
			const string __id = "QISRRegisterNotify.([CLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRSessionBegin' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISRSessionBegin", "([B[BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QISRSessionBegin (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISRSessionBegin.([B[BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRSessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QISRSessionEnd", "([C[B)I", "")]
		public static unsafe int QISRSessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QISRSessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRSetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QISRSetParam", "([C[B[B)I", "")]
		public static unsafe int QISRSetParam (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QISRSetParam.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRUpdateLexicon' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object']]"
		[Register ("QISRUpdateLexicon", "([B[BI[BLjava/lang/String;Ljava/lang/Object;)I", "")]
		public static unsafe int QISRUpdateLexicon (byte[] p0, byte[] p1, int p2, byte[] p3, string p4, global::Java.Lang.Object p5)
		{
			const string __id = "QISRUpdateLexicon.([B[BI[BLjava/lang/String;Ljava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISRUploadData' and count(parameter)=6 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISRUploadData", "([C[B[BI[BLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QISRUploadData (char[] p0, byte[] p1, byte[] p2, int p3, byte[] p4, global::Com.Iflytek.Msc.MSCSessionInfo p5)
		{
			const string __id = "QISRUploadData.([C[B[BI[BLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVAudioWrite' and count(parameter)=6 and parameter[1][@type='char[]'] and parameter[2][@type='char[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISVAudioWrite", "([C[C[BIILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QISVAudioWrite (char[] p0, char[] p1, byte[] p2, int p3, int p4, global::Com.Iflytek.Msc.MSCSessionInfo p5)
		{
			const string __id = "QISVAudioWrite.([C[C[BIILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVFini' and count(parameter)=0]"
		[Register ("QISVFini", "()I", "")]
		public static unsafe int QISVFini ()
		{
			const string __id = "QISVFini.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVGetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISVGetParam", "([C[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QISVGetParam (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISVGetParam.([C[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVGetResult' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='char[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISVGetResult", "([C[CLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QISVGetResult (char[] p0, char[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISVGetResult.([C[CLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVInit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("QISVInit", "([B)I", "")]
		public static unsafe int QISVInit (byte[] p0)
		{
			const string __id = "QISVInit.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVQueDelModel' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISVQueDelModel", "([B[BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QISVQueDelModel (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISVQueDelModel.([B[BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVQueDelModelRelease' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("QISVQueDelModelRelease", "([C)I", "")]
		public static unsafe int QISVQueDelModelRelease (char[] p0)
		{
			const string __id = "QISVQueDelModelRelease.([C)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVSessionBegin' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QISVSessionBegin", "([B[BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QISVSessionBegin (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QISVSessionBegin.([B[BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QISVSessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QISVSessionEnd", "([C[B)I", "")]
		public static unsafe int QISVSessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QISVSessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIVWAudioWrite' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QIVWAudioWrite", "([C[BIILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QIVWAudioWrite (char[] p0, byte[] p1, int p2, int p3, global::Com.Iflytek.Msc.MSCSessionInfo p4)
		{
			const string __id = "QIVWAudioWrite.([C[BIILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIVWGetResInfo' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QIVWGetResInfo", "([B[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QIVWGetResInfo (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QIVWGetResInfo.([B[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIVWRegisterNotify' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("QIVWRegisterNotify", "([CLjava/lang/String;Ljava/lang/Object;)I", "")]
		public static unsafe int QIVWRegisterNotify (char[] p0, string p1, global::Java.Lang.Object p2)
		{
			const string __id = "QIVWRegisterNotify.([CLjava/lang/String;Ljava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIVWResMerge' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QIVWResMerge", "([B[B[B)I", "")]
		public static unsafe int QIVWResMerge (byte[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QIVWResMerge.([B[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIVWSessionBegin' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QIVWSessionBegin", "([B[BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QIVWSessionBegin (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QIVWSessionBegin.([B[BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QIVWSessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QIVWSessionEnd", "([C[B)I", "")]
		public static unsafe int QIVWSessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QIVWSessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVDataWrite' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMFVDataWrite", "([C[B[BILcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QMFVDataWrite (char[] p0, byte[] p1, byte[] p2, int p3, global::Com.Iflytek.Msc.MSCSessionInfo p4)
		{
			const string __id = "QMFVDataWrite.([C[B[BILcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVGetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMFVGetParam", "([C[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QMFVGetParam (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QMFVGetParam.([C[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVGetResult' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMFVGetResult", "([CLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QMFVGetResult (char[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QMFVGetResult.([CLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVRegisterNotify' and count(parameter)=5 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object']]"
		[Register ("QMFVRegisterNotify", "([CLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I", "")]
		public static unsafe int QMFVRegisterNotify (char[] p0, string p1, string p2, string p3, global::Java.Lang.Object p4)
		{
			const string __id = "QMFVRegisterNotify.([CLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVSessionBegin' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMFVSessionBegin", "([BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QMFVSessionBegin (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QMFVSessionBegin.([BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVSessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QMFVSessionEnd", "([C[B)I", "")]
		public static unsafe int QMFVSessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QMFVSessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMFVSetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QMFVSetParam", "([C[B[B)I", "")]
		public static unsafe int QMFVSetParam (char[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QMFVSetParam.([C[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPDownload' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.Object']]"
		[Register ("QMSPDownload", "([B[BLjava/lang/Object;)I", "")]
		public static unsafe int QMSPDownload (byte[] p0, byte[] p1, global::Java.Lang.Object p2)
		{
			const string __id = "QMSPDownload.([B[BLjava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPDownloadData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMSPDownloadData", "([BLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QMSPDownloadData (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QMSPDownloadData.([BLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPGetParam' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMSPGetParam", "([BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QMSPGetParam (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QMSPGetParam.([BLcom/iflytek/msc/MSCSessionInfo;)I";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPGetVersion' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMSPGetVersion", "([BLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QMSPGetVersion (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QMSPGetVersion.([BLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPLogOut' and count(parameter)=0]"
		[Register ("QMSPLogOut", "()I", "")]
		public static unsafe int QMSPLogOut ()
		{
			const string __id = "QMSPLogOut.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPLogin' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("QMSPLogin", "([B[B[B)I", "")]
		public static unsafe int QMSPLogin (byte[] p0, byte[] p1, byte[] p2)
		{
			const string __id = "QMSPLogin.([B[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPRegisterNotify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("QMSPRegisterNotify", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int QMSPRegisterNotify (string p0, string p1)
		{
			const string __id = "QMSPRegisterNotify.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPSearch' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMSPSearch", "([B[BLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QMSPSearch (byte[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QMSPSearch.([B[BLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPSetParam' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("QMSPSetParam", "([B[B)I", "")]
		public static unsafe int QMSPSetParam (byte[] p0, byte[] p1)
		{
			const string __id = "QMSPSetParam.([B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QMSPUploadData' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QMSPUploadData", "([B[BI[BLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QMSPUploadData (byte[] p0, byte[] p1, int p2, byte[] p3, global::Com.Iflytek.Msc.MSCSessionInfo p4)
		{
			const string __id = "QMSPUploadData.([B[BI[BLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSAudioGet' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QTTSAudioGet", "([CLcom/iflytek/msc/MSCSessionInfo;)[B", "")]
		public static unsafe byte[] QTTSAudioGet (char[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QTTSAudioGet.([CLcom/iflytek/msc/MSCSessionInfo;)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSAudioInfo' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("QTTSAudioInfo", "([C)[C", "")]
		public static unsafe char[] QTTSAudioInfo (char[] p0)
		{
			const string __id = "QTTSAudioInfo.([C)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSFini' and count(parameter)=0]"
		[Register ("QTTSFini", "()I", "")]
		public static unsafe int QTTSFini ()
		{
			const string __id = "QTTSFini.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSGetParam' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QTTSGetParam", "([C[BLcom/iflytek/msc/MSCSessionInfo;)I", "")]
		public static unsafe int QTTSGetParam (char[] p0, byte[] p1, global::Com.Iflytek.Msc.MSCSessionInfo p2)
		{
			const string __id = "QTTSGetParam.([C[BLcom/iflytek/msc/MSCSessionInfo;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSInit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("QTTSInit", "([B)I", "")]
		public static unsafe int QTTSInit (byte[] p0)
		{
			const string __id = "QTTSInit.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSSessionBegin' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.iflytek.msc.MSCSessionInfo']]"
		[Register ("QTTSSessionBegin", "([BLcom/iflytek/msc/MSCSessionInfo;)[C", "")]
		public static unsafe char[] QTTSSessionBegin (byte[] p0, global::Com.Iflytek.Msc.MSCSessionInfo p1)
		{
			const string __id = "QTTSSessionBegin.([BLcom/iflytek/msc/MSCSessionInfo;)[C";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSSessionEnd' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QTTSSessionEnd", "([C[B)I", "")]
		public static unsafe int QTTSSessionEnd (char[] p0, byte[] p1)
		{
			const string __id = "QTTSSessionEnd.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='QTTSTextPut' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='byte[]']]"
		[Register ("QTTSTextPut", "([C[B)I", "")]
		public static unsafe int QTTSTextPut (char[] p0, byte[] p1)
		{
			const string __id = "QTTSTextPut.([C[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='SetLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetLogLevel", "(I)I", "")]
		public static unsafe int SetLogLevel (int p0)
		{
			const string __id = "SetLogLevel.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='UMSPLogin' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.Object']]"
		[Register ("UMSPLogin", "([B[B[BLjava/lang/Object;)I", "")]
		public static unsafe int UMSPLogin (byte[] p0, byte[] p1, byte[] p2, global::Java.Lang.Object p3)
		{
			const string __id = "UMSPLogin.([B[B[BLjava/lang/Object;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='doARGB2Gray' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("doARGB2Gray", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)Z", "")]
		public static unsafe bool DoARGB2Gray (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Bitmap p1)
		{
			const string __id = "doARGB2Gray.(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='getFileDescriptorFD' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("getFileDescriptorFD", "(Ljava/io/FileDescriptor;)I", "")]
		public static unsafe int GetFileDescriptorFD (global::Java.IO.FileDescriptor p0)
		{
			const string __id = "getFileDescriptorFD.(Ljava/io/FileDescriptor;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSC']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool LoadLibrary (string p0)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
