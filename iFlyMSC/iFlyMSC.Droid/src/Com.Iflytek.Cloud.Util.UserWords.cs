using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/util/UserWords", DoNotGenerateAcw=true)]
	public partial class UserWords : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/UserWords", typeof (UserWords));
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

		protected UserWords (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/constructor[@name='UserWords' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserWords ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/constructor[@name='UserWords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UserWords (string p0)
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

		static Delegate cb_getKeys;
#pragma warning disable 0169
		static Delegate GetGetKeysHandler ()
		{
			if (cb_getKeys == null)
				cb_getKeys = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKeys);
			return cb_getKeys;
		}

		static IntPtr n_GetKeys (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Keys);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/ArrayList;", "GetGetKeysHandler")]
			get {
				const string __id = "getKeys.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWords;
#pragma warning disable 0169
		static Delegate GetGetWordsHandler ()
		{
			if (cb_getWords == null)
				cb_getWords = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWords);
			return cb_getWords;
		}

		static IntPtr n_GetWords (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Words);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Words {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='getWords' and count(parameter)=0]"
			[Register ("getWords", "()Ljava/util/ArrayList;", "GetGetWordsHandler")]
			get {
				const string __id = "getWords.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetWords_Ljava_lang_String_Handler ()
		{
			if (cb_getWords_Ljava_lang_String_ == null)
				cb_getWords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetWords_Ljava_lang_String_);
			return cb_getWords_Ljava_lang_String_;
		}

		static IntPtr n_GetWords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetWords (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='getWords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getWords", "(Ljava/lang/String;)Ljava/util/ArrayList;", "GetGetWords_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetWords (string p0)
		{
			const string __id = "getWords.(Ljava/lang/String;)Ljava/util/ArrayList;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasKey_Ljava_lang_String_Handler ()
		{
			if (cb_hasKey_Ljava_lang_String_ == null)
				cb_hasKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasKey_Ljava_lang_String_);
			return cb_hasKey_Ljava_lang_String_;
		}

		static bool n_HasKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='hasKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasKey", "(Ljava/lang/String;)Z", "GetHasKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasKey (string p0)
		{
			const string __id = "hasKey.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putWord_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutWord_Ljava_lang_String_Handler ()
		{
			if (cb_putWord_Ljava_lang_String_ == null)
				cb_putWord_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PutWord_Ljava_lang_String_);
			return cb_putWord_Ljava_lang_String_;
		}

		static bool n_PutWord_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PutWord (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='putWord' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putWord", "(Ljava/lang/String;)Z", "GetPutWord_Ljava_lang_String_Handler")]
		public virtual unsafe bool PutWord (string p0)
		{
			const string __id = "putWord.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putWord_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutWord_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putWord_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putWord_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_PutWord_Ljava_lang_String_Ljava_lang_String_);
			return cb_putWord_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_PutWord_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PutWord (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='putWord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putWord", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetPutWord_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool PutWord (string p0, string p1)
		{
			const string __id = "putWord.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_putWords_Ljava_lang_String_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetPutWords_Ljava_lang_String_Ljava_util_ArrayList_Handler ()
		{
			if (cb_putWords_Ljava_lang_String_Ljava_util_ArrayList_ == null)
				cb_putWords_Ljava_lang_String_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_PutWords_Ljava_lang_String_Ljava_util_ArrayList_);
			return cb_putWords_Ljava_lang_String_Ljava_util_ArrayList_;
		}

		static bool n_PutWords_Ljava_lang_String_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PutWords (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='putWords' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("putWords", "(Ljava/lang/String;Ljava/util/ArrayList;)Z", "GetPutWords_Ljava_lang_String_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool PutWords (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			const string __id = "putWords.(Ljava/lang/String;Ljava/util/ArrayList;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_putWords_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetPutWords_Ljava_util_ArrayList_Handler ()
		{
			if (cb_putWords_Ljava_util_ArrayList_ == null)
				cb_putWords_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PutWords_Ljava_util_ArrayList_);
			return cb_putWords_Ljava_util_ArrayList_;
		}

		static bool n_PutWords_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.UserWords> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PutWords (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='UserWords']/method[@name='putWords' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("putWords", "(Ljava/util/ArrayList;)Z", "GetPutWords_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool PutWords (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "putWords.(Ljava/util/ArrayList;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
