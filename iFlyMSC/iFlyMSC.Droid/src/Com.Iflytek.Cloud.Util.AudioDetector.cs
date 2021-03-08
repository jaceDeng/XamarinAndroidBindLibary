using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/util/AudioDetector", DoNotGenerateAcw=true)]
	public abstract partial class AudioDetector : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='DEF_BOS']"
		[Register ("DEF_BOS")]
		public const int DefBos = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='DEF_ENGINE_TYPE']"
		[Register ("DEF_ENGINE_TYPE")]
		public const string DefEngineType = (string) "fixfront";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='DEF_EOS']"
		[Register ("DEF_EOS")]
		public const int DefEos = (int) 700;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='DEF_RATE']"
		[Register ("DEF_RATE")]
		public const int DefRate = (int) 16000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='EARLY_START']"
		[Register ("EARLY_START")]
		public const string EarlyStart = (string) "early_start";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='MAX_BUF_LEN']"
		[Register ("MAX_BUF_LEN")]
		public const int MaxBufLen = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='REDUCE_FLOW']"
		[Register ("REDUCE_FLOW")]
		public const string ReduceFlow = (string) "vad_reduce_flow";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='RESET_SENTENCE']"
		[Register ("RESET_SENTENCE")]
		public const string ResetSentence = (string) "reset_sentence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='RES_PATH']"
		[Register ("RES_PATH")]
		public const string ResPath = (string) "vad_res_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='SUB_TIMEOUT']"
		[Register ("SUB_TIMEOUT")]
		public const string SubTimeout = (string) "sub_timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='THRESHOLD']"
		[Register ("THRESHOLD")]
		public const string Threshold = (string) "threshold";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='TYPE_FIXFRONT']"
		[Register ("TYPE_FIXFRONT")]
		public const string TypeFixfront = (string) "fixfront";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='TYPE_META']"
		[Register ("TYPE_META")]
		public const string TypeMeta = (string) "meta";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='VAD_ENGINE']"
		[Register ("VAD_ENGINE")]
		public const string VadEngine = (string) "vad_engine";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='a']"
		[Register ("a")]
		protected static global::Com.Iflytek.Cloud.Util.AudioDetector A {
			get {
				const string __id = "a.Lcom/iflytek/cloud/util/AudioDetector;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/iflytek/cloud/util/AudioDetector;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/field[@name='b']"
		[Register ("b")]
		protected static global::Java.Lang.Object B {
			get {
				const string __id = "b.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']"
		[global::Android.Runtime.Register ("com/iflytek/cloud/util/AudioDetector$DetectorResult", DoNotGenerateAcw=true)]
		public partial class DetectorResult : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='STATUS_BOS']"
			[Register ("STATUS_BOS")]
			public const int StatusBos = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='STATUS_EOS']"
			[Register ("STATUS_EOS")]
			public const int StatusEos = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='STATUS_OK']"
			[Register ("STATUS_OK")]
			public const int StatusOk = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='STATUS_START']"
			[Register ("STATUS_START")]
			public const int StatusStart = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='STATUS_TIMEOUT']"
			[Register ("STATUS_TIMEOUT")]
			public const int StatusTimeout = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='SUB_END']"
			[Register ("SUB_END")]
			public const int SubEnd = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='SUB_OK']"
			[Register ("SUB_OK")]
			public const int SubOk = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='SUB_START']"
			[Register ("SUB_START")]
			public const int SubStart = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='SUB_STARTEND']"
			[Register ("SUB_STARTEND")]
			public const int SubStartend = (int) 3;


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='buffer']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='confidence']"
			[Register ("confidence")]
			public float Confidence {
				get {
					const string __id = "confidence.F";

					var __v = _members.InstanceFields.GetSingleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "confidence.F";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='end']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='error']"
			[Register ("error")]
			public int Error {
				get {
					const string __id = "error.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "error.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='length']"
			[Register ("length")]
			public int Length {
				get {
					const string __id = "length.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "length.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='offset']"
			[Register ("offset")]
			public int Offset {
				get {
					const string __id = "offset.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "offset.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='quality']"
			[Register ("quality")]
			public int Quality {
				get {
					const string __id = "quality.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "quality.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='start']"
			[Register ("start")]
			public int Start {
				get {
					const string __id = "start.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "start.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='status']"
			[Register ("status")]
			public int Status {
				get {
					const string __id = "status.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "status.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='sub']"
			[Register ("sub")]
			public int Sub {
				get {
					const string __id = "sub.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sub.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='subs']"
			[Register ("subs")]
			public global::Java.Util.LinkedHashMap Subs {
				get {
					const string __id = "subs.Ljava/util/LinkedHashMap;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "subs.Ljava/util/LinkedHashMap;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='voice']"
			[Register ("voice")]
			public bool Voice {
				get {
					const string __id = "voice.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "voice.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/field[@name='volume']"
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
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/AudioDetector$DetectorResult", typeof (DetectorResult));
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

			protected DetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector.DetectorResult']/constructor[@name='AudioDetector.DetectorResult' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DetectorResult ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/AudioDetector", typeof (AudioDetector));
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

		protected AudioDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/constructor[@name='AudioDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		protected unsafe AudioDetector (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		public static unsafe global::Com.Iflytek.Cloud.Util.AudioDetector Detector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='getDetector' and count(parameter)=0]"
			[Register ("getDetector", "()Lcom/iflytek/cloud/util/AudioDetector;", "")]
			get {
				const string __id = "getDetector.()Lcom/iflytek/cloud/util/AudioDetector;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='createDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createDetector", "(Landroid/content/Context;Ljava/lang/String;)Lcom/iflytek/cloud/util/AudioDetector;", "")]
		public static unsafe global::Com.Iflytek.Cloud.Util.AudioDetector CreateDetector (global::Android.Content.Context p0, string p1)
		{
			const string __id = "createDetector.(Landroid/content/Context;Ljava/lang/String;)Lcom/iflytek/cloud/util/AudioDetector;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Destroy);
			return cb_destroy;
		}

		static bool n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()Z", "GetDestroyHandler")]
		public abstract bool Destroy ();

		static Delegate cb_detect_arrayBIIZ;
#pragma warning disable 0169
		static Delegate GetDetect_arrayBIIZHandler ()
		{
			if (cb_detect_arrayBIIZ == null)
				cb_detect_arrayBIIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_L) n_Detect_arrayBIIZ);
			return cb_detect_arrayBIIZ;
		}

		static IntPtr n_Detect_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Detect (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='detect' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("detect", "([BIIZ)Lcom/iflytek/cloud/util/AudioDetector$DetectorResult;", "GetDetect_arrayBIIZHandler")]
		public abstract global::Com.Iflytek.Cloud.Util.AudioDetector.DetectorResult Detect (byte[] p0, int p1, int p2, bool p3);

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public abstract void Reset ();

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetParameter (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void SetParameter (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/util/AudioDetector", DoNotGenerateAcw=true)]
	internal partial class AudioDetectorInvoker : AudioDetector {

		public AudioDetectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/AudioDetector", typeof (AudioDetectorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()Z", "GetDestroyHandler")]
		public override unsafe bool Destroy ()
		{
			const string __id = "destroy.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='detect' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("detect", "([BIIZ)Lcom/iflytek/cloud/util/AudioDetector$DetectorResult;", "GetDetect_arrayBIIZHandler")]
		public override unsafe global::Com.Iflytek.Cloud.Util.AudioDetector.DetectorResult Detect (byte[] p0, int p1, int p2, bool p3)
		{
			const string __id = "detect.([BIIZ)Lcom/iflytek/cloud/util/AudioDetector$DetectorResult;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.AudioDetector.DetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public override unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='AudioDetector']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void SetParameter (string p0, string p1)
		{
			const string __id = "setParameter.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
