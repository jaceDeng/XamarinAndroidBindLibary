using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Msc.Ist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/msc/ist/MscTranscripter", DoNotGenerateAcw=true)]
	public partial class MscTranscripter : global::Java.Lang.Object, global::Com.Iflytek.Cloud.Record.PcmRecorder.IPcmRecordListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='MSG_CUSTOM_MIN']"
		[Register ("MSG_CUSTOM_MIN")]
		protected const int MsgCustomMin = (int) 32789;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mAudioSource']"
		[Register ("mAudioSource")]
		protected int MAudioSource {
			get {
				const string __id = "mAudioSource.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mAudioSource.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mDownflow']"
		[Register ("mDownflow")]
		public static int MDownflow {
			get {
				const string __id = "mDownflow.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "mDownflow.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mFirstDataArrival']"
		[Register ("mFirstDataArrival")]
		protected bool MFirstDataArrival {
			get {
				const string __id = "mFirstDataArrival.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mFirstDataArrival.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mFirstDataWrite']"
		[Register ("mFirstDataWrite")]
		protected bool MFirstDataWrite {
			get {
				const string __id = "mFirstDataWrite.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mFirstDataWrite.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mFirstRecordAudio']"
		[Register ("mFirstRecordAudio")]
		protected bool MFirstRecordAudio {
			get {
				const string __id = "mFirstRecordAudio.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mFirstRecordAudio.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::Com.Iflytek.Cloud.ITranscripterListener MListener {
			get {
				const string __id = "mListener.Lcom/iflytek/cloud/TranscripterListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mListener.Lcom/iflytek/cloud/TranscripterListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mRecorder']"
		[Register ("mRecorder")]
		protected global::Com.Iflytek.Cloud.Record.PcmRecorder MRecorder {
			get {
				const string __id = "mRecorder.Lcom/iflytek/cloud/record/PcmRecorder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Record.PcmRecorder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRecorder.Lcom/iflytek/cloud/record/PcmRecorder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mResults']"
		[Register ("mResults")]
		protected global::System.Collections.IList MResults {
			get {
				const string __id = "mResults.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mResults.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mSession']"
		[Register ("mSession")]
		protected global::Com.Iflytek.Cloud.Msc.Ist.IstSession MSession {
			get {
				const string __id = "mSession.Lcom/iflytek/cloud/msc/ist/IstSession;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.IstSession> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSession.Lcom/iflytek/cloud/msc/ist/IstSession;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mUpflow']"
		[Register ("mUpflow")]
		public static int MUpflow {
			get {
				const string __id = "mUpflow.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "mUpflow.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/field[@name='mUstopRecord']"
		[Register ("mUstopRecord")]
		protected bool MUstopRecord {
			get {
				const string __id = "mUstopRecord.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mUstopRecord.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/msc/ist/MscTranscripter", typeof (MscTranscripter));
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

		protected MscTranscripter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAudioPath;
#pragma warning disable 0169
		static Delegate GetGetAudioPathHandler ()
		{
			if (cb_getAudioPath == null)
				cb_getAudioPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioPath);
			return cb_getAudioPath;
		}

		static IntPtr n_GetAudioPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AudioPath);
		}
#pragma warning restore 0169

		public virtual unsafe string AudioPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getAudioPath' and count(parameter)=0]"
			[Register ("getAudioPath", "()Ljava/lang/String;", "GetGetAudioPathHandler")]
			get {
				const string __id = "getAudioPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioSource;
#pragma warning disable 0169
		static Delegate GetGetAudioSourceHandler ()
		{
			if (cb_getAudioSource == null)
				cb_getAudioSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioSource);
			return cb_getAudioSource;
		}

		static int n_GetAudioSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSource;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getAudioSource' and count(parameter)=0]"
			[Register ("getAudioSource", "()I", "GetGetAudioSourceHandler")]
			get {
				const string __id = "getAudioSource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getClientID;
#pragma warning disable 0169
		static Delegate GetGetClientIDHandler ()
		{
			if (cb_getClientID == null)
				cb_getClientID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientID);
			return cb_getClientID;
		}

		static IntPtr n_GetClientID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientID);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getClientID' and count(parameter)=0]"
			[Register ("getClientID", "()Ljava/lang/String;", "GetGetClientIDHandler")]
			get {
				const string __id = "getClientID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionID;
#pragma warning disable 0169
		static Delegate GetGetSessionIDHandler ()
		{
			if (cb_getSessionID == null)
				cb_getSessionID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSessionID);
			return cb_getSessionID;
		}

		static IntPtr n_GetSessionID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionID);
		}
#pragma warning restore 0169

		public virtual unsafe string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "GetGetSessionIDHandler")]
			get {
				const string __id = "getSessionID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSyncID;
#pragma warning disable 0169
		static Delegate GetGetSyncIDHandler ()
		{
			if (cb_getSyncID == null)
				cb_getSyncID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSyncID);
			return cb_getSyncID;
		}

		static int n_GetSyncID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SyncID;
		}
#pragma warning restore 0169

		public virtual unsafe int SyncID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getSyncID' and count(parameter)=0]"
			[Register ("getSyncID", "()I", "GetGetSyncIDHandler")]
			get {
				const string __id = "getSyncID.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTranscriptResult;
#pragma warning disable 0169
		static Delegate GetGetTranscriptResultHandler ()
		{
			if (cb_getTranscriptResult == null)
				cb_getTranscriptResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTranscriptResult);
			return cb_getTranscriptResult;
		}

		static IntPtr n_GetTranscriptResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranscriptResult);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Iflytek.Cloud.TranscripterResult TranscriptResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getTranscriptResult' and count(parameter)=0]"
			[Register ("getTranscriptResult", "()Lcom/iflytek/cloud/TranscripterResult;", "GetGetTranscriptResultHandler")]
			get {
				const string __id = "getTranscriptResult.()Lcom/iflytek/cloud/TranscripterResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.TranscripterResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUploadBytes;
#pragma warning disable 0169
		static Delegate GetGetUploadBytesHandler ()
		{
			if (cb_getUploadBytes == null)
				cb_getUploadBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetUploadBytes);
			return cb_getUploadBytes;
		}

		static int n_GetUploadBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UploadBytes;
		}
#pragma warning restore 0169

		public virtual unsafe int UploadBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='getUploadBytes' and count(parameter)=0]"
			[Register ("getUploadBytes", "()I", "GetGetUploadBytesHandler")]
			get {
				const string __id = "getUploadBytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_callbackVolume_arrayBI;
#pragma warning disable 0169
		static Delegate GetCallbackVolume_arrayBIHandler ()
		{
			if (cb_callbackVolume_arrayBI == null)
				cb_callbackVolume_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_CallbackVolume_arrayBI);
			return cb_callbackVolume_arrayBI;
		}

		static void n_CallbackVolume_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CallbackVolume (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='callbackVolume' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("callbackVolume", "([BI)V", "GetCallbackVolume_arrayBIHandler")]
		public virtual unsafe void CallbackVolume (byte[] p0, int p1)
		{
			const string __id = "callbackVolume.([BI)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onError_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onError_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onError_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_iflytek_cloud_SpeechError_);
			return cb_onError_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnError_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler")]
		public virtual unsafe void OnError (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			const string __id = "onError.(Lcom/iflytek/cloud/SpeechError;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onRecordBuffer_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnRecordBuffer_arrayBIIHandler ()
		{
			if (cb_onRecordBuffer_arrayBII == null)
				cb_onRecordBuffer_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnRecordBuffer_arrayBII);
			return cb_onRecordBuffer_arrayBII;
		}

		static void n_OnRecordBuffer_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnRecordBuffer (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='onRecordBuffer' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onRecordBuffer", "([BII)V", "GetOnRecordBuffer_arrayBIIHandler")]
		public virtual unsafe void OnRecordBuffer (byte[] p0, int p1, int p2)
		{
			const string __id = "onRecordBuffer.([BII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onRecordReleased;
#pragma warning disable 0169
		static Delegate GetOnRecordReleasedHandler ()
		{
			if (cb_onRecordReleased == null)
				cb_onRecordReleased = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRecordReleased);
			return cb_onRecordReleased;
		}

		static void n_OnRecordReleased (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRecordReleased ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='onRecordReleased' and count(parameter)=0]"
		[Register ("onRecordReleased", "()V", "GetOnRecordReleasedHandler")]
		public virtual unsafe void OnRecordReleased ()
		{
			const string __id = "onRecordReleased.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onRecordStarted_Z;
#pragma warning disable 0169
		static Delegate GetOnRecordStarted_ZHandler ()
		{
			if (cb_onRecordStarted_Z == null)
				cb_onRecordStarted_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnRecordStarted_Z);
			return cb_onRecordStarted_Z;
		}

		static void n_OnRecordStarted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRecordStarted (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='onRecordStarted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRecordStarted", "(Z)V", "GetOnRecordStarted_ZHandler")]
		public virtual unsafe void OnRecordStarted (bool p0)
		{
			const string __id = "onRecordStarted.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_proc_Msg_Netperf;
#pragma warning disable 0169
		static Delegate GetProc_Msg_NetperfHandler ()
		{
			if (cb_proc_Msg_Netperf == null)
				cb_proc_Msg_Netperf = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Proc_Msg_Netperf);
			return cb_proc_Msg_Netperf;
		}

		static void n_Proc_Msg_Netperf (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Proc_Msg_Netperf ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='proc_Msg_Netperf' and count(parameter)=0]"
		[Register ("proc_Msg_Netperf", "()V", "GetProc_Msg_NetperfHandler")]
		public virtual unsafe void Proc_Msg_Netperf ()
		{
			const string __id = "proc_Msg_Netperf.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_proc_Msg_Record_Data_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetProc_Msg_Record_Data_Landroid_os_Message_Handler ()
		{
			if (cb_proc_Msg_Record_Data_Landroid_os_Message_ == null)
				cb_proc_Msg_Record_Data_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Proc_Msg_Record_Data_Landroid_os_Message_);
			return cb_proc_Msg_Record_Data_Landroid_os_Message_;
		}

		static void n_Proc_Msg_Record_Data_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Proc_Msg_Record_Data (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='proc_Msg_Record_Data' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("proc_Msg_Record_Data", "(Landroid/os/Message;)V", "GetProc_Msg_Record_Data_Landroid_os_Message_Handler")]
		protected virtual unsafe void Proc_Msg_Record_Data (global::Android.OS.Message p0)
		{
			const string __id = "proc_Msg_Record_Data.(Landroid/os/Message;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_proc_Msg_Session_Begin;
#pragma warning disable 0169
		static Delegate GetProc_Msg_Session_BeginHandler ()
		{
			if (cb_proc_Msg_Session_Begin == null)
				cb_proc_Msg_Session_Begin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Proc_Msg_Session_Begin);
			return cb_proc_Msg_Session_Begin;
		}

		static void n_Proc_Msg_Session_Begin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Proc_Msg_Session_Begin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='proc_Msg_Session_Begin' and count(parameter)=0]"
		[Register ("proc_Msg_Session_Begin", "()V", "GetProc_Msg_Session_BeginHandler")]
		protected virtual unsafe void Proc_Msg_Session_Begin ()
		{
			const string __id = "proc_Msg_Session_Begin.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_proc_Msg_Start;
#pragma warning disable 0169
		static Delegate GetProc_Msg_StartHandler ()
		{
			if (cb_proc_Msg_Start == null)
				cb_proc_Msg_Start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Proc_Msg_Start);
			return cb_proc_Msg_Start;
		}

		static void n_Proc_Msg_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Proc_Msg_Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='proc_Msg_Start' and count(parameter)=0]"
		[Register ("proc_Msg_Start", "()V", "GetProc_Msg_StartHandler")]
		protected virtual unsafe void Proc_Msg_Start ()
		{
			const string __id = "proc_Msg_Start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_proc_Msg_Wait_Result;
#pragma warning disable 0169
		static Delegate GetProc_Msg_Wait_ResultHandler ()
		{
			if (cb_proc_Msg_Wait_Result == null)
				cb_proc_Msg_Wait_Result = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Proc_Msg_Wait_Result);
			return cb_proc_Msg_Wait_Result;
		}

		static void n_Proc_Msg_Wait_Result (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Proc_Msg_Wait_Result ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='proc_Msg_Wait_Result' and count(parameter)=0]"
		[Register ("proc_Msg_Wait_Result", "()V", "GetProc_Msg_Wait_ResultHandler")]
		protected virtual unsafe void Proc_Msg_Wait_Result ()
		{
			const string __id = "proc_Msg_Wait_Result.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startTranscripting_Lcom_iflytek_cloud_TranscripterListener_;
#pragma warning disable 0169
		static Delegate GetStartTranscripting_Lcom_iflytek_cloud_TranscripterListener_Handler ()
		{
			if (cb_startTranscripting_Lcom_iflytek_cloud_TranscripterListener_ == null)
				cb_startTranscripting_Lcom_iflytek_cloud_TranscripterListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StartTranscripting_Lcom_iflytek_cloud_TranscripterListener_);
			return cb_startTranscripting_Lcom_iflytek_cloud_TranscripterListener_;
		}

		static void n_StartTranscripting_Lcom_iflytek_cloud_TranscripterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.ITranscripterListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ITranscripterListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartTranscripting (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='startTranscripting' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.TranscripterListener']]"
		[Register ("startTranscripting", "(Lcom/iflytek/cloud/TranscripterListener;)V", "GetStartTranscripting_Lcom_iflytek_cloud_TranscripterListener_Handler")]
		public virtual unsafe void StartTranscripting (global::Com.Iflytek.Cloud.ITranscripterListener p0)
		{
			const string __id = "startTranscripting.(Lcom/iflytek/cloud/TranscripterListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_stopTranscripting_Z;
#pragma warning disable 0169
		static Delegate GetStopTranscripting_ZHandler ()
		{
			if (cb_stopTranscripting_Z == null)
				cb_stopTranscripting_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_StopTranscripting_Z);
			return cb_stopTranscripting_Z;
		}

		static bool n_StopTranscripting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopTranscripting (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='stopTranscripting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stopTranscripting", "(Z)Z", "GetStopTranscripting_ZHandler")]
		public virtual unsafe bool StopTranscripting (bool p0)
		{
			const string __id = "stopTranscripting.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_uploadData_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetUploadData_arrayBIZHandler ()
		{
			if (cb_uploadData_arrayBIZ == null)
				cb_uploadData_arrayBIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZ_V) n_UploadData_arrayBIZ);
			return cb_uploadData_arrayBIZ;
		}

		static void n_UploadData_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.MscTranscripter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.UploadData (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='MscTranscripter']/method[@name='uploadData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("uploadData", "([BIZ)V", "GetUploadData_arrayBIZHandler")]
		protected virtual unsafe void UploadData (byte[] p0, int p1, bool p2)
		{
			const string __id = "uploadData.([BIZ)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
