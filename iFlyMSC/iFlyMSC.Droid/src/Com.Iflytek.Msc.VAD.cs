using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Msc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']"
	[global::Android.Runtime.Register ("com/iflytek/msc/VAD", DoNotGenerateAcw=true)]
	public partial class VAD : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']"
		[global::Android.Runtime.Register ("com/iflytek/msc/VAD$VadData", DoNotGenerateAcw=true)]
		public partial class VadData : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='audioQuality']"
			[Register ("audioQuality")]
			public int AudioQuality {
				get {
					const string __id = "audioQuality.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "audioQuality.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='endByte']"
			[Register ("endByte")]
			public int EndByte {
				get {
					const string __id = "endByte.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "endByte.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='endRemainFrameNum']"
			[Register ("endRemainFrameNum")]
			public int EndRemainFrameNum {
				get {
					const string __id = "endRemainFrameNum.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "endRemainFrameNum.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='firstOutByte']"
			[Register ("firstOutByte")]
			public int FirstOutByte {
				get {
					const string __id = "firstOutByte.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "firstOutByte.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='inSpeech']"
			[Register ("inSpeech")]
			public int InSpeech {
				get {
					const string __id = "inSpeech.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "inSpeech.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='startByte']"
			[Register ("startByte")]
			public int StartByte {
				get {
					const string __id = "startByte.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "startByte.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='startRemainFrameNum']"
			[Register ("startRemainFrameNum")]
			public int StartRemainFrameNum {
				get {
					const string __id = "startRemainFrameNum.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "startRemainFrameNum.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='status']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='volumeLevel']"
			[Register ("volumeLevel")]
			public int VolumeLevel {
				get {
					const string __id = "volumeLevel.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "volumeLevel.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='waitPauseOrEnd']"
			[Register ("waitPauseOrEnd")]
			public int WaitPauseOrEnd {
				get {
					const string __id = "waitPauseOrEnd.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "waitPauseOrEnd.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='waitStart']"
			[Register ("waitStart")]
			public int WaitStart {
				get {
					const string __id = "waitStart.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "waitStart.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='wavData']"
			[Register ("wavData")]
			public IList<byte> WavData {
				get {
					const string __id = "wavData.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "wavData.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/field[@name='wavDataSize']"
			[Register ("wavDataSize")]
			public int WavDataSize {
				get {
					const string __id = "wavDataSize.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "wavDataSize.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/VAD$VadData", typeof (VadData));
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

			protected VadData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD.VadData']/constructor[@name='VAD.VadData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe VadData ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/msc/VAD", typeof (VAD));
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

		protected VAD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/constructor[@name='VAD' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VAD ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='AppendData' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("AppendData", "(J[BI)I", "")]
		public static unsafe int AppendData (long p0, byte[] p1, int p2)
		{
			const string __id = "AppendData.(J[BI)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='CalcVolumLevel' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='com.iflytek.msc.VAD.VadData']]"
		[Register ("CalcVolumLevel", "(J[BILcom/iflytek/msc/VAD$VadData;)I", "")]
		public static unsafe int CalcVolumLevel (long p0, byte[] p1, int p2, global::Com.Iflytek.Msc.VAD.VadData p3)
		{
			const string __id = "CalcVolumLevel.(J[BILcom/iflytek/msc/VAD$VadData;)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='EndAudioData' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("EndAudioData", "(J)I", "")]
		public static unsafe int EndAudioData (long p0)
		{
			const string __id = "EndAudioData.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='FetchData' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.iflytek.msc.VAD.VadData']]"
		[Register ("FetchData", "(JLcom/iflytek/msc/VAD$VadData;)I", "")]
		public static unsafe int FetchData (long p0, global::Com.Iflytek.Msc.VAD.VadData p1)
		{
			const string __id = "FetchData.(JLcom/iflytek/msc/VAD$VadData;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='GetLastSpeechPos' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.iflytek.msc.VAD.VadData']]"
		[Register ("GetLastSpeechPos", "(JLcom/iflytek/msc/VAD$VadData;)I", "")]
		public static unsafe int GetLastSpeechPos (long p0, global::Com.Iflytek.Msc.VAD.VadData p1)
		{
			const string __id = "GetLastSpeechPos.(JLcom/iflytek/msc/VAD$VadData;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='Initialize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Initialize", "(I)J", "")]
		public static unsafe long Initialize (int p0)
		{
			const string __id = "Initialize.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='Reset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Reset", "(J)V", "")]
		public static unsafe void Reset (long p0)
		{
			const string __id = "Reset.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='SetParam' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("SetParam", "(JII)I", "")]
		public static unsafe int SetParam (long p0, int p1, int p2)
		{
			const string __id = "SetParam.(JII)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.msc']/class[@name='VAD']/method[@name='Uninitialize' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Uninitialize", "(J)V", "")]
		public static unsafe void Uninitialize (long p0)
		{
			const string __id = "Uninitialize.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
