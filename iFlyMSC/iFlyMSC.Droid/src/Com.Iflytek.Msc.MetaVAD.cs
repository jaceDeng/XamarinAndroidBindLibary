using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Msc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']"
	[global::Android.Runtime.Register ("com/iflytek/msc/MetaVAD", DoNotGenerateAcw=true)]
	public partial class MetaVAD : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']"
		[global::Android.Runtime.Register ("com/iflytek/msc/MetaVAD$Instance", DoNotGenerateAcw=true)]
		public partial class Instance : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='INVALID_HANDLE']"
			[Register ("INVALID_HANDLE")]
			public const long InvalidHandle = (long) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='SEG']"
			[Register ("SEG")]
			public const sbyte Seg = (sbyte) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='SEG_FIRST']"
			[Register ("SEG_FIRST")]
			public const sbyte SegFirst = (sbyte) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='SEG_LAST']"
			[Register ("SEG_LAST")]
			public const sbyte SegLast = (sbyte) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='SEG_NONE']"
			[Register ("SEG_NONE")]
			public const sbyte SegNone = (sbyte) 0;


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='begin']"
			[Register ("begin")]
			public int Begin {
				get {
					const string __id = "begin.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "begin.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='end']"
			[Register ("end")]
			public int End {
				get {
					const string __id = "end.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "end.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='handle']"
			[Register ("handle")]
			public long Handle {
				get {
					const string __id = "handle.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "handle.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='rate']"
			[Register ("rate")]
			public int Rate {
				get {
					const string __id = "rate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "rate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/field[@name='volume']"
			[Register ("volume")]
			public int Volume {
				get {
					const string __id = "volume.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "volume.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/MetaVAD$Instance", typeof (Instance));
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

			protected Instance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/constructor[@name='MetaVAD.Instance' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Instance ()
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

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Msc.MetaVAD.Instance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD.Instance']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "GetAHandler")]
			public virtual unsafe void A ()
			{
				const string __id = "a.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/MetaVAD", typeof (MetaVAD));
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

		protected MetaVAD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/constructor[@name='MetaVAD' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MetaVAD ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADAppendPCM' and count(parameter)=5 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("VADAppendPCM", "(Lcom/iflytek/msc/MetaVAD$Instance;[BIII)I", "")]
		public static unsafe int VADAppendPCM (global::Com.Iflytek.Msc.MetaVAD.Instance p0, byte[] p1, int p2, int p3, int p4)
		{
			const string __id = "VADAppendPCM.(Lcom/iflytek/msc/MetaVAD$Instance;[BIII)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADCreateSession' and count(parameter)=1 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance']]"
		[Register ("VADCreateSession", "(Lcom/iflytek/msc/MetaVAD$Instance;)I", "")]
		public static unsafe int VADCreateSession (global::Com.Iflytek.Msc.MetaVAD.Instance p0)
		{
			const string __id = "VADCreateSession.(Lcom/iflytek/msc/MetaVAD$Instance;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADDelResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("VADDelResource", "(I)I", "")]
		public static unsafe int VADDelResource (int p0)
		{
			const string __id = "VADDelResource.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADDestroySession' and count(parameter)=1 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance']]"
		[Register ("VADDestroySession", "(Lcom/iflytek/msc/MetaVAD$Instance;)I", "")]
		public static unsafe int VADDestroySession (global::Com.Iflytek.Msc.MetaVAD.Instance p0)
		{
			const string __id = "VADDestroySession.(Lcom/iflytek/msc/MetaVAD$Instance;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADGetSeg' and count(parameter)=1 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance']]"
		[Register ("VADGetSeg", "(Lcom/iflytek/msc/MetaVAD$Instance;)I", "")]
		public static unsafe int VADGetSeg (global::Com.Iflytek.Msc.MetaVAD.Instance p0)
		{
			const string __id = "VADGetSeg.(Lcom/iflytek/msc/MetaVAD$Instance;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADGetSentConfidence' and count(parameter)=1 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance']]"
		[Register ("VADGetSentConfidence", "(Lcom/iflytek/msc/MetaVAD$Instance;)F", "")]
		public static unsafe float VADGetSentConfidence (global::Com.Iflytek.Msc.MetaVAD.Instance p0)
		{
			const string __id = "VADGetSentConfidence.(Lcom/iflytek/msc/MetaVAD$Instance;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADInitialize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("VADInitialize", "([B)I", "")]
		public static unsafe int VADInitialize (byte[] p0)
		{
			const string __id = "VADInitialize.([B)I";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADLoadResource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("VADLoadResource", "(I[B)I", "")]
		public static unsafe int VADLoadResource (int p0, byte[] p1)
		{
			const string __id = "VADLoadResource.(I[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADResetSentence' and count(parameter)=1 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance']]"
		[Register ("VADResetSentence", "(Lcom/iflytek/msc/MetaVAD$Instance;)I", "")]
		public static unsafe int VADResetSentence (global::Com.Iflytek.Msc.MetaVAD.Instance p0)
		{
			const string __id = "VADResetSentence.(Lcom/iflytek/msc/MetaVAD$Instance;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADResetSession' and count(parameter)=1 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance']]"
		[Register ("VADResetSession", "(Lcom/iflytek/msc/MetaVAD$Instance;)I", "")]
		public static unsafe int VADResetSession (global::Com.Iflytek.Msc.MetaVAD.Instance p0)
		{
			const string __id = "VADResetSession.(Lcom/iflytek/msc/MetaVAD$Instance;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADSetParam' and count(parameter)=3 and parameter[1][@type='com.iflytek.msc.MetaVAD.Instance'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("VADSetParam", "(Lcom/iflytek/msc/MetaVAD$Instance;[B[B)I", "")]
		public static unsafe int VADSetParam (global::Com.Iflytek.Msc.MetaVAD.Instance p0, byte[] p1, byte[] p2)
		{
			const string __id = "VADSetParam.(Lcom/iflytek/msc/MetaVAD$Instance;[B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MetaVAD']/method[@name='VADUninitialize' and count(parameter)=0]"
		[Register ("VADUninitialize", "()I", "")]
		public static unsafe int VADUninitialize ()
		{
			const string __id = "VADUninitialize.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
