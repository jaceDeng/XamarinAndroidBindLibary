using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/SpeechRecognizer", DoNotGenerateAcw=true)]
	public sealed partial class SpeechRecognizer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/SpeechRecognizer", typeof (SpeechRecognizer));
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

		internal SpeechRecognizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "")]
			get {
				const string __id = "isListening.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Iflytek.Cloud.SpeechRecognizer Recognizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='getRecognizer' and count(parameter)=0]"
			[Register ("getRecognizer", "()Lcom/iflytek/cloud/SpeechRecognizer;", "")]
			get {
				const string __id = "getRecognizer.()Lcom/iflytek/cloud/SpeechRecognizer;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechRecognizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "")]
		private unsafe void A (global::Android.Content.Context p0)
		{
			const string __id = "a.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='buildGrammar' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.cloud.GrammarListener']]"
		[Register ("buildGrammar", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/GrammarListener;)I", "")]
		public unsafe int BuildGrammar (string p0, string p1, global::Com.Iflytek.Cloud.IGrammarListener p2)
		{
			const string __id = "buildGrammar.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/GrammarListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='createRecognizer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.iflytek.cloud.InitListener']]"
		[Register ("createRecognizer", "(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechRecognizer;", "")]
		public static unsafe global::Com.Iflytek.Cloud.SpeechRecognizer CreateRecognizer (global::Android.Content.Context p0, global::Com.Iflytek.Cloud.IInitListener p1)
		{
			const string __id = "createRecognizer.(Landroid/content/Context;Lcom/iflytek/cloud/InitListener;)Lcom/iflytek/cloud/SpeechRecognizer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechRecognizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='startListening' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.RecognizerListener']]"
		[Register ("startListening", "(Lcom/iflytek/cloud/RecognizerListener;)I", "")]
		public unsafe int StartListening (global::Com.Iflytek.Cloud.IRecognizerListener p0)
		{
			const string __id = "startListening.(Lcom/iflytek/cloud/RecognizerListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='stopListening' and count(parameter)=0]"
		[Register ("stopListening", "()V", "")]
		public unsafe void StopListening ()
		{
			const string __id = "stopListening.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='updateLexicon' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.iflytek.cloud.LexiconListener']]"
		[Register ("updateLexicon", "(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/LexiconListener;)I", "")]
		public unsafe int UpdateLexicon (string p0, string p1, global::Com.Iflytek.Cloud.ILexiconListener p2)
		{
			const string __id = "updateLexicon.(Ljava/lang/String;Ljava/lang/String;Lcom/iflytek/cloud/LexiconListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='writeAudio' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeAudio", "([BII)I", "")]
		public unsafe int WriteAudio (byte[] p0, int p1, int p2)
		{
			const string __id = "writeAudio.([BII)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='SpeechRecognizer']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register("setParameter", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe bool SetParameter(string p0, string p1)
		{
			const string __id = "setParameter.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString(p0);
			IntPtr native_p1 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue(native_p0);
				__args[1] = new JniArgumentValue(native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod(__id, this, __args);
				return __rm;
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
				JNIEnv.DeleteLocalRef(native_p1);
			}
		}

	}
}
