using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='ISpeechModule']"
	[Register ("com/iflytek/speech/ISpeechModule", "", "Com.Iflytek.Speech.ISpeechModuleInvoker")]
	public partial interface ISpeechModule : IJavaObject, IJavaPeerable {

		global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='ISpeechModule']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler:Com.Iflytek.Speech.ISpeechModuleInvoker, iFlyMSC.Droid")] get;
		}

		bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='ISpeechModule']/method[@name='isAvailable' and count(parameter)=0]"
			[Register ("isAvailable", "()Z", "GetIsAvailableHandler:Com.Iflytek.Speech.ISpeechModuleInvoker, iFlyMSC.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='ISpeechModule']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()Z", "GetDestoryHandler:Com.Iflytek.Speech.ISpeechModuleInvoker, iFlyMSC.Droid")]
		bool Destory ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='ISpeechModule']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParameter_Ljava_lang_String_Handler:Com.Iflytek.Speech.ISpeechModuleInvoker, iFlyMSC.Droid")]
		string GetParameter (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='ISpeechModule']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)I", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler:Com.Iflytek.Speech.ISpeechModuleInvoker, iFlyMSC.Droid")]
		int SetParameter (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/ISpeechModule", DoNotGenerateAcw=true)]
	internal partial class ISpeechModuleInvoker : global::Java.Lang.Object, ISpeechModule {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/ISpeechModule", typeof (ISpeechModuleInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ISpeechModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpeechModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.ISpeechModule"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpeechModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		IntPtr id_getIntent;
		public unsafe global::Android.Content.Intent Intent {
			get {
				if (id_getIntent == IntPtr.Zero)
					id_getIntent = JNIEnv.GetMethodID (class_ref, "getIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isAvailable;
#pragma warning disable 0169
		static Delegate GetIsAvailableHandler ()
		{
			if (cb_isAvailable == null)
				cb_isAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAvailable);
			return cb_isAvailable;
		}

		static bool n_IsAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailable;
		}
#pragma warning restore 0169

		IntPtr id_isAvailable;
		public unsafe bool IsAvailable {
			get {
				if (id_isAvailable == IntPtr.Zero)
					id_isAvailable = JNIEnv.GetMethodID (class_ref, "isAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAvailable);
			}
		}

		static Delegate cb_destory;
#pragma warning disable 0169
		static Delegate GetDestoryHandler ()
		{
			if (cb_destory == null)
				cb_destory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Destory);
			return cb_destory;
		}

		static bool n_Destory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Destory ();
		}
#pragma warning restore 0169

		IntPtr id_destory;
		public unsafe bool Destory ()
		{
			if (id_destory == IntPtr.Zero)
				id_destory = JNIEnv.GetMethodID (class_ref, "destory", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_destory);
		}

		static Delegate cb_getParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParameter_Ljava_lang_String_Handler ()
		{
			if (cb_getParameter_Ljava_lang_String_ == null)
				cb_getParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetParameter_Ljava_lang_String_);
			return cb_getParameter_Ljava_lang_String_;
		}

		static IntPtr n_GetParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParameter_Ljava_lang_String_;
		public unsafe string GetParameter (string p0)
		{
			if (id_getParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_getParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setParameter_Ljava_lang_String_Ljava_lang_String_;
		public unsafe int SetParameter (string p0, string p1)
		{
			if (id_setParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setParameter", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setParameter_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
