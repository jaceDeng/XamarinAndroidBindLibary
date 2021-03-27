using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']"
	[global::Android.Runtime.Register ("com/iflytek/speech/SpeakerVerifierAidl", DoNotGenerateAcw=true)]
	public partial class SpeakerVerifierAidl : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/field[@name='IVP_PARAM_CONSISTTHRESHOLD']"
		[Register ("IVP_PARAM_CONSISTTHRESHOLD")]
		public static string IvpParamConsistthreshold {
			get {
				const string __id = "IVP_PARAM_CONSISTTHRESHOLD.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "IVP_PARAM_CONSISTTHRESHOLD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/field[@name='IVP_PARAM_DTW_CHECK_THRESHOLD']"
		[Register ("IVP_PARAM_DTW_CHECK_THRESHOLD")]
		public static string IvpParamDtwCheckThreshold {
			get {
				const string __id = "IVP_PARAM_DTW_CHECK_THRESHOLD.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "IVP_PARAM_DTW_CHECK_THRESHOLD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/field[@name='IVP_SENTENCE_CNT']"
		[Register ("IVP_SENTENCE_CNT")]
		public static string IvpSentenceCnt {
			get {
				const string __id = "IVP_SENTENCE_CNT.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "IVP_SENTENCE_CNT.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/field[@name='USER_NAME']"
		[Register ("USER_NAME")]
		public static string UserName {
			get {
				const string __id = "USER_NAME.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "USER_NAME.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/field[@name='VID']"
		[Register ("VID")]
		public static string Vid {
			get {
				const string __id = "VID.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "VID.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SpeakerVerifierAidl.DownloadListener']"
		[Register ("com/iflytek/speech/SpeakerVerifierAidl$DownloadListener", "", "Com.Iflytek.Speech.SpeakerVerifierAidl/IDownloadListenerInvoker")]
		public partial interface IDownloadListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SpeakerVerifierAidl.DownloadListener']/method[@name='onData' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.iflytek.speech.SpeakerVerifierAidl.PassWord&gt;']]"
			[Register ("onData", "(Ljava/util/ArrayList;)V", "GetOnData_Ljava_util_ArrayList_Handler:Com.Iflytek.Speech.SpeakerVerifierAidl/IDownloadListenerInvoker, iFlyMSC.Droid")]
			void OnData (global::System.Collections.Generic.IList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord> p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/interface[@name='SpeakerVerifierAidl.DownloadListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Iflytek.Speech.SpeakerVerifierAidl/IDownloadListenerInvoker, iFlyMSC.Droid")]
			void OnError (int p0);

		}

		[global::Android.Runtime.Register ("com/iflytek/speech/SpeakerVerifierAidl$DownloadListener", DoNotGenerateAcw=true)]
		internal partial class IDownloadListenerInvoker : global::Java.Lang.Object, IDownloadListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SpeakerVerifierAidl$DownloadListener", typeof (IDownloadListenerInvoker));

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

			public static IDownloadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownloadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.SpeakerVerifierAidl.DownloadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownloadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onData_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetOnData_Ljava_util_ArrayList_Handler ()
			{
				if (cb_onData_Ljava_util_ArrayList_ == null)
					cb_onData_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnData_Ljava_util_ArrayList_);
				return cb_onData_Ljava_util_ArrayList_;
			}

			static void n_OnData_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnData (p0);
			}
#pragma warning restore 0169

			IntPtr id_onData_Ljava_util_ArrayList_;
			public unsafe void OnData (global::System.Collections.Generic.IList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord> p0)
			{
				if (id_onData_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_onData_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/util/ArrayList;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onError_I;
#pragma warning disable 0169
			static Delegate GetOnError_IHandler ()
			{
				if (cb_onError_I == null)
					cb_onError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnError_I);
				return cb_onError_I;
			}

			static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_I;
			public unsafe void OnError (int p0)
			{
				if (id_onError_I == IntPtr.Zero)
					id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
			}

		}

		// event args for com.iflytek.speech.SpeakerVerifierAidl.DownloadListener.onData
		public partial class DataEventArgs : global::System.EventArgs {

			public DataEventArgs (global::System.Collections.Generic.IList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord> p0)
			{
				this.p0 = p0;
			}

			global::System.Collections.Generic.IList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord> p0;
			public global::System.Collections.Generic.IList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord> P0 {
				get { return p0; }
			}
		}

		// event args for com.iflytek.speech.SpeakerVerifierAidl.DownloadListener.onError
		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/iflytek/speech/SpeakerVerifierAidl_DownloadListenerImplementor")]
		internal sealed partial class IDownloadListenerImplementor : global::Java.Lang.Object, IDownloadListener {

			object sender;

			public IDownloadListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/speech/SpeakerVerifierAidl_DownloadListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DataEventArgs> OnDataHandler;
#pragma warning restore 0649

			public void OnData (global::System.Collections.Generic.IList<global::Com.Iflytek.Speech.SpeakerVerifierAidl.PassWord> p0)
			{
				var __h = OnDataHandler;
				if (__h != null)
					__h (sender, new DataEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (int p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IDownloadListenerImplementor value)
			{
				return value.OnDataHandler == null && value.OnErrorHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl.PassWord']"
		[global::Android.Runtime.Register ("com/iflytek/speech/SpeakerVerifierAidl$PassWord", DoNotGenerateAcw=true)]
		public partial class PassWord : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl.PassWord']/field[@name='pwdt']"
			[Register ("pwdt")]
			public string Pwdt {
				get {
					const string __id = "pwdt.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pwdt.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl.PassWord']/field[@name='pwid']"
			[Register ("pwid")]
			public string Pwid {
				get {
					const string __id = "pwid.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pwid.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl.PassWord']/field[@name='pwtext']"
			[Register ("pwtext")]
			public string Pwtext {
				get {
					const string __id = "pwtext.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pwtext.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SpeakerVerifierAidl$PassWord", typeof (PassWord));
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

			protected PassWord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl.PassWord']/constructor[@name='SpeakerVerifierAidl.PassWord' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeakerVerifierAidl']]"
			[Register (".ctor", "(Lcom/iflytek/speech/SpeakerVerifierAidl;)V", "")]
			public unsafe PassWord (global::Com.Iflytek.Speech.SpeakerVerifierAidl __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/SpeakerVerifierAidl", typeof (SpeakerVerifierAidl));
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

		protected SpeakerVerifierAidl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/constructor[@name='SpeakerVerifierAidl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)V", "")]
		public unsafe SpeakerVerifierAidl (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
			get {
				const string __id = "getIntent.()Landroid/content/Intent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='isAvailable' and count(parameter)=0]"
			[Register ("isAvailable", "()Z", "GetIsAvailableHandler")]
			get {
				const string __id = "isAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Destory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()Z", "GetDestoryHandler")]
		public virtual unsafe bool Destory ()
		{
			const string __id = "destory.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_endSpeak;
#pragma warning disable 0169
		static Delegate GetEndSpeakHandler ()
		{
			if (cb_endSpeak == null)
				cb_endSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndSpeak);
			return cb_endSpeak;
		}

		static void n_EndSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndSpeak ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='endSpeak' and count(parameter)=0]"
		[Register ("endSpeak", "()V", "GetEndSpeakHandler")]
		public virtual unsafe void EndSpeak ()
		{
			const string __id = "endSpeak.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParameter_Ljava_lang_String_Handler")]
		public virtual unsafe string GetParameter (string p0)
		{
			const string __id = "getParameter.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_Handler ()
		{
			if (cb_getPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_ == null)
				cb_getPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_GetPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_);
			return cb_getPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_;
		}

		static int n_GetPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.SpeakerVerifierAidl.IDownloadListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl.IDownloadListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPasswordList (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='getPasswordList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.speech.SpeakerVerifierAidl.DownloadListener'] and parameter[3][@type='java.lang.String']]"
		[Register ("getPasswordList", "(Landroid/content/Context;Lcom/iflytek/speech/SpeakerVerifierAidl$DownloadListener;Ljava/lang/String;)I", "GetGetPasswordList_Landroid_content_Context_Lcom_iflytek_speech_SpeakerVerifierAidl_DownloadListener_Ljava_lang_String_Handler")]
		public virtual unsafe int GetPasswordList (global::Android.Content.Context p0, global::Com.Iflytek.Speech.SpeakerVerifierAidl.IDownloadListener p1, string p2)
		{
			const string __id = "getPasswordList.(Landroid/content/Context;Lcom/iflytek/speech/SpeakerVerifierAidl$DownloadListener;Ljava/lang/String;)I";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_identify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_identify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_identify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Identify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_identify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Identify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Identify (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='identify' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("identify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetIdentify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public virtual unsafe int Identify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "identify.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
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

		static Delegate cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsActionInstalled_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IsActionInstalled_Landroid_content_Context_Ljava_lang_String_);
			return cb_isActionInstalled_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_IsActionInstalled_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsActionInstalled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='isActionInstalled' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isActionInstalled", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetIsActionInstalled_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsActionInstalled (global::Android.Content.Context p0, string p1)
		{
			const string __id = "isActionInstalled.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Register_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Register (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetRegister_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public virtual unsafe int Register (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "register.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)I", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int SetParameter (string p0, string p1)
		{
			const string __id = "setParameter.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_stopSpeak;
#pragma warning disable 0169
		static Delegate GetStopSpeakHandler ()
		{
			if (cb_stopSpeak == null)
				cb_stopSpeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopSpeak);
			return cb_stopSpeak;
		}

		static void n_StopSpeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSpeak ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='stopSpeak' and count(parameter)=0]"
		[Register ("stopSpeak", "()V", "GetStopSpeakHandler")]
		public virtual unsafe void StopSpeak ()
		{
			const string __id = "stopSpeak.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler ()
		{
			if (cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ == null)
				cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_);
			return cb_verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_;
		}

		static int n_Verify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.SpeakerVerifierAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Iflytek.Speech.IVerifierListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.IVerifierListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Verify (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech']/class[@name='SpeakerVerifierAidl']/method[@name='verify' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.speech.VerifierListener']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I", "GetVerify_Ljava_lang_String_Ljava_lang_String_Lcom_iflytek_speech_VerifierListener_Handler")]
		public virtual unsafe int Verify (string p0, string p1, global::Com.Iflytek.Speech.IVerifierListener p2)
		{
			const string __id = "verify.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/speech/VerifierListener;)I";
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

	}
}
