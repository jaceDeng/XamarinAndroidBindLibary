using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechEvaluator", DoNotGenerateAcw=true)]
	public partial class SpeechEvaluator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechEvaluator", typeof (SpeechEvaluator));
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

		protected SpeechEvaluator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/constructor[@name='SpeechEvaluator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		protected unsafe SpeechEvaluator (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		public static unsafe global::Com.Iflytek.Cloud.SpeechEvaluator Evaluator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='getEvaluator' and count(parameter)=0]"
			[Register ("getEvaluator", "()Lcom/iflytek/cloud/SpeechEvaluator;", "")]
			get {
				const string __id = "getEvaluator.()Lcom/iflytek/cloud/SpeechEvaluator;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEvaluating;
#pragma warning disable 0169
		static Delegate GetIsEvaluatingHandler ()
		{
			if (cb_isEvaluating == null)
				cb_isEvaluating = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEvaluating);
			return cb_isEvaluating;
		}

		static bool n_IsEvaluating (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEvaluating;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEvaluating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='isEvaluating' and count(parameter)=0]"
			[Register ("isEvaluating", "()Z", "GetIsEvaluatingHandler")]
			get {
				const string __id = "isEvaluating.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='createEvaluator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createEvaluator", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechEvaluator;", "")]
		public static unsafe global::Com.Iflytek.Cloud.SpeechEvaluator CreateEvaluator (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
		{
			const string __id = "createEvaluator.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechEvaluator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_startEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_;
#pragma warning disable 0169
		static Delegate GetStartEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_Handler ()
		{
			if (cb_startEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_ == null)
				cb_startEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_StartEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_);
			return cb_startEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_;
		}

		static int n_StartEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Cloud.IEvaluatorListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IEvaluatorListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartEvaluating (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='startEvaluating' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.cloud.EvaluatorListener']]"
		[Register ("startEvaluating", "([BLjava/lang/String;Lcom/iflytek/cloud/EvaluatorListener;)I", "GetStartEvaluating_arrayBLjava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_Handler")]
		public virtual unsafe int StartEvaluating (byte[] p0, string p1, global::Com.Iflytek.Cloud.IEvaluatorListener p2)
		{
			const string __id = "startEvaluating.([BLjava/lang/String;Lcom/iflytek/cloud/EvaluatorListener;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_startEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_;
#pragma warning disable 0169
		static Delegate GetStartEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_Handler ()
		{
			if (cb_startEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_ == null)
				cb_startEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_StartEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_);
			return cb_startEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_;
		}

		static int n_StartEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Cloud.IEvaluatorListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IEvaluatorListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartEvaluating (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='startEvaluating' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.cloud.EvaluatorListener']]"
		[Register ("startEvaluating", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/EvaluatorListener;)I", "GetStartEvaluating_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_cloud_EvaluatorListener_Handler")]
		public virtual unsafe int StartEvaluating (string p0, string p1, global::Com.Iflytek.Cloud.IEvaluatorListener p2)
		{
			const string __id = "startEvaluating.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/EvaluatorListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_stopEvaluating;
#pragma warning disable 0169
		static Delegate GetStopEvaluatingHandler ()
		{
			if (cb_stopEvaluating == null)
				cb_stopEvaluating = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopEvaluating);
			return cb_stopEvaluating;
		}

		static void n_StopEvaluating (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopEvaluating ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='stopEvaluating' and count(parameter)=0]"
		[Register ("stopEvaluating", "()V", "GetStopEvaluatingHandler")]
		public virtual unsafe void StopEvaluating ()
		{
			const string __id = "stopEvaluating.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeAudio_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_arrayBIIHandler ()
		{
			if (cb_writeAudio_arrayBII == null)
				cb_writeAudio_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_WriteAudio_arrayBII);
			return cb_writeAudio_arrayBII;
		}

		static bool n_WriteAudio_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.WriteAudio (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechEvaluator']/method[@name='writeAudio' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeAudio", "([BII)Z", "GetWriteAudio_arrayBIIHandler")]
		public virtual unsafe bool WriteAudio (byte[] p0, int p1, int p2)
		{
			const string __id = "writeAudio.([BII)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
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

	}
}
