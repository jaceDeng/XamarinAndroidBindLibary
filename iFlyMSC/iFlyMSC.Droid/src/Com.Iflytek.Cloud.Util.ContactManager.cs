using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/util/ContactManager", DoNotGenerateAcw=true)]
	public abstract partial class ContactManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud.util']/interface[@name='ContactManager.ContactListener']"
		[Register ("com/iflytek/cloud/util/ContactManager$ContactListener", "", "Com.Iflytek.Cloud.Util.ContactManager/IContactListenerInvoker")]
		public partial interface IContactListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/interface[@name='ContactManager.ContactListener']/method[@name='onContactQueryFinish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("onContactQueryFinish", "(Ljava/lang/String;Z)V", "GetOnContactQueryFinish_Ljava_lang_String_ZHandler:Com.Iflytek.Cloud.Util.ContactManager/IContactListenerInvoker, iFlyMSC.Droid")]
			void OnContactQueryFinish (string p0, bool p1);

		}

		[global::Android.Runtime.Register ("com/iflytek/cloud/util/ContactManager$ContactListener", DoNotGenerateAcw=true)]
		internal partial class IContactListenerInvoker : global::Java.Lang.Object, IContactListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/ContactManager$ContactListener", typeof (IContactListenerInvoker));

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

			public static IContactListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IContactListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.util.ContactManager.ContactListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IContactListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onContactQueryFinish_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetOnContactQueryFinish_Ljava_lang_String_ZHandler ()
			{
				if (cb_onContactQueryFinish_Ljava_lang_String_Z == null)
					cb_onContactQueryFinish_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnContactQueryFinish_Ljava_lang_String_Z);
				return cb_onContactQueryFinish_Ljava_lang_String_Z;
			}

			static void n_OnContactQueryFinish_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ContactManager.IContactListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnContactQueryFinish (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onContactQueryFinish_Ljava_lang_String_Z;
			public unsafe void OnContactQueryFinish (string p0, bool p1)
			{
				if (id_onContactQueryFinish_Ljava_lang_String_Z == IntPtr.Zero)
					id_onContactQueryFinish_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onContactQueryFinish", "(Ljava/lang/String;Z)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContactQueryFinish_Ljava_lang_String_Z, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.iflytek.cloud.util.ContactManager.ContactListener.onContactQueryFinish
		public partial class ContactEventArgs : global::System.EventArgs {

			public ContactEventArgs (string p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/iflytek/cloud/util/ContactManager_ContactListenerImplementor")]
		internal sealed partial class IContactListenerImplementor : global::Java.Lang.Object, IContactListener {

			object sender;

			public IContactListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/util/ContactManager_ContactListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ContactEventArgs> Handler;
#pragma warning restore 0649

			public void OnContactQueryFinish (string p0, bool p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ContactEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IContactListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/ContactManager", typeof (ContactManager));
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

		protected ContactManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/constructor[@name='ContactManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ContactManager ()
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

		public static unsafe global::Com.Iflytek.Cloud.Util.ContactManager Manager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='getManager' and count(parameter)=0]"
			[Register ("getManager", "()Lcom/iflytek/cloud/util/ContactManager;", "")]
			get {
				const string __id = "getManager.()Lcom/iflytek/cloud/util/ContactManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ContactManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asyncQueryAllContactsName;
#pragma warning disable 0169
		static Delegate GetAsyncQueryAllContactsNameHandler ()
		{
			if (cb_asyncQueryAllContactsName == null)
				cb_asyncQueryAllContactsName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AsyncQueryAllContactsName);
			return cb_asyncQueryAllContactsName;
		}

		static void n_AsyncQueryAllContactsName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ContactManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AsyncQueryAllContactsName ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='asyncQueryAllContactsName' and count(parameter)=0]"
		[Register ("asyncQueryAllContactsName", "()V", "GetAsyncQueryAllContactsNameHandler")]
		public abstract void AsyncQueryAllContactsName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='createManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.util.ContactManager.ContactListener']]"
		[Register ("createManager", "(Landroid/content/Context;Lcom/iflytek/cloud/util/ContactManager$ContactListener;)Lcom/iflytek/cloud/util/ContactManager;", "")]
		public static unsafe global::Com.Iflytek.Cloud.Util.ContactManager CreateManager (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.Util.ContactManager.IContactListener p1)
		{
			const string __id = "createManager.(Landroid/content/Context;Lcom/iflytek/cloud/util/ContactManager$ContactListener;)Lcom/iflytek/cloud/util/ContactManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ContactManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public static unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_queryAllContactsName;
#pragma warning disable 0169
		static Delegate GetQueryAllContactsNameHandler ()
		{
			if (cb_queryAllContactsName == null)
				cb_queryAllContactsName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryAllContactsName);
			return cb_queryAllContactsName;
		}

		static IntPtr n_QueryAllContactsName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Util.ContactManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.QueryAllContactsName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='queryAllContactsName' and count(parameter)=0]"
		[Register ("queryAllContactsName", "()Ljava/lang/String;", "GetQueryAllContactsNameHandler")]
		public abstract string QueryAllContactsName ();

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/util/ContactManager", DoNotGenerateAcw=true)]
	internal partial class ContactManagerInvoker : ContactManager {

		public ContactManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/util/ContactManager", typeof (ContactManagerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='asyncQueryAllContactsName' and count(parameter)=0]"
		[Register ("asyncQueryAllContactsName", "()V", "GetAsyncQueryAllContactsNameHandler")]
		public override unsafe void AsyncQueryAllContactsName ()
		{
			const string __id = "asyncQueryAllContactsName.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud.util']/class[@name='ContactManager']/method[@name='queryAllContactsName' and count(parameter)=0]"
		[Register ("queryAllContactsName", "()Ljava/lang/String;", "GetQueryAllContactsNameHandler")]
		public override unsafe string QueryAllContactsName ()
		{
			const string __id = "queryAllContactsName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
