using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Msc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']"
	[global::Android.Runtime.Register ("com/iflytek/msc/MSCSessionInfo", DoNotGenerateAcw=true)]
	public partial class MSCSessionInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/field[@name='buffer']"
		[Register ("buffer")]
		public IList<byte> Buffer {
			get {
				const string __id = "buffer.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buffer.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/field[@name='buflen']"
		[Register ("buflen")]
		public int Buflen {
			get {
				const string __id = "buflen.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "buflen.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/field[@name='epstatues']"
		[Register ("epstatues")]
		public int Epstatues {
			get {
				const string __id = "epstatues.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "epstatues.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/field[@name='errorcode']"
		[Register ("errorcode")]
		public int Errorcode {
			get {
				const string __id = "errorcode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorcode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/field[@name='rsltstatus']"
		[Register ("rsltstatus")]
		public int Rsltstatus {
			get {
				const string __id = "rsltstatus.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rsltstatus.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/field[@name='sesstatus']"
		[Register ("sesstatus")]
		public int Sesstatus {
			get {
				const string __id = "sesstatus.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sesstatus.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/MSCSessionInfo", typeof (MSCSessionInfo));
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

		protected MSCSessionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='MSCSessionInfo']/constructor[@name='MSCSessionInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MSCSessionInfo ()
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

	}
}
