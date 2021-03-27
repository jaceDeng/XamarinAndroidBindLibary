using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/iflytek/speech/Version", DoNotGenerateAcw=true)]
	public partial class Version : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/Version", typeof (Version));
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

		protected Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='Version']/constructor[@name='Version' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Version ()
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

		public static unsafe string VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='Version']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVersionCode.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string VersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='Version']/method[@name='getVersionName' and count(parameter)=0]"
			[Register ("getVersionName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
