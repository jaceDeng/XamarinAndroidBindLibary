using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/VerifierResult", DoNotGenerateAcw=true)]
	public partial class VerifierResult : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_EXTRA_RGN_SOPPORT']"
		[Register ("MSS_ERROR_IVP_EXTRA_RGN_SOPPORT")]
		public const int MssErrorIvpExtraRgnSopport = (int) 11601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_GENERAL']"
		[Register ("MSS_ERROR_IVP_GENERAL")]
		public const int MssErrorIvpGeneral = (int) 11600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_MUCH_NOISE']"
		[Register ("MSS_ERROR_IVP_MUCH_NOISE")]
		public const int MssErrorIvpMuchNoise = (int) 11603;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_NO_ENOUGH_AUDIO']"
		[Register ("MSS_ERROR_IVP_NO_ENOUGH_AUDIO")]
		public const int MssErrorIvpNoEnoughAudio = (int) 11608;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_TEXT_NOT_MATCH']"
		[Register ("MSS_ERROR_IVP_TEXT_NOT_MATCH")]
		public const int MssErrorIvpTextNotMatch = (int) 11607;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_TOO_LOW']"
		[Register ("MSS_ERROR_IVP_TOO_LOW")]
		public const int MssErrorIvpTooLow = (int) 11604;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_TRUNCATED']"
		[Register ("MSS_ERROR_IVP_TRUNCATED")]
		public const int MssErrorIvpTruncated = (int) 11602;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_UTTER_TOO_SHORT']"
		[Register ("MSS_ERROR_IVP_UTTER_TOO_SHORT")]
		public const int MssErrorIvpUtterTooShort = (int) 11606;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='MSS_ERROR_IVP_ZERO_AUDIO']"
		[Register ("MSS_ERROR_IVP_ZERO_AUDIO")]
		public const int MssErrorIvpZeroAudio = (int) 11605;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "VerifyResult";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='dcs']"
		[Register ("dcs")]
		public string Dcs {
			get {
				const string __id = "dcs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dcs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='err']"
		[Register ("err")]
		public int Err {
			get {
				const string __id = "err.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "err.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='ret']"
		[Register ("ret")]
		public int Ret {
			get {
				const string __id = "ret.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ret.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='rgn']"
		[Register ("rgn")]
		public int Rgn {
			get {
				const string __id = "rgn.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rgn.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='score']"
		[Register ("score")]
		public global::Java.Lang.Double Score {
			get {
				const string __id = "score.Ljava/lang/Double;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "score.Ljava/lang/Double;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='score_raw']"
		[Register ("score_raw")]
		public global::Java.Lang.Double ScoreRaw {
			get {
				const string __id = "score_raw.Ljava/lang/Double;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "score_raw.Ljava/lang/Double;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='source']"
		[Register ("source")]
		public string Source {
			get {
				const string __id = "source.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "source.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='sst']"
		[Register ("sst")]
		public string Sst {
			get {
				const string __id = "sst.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sst.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='suc']"
		[Register ("suc")]
		public int Suc {
			get {
				const string __id = "suc.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "suc.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='trs']"
		[Register ("trs")]
		public string Trs {
			get {
				const string __id = "trs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/field[@name='vid']"
		[Register ("vid")]
		public string Vid {
			get {
				const string __id = "vid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "vid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/VerifierResult", typeof (VerifierResult));
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

		protected VerifierResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='VerifierResult']/constructor[@name='VerifierResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe VerifierResult (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
