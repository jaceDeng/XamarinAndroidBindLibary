using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechUnderstander", DoNotGenerateAcw=true)]
	public partial class SpeechUnderstander : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/field[@name='f']"
		[Register ("f")]
		protected static global::Com.Iflytek.Cloud.SpeechUnderstander F {
			get {
				const string __id = "f.Lcom/iflytek/cloud/SpeechUnderstander;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Lcom/iflytek/cloud/SpeechUnderstander;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechUnderstander", typeof (SpeechUnderstander));
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

		protected SpeechUnderstander (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/constructor[@name='SpeechUnderstander' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		protected unsafe SpeechUnderstander (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")]
			get {
				const string __id = "isUnderstanding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Iflytek.Cloud.SpeechUnderstander Understander {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='getUnderstander' and count(parameter)=0]"
			[Register ("getUnderstander", "()Lcom/iflytek/cloud/SpeechUnderstander;", "")]
			get {
				const string __id = "getUnderstander.()Lcom/iflytek/cloud/SpeechUnderstander;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_a_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Handler ()
		{
			if (cb_a_Landroid_content_Context_ == null)
				cb_a_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_Landroid_content_Context_);
			return cb_a_Landroid_content_Context_;
		}

		static void n_A_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "GetA_Landroid_content_Context_Handler")]
		protected virtual unsafe void A (global::Android.Content.Context p0)
		{
			const string __id = "a.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='createUnderstander' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createUnderstander", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechUnderstander;", "")]
		public static unsafe global::Com.Iflytek.Cloud.SpeechUnderstander CreateUnderstander (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
		{
			const string __id = "createUnderstander.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechUnderstander;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_startUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStartUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_Handler ()
		{
			if (cb_startUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_ == null)
				cb_startUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_StartUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_);
			return cb_startUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_;
		}

		static int n_StartUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Cloud.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartUnderstanding (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='startUnderstanding' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechUnderstanderListener']]"
		[Register ("startUnderstanding", "(Lcom/iflytek/cloud/SpeechUnderstanderListener;)I", "GetStartUnderstanding_Lcom_iflytek_cloud_SpeechUnderstanderListener_Handler")]
		public virtual unsafe int StartUnderstanding (global::Com.Iflytek.Cloud.ISpeechUnderstanderListener p0)
		{
			const string __id = "startUnderstanding.(Lcom/iflytek/cloud/SpeechUnderstanderListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_stopUnderstanding;
#pragma warning disable 0169
		static Delegate GetStopUnderstandingHandler ()
		{
			if (cb_stopUnderstanding == null)
				cb_stopUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopUnderstanding);
			return cb_stopUnderstanding;
		}

		static void n_StopUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopUnderstanding ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='stopUnderstanding' and count(parameter)=0]"
		[Register ("stopUnderstanding", "()V", "GetStopUnderstandingHandler")]
		public virtual unsafe void StopUnderstanding ()
		{
			const string __id = "stopUnderstanding.()V";
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
				cb_writeAudio_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_WriteAudio_arrayBII);
			return cb_writeAudio_arrayBII;
		}

		static int n_WriteAudio_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteAudio (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechUnderstander']/method[@name='writeAudio' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeAudio", "([BII)I", "GetWriteAudio_arrayBIIHandler")]
		public virtual unsafe int WriteAudio (byte[] p0, int p1, int p2)
		{
			const string __id = "writeAudio.([BII)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
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

	}
}
