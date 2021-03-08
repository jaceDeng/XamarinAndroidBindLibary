using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Msc.Ist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/msc/ist/AudioAccessor", DoNotGenerateAcw=true)]
	public partial class AudioAccessor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']"
		[global::Android.Runtime.Register ("com/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys", DoNotGenerateAcw=true)]
		public sealed partial class AudioKeys : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']/field[@name='BIT']"
			[Register ("BIT")]
			public static global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys Bit {
				get {
					const string __id = "BIT.Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']/field[@name='CHANNEL']"
			[Register ("CHANNEL")]
			public static global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys Channel {
				get {
					const string __id = "CHANNEL.Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']/field[@name='FORMAT']"
			[Register ("FORMAT")]
			public static global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys Format {
				get {
					const string __id = "FORMAT.Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']/field[@name='RATE']"
			[Register ("RATE")]
			public static global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys Rate {
				get {
					const string __id = "RATE.Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys", typeof (AudioKeys));
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

			internal AudioKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor.AudioKeys']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys[] Values ()
			{
				const string __id = "values.()[Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/msc/ist/AudioAccessor", typeof (AudioAccessor));
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

		protected AudioAccessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/constructor[@name='AudioAccessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AudioAccessor ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/constructor[@name='AudioAccessor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe AudioAccessor (string p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/constructor[@name='AudioAccessor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		protected unsafe AudioAccessor (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBufferLength;
#pragma warning disable 0169
		static Delegate GetGetBufferLengthHandler ()
		{
			if (cb_getBufferLength == null)
				cb_getBufferLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBufferLength);
			return cb_getBufferLength;
		}

		static int n_GetBufferLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferLength;
		}
#pragma warning restore 0169

		public virtual unsafe int BufferLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='getBufferLength' and count(parameter)=0]"
			[Register ("getBufferLength", "()I", "GetGetBufferLengthHandler")]
			get {
				const string __id = "getBufferLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCacheLeft;
#pragma warning disable 0169
		static Delegate GetGetCacheLeftHandler ()
		{
			if (cb_getCacheLeft == null)
				cb_getCacheLeft = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCacheLeft);
			return cb_getCacheLeft;
		}

		static int n_GetCacheLeft (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheLeft;
		}
#pragma warning restore 0169

		public virtual unsafe int CacheLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='getCacheLeft' and count(parameter)=0]"
			[Register ("getCacheLeft", "()I", "GetGetCacheLeftHandler")]
			get {
				const string __id = "getCacheLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDataLength;
#pragma warning disable 0169
		static Delegate GetGetDataLengthHandler ()
		{
			if (cb_getDataLength == null)
				cb_getDataLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDataLength);
			return cb_getDataLength;
		}

		static long n_GetDataLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataLength;
		}
#pragma warning restore 0169

		public virtual unsafe long DataLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='getDataLength' and count(parameter)=0]"
			[Register ("getDataLength", "()J", "GetGetDataLengthHandler")]
			get {
				const string __id = "getDataLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFilePath;
#pragma warning disable 0169
		static Delegate GetGetFilePathHandler ()
		{
			if (cb_getFilePath == null)
				cb_getFilePath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFilePath);
			return cb_getFilePath;
		}

		static IntPtr n_GetFilePath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FilePath);
		}
#pragma warning restore 0169

		public virtual unsafe string FilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='getFilePath' and count(parameter)=0]"
			[Register ("getFilePath", "()Ljava/lang/String;", "GetGetFilePathHandler")]
			get {
				const string __id = "getFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='createBufferAccessor' and count(parameter)=0]"
		[Register ("createBufferAccessor", "()Lcom/iflytek/cloud/msc/ist/AudioAccessor;", "")]
		public static unsafe global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor CreateBufferAccessor ()
		{
			const string __id = "createBufferAccessor.()Lcom/iflytek/cloud/msc/ist/AudioAccessor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='createReadOnlyAccessor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createReadOnlyAccessor", "(Ljava/lang/String;)Lcom/iflytek/cloud/msc/ist/AudioAccessor;", "")]
		public static unsafe global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor CreateReadOnlyAccessor (string p0)
		{
			const string __id = "createReadOnlyAccessor.(Ljava/lang/String;)Lcom/iflytek/cloud/msc/ist/AudioAccessor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='createWriteReadAccessor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createWriteReadAccessor", "(Ljava/lang/String;I)Lcom/iflytek/cloud/msc/ist/AudioAccessor;", "")]
		public static unsafe global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor CreateWriteReadAccessor (string p0, int p1)
		{
			const string __id = "createWriteReadAccessor.(Ljava/lang/String;I)Lcom/iflytek/cloud/msc/ist/AudioAccessor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAudio_arrayB;
#pragma warning disable 0169
		static Delegate GetGetAudio_arrayBHandler ()
		{
			if (cb_getAudio_arrayB == null)
				cb_getAudio_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetAudio_arrayB);
			return cb_getAudio_arrayB;
		}

		static int n_GetAudio_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetAudio (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='getAudio' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getAudio", "([B)I", "GetGetAudio_arrayBHandler")]
		public virtual unsafe int GetAudio (byte[] p0)
		{
			const string __id = "getAudio.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_;
#pragma warning disable 0169
		static Delegate GetGetAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_Handler ()
		{
			if (cb_getAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_ == null)
				cb_getAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_);
			return cb_getAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_;
		}

		static IntPtr n_GetAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAudioInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='getAudioInfo' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.msc.ist.AudioAccessor.AudioKeys']]"
		[Register ("getAudioInfo", "(Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;)Ljava/lang/String;", "GetGetAudioInfo_Lcom_iflytek_cloud_msc_ist_AudioAccessor_AudioKeys_Handler")]
		public virtual unsafe string GetAudioInfo (global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor.AudioKeys p0)
		{
			const string __id = "getAudioInfo.(Lcom/iflytek/cloud/msc/ist/AudioAccessor$AudioKeys;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_initAudioFileHeader;
#pragma warning disable 0169
		static Delegate GetInitAudioFileHeaderHandler ()
		{
			if (cb_initAudioFileHeader == null)
				cb_initAudioFileHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitAudioFileHeader);
			return cb_initAudioFileHeader;
		}

		static void n_InitAudioFileHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitAudioFileHeader ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='initAudioFileHeader' and count(parameter)=0]"
		[Register ("initAudioFileHeader", "()V", "GetInitAudioFileHeaderHandler")]
		protected virtual unsafe void InitAudioFileHeader ()
		{
			const string __id = "initAudioFileHeader.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_putAudio_arrayBI;
#pragma warning disable 0169
		static Delegate GetPutAudio_arrayBIHandler ()
		{
			if (cb_putAudio_arrayBI == null)
				cb_putAudio_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_PutAudio_arrayBI);
			return cb_putAudio_arrayBI;
		}

		static bool n_PutAudio_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PutAudio (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='putAudio' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("putAudio", "([BI)Z", "GetPutAudio_arrayBIHandler")]
		public virtual unsafe bool PutAudio (byte[] p0, int p1)
		{
			const string __id = "putAudio.([BI)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_readAudioInfo;
#pragma warning disable 0169
		static Delegate GetReadAudioInfoHandler ()
		{
			if (cb_readAudioInfo == null)
				cb_readAudioInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReadAudioInfo);
			return cb_readAudioInfo;
		}

		static void n_ReadAudioInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadAudioInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='readAudioInfo' and count(parameter)=0]"
		[Register ("readAudioInfo", "()V", "GetReadAudioInfoHandler")]
		protected virtual unsafe void ReadAudioInfo ()
		{
			const string __id = "readAudioInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_readBytes_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadBytes_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_readBytes_ILjava_nio_ByteBuffer_ == null)
				cb_readBytes_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_ReadBytes_ILjava_nio_ByteBuffer_);
			return cb_readBytes_ILjava_nio_ByteBuffer_;
		}

		static int n_ReadBytes_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadBytes (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='readBytes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("readBytes", "(ILjava/nio/ByteBuffer;)I", "GetReadBytes_ILjava_nio_ByteBuffer_Handler")]
		protected virtual unsafe int ReadBytes (int p0, global::Java.Nio.ByteBuffer p1)
		{
			const string __id = "readBytes.(ILjava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_readInt_I;
#pragma warning disable 0169
		static Delegate GetReadInt_IHandler ()
		{
			if (cb_readInt_I == null)
				cb_readInt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_ReadInt_I);
			return cb_readInt_I;
		}

		static int n_ReadInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadInt (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='readInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readInt", "(I)I", "GetReadInt_IHandler")]
		protected virtual unsafe int ReadInt (int p0)
		{
			const string __id = "readInt.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_readShort_I;
#pragma warning disable 0169
		static Delegate GetReadShort_IHandler ()
		{
			if (cb_readShort_I == null)
				cb_readShort_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_S) n_ReadShort_I);
			return cb_readShort_I;
		}

		static short n_ReadShort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadShort (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='readShort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readShort", "(I)S", "GetReadShort_IHandler")]
		protected virtual unsafe short ReadShort (int p0)
		{
			const string __id = "readShort.(I)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updateAudioFileHeader;
#pragma warning disable 0169
		static Delegate GetUpdateAudioFileHeaderHandler ()
		{
			if (cb_updateAudioFileHeader == null)
				cb_updateAudioFileHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UpdateAudioFileHeader);
			return cb_updateAudioFileHeader;
		}

		static void n_UpdateAudioFileHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateAudioFileHeader ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='updateAudioFileHeader' and count(parameter)=0]"
		[Register ("updateAudioFileHeader", "()V", "GetUpdateAudioFileHeaderHandler")]
		protected virtual unsafe void UpdateAudioFileHeader ()
		{
			const string __id = "updateAudioFileHeader.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeBytes_IarrayB;
#pragma warning disable 0169
		static Delegate GetWriteBytes_IarrayBHandler ()
		{
			if (cb_writeBytes_IarrayB == null)
				cb_writeBytes_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_WriteBytes_IarrayB);
			return cb_writeBytes_IarrayB;
		}

		static void n_WriteBytes_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteBytes (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='writeBytes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("writeBytes", "(I[B)V", "GetWriteBytes_IarrayBHandler")]
		protected virtual unsafe void WriteBytes (int p0, byte[] p1)
		{
			const string __id = "writeBytes.(I[B)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_writeBytes_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWriteBytes_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_writeBytes_ILjava_nio_ByteBuffer_ == null)
				cb_writeBytes_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_WriteBytes_ILjava_nio_ByteBuffer_);
			return cb_writeBytes_ILjava_nio_ByteBuffer_;
		}

		static void n_WriteBytes_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteBytes (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='writeBytes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("writeBytes", "(ILjava/nio/ByteBuffer;)V", "GetWriteBytes_ILjava_nio_ByteBuffer_Handler")]
		protected virtual unsafe void WriteBytes (int p0, global::Java.Nio.ByteBuffer p1)
		{
			const string __id = "writeBytes.(ILjava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_writeBytes_ILjava_nio_ByteBuffer_I;
#pragma warning disable 0169
		static Delegate GetWriteBytes_ILjava_nio_ByteBuffer_IHandler ()
		{
			if (cb_writeBytes_ILjava_nio_ByteBuffer_I == null)
				cb_writeBytes_ILjava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILI_V) n_WriteBytes_ILjava_nio_ByteBuffer_I);
			return cb_writeBytes_ILjava_nio_ByteBuffer_I;
		}

		static void n_WriteBytes_ILjava_nio_ByteBuffer_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteBytes (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='writeBytes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='int']]"
		[Register ("writeBytes", "(ILjava/nio/ByteBuffer;I)V", "GetWriteBytes_ILjava_nio_ByteBuffer_IHandler")]
		protected virtual unsafe void WriteBytes (int p0, global::Java.Nio.ByteBuffer p1, int p2)
		{
			const string __id = "writeBytes.(ILjava/nio/ByteBuffer;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_writeInt_II;
#pragma warning disable 0169
		static Delegate GetWriteInt_IIHandler ()
		{
			if (cb_writeInt_II == null)
				cb_writeInt_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_WriteInt_II);
			return cb_writeInt_II;
		}

		static void n_WriteInt_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='writeInt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeInt", "(II)V", "GetWriteInt_IIHandler")]
		protected virtual unsafe void WriteInt (int p0, int p1)
		{
			const string __id = "writeInt.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeShort_IS;
#pragma warning disable 0169
		static Delegate GetWriteShort_ISHandler ()
		{
			if (cb_writeShort_IS == null)
				cb_writeShort_IS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIS_V) n_WriteShort_IS);
			return cb_writeShort_IS;
		}

		static void n_WriteShort_IS (IntPtr jnienv, IntPtr native__this, int p0, short p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Msc.Ist.AudioAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteShort (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.msc.ist']/class[@name='AudioAccessor']/method[@name='writeShort' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='short']]"
		[Register ("writeShort", "(IS)V", "GetWriteShort_ISHandler")]
		protected virtual unsafe void WriteShort (int p0, short p1)
		{
			const string __id = "writeShort.(IS)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
