using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/util/ResourceUtil", DoNotGenerateAcw=true)]
	public partial class ResourceUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/field[@name='ASR_RES_PATH']"
		[Register ("ASR_RES_PATH")]
		public const string AsrResPath = (string) "asr_res_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/field[@name='ENGINE_DESTROY']"
		[Register ("ENGINE_DESTROY")]
		public const string EngineDestroy = (string) "engine_destroy";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/field[@name='ENGINE_START']"
		[Register ("ENGINE_START")]
		public const string EngineStart = (string) "engine_start";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/field[@name='GRM_BUILD_PATH']"
		[Register ("GRM_BUILD_PATH")]
		public const string GrmBuildPath = (string) "grm_build_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/field[@name='IVW_RES_PATH']"
		[Register ("IVW_RES_PATH")]
		public const string IvwResPath = (string) "ivw_res_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/field[@name='TTS_RES_PATH']"
		[Register ("TTS_RES_PATH")]
		public const string TtsResPath = (string) "tts_res_path";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil.RESOURCE_TYPE']"
		[global::Android.Runtime.Register ("com/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class RESOURCE_TYPE : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil.RESOURCE_TYPE']/field[@name='assets']"
			[Register ("assets")]
			public static global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE Assets {
				get {
					const string __id = "assets.Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil.RESOURCE_TYPE']/field[@name='path']"
			[Register ("path")]
			public static global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE Path {
				get {
					const string __id = "path.Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil.RESOURCE_TYPE']/field[@name='res']"
			[Register ("res")]
			public static global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE Res {
				get {
					const string __id = "res.Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE", typeof (RESOURCE_TYPE));
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

			internal RESOURCE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil.RESOURCE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil.RESOURCE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE[] Values ()
			{
				const string __id = "values.()[Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/ResourceUtil", typeof (ResourceUtil));
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

		protected ResourceUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/constructor[@name='ResourceUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ResourceUtil']/method[@name='generateResourcePath' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.util.ResourceUtil.RESOURCE_TYPE'] and parameter[3][@type='java.lang.String']]"
		[Register ("generateResourcePath", "(Landroid/content/Context;Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GenerateResourcePath (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.Util.ResourceUtil.RESOURCE_TYPE p1, string p2)
		{
			const string __id = "generateResourcePath.(Landroid/content/Context;Lcom/iflytek/cloud/util/ResourceUtil$RESOURCE_TYPE;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
