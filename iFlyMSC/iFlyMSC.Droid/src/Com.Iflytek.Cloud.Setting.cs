using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/Setting", DoNotGenerateAcw=true)]
	public partial class Setting : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/field[@name='a']"
		[Register ("a")]
		public static string A {
			get {
				const string __id = "a.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']"
		[global::Android.Runtime.Register ("com/iflytek/cloud/Setting$LOG_LEVEL", DoNotGenerateAcw=true)]
		public sealed partial class LOG_LEVEL : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/field[@name='all']"
			[Register ("all")]
			public static global::Com.Iflytek.Cloud.Setting.LOG_LEVEL All {
				get {
					const string __id = "all.Lcom/iflytek/cloud/Setting$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/field[@name='detail']"
			[Register ("detail")]
			public static global::Com.Iflytek.Cloud.Setting.LOG_LEVEL Detail {
				get {
					const string __id = "detail.Lcom/iflytek/cloud/Setting$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/field[@name='low']"
			[Register ("low")]
			public static global::Com.Iflytek.Cloud.Setting.LOG_LEVEL Low {
				get {
					const string __id = "low.Lcom/iflytek/cloud/Setting$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/field[@name='none']"
			[Register ("none")]
			public static global::Com.Iflytek.Cloud.Setting.LOG_LEVEL None {
				get {
					const string __id = "none.Lcom/iflytek/cloud/Setting$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/field[@name='normal']"
			[Register ("normal")]
			public static global::Com.Iflytek.Cloud.Setting.LOG_LEVEL Normal {
				get {
					const string __id = "normal.Lcom/iflytek/cloud/Setting$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/Setting$LOG_LEVEL", typeof (LOG_LEVEL));
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

			internal LOG_LEVEL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/iflytek/cloud/Setting$LOG_LEVEL;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Setting.LOG_LEVEL ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/iflytek/cloud/Setting$LOG_LEVEL;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting.LOG_LEVEL']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/iflytek/cloud/Setting$LOG_LEVEL;", "")]
			public static unsafe global::Com.Iflytek.Cloud.Setting.LOG_LEVEL[] Values ()
			{
				const string __id = "values.()[Lcom/iflytek/cloud/Setting$LOG_LEVEL;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Iflytek.Cloud.Setting.LOG_LEVEL[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Iflytek.Cloud.Setting.LOG_LEVEL));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/Setting", typeof (Setting));
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

		protected Setting (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe bool LocationEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='getLocationEnable' and count(parameter)=0]"
			[Register ("getLocationEnable", "()Z", "")]
			get {
				const string __id = "getLocationEnable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='setLocationEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocationEnable", "(Z)V", "")]
			set {
				const string __id = "setLocationEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Iflytek.Cloud.Setting.LOG_LEVEL LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lcom/iflytek/cloud/Setting$LOG_LEVEL;", "")]
			get {
				const string __id = "getLogLevel.()Lcom/iflytek/cloud/Setting$LOG_LEVEL;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Setting.LOG_LEVEL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.Setting.LOG_LEVEL']]"
			[Register ("setLogLevel", "(Lcom/iflytek/cloud/Setting$LOG_LEVEL;)V", "")]
			set {
				const string __id = "setLogLevel.(Lcom/iflytek/cloud/Setting$LOG_LEVEL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public static unsafe string LogPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='getLogPath' and count(parameter)=0]"
			[Register ("getLogPath", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLogPath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='setLogPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLogPath", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setLogPath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe bool SaveTestLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='getSaveTestLog' and count(parameter)=0]"
			[Register ("getSaveTestLog", "()Z", "")]
			get {
				const string __id = "getSaveTestLog.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='setSaveTestLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSaveTestLog", "(Z)V", "")]
			set {
				const string __id = "setSaveTestLog.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool ShowLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='getShowLog' and count(parameter)=0]"
			[Register ("getShowLog", "()Z", "")]
			get {
				const string __id = "getShowLog.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='setShowLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowLog", "(Z)V", "")]
			set {
				const string __id = "setShowLog.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='Setting']/method[@name='setLocale' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("setLocale", "(Ljava/util/Locale;)V", "")]
		public static unsafe void SetLocale (global::Java.Util.Locale p0)
		{
			const string __id = "setLocale.(Ljava/util/Locale;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
