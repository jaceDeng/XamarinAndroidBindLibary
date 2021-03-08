using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/iflytek/cloud/ErrorCode", DoNotGenerateAcw=true)]
	public partial class ErrorCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_BASE']"
		[Register ("ERROR_AIMIC_BASE")]
		public const int ErrorAimicBase = (int) 27000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_BUSY']"
		[Register ("ERROR_AIMIC_BUSY")]
		public const int ErrorAimicBusy = (int) 27014;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_CREATE_HANDLE']"
		[Register ("ERROR_AIMIC_CREATE_HANDLE")]
		public const int ErrorAimicCreateHandle = (int) 27005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_FILE_ACCESS']"
		[Register ("ERROR_AIMIC_FILE_ACCESS")]
		public const int ErrorAimicFileAccess = (int) 27002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_FILE_OPEN']"
		[Register ("ERROR_AIMIC_FILE_OPEN")]
		public const int ErrorAimicFileOpen = (int) 27001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_INVALID_CALL']"
		[Register ("ERROR_AIMIC_INVALID_CALL")]
		public const int ErrorAimicInvalidCall = (int) 27017;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_INVALID_DATA']"
		[Register ("ERROR_AIMIC_INVALID_DATA")]
		public const int ErrorAimicInvalidData = (int) 27010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_INVALID_PARA']"
		[Register ("ERROR_AIMIC_INVALID_PARA")]
		public const int ErrorAimicInvalidPara = (int) 27013;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_INVALID_PARA_VALUE']"
		[Register ("ERROR_AIMIC_INVALID_PARA_VALUE")]
		public const int ErrorAimicInvalidParaValue = (int) 27012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_INVALID_RESULT']"
		[Register ("ERROR_AIMIC_INVALID_RESULT")]
		public const int ErrorAimicInvalidResult = (int) 27019;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_JNIENV']"
		[Register ("ERROR_AIMIC_JNIENV")]
		public const int ErrorAimicJnienv = (int) 27015;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_LOCK']"
		[Register ("ERROR_AIMIC_LOCK")]
		public const int ErrorAimicLock = (int) 27003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_MSG_UNHANDLED']"
		[Register ("ERROR_AIMIC_MSG_UNHANDLED")]
		public const int ErrorAimicMsgUnhandled = (int) 27018;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_NOT_ENOUGH_BUF']"
		[Register ("ERROR_AIMIC_NOT_ENOUGH_BUF")]
		public const int ErrorAimicNotEnoughBuf = (int) 27011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_NOT_INIT']"
		[Register ("ERROR_AIMIC_NOT_INIT")]
		public const int ErrorAimicNotInit = (int) 27008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_NULL_HANDLE']"
		[Register ("ERROR_AIMIC_NULL_HANDLE")]
		public const int ErrorAimicNullHandle = (int) 27006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_OOM']"
		[Register ("ERROR_AIMIC_OOM")]
		public const int ErrorAimicOom = (int) 27004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_QUEUE']"
		[Register ("ERROR_AIMIC_QUEUE")]
		public const int ErrorAimicQueue = (int) 27007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_STR_COPY']"
		[Register ("ERROR_AIMIC_STR_COPY")]
		public const int ErrorAimicStrCopy = (int) 27009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_UNKNOWN']"
		[Register ("ERROR_AIMIC_UNKNOWN")]
		public const int ErrorAimicUnknown = (int) 27099;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AIMIC_UNSATISFIED_LINK']"
		[Register ("ERROR_AIMIC_UNSATISFIED_LINK")]
		public const int ErrorAimicUnsatisfiedLink = (int) 27016;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_BASE']"
		[Register ("ERROR_AISOUND_BASE")]
		public const int ErrorAisoundBase = (int) 24100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_BUFFER_OVERFLOW']"
		[Register ("ERROR_AISOUND_BUFFER_OVERFLOW")]
		public const int ErrorAisoundBufferOverflow = (int) 24112;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_HEADFILE']"
		[Register ("ERROR_AISOUND_HEADFILE")]
		public const int ErrorAisoundHeadfile = (int) 24111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INSUFFICIENT_HEAP']"
		[Register ("ERROR_AISOUND_INSUFFICIENT_HEAP")]
		public const int ErrorAisoundInsufficientHeap = (int) 24104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INVALID_CSSML']"
		[Register ("ERROR_AISOUND_INVALID_CSSML")]
		public const int ErrorAisoundInvalidCssml = (int) 24114;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INVALID_HANDLE']"
		[Register ("ERROR_AISOUND_INVALID_HANDLE")]
		public const int ErrorAisoundInvalidHandle = (int) 24102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INVALID_ISAMPA']"
		[Register ("ERROR_AISOUND_INVALID_ISAMPA")]
		public const int ErrorAisoundInvalidIsampa = (int) 24113;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INVALID_PARA']"
		[Register ("ERROR_AISOUND_INVALID_PARA")]
		public const int ErrorAisoundInvalidPara = (int) 24103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INVALID_PARA_ID']"
		[Register ("ERROR_AISOUND_INVALID_PARA_ID")]
		public const int ErrorAisoundInvalidParaId = (int) 24106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_INVALID_PARA_VALUE']"
		[Register ("ERROR_AISOUND_INVALID_PARA_VALUE")]
		public const int ErrorAisoundInvalidParaValue = (int) 24107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_LBENDIAN']"
		[Register ("ERROR_AISOUND_LBENDIAN")]
		public const int ErrorAisoundLbendian = (int) 24110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_RESOURCE']"
		[Register ("ERROR_AISOUND_RESOURCE")]
		public const int ErrorAisoundResource = (int) 24108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_RESOURCE_READ']"
		[Register ("ERROR_AISOUND_RESOURCE_READ")]
		public const int ErrorAisoundResourceRead = (int) 24109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_STATE_REFUSE']"
		[Register ("ERROR_AISOUND_STATE_REFUSE")]
		public const int ErrorAisoundStateRefuse = (int) 24105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_UNIMPEMENTED']"
		[Register ("ERROR_AISOUND_UNIMPEMENTED")]
		public const int ErrorAisoundUnimpemented = (int) 24100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AISOUND_UNSUPPORTED']"
		[Register ("ERROR_AISOUND_UNSUPPORTED")]
		public const int ErrorAisoundUnsupported = (int) 24101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_ALREADY_STARTED']"
		[Register ("ERROR_AITALK_ALREADY_STARTED")]
		public const int ErrorAitalkAlreadyStarted = (int) 23130;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_ALREADY_STOPPED']"
		[Register ("ERROR_AITALK_ALREADY_STOPPED")]
		public const int ErrorAitalkAlreadyStopped = (int) 23131;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_AUDIO_CUT']"
		[Register ("ERROR_AITALK_AUDIO_CUT")]
		public const int ErrorAitalkAudioCut = (int) 23121;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_AUDIO_LOWER']"
		[Register ("ERROR_AITALK_AUDIO_LOWER")]
		public const int ErrorAitalkAudioLower = (int) 23122;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_BUFFER_EMPTY']"
		[Register ("ERROR_AITALK_BUFFER_EMPTY")]
		public const int ErrorAitalkBufferEmpty = (int) 23117;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_BUFFER_OVERFLOW']"
		[Register ("ERROR_AITALK_BUFFER_OVERFLOW")]
		public const int ErrorAitalkBufferOverflow = (int) 23103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_BUSY']"
		[Register ("ERROR_AITALK_BUSY")]
		public const int ErrorAitalkBusy = (int) 23126;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_CANNOT_SAVE_FILE']"
		[Register ("ERROR_AITALK_CANNOT_SAVE_FILE")]
		public const int ErrorAitalkCannotSaveFile = (int) 23115;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_ENDED']"
		[Register ("ERROR_AITALK_ENDED")]
		public const int ErrorAitalkEnded = (int) 23113;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_FAILED']"
		[Register ("ERROR_AITALK_FAILED")]
		public const int ErrorAitalkFailed = (int) 23104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_FALSE']"
		[Register ("ERROR_AITALK_FALSE")]
		public const int ErrorAitalkFalse = (int) 23100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_GET_RESULT']"
		[Register ("ERROR_AITALK_GET_RESULT")]
		public const int ErrorAitalkGetResult = (int) 23118;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_GRM_ERR']"
		[Register ("ERROR_AITALK_GRM_ERR")]
		public const int ErrorAitalkGrmErr = (int) 23300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_GRM_NOT_UPDATE']"
		[Register ("ERROR_AITALK_GRM_NOT_UPDATE")]
		public const int ErrorAitalkGrmNotUpdate = (int) 23127;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_IDLE']"
		[Register ("ERROR_AITALK_IDLE")]
		public const int ErrorAitalkIdle = (int) 23114;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_INSUFFICIENT_PERMISSIONS']"
		[Register ("ERROR_AITALK_INSUFFICIENT_PERMISSIONS")]
		public const int ErrorAitalkInsufficientPermissions = (int) 23123;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_INVALID_CALL']"
		[Register ("ERROR_AITALK_INVALID_CALL")]
		public const int ErrorAitalkInvalidCall = (int) 23110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_INVALID_GRAMMAR']"
		[Register ("ERROR_AITALK_INVALID_GRAMMAR")]
		public const int ErrorAitalkInvalidGrammar = (int) 23109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_INVALID_GRAMMAR_NAME']"
		[Register ("ERROR_AITALK_INVALID_GRAMMAR_NAME")]
		public const int ErrorAitalkInvalidGrammarName = (int) 23116;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_INVALID_PARA']"
		[Register ("ERROR_AITALK_INVALID_PARA")]
		public const int ErrorAitalkInvalidPara = (int) 23102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_INVALID_RESOURCE']"
		[Register ("ERROR_AITALK_INVALID_RESOURCE")]
		public const int ErrorAitalkInvalidResource = (int) 23107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_MAE_RIGHT']"
		[Register ("ERROR_AITALK_MAE_RIGHT")]
		public const int ErrorAitalkMaeRight = (int) 23134;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_MAE_WRONG']"
		[Register ("ERROR_AITALK_MAE_WRONG")]
		public const int ErrorAitalkMaeWrong = (int) 23135;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_NOT_FOUND']"
		[Register ("ERROR_AITALK_NOT_FOUND")]
		public const int ErrorAitalkNotFound = (int) 23108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_NOT_SUPPORTED']"
		[Register ("ERROR_AITALK_NOT_SUPPORTED")]
		public const int ErrorAitalkNotSupported = (int) 23105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_OUT_OF_MEMORY']"
		[Register ("ERROR_AITALK_OUT_OF_MEMORY")]
		public const int ErrorAitalkOutOfMemory = (int) 23106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_PERMISSION_DENIED']"
		[Register ("ERROR_AITALK_PERMISSION_DENIED")]
		public const int ErrorAitalkPermissionDenied = (int) 23101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_REACT_OUT_TIME']"
		[Register ("ERROR_AITALK_REACT_OUT_TIME")]
		public const int ErrorAitalkReactOutTime = (int) 23119;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_RESET']"
		[Register ("ERROR_AITALK_RESET")]
		public const int ErrorAitalkReset = (int) 23112;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_RESULT_ERROR']"
		[Register ("ERROR_AITALK_RESULT_ERROR")]
		public const int ErrorAitalkResultError = (int) 23124;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_SHORT_PAUSE']"
		[Register ("ERROR_AITALK_SHORT_PAUSE")]
		public const int ErrorAitalkShortPause = (int) 23125;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_SPEECH_OUT_TIME']"
		[Register ("ERROR_AITALK_SPEECH_OUT_TIME")]
		public const int ErrorAitalkSpeechOutTime = (int) 23120;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_STARTED']"
		[Register ("ERROR_AITALK_STARTED")]
		public const int ErrorAitalkStarted = (int) 23128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_STOPPED']"
		[Register ("ERROR_AITALK_STOPPED")]
		public const int ErrorAitalkStopped = (int) 23129;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_SYNTAX_ERROR']"
		[Register ("ERROR_AITALK_SYNTAX_ERROR")]
		public const int ErrorAitalkSyntaxError = (int) 23111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_TOO_MANY_COMMAND']"
		[Register ("ERROR_AITALK_TOO_MANY_COMMAND")]
		public const int ErrorAitalkTooManyCommand = (int) 23132;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AITALK_WAIT']"
		[Register ("ERROR_AITALK_WAIT")]
		public const int ErrorAitalkWait = (int) 23133;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_CLIENT']"
		[Register ("ERROR_ASR_CLIENT")]
		public const int ErrorAsrClient = (int) 23000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_CREATE_HANDLE_FAILED']"
		[Register ("ERROR_ASR_CREATE_HANDLE_FAILED")]
		public const int ErrorAsrCreateHandleFailed = (int) 23004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_ENGINE_INIT_FAILED']"
		[Register ("ERROR_ASR_ENGINE_INIT_FAILED")]
		public const int ErrorAsrEngineInitFailed = (int) 23005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_ENGINE_STARTED']"
		[Register ("ERROR_ASR_ENGINE_STARTED")]
		public const int ErrorAsrEngineStarted = (int) 23006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_ENGINE_UNINIT']"
		[Register ("ERROR_ASR_ENGINE_UNINIT")]
		public const int ErrorAsrEngineUninit = (int) 23007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_FILE_ACCESS']"
		[Register ("ERROR_ASR_FILE_ACCESS")]
		public const int ErrorAsrFileAccess = (int) 23011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_INVALID_HANDLE']"
		[Register ("ERROR_ASR_INVALID_HANDLE")]
		public const int ErrorAsrInvalidHandle = (int) 23010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_INVALID_PARA']"
		[Register ("ERROR_ASR_INVALID_PARA")]
		public const int ErrorAsrInvalidPara = (int) 23001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_INVALID_PARA_VALUE']"
		[Register ("ERROR_ASR_INVALID_PARA_VALUE")]
		public const int ErrorAsrInvalidParaValue = (int) 23002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_NO_RECOGNIZED_RESULT']"
		[Register ("ERROR_ASR_NO_RECOGNIZED_RESULT")]
		public const int ErrorAsrNoRecognizedResult = (int) 23009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_OUT_OF_MEMORY']"
		[Register ("ERROR_ASR_OUT_OF_MEMORY")]
		public const int ErrorAsrOutOfMemory = (int) 23003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ASR_SPEECH_TIMEOUT']"
		[Register ("ERROR_ASR_SPEECH_TIMEOUT")]
		public const int ErrorAsrSpeechTimeout = (int) 23008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_AUDIO_RECORD']"
		[Register ("ERROR_AUDIO_RECORD")]
		public const int ErrorAudioRecord = (int) 20006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_COMPONENT_NOT_INSTALLED']"
		[Register ("ERROR_COMPONENT_NOT_INSTALLED")]
		public const int ErrorComponentNotInstalled = (int) 21001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_EMPTY_UTTERANCE']"
		[Register ("ERROR_EMPTY_UTTERANCE")]
		public const int ErrorEmptyUtterance = (int) 20009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ENGINE_BUSY']"
		[Register ("ERROR_ENGINE_BUSY")]
		public const int ErrorEngineBusy = (int) 21005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ENGINE_CALL_FAIL']"
		[Register ("ERROR_ENGINE_CALL_FAIL")]
		public const int ErrorEngineCallFail = (int) 21004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ENGINE_INIT_FAIL']"
		[Register ("ERROR_ENGINE_INIT_FAIL")]
		public const int ErrorEngineInitFail = (int) 21003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_ENGINE_NOT_SUPPORTED']"
		[Register ("ERROR_ENGINE_NOT_SUPPORTED")]
		public const int ErrorEngineNotSupported = (int) 21002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_FILE_ACCESS']"
		[Register ("ERROR_FILE_ACCESS")]
		public const int ErrorFileAccess = (int) 20010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_INTERRUPT']"
		[Register ("ERROR_INTERRUPT")]
		public const int ErrorInterrupt = (int) 20017;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_INVALID_DATA']"
		[Register ("ERROR_INVALID_DATA")]
		public const int ErrorInvalidData = (int) 20014;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_INVALID_PARAM']"
		[Register ("ERROR_INVALID_PARAM")]
		public const int ErrorInvalidParam = (int) 20012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_INVALID_RESULT']"
		[Register ("ERROR_INVALID_RESULT")]
		public const int ErrorInvalidResult = (int) 20004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENGINE_UNINI']"
		[Register ("ERROR_IVW_ENGINE_UNINI")]
		public const int ErrorIvwEngineUnini = (int) 25000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENROLL1_FAILED']"
		[Register ("ERROR_IVW_ENROLL1_FAILED")]
		public const int ErrorIvwEnroll1Failed = (int) 25115;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENROLL1_SUCESS']"
		[Register ("ERROR_IVW_ENROLL1_SUCESS")]
		public const int ErrorIvwEnroll1Sucess = (int) 25114;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENROLL2_FAILED']"
		[Register ("ERROR_IVW_ENROLL2_FAILED")]
		public const int ErrorIvwEnroll2Failed = (int) 25117;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENROLL2_SUCESS']"
		[Register ("ERROR_IVW_ENROLL2_SUCESS")]
		public const int ErrorIvwEnroll2Sucess = (int) 25116;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENROLL3_FAILED']"
		[Register ("ERROR_IVW_ENROLL3_FAILED")]
		public const int ErrorIvwEnroll3Failed = (int) 25119;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_ENROLL3_SUCESS']"
		[Register ("ERROR_IVW_ENROLL3_SUCESS")]
		public const int ErrorIvwEnroll3Sucess = (int) 25118;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_INTERRUPT']"
		[Register ("ERROR_IVW_INTERRUPT")]
		public const int ErrorIvwInterrupt = (int) 22004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_INVALID_ARG']"
		[Register ("ERROR_IVW_INVALID_ARG")]
		public const int ErrorIvwInvalidArg = (int) 25102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_INVALID_CALL']"
		[Register ("ERROR_IVW_INVALID_CALL")]
		public const int ErrorIvwInvalidCall = (int) 25101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_INVALID_RESOURCE']"
		[Register ("ERROR_IVW_INVALID_RESOURCE")]
		public const int ErrorIvwInvalidResource = (int) 25107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_INVALID_SN']"
		[Register ("ERROR_IVW_INVALID_SN")]
		public const int ErrorIvwInvalidSn = (int) 25111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_LIMITTED']"
		[Register ("ERROR_IVW_LIMITTED")]
		public const int ErrorIvwLimitted = (int) 25112;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_NOT_FOUND']"
		[Register ("ERROR_IVW_NOT_FOUND")]
		public const int ErrorIvwNotFound = (int) 25110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_NOT_SUPPORT']"
		[Register ("ERROR_IVW_NOT_SUPPORT")]
		public const int ErrorIvwNotSupport = (int) 25109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_OUT_BUFFER_EMPTY']"
		[Register ("ERROR_IVW_OUT_BUFFER_EMPTY")]
		public const int ErrorIvwOutBufferEmpty = (int) 25106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_OUT_BUFFER_FULL']"
		[Register ("ERROR_IVW_OUT_BUFFER_FULL")]
		public const int ErrorIvwOutBufferFull = (int) 25105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_OUT_OF_MEMORY']"
		[Register ("ERROR_IVW_OUT_OF_MEMORY")]
		public const int ErrorIvwOutOfMemory = (int) 25104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_REPETITIOPN_ENTER']"
		[Register ("ERROR_IVW_REPETITIOPN_ENTER")]
		public const int ErrorIvwRepetitiopnEnter = (int) 25108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_RESVER_NOMATCH']"
		[Register ("ERROR_IVW_RESVER_NOMATCH")]
		public const int ErrorIvwResverNomatch = (int) 25001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_SPEECH_STOP']"
		[Register ("ERROR_IVW_SPEECH_STOP")]
		public const int ErrorIvwSpeechStop = (int) 25121;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_SPEECH_TOO_SHORT']"
		[Register ("ERROR_IVW_SPEECH_TOO_SHORT")]
		public const int ErrorIvwSpeechTooShort = (int) 25120;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_TELL_SIZE']"
		[Register ("ERROR_IVW_TELL_SIZE")]
		public const int ErrorIvwTellSize = (int) 25103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_IVW_TIME_OUT']"
		[Register ("ERROR_IVW_TIME_OUT")]
		public const int ErrorIvwTimeOut = (int) 25113;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_LOCAL_ENGINE']"
		[Register ("ERROR_LOCAL_ENGINE")]
		public const int ErrorLocalEngine = (int) 22003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_LOCAL_NO_INIT']"
		[Register ("ERROR_LOCAL_NO_INIT")]
		public const int ErrorLocalNoInit = (int) 22001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_LOCAL_RESOURCE']"
		[Register ("ERROR_LOCAL_RESOURCE")]
		public const int ErrorLocalResource = (int) 22002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_LOGIN']"
		[Register ("ERROR_LOGIN")]
		public const int ErrorLogin = (int) 20015;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_MFV_ENGINE_UNINI']"
		[Register ("ERROR_MFV_ENGINE_UNINI")]
		public const int ErrorMfvEngineUnini = (int) 26000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_MFV_RESVER_NOMATCH']"
		[Register ("ERROR_MFV_RESVER_NOMATCH")]
		public const int ErrorMfvResverNomatch = (int) 26001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_NETWORK_TIMEOUT']"
		[Register ("ERROR_NETWORK_TIMEOUT")]
		public const int ErrorNetworkTimeout = (int) 20002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_NET_EXCEPTION']"
		[Register ("ERROR_NET_EXCEPTION")]
		public const int ErrorNetException = (int) 20003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_NO_MATCH']"
		[Register ("ERROR_NO_MATCH")]
		public const int ErrorNoMatch = (int) 20005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_NO_NETWORK']"
		[Register ("ERROR_NO_NETWORK")]
		public const int ErrorNoNetwork = (int) 20001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_NO_SPEECH']"
		[Register ("ERROR_NO_SPEECH")]
		public const int ErrorNoSpeech = (int) 20007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_PERMISSION_DENIED']"
		[Register ("ERROR_PERMISSION_DENIED")]
		public const int ErrorPermissionDenied = (int) 20016;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_PLAY_MEDIA']"
		[Register ("ERROR_PLAY_MEDIA")]
		public const int ErrorPlayMedia = (int) 20011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_SPEECH_TIMEOUT']"
		[Register ("ERROR_SPEECH_TIMEOUT")]
		public const int ErrorSpeechTimeout = (int) 20008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_SYSTEM_PREINSTALL']"
		[Register ("ERROR_SYSTEM_PREINSTALL")]
		public const int ErrorSystemPreinstall = (int) 20020;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TEXT_OVERFLOW']"
		[Register ("ERROR_TEXT_OVERFLOW")]
		public const int ErrorTextOverflow = (int) 20013;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_CREATE_HANDLE_FAILED']"
		[Register ("ERROR_TTS_CREATE_HANDLE_FAILED")]
		public const int ErrorTtsCreateHandleFailed = (int) 24004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_ENGINE_BUSY']"
		[Register ("ERROR_TTS_ENGINE_BUSY")]
		public const int ErrorTtsEngineBusy = (int) 24009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_ENGINE_INIT_FAILED']"
		[Register ("ERROR_TTS_ENGINE_INIT_FAILED")]
		public const int ErrorTtsEngineInitFailed = (int) 24008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_ENGINE_UNINIT']"
		[Register ("ERROR_TTS_ENGINE_UNINIT")]
		public const int ErrorTtsEngineUninit = (int) 24007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_INVALID_HANDLE']"
		[Register ("ERROR_TTS_INVALID_HANDLE")]
		public const int ErrorTtsInvalidHandle = (int) 24003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_INVALID_PARA']"
		[Register ("ERROR_TTS_INVALID_PARA")]
		public const int ErrorTtsInvalidPara = (int) 24000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_INVALID_PARA_VALUE']"
		[Register ("ERROR_TTS_INVALID_PARA_VALUE")]
		public const int ErrorTtsInvalidParaValue = (int) 24001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_INVALID_RESOURCE']"
		[Register ("ERROR_TTS_INVALID_RESOURCE")]
		public const int ErrorTtsInvalidResource = (int) 24005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_INVALID_VOICE_NAME']"
		[Register ("ERROR_TTS_INVALID_VOICE_NAME")]
		public const int ErrorTtsInvalidVoiceName = (int) 24006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_TTS_OUT_OF_MEMORY']"
		[Register ("ERROR_TTS_OUT_OF_MEMORY")]
		public const int ErrorTtsOutOfMemory = (int) 24002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_UNKNOWN']"
		[Register ("ERROR_UNKNOWN")]
		public const int ErrorUnknown = (int) 20999;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_UNSATISFIED_LINK']"
		[Register ("ERROR_UNSATISFIED_LINK")]
		public const int ErrorUnsatisfiedLink = (int) 20021;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='ERROR_VERSION_LOWER']"
		[Register ("ERROR_VERSION_LOWER")]
		public const int ErrorVersionLower = (int) 20018;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ACCESS']"
		[Register ("MSP_ERROR_ACCESS")]
		public const int MspErrorAccess = (int) 10105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ALREADY_EXIST']"
		[Register ("MSP_ERROR_ALREADY_EXIST")]
		public const int MspErrorAlreadyExist = (int) 10121;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_NOTMONO']"
		[Register ("MSP_ERROR_ASE_EXCEP_NOTMONO")]
		public const int MspErrorAseExcepNotmono = (int) 11405;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_OTHERS']"
		[Register ("MSP_ERROR_ASE_EXCEP_OTHERS")]
		public const int MspErrorAseExcepOthers = (int) 11406;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_PAPERCONTENTS']"
		[Register ("MSP_ERROR_ASE_EXCEP_PAPERCONTENTS")]
		public const int MspErrorAseExcepPapercontents = (int) 11404;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_PAPERDATA']"
		[Register ("MSP_ERROR_ASE_EXCEP_PAPERDATA")]
		public const int MspErrorAseExcepPaperdata = (int) 11403;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_PAPERFMT']"
		[Register ("MSP_ERROR_ASE_EXCEP_PAPERFMT")]
		public const int MspErrorAseExcepPaperfmt = (int) 11407;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_SILENCE']"
		[Register ("MSP_ERROR_ASE_EXCEP_SILENCE")]
		public const int MspErrorAseExcepSilence = (int) 11401;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_SNRATIO']"
		[Register ("MSP_ERROR_ASE_EXCEP_SNRATIO")]
		public const int MspErrorAseExcepSnratio = (int) 11402;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ASE_EXCEP_ULISTWORD']"
		[Register ("MSP_ERROR_ASE_EXCEP_ULISTWORD")]
		public const int MspErrorAseExcepUlistword = (int) 11408;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_APPID_NOT_MATCH']"
		[Register ("MSP_ERROR_AUTH_APPID_NOT_MATCH")]
		public const int MspErrorAuthAppidNotMatch = (int) 11210;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_EXCEED_LICENSE']"
		[Register ("MSP_ERROR_AUTH_DVC_EXCEED_LICENSE")]
		public const int MspErrorAuthDvcExceedLicense = (int) 11306;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_INVALID_LICENSE']"
		[Register ("MSP_ERROR_AUTH_DVC_INVALID_LICENSE")]
		public const int MspErrorAuthDvcInvalidLicense = (int) 11302;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_LICENSE_EXPIRED']"
		[Register ("MSP_ERROR_AUTH_DVC_LICENSE_EXPIRED")]
		public const int MspErrorAuthDvcLicenseExpired = (int) 11303;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_LICENSE_TO_BE_EXPIRED']"
		[Register ("MSP_ERROR_AUTH_DVC_LICENSE_TO_BE_EXPIRED")]
		public const int MspErrorAuthDvcLicenseToBeExpired = (int) 11305;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_NEED_MORE_DATA']"
		[Register ("MSP_ERROR_AUTH_DVC_NEED_MORE_DATA")]
		public const int MspErrorAuthDvcNeedMoreData = (int) 11304;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_NO_ENOUGH_LICENSE']"
		[Register ("MSP_ERROR_AUTH_DVC_NO_ENOUGH_LICENSE")]
		public const int MspErrorAuthDvcNoEnoughLicense = (int) 11301;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_DVC_NO_LICENSE']"
		[Register ("MSP_ERROR_AUTH_DVC_NO_LICENSE")]
		public const int MspErrorAuthDvcNoLicense = (int) 11300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_ERROR_END']"
		[Register ("MSP_ERROR_AUTH_ERROR_END")]
		public const int MspErrorAuthErrorEnd = (int) 11250;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_INVALID_LICENSE']"
		[Register ("MSP_ERROR_AUTH_INVALID_LICENSE")]
		public const int MspErrorAuthInvalidLicense = (int) 11202;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_INVALID_MACHINE_ID']"
		[Register ("MSP_ERROR_AUTH_INVALID_MACHINE_ID")]
		public const int MspErrorAuthInvalidMachineId = (int) 11206;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_LICENSE_EXPIRED']"
		[Register ("MSP_ERROR_AUTH_LICENSE_EXPIRED")]
		public const int MspErrorAuthLicenseExpired = (int) 11203;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_LICENSE_TO_BE_EXPIRED']"
		[Register ("MSP_ERROR_AUTH_LICENSE_TO_BE_EXPIRED")]
		public const int MspErrorAuthLicenseToBeExpired = (int) 11205;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_LOCAL_ASR_FORBIDDEN']"
		[Register ("MSP_ERROR_AUTH_LOCAL_ASR_FORBIDDEN")]
		public const int MspErrorAuthLocalAsrForbidden = (int) 11207;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_LOCAL_IVW_FORBIDDEN']"
		[Register ("MSP_ERROR_AUTH_LOCAL_IVW_FORBIDDEN")]
		public const int MspErrorAuthLocalIvwForbidden = (int) 11209;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_LOCAL_TTS_FORBIDDEN']"
		[Register ("MSP_ERROR_AUTH_LOCAL_TTS_FORBIDDEN")]
		public const int MspErrorAuthLocalTtsForbidden = (int) 11208;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_NEED_MORE_DATA']"
		[Register ("MSP_ERROR_AUTH_NEED_MORE_DATA")]
		public const int MspErrorAuthNeedMoreData = (int) 11204;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_NO_ENOUGH_LICENSE']"
		[Register ("MSP_ERROR_AUTH_NO_ENOUGH_LICENSE")]
		public const int MspErrorAuthNoEnoughLicense = (int) 11201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_NO_LICENSE']"
		[Register ("MSP_ERROR_AUTH_NO_LICENSE")]
		public const int MspErrorAuthNoLicense = (int) 11200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_TRIAL_EXPIRED']"
		[Register ("MSP_ERROR_AUTH_TRIAL_EXPIRED")]
		public const int MspErrorAuthTrialExpired = (int) 11212;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_AUTH_UID_NOT_MATCH']"
		[Register ("MSP_ERROR_AUTH_UID_NOT_MATCH")]
		public const int MspErrorAuthUidNotMatch = (int) 11211;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_BIZ_BASE']"
		[Register ("MSP_ERROR_BIZ_BASE")]
		public const int MspErrorBizBase = (int) 17000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_BOS_TIMEOUT']"
		[Register ("MSP_ERROR_BOS_TIMEOUT")]
		public const int MspErrorBosTimeout = (int) 10140;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_BUSY']"
		[Register ("MSP_ERROR_BUSY")]
		public const int MspErrorBusy = (int) 10123;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_BUSY_GRMBUILDING']"
		[Register ("MSP_ERROR_BUSY_GRMBUILDING")]
		public const int MspErrorBusyGrmbuilding = (int) 10137;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_BUSY_LEXUPDATING']"
		[Register ("MSP_ERROR_BUSY_LEXUPDATING")]
		public const int MspErrorBusyLexupdating = (int) 10138;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_CANCELED']"
		[Register ("MSP_ERROR_CANCELED")]
		public const int MspErrorCanceled = (int) 10126;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_CLIENT_AREA_CHANGE']"
		[Register ("MSP_ERROR_CLIENT_AREA_CHANGE")]
		public const int MspErrorClientAreaChange = (int) 10220;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_CLIENT_CLOSE']"
		[Register ("MSP_ERROR_CLIENT_CLOSE")]
		public const int MspErrorClientClose = (int) 10219;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_CODING_LIB_NOT_LOAD']"
		[Register ("MSP_ERROR_CODING_LIB_NOT_LOAD")]
		public const int MspErrorCodingLibNotLoad = (int) 10130;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_CONFIG_INITIALIZE']"
		[Register ("MSP_ERROR_CONFIG_INITIALIZE")]
		public const int MspErrorConfigInitialize = (int) 10128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_CREATE_HANDLE']"
		[Register ("MSP_ERROR_CREATE_HANDLE")]
		public const int MspErrorCreateHandle = (int) 10129;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_CONNECT']"
		[Register ("MSP_ERROR_DB_CONNECT")]
		public const int MspErrorDbConnect = (int) 10405;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_EXCEPTION']"
		[Register ("MSP_ERROR_DB_EXCEPTION")]
		public const int MspErrorDbException = (int) 10401;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_GENERAL']"
		[Register ("MSP_ERROR_DB_GENERAL")]
		public const int MspErrorDbGeneral = (int) 10400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_INVALID_APPID']"
		[Register ("MSP_ERROR_DB_INVALID_APPID")]
		public const int MspErrorDbInvalidAppid = (int) 10407;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_INVALID_PWD']"
		[Register ("MSP_ERROR_DB_INVALID_PWD")]
		public const int MspErrorDbInvalidPwd = (int) 10404;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_INVALID_SQL']"
		[Register ("MSP_ERROR_DB_INVALID_SQL")]
		public const int MspErrorDbInvalidSql = (int) 10406;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_INVALID_USER']"
		[Register ("MSP_ERROR_DB_INVALID_USER")]
		public const int MspErrorDbInvalidUser = (int) 10403;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_NO_RESULT']"
		[Register ("MSP_ERROR_DB_NO_RESULT")]
		public const int MspErrorDbNoResult = (int) 10402;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_DB_NO_UID']"
		[Register ("MSP_ERROR_DB_NO_UID")]
		public const int MspErrorDbNoUid = (int) 10408;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_EP_GENERAL']"
		[Register ("MSP_ERROR_EP_GENERAL")]
		public const int MspErrorEpGeneral = (int) 10800;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_EP_INACTIVE']"
		[Register ("MSP_ERROR_EP_INACTIVE")]
		public const int MspErrorEpInactive = (int) 10802;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_EP_INITIALIZED']"
		[Register ("MSP_ERROR_EP_INITIALIZED")]
		public const int MspErrorEpInitialized = (int) 10803;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_EP_NO_SESSION_NAME']"
		[Register ("MSP_ERROR_EP_NO_SESSION_NAME")]
		public const int MspErrorEpNoSessionName = (int) 10801;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_EXCEPTION']"
		[Register ("MSP_ERROR_EXCEPTION")]
		public const int MspErrorException = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FACE_IMAGE_FULL_LEFT']"
		[Register ("MSP_ERROR_FACE_IMAGE_FULL_LEFT")]
		public const int MspErrorFaceImageFullLeft = (int) 11701;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FACE_IMAGE_FULL_RIGHT']"
		[Register ("MSP_ERROR_FACE_IMAGE_FULL_RIGHT")]
		public const int MspErrorFaceImageFullRight = (int) 11702;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FACE_INVALID_MODEL']"
		[Register ("MSP_ERROR_FACE_INVALID_MODEL")]
		public const int MspErrorFaceInvalidModel = (int) 11708;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FACE_MODEL_NOT_FOUND_IN_HBASE']"
		[Register ("MSP_ERROR_FACE_MODEL_NOT_FOUND_IN_HBASE")]
		public const int MspErrorFaceModelNotFoundInHbase = (int) 11712;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FACE_OCCULTATION']"
		[Register ("MSP_ERROR_FACE_OCCULTATION")]
		public const int MspErrorFaceOccultation = (int) 11707;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FAIL']"
		[Register ("MSP_ERROR_FAIL")]
		public const int MspErrorFail = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FILE_NOT_FOUND']"
		[Register ("MSP_ERROR_FILE_NOT_FOUND")]
		public const int MspErrorFileNotFound = (int) 10102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FUSION_ENOUGH_DATA']"
		[Register ("MSP_ERROR_FUSION_ENOUGH_DATA")]
		public const int MspErrorFusionEnoughData = (int) 11711;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FUSION_INVALID_INPUT_TYPE']"
		[Register ("MSP_ERROR_FUSION_INVALID_INPUT_TYPE")]
		public const int MspErrorFusionInvalidInputType = (int) 11709;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_FUSION_NO_ENOUGH_DATA']"
		[Register ("MSP_ERROR_FUSION_NO_ENOUGH_DATA")]
		public const int MspErrorFusionNoEnoughData = (int) 11710;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_GENERAL']"
		[Register ("MSP_ERROR_GENERAL")]
		public const int MspErrorGeneral = (int) 10100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_GROUP_EMPTY']"
		[Register ("MSP_ERROR_GROUP_EMPTY")]
		public const int MspErrorGroupEmpty = (int) 10141;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_APPEND_STROKES']"
		[Register ("MSP_ERROR_HCR_APPEND_STROKES")]
		public const int MspErrorHcrAppendStrokes = (int) 11105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_CREATE']"
		[Register ("MSP_ERROR_HCR_CREATE")]
		public const int MspErrorHcrCreate = (int) 11102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_DESTROY']"
		[Register ("MSP_ERROR_HCR_DESTROY")]
		public const int MspErrorHcrDestroy = (int) 11103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_DISPATCH']"
		[Register ("MSP_ERROR_HCR_DISPATCH")]
		public const int MspErrorHcrDispatch = (int) 11108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_GENERAL']"
		[Register ("MSP_ERROR_HCR_GENERAL")]
		public const int MspErrorHcrGeneral = (int) 11100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_GETRESULT']"
		[Register ("MSP_ERROR_HCR_GETRESULT")]
		public const int MspErrorHcrGetresult = (int) 11109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_INIT']"
		[Register ("MSP_ERROR_HCR_INIT")]
		public const int MspErrorHcrInit = (int) 11106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_POINT_DECODE']"
		[Register ("MSP_ERROR_HCR_POINT_DECODE")]
		public const int MspErrorHcrPointDecode = (int) 11107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_RESOURCE']"
		[Register ("MSP_ERROR_HCR_RESOURCE")]
		public const int MspErrorHcrResource = (int) 11110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_RESOURCE_NOT_EXIST']"
		[Register ("MSP_ERROR_HCR_RESOURCE_NOT_EXIST")]
		public const int MspErrorHcrResourceNotExist = (int) 11101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HCR_START']"
		[Register ("MSP_ERROR_HCR_START")]
		public const int MspErrorHcrStart = (int) 11104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_HTTP_BASE']"
		[Register ("MSP_ERROR_HTTP_BASE")]
		public const int MspErrorHttpBase = (int) 12000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IFR_NOT_FACE_IMAGE']"
		[Register ("MSP_ERROR_IFR_NOT_FACE_IMAGE")]
		public const int MspErrorIfrNotFaceImage = (int) 11700;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ILLUMINATION']"
		[Register ("MSP_ERROR_ILLUMINATION")]
		public const int MspErrorIllumination = (int) 11706;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IMAGE_CLOCKWISE_WHIRL']"
		[Register ("MSP_ERROR_IMAGE_CLOCKWISE_WHIRL")]
		public const int MspErrorImageClockwiseWhirl = (int) 11703;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IMAGE_COUNTET_CLOCKWISE_WHIRL']"
		[Register ("MSP_ERROR_IMAGE_COUNTET_CLOCKWISE_WHIRL")]
		public const int MspErrorImageCountetClockwiseWhirl = (int) 11704;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_CONFIG']"
		[Register ("MSP_ERROR_INVALID_CONFIG")]
		public const int MspErrorInvalidConfig = (int) 10124;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_DATA']"
		[Register ("MSP_ERROR_INVALID_DATA")]
		public const int MspErrorInvalidData = (int) 10109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_HANDLE']"
		[Register ("MSP_ERROR_INVALID_HANDLE")]
		public const int MspErrorInvalidHandle = (int) 10108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_MEDIA_TYPE']"
		[Register ("MSP_ERROR_INVALID_MEDIA_TYPE")]
		public const int MspErrorInvalidMediaType = (int) 10127;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_OPERATION']"
		[Register ("MSP_ERROR_INVALID_OPERATION")]
		public const int MspErrorInvalidOperation = (int) 10132;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_PARA']"
		[Register ("MSP_ERROR_INVALID_PARA")]
		public const int MspErrorInvalidPara = (int) 10106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_INVALID_PARA_VALUE']"
		[Register ("MSP_ERROR_INVALID_PARA_VALUE")]
		public const int MspErrorInvalidParaValue = (int) 10107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_ISV_NO_USER']"
		[Register ("MSP_ERROR_ISV_NO_USER")]
		public const int MspErrorIsvNoUser = (int) 13000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_EXTRA_RGN_SOPPORT']"
		[Register ("MSP_ERROR_IVP_EXTRA_RGN_SOPPORT")]
		public const int MspErrorIvpExtraRgnSopport = (int) 11601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_GENERAL']"
		[Register ("MSP_ERROR_IVP_GENERAL")]
		public const int MspErrorIvpGeneral = (int) 11600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_MODEL_NOT_FOUND_IN_HBASE']"
		[Register ("MSP_ERROR_IVP_MODEL_NOT_FOUND_IN_HBASE")]
		public const int MspErrorIvpModelNotFoundInHbase = (int) 11610;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_MUCH_NOISE']"
		[Register ("MSP_ERROR_IVP_MUCH_NOISE")]
		public const int MspErrorIvpMuchNoise = (int) 11603;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_NO_ENOUGH_AUDIO']"
		[Register ("MSP_ERROR_IVP_NO_ENOUGH_AUDIO")]
		public const int MspErrorIvpNoEnoughAudio = (int) 11608;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_TEXT_NOT_MATCH']"
		[Register ("MSP_ERROR_IVP_TEXT_NOT_MATCH")]
		public const int MspErrorIvpTextNotMatch = (int) 11607;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_TOO_LOW']"
		[Register ("MSP_ERROR_IVP_TOO_LOW")]
		public const int MspErrorIvpTooLow = (int) 11604;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_TRUNCATED']"
		[Register ("MSP_ERROR_IVP_TRUNCATED")]
		public const int MspErrorIvpTruncated = (int) 11602;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_UTTER_TOO_SHORT']"
		[Register ("MSP_ERROR_IVP_UTTER_TOO_SHORT")]
		public const int MspErrorIvpUtterTooShort = (int) 11606;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVP_ZERO_AUDIO']"
		[Register ("MSP_ERROR_IVP_ZERO_AUDIO")]
		public const int MspErrorIvpZeroAudio = (int) 11605;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVW_BUSY']"
		[Register ("MSP_ERROR_IVW_BUSY")]
		public const int MspErrorIvwBusy = (int) 11503;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVW_MODEL_NO_FOUND']"
		[Register ("MSP_ERROR_IVW_MODEL_NO_FOUND")]
		public const int MspErrorIvwModelNoFound = (int) 11502;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_IVW_MODEL_TRAINING']"
		[Register ("MSP_ERROR_IVW_MODEL_TRAINING")]
		public const int MspErrorIvwModelTraining = (int) 11501;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_ALREADY_LOADED']"
		[Register ("MSP_ERROR_LMOD_ALREADY_LOADED")]
		public const int MspErrorLmodAlreadyLoaded = (int) 16006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_BASE']"
		[Register ("MSP_ERROR_LMOD_BASE")]
		public const int MspErrorLmodBase = (int) 16000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_LOADCODE']"
		[Register ("MSP_ERROR_LMOD_LOADCODE")]
		public const int MspErrorLmodLoadcode = (int) 16003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_NOT_FOUND']"
		[Register ("MSP_ERROR_LMOD_NOT_FOUND")]
		public const int MspErrorLmodNotFound = (int) 16001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_PRECALL']"
		[Register ("MSP_ERROR_LMOD_PRECALL")]
		public const int MspErrorLmodPrecall = (int) 16004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_RUNTIME_EXCEPTION']"
		[Register ("MSP_ERROR_LMOD_RUNTIME_EXCEPTION")]
		public const int MspErrorLmodRuntimeException = (int) 16005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LMOD_UNEXPECTED_BIN']"
		[Register ("MSP_ERROR_LMOD_UNEXPECTED_BIN")]
		public const int MspErrorLmodUnexpectedBin = (int) 16002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOAD_MODULE']"
		[Register ("MSP_ERROR_LOAD_MODULE")]
		public const int MspErrorLoadModule = (int) 10122;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_INVALID_PWD']"
		[Register ("MSP_ERROR_LOGIN_INVALID_PWD")]
		public const int MspErrorLoginInvalidPwd = (int) 11006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_INVALID_USER']"
		[Register ("MSP_ERROR_LOGIN_INVALID_USER")]
		public const int MspErrorLoginInvalidUser = (int) 11005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_NO_LICENSE']"
		[Register ("MSP_ERROR_LOGIN_NO_LICENSE")]
		public const int MspErrorLoginNoLicense = (int) 11001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_SESSIONID_ERROR']"
		[Register ("MSP_ERROR_LOGIN_SESSIONID_ERROR")]
		public const int MspErrorLoginSessionidError = (int) 11003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_SESSIONID_INVALID']"
		[Register ("MSP_ERROR_LOGIN_SESSIONID_INVALID")]
		public const int MspErrorLoginSessionidInvalid = (int) 11002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_SUCCESS']"
		[Register ("MSP_ERROR_LOGIN_SUCCESS")]
		public const int MspErrorLoginSuccess = (int) 11000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_SYSTEM_ERROR']"
		[Register ("MSP_ERROR_LOGIN_SYSTEM_ERROR")]
		public const int MspErrorLoginSystemError = (int) 11099;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LOGIN_UNLOGIN']"
		[Register ("MSP_ERROR_LOGIN_UNLOGIN")]
		public const int MspErrorLoginUnlogin = (int) 11004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_BASE']"
		[Register ("MSP_ERROR_LUA_BASE")]
		public const int MspErrorLuaBase = (int) 14000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_ERRERR']"
		[Register ("MSP_ERROR_LUA_ERRERR")]
		public const int MspErrorLuaErrerr = (int) 14005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_ERRMEM']"
		[Register ("MSP_ERROR_LUA_ERRMEM")]
		public const int MspErrorLuaErrmem = (int) 14004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_ERRRUN']"
		[Register ("MSP_ERROR_LUA_ERRRUN")]
		public const int MspErrorLuaErrrun = (int) 14002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_ERRSYNTAX']"
		[Register ("MSP_ERROR_LUA_ERRSYNTAX")]
		public const int MspErrorLuaErrsyntax = (int) 14003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_INVALID_PARAM']"
		[Register ("MSP_ERROR_LUA_INVALID_PARAM")]
		public const int MspErrorLuaInvalidParam = (int) 14006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_LUA_YIELD']"
		[Register ("MSP_ERROR_LUA_YIELD")]
		public const int MspErrorLuaYield = (int) 14001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MESSAGE_NOT_COMPLETE']"
		[Register ("MSP_ERROR_MESSAGE_NOT_COMPLETE")]
		public const int MspErrorMessageNotComplete = (int) 10133;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_ALARM_CONTXT_NULL']"
		[Register ("MSP_ERROR_MMP_ALARM_CONTXT_NULL")]
		public const int MspErrorMmpAlarmContxtNull = (int) 15029;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_ALARM_GROUP_NULL']"
		[Register ("MSP_ERROR_MMP_ALARM_GROUP_NULL")]
		public const int MspErrorMmpAlarmGroupNull = (int) 15028;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_BASE']"
		[Register ("MSP_ERROR_MMP_BASE")]
		public const int MspErrorMmpBase = (int) 15000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_DB_DATA_ILLEGAL']"
		[Register ("MSP_ERROR_MMP_DB_DATA_ILLEGAL")]
		public const int MspErrorMmpDbDataIllegal = (int) 15023;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_ERR_MORE_TOTAL']"
		[Register ("MSP_ERROR_MMP_ERR_MORE_TOTAL")]
		public const int MspErrorMmpErrMoreTotal = (int) 15017;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MAIL_INIT_FAIL']"
		[Register ("MSP_ERROR_MMP_MAIL_INIT_FAIL")]
		public const int MspErrorMmpMailInitFail = (int) 15011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MAIL_LOGON_FAIL']"
		[Register ("MSP_ERROR_MMP_MAIL_LOGON_FAIL")]
		public const int MspErrorMmpMailLogonFail = (int) 15007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MAIL_PWD_ERR']"
		[Register ("MSP_ERROR_MMP_MAIL_PWD_ERR")]
		public const int MspErrorMmpMailPwdErr = (int) 15009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MAIL_SESSION_FAIL']"
		[Register ("MSP_ERROR_MMP_MAIL_SESSION_FAIL")]
		public const int MspErrorMmpMailSessionFail = (int) 15006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MAIL_SOCKET_ERR']"
		[Register ("MSP_ERROR_MMP_MAIL_SOCKET_ERR")]
		public const int MspErrorMmpMailSocketErr = (int) 15010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MAIL_USER_ILLEGAL']"
		[Register ("MSP_ERROR_MMP_MAIL_USER_ILLEGAL")]
		public const int MspErrorMmpMailUserIllegal = (int) 15008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_MYSQL_INITFAIL']"
		[Register ("MSP_ERROR_MMP_MYSQL_INITFAIL")]
		public const int MspErrorMmpMysqlInitfail = (int) 15001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_NETDSS_INITFAIL']"
		[Register ("MSP_ERROR_MMP_NETDSS_INITFAIL")]
		public const int MspErrorMmpNetdssInitfail = (int) 15003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PARAM_NULL']"
		[Register ("MSP_ERROR_MMP_PARAM_NULL")]
		public const int MspErrorMmpParamNull = (int) 15016;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PMA_NOT_FOUND_STRATEGY']"
		[Register ("MSP_ERROR_MMP_PMA_NOT_FOUND_STRATEGY")]
		public const int MspErrorMmpPmaNotFoundStrategy = (int) 15025;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PMC_SERVINFO_INVALID']"
		[Register ("MSP_ERROR_MMP_PMC_SERVINFO_INVALID")]
		public const int MspErrorMmpPmcServinfoInvalid = (int) 15027;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PROC_THRESHOLD']"
		[Register ("MSP_ERROR_MMP_PROC_THRESHOLD")]
		public const int MspErrorMmpProcThreshold = (int) 15018;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PYTHON_BAD_FUNC']"
		[Register ("MSP_ERROR_MMP_PYTHON_BAD_FUNC")]
		public const int MspErrorMmpPythonBadFunc = (int) 15022;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PYTHON_IMPORT_FAILED']"
		[Register ("MSP_ERROR_MMP_PYTHON_IMPORT_FAILED")]
		public const int MspErrorMmpPythonImportFailed = (int) 15021;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_PYTHON_NO_EXIST']"
		[Register ("MSP_ERROR_MMP_PYTHON_NO_EXIST")]
		public const int MspErrorMmpPythonNoExist = (int) 15020;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_REDIS_INITFAIL']"
		[Register ("MSP_ERROR_MMP_REDIS_INITFAIL")]
		public const int MspErrorMmpRedisInitfail = (int) 15002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_REDIS_NOT_CONN']"
		[Register ("MSP_ERROR_MMP_REDIS_NOT_CONN")]
		public const int MspErrorMmpRedisNotConn = (int) 15024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_SERVER_THRESHOLD']"
		[Register ("MSP_ERROR_MMP_SERVER_THRESHOLD")]
		public const int MspErrorMmpServerThreshold = (int) 15019;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_STORE_MNR_NO_INIT']"
		[Register ("MSP_ERROR_MMP_STORE_MNR_NO_INIT")]
		public const int MspErrorMmpStoreMnrNoInit = (int) 15012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_STORE_MNR_POOL_FULL']"
		[Register ("MSP_ERROR_MMP_STORE_MNR_POOL_FULL")]
		public const int MspErrorMmpStoreMnrPoolFull = (int) 15013;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_STRATGY_PARAM_ILLEGAL']"
		[Register ("MSP_ERROR_MMP_STRATGY_PARAM_ILLEGAL")]
		public const int MspErrorMmpStratgyParamIllegal = (int) 15014;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_STRATGY_PARAM_TOOLOOG']"
		[Register ("MSP_ERROR_MMP_STRATGY_PARAM_TOOLOOG")]
		public const int MspErrorMmpStratgyParamTooloog = (int) 15015;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_TAIR_CONNECT']"
		[Register ("MSP_ERROR_MMP_TAIR_CONNECT")]
		public const int MspErrorMmpTairConnect = (int) 15026;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MMP_TAIR_INITFAIL']"
		[Register ("MSP_ERROR_MMP_TAIR_INITFAIL")]
		public const int MspErrorMmpTairInitfail = (int) 15004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_APP_ID_EMPTY']"
		[Register ("MSP_ERROR_MSG_APP_ID_EMPTY")]
		public const int MspErrorMsgAppIdEmpty = (int) 10313;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_BUILD_ERROR']"
		[Register ("MSP_ERROR_MSG_BUILD_ERROR")]
		public const int MspErrorMsgBuildError = (int) 10302;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_CONTENT_EMPTY']"
		[Register ("MSP_ERROR_MSG_CONTENT_EMPTY")]
		public const int MspErrorMsgContentEmpty = (int) 10304;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_EXTERN_ID_EMPTY']"
		[Register ("MSP_ERROR_MSG_EXTERN_ID_EMPTY")]
		public const int MspErrorMsgExternIdEmpty = (int) 10314;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_GENERAL']"
		[Register ("MSP_ERROR_MSG_GENERAL")]
		public const int MspErrorMsgGeneral = (int) 10300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_CMD']"
		[Register ("MSP_ERROR_MSG_INVALID_CMD")]
		public const int MspErrorMsgInvalidCmd = (int) 10315;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_CONTENT']"
		[Register ("MSP_ERROR_MSG_INVALID_CONTENT")]
		public const int MspErrorMsgInvalidContent = (int) 10325;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_CONTENT_ENCODE']"
		[Register ("MSP_ERROR_MSG_INVALID_CONTENT_ENCODE")]
		public const int MspErrorMsgInvalidContentEncode = (int) 10307;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_CONTENT_LENGTH']"
		[Register ("MSP_ERROR_MSG_INVALID_CONTENT_LENGTH")]
		public const int MspErrorMsgInvalidContentLength = (int) 10306;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_CONTENT_TYPE']"
		[Register ("MSP_ERROR_MSG_INVALID_CONTENT_TYPE")]
		public const int MspErrorMsgInvalidContentType = (int) 10305;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_KEY']"
		[Register ("MSP_ERROR_MSG_INVALID_KEY")]
		public const int MspErrorMsgInvalidKey = (int) 10308;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_SESSION_ID']"
		[Register ("MSP_ERROR_MSG_INVALID_SESSION_ID")]
		public const int MspErrorMsgInvalidSessionId = (int) 10324;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_SUBJECT']"
		[Register ("MSP_ERROR_MSG_INVALID_SUBJECT")]
		public const int MspErrorMsgInvalidSubject = (int) 10316;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_INVALID_VERSION']"
		[Register ("MSP_ERROR_MSG_INVALID_VERSION")]
		public const int MspErrorMsgInvalidVersion = (int) 10317;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_KEY_EMPTY']"
		[Register ("MSP_ERROR_MSG_KEY_EMPTY")]
		public const int MspErrorMsgKeyEmpty = (int) 10309;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_LOGIN_ID_EMPTY']"
		[Register ("MSP_ERROR_MSG_LOGIN_ID_EMPTY")]
		public const int MspErrorMsgLoginIdEmpty = (int) 10311;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_MSSP_EMPTY']"
		[Register ("MSP_ERROR_MSG_MSSP_EMPTY")]
		public const int MspErrorMsgMsspEmpty = (int) 10321;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_NEW_CONTENT']"
		[Register ("MSP_ERROR_MSG_NEW_CONTENT")]
		public const int MspErrorMsgNewContent = (int) 10323;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_NEW_RESPONSE']"
		[Register ("MSP_ERROR_MSG_NEW_RESPONSE")]
		public const int MspErrorMsgNewResponse = (int) 10322;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_NO_CMD']"
		[Register ("MSP_ERROR_MSG_NO_CMD")]
		public const int MspErrorMsgNoCmd = (int) 10318;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_NO_SUBJECT']"
		[Register ("MSP_ERROR_MSG_NO_SUBJECT")]
		public const int MspErrorMsgNoSubject = (int) 10319;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_NO_VERSION']"
		[Register ("MSP_ERROR_MSG_NO_VERSION")]
		public const int MspErrorMsgNoVersion = (int) 10320;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_PARAM_ERROR']"
		[Register ("MSP_ERROR_MSG_PARAM_ERROR")]
		public const int MspErrorMsgParamError = (int) 10303;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_PARSE_ERROR']"
		[Register ("MSP_ERROR_MSG_PARSE_ERROR")]
		public const int MspErrorMsgParseError = (int) 10301;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_SESSION_ID_EMPTY']"
		[Register ("MSP_ERROR_MSG_SESSION_ID_EMPTY")]
		public const int MspErrorMsgSessionIdEmpty = (int) 10310;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSG_SYNC_ID_EMPTY']"
		[Register ("MSP_ERROR_MSG_SYNC_ID_EMPTY")]
		public const int MspErrorMsgSyncIdEmpty = (int) 10312;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_MSS_TIME_OUT']"
		[Register ("MSP_ERROR_MSS_TIME_OUT")]
		public const int MspErrorMssTimeOut = (int) 10217;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_ACCEPTSOCK']"
		[Register ("MSP_ERROR_NET_ACCEPTSOCK")]
		public const int MspErrorNetAcceptsock = (int) 10203;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_BADADDRESS']"
		[Register ("MSP_ERROR_NET_BADADDRESS")]
		public const int MspErrorNetBadaddress = (int) 10207;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_BINDSEQUENCE']"
		[Register ("MSP_ERROR_NET_BINDSEQUENCE")]
		public const int MspErrorNetBindsequence = (int) 10208;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_CONNECTCLOSE']"
		[Register ("MSP_ERROR_NET_CONNECTCLOSE")]
		public const int MspErrorNetConnectclose = (int) 10212;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_CONNECTSOCK']"
		[Register ("MSP_ERROR_NET_CONNECTSOCK")]
		public const int MspErrorNetConnectsock = (int) 10202;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_DNS']"
		[Register ("MSP_ERROR_NET_DNS")]
		public const int MspErrorNetDns = (int) 10214;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_GENERAL']"
		[Register ("MSP_ERROR_NET_GENERAL")]
		public const int MspErrorNetGeneral = (int) 10200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_INIT']"
		[Register ("MSP_ERROR_NET_INIT")]
		public const int MspErrorNetInit = (int) 10215;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_INVALIDSOCK']"
		[Register ("MSP_ERROR_NET_INVALIDSOCK")]
		public const int MspErrorNetInvalidsock = (int) 10206;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_INVALID_CLIENT_CERT']"
		[Register ("MSP_ERROR_NET_INVALID_CLIENT_CERT")]
		public const int MspErrorNetInvalidClientCert = (int) 10223;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_INVALID_KEY']"
		[Register ("MSP_ERROR_NET_INVALID_KEY")]
		public const int MspErrorNetInvalidKey = (int) 10225;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_INVALID_ROOT_CERT']"
		[Register ("MSP_ERROR_NET_INVALID_ROOT_CERT")]
		public const int MspErrorNetInvalidRootCert = (int) 10222;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_INVALID_SERVER_CERT']"
		[Register ("MSP_ERROR_NET_INVALID_SERVER_CERT")]
		public const int MspErrorNetInvalidServerCert = (int) 10224;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_NOTBIND']"
		[Register ("MSP_ERROR_NET_NOTBIND")]
		public const int MspErrorNetNotbind = (int) 10210;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_NOTDGRAMSOCK']"
		[Register ("MSP_ERROR_NET_NOTDGRAMSOCK")]
		public const int MspErrorNetNotdgramsock = (int) 10213;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_NOTLISTEN']"
		[Register ("MSP_ERROR_NET_NOTLISTEN")]
		public const int MspErrorNetNotlisten = (int) 10211;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_NOTOPENSOCK']"
		[Register ("MSP_ERROR_NET_NOTOPENSOCK")]
		public const int MspErrorNetNotopensock = (int) 10209;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_OPENSOCK']"
		[Register ("MSP_ERROR_NET_OPENSOCK")]
		public const int MspErrorNetOpensock = (int) 10201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_RECVSOCK']"
		[Register ("MSP_ERROR_NET_RECVSOCK")]
		public const int MspErrorNetRecvsock = (int) 10205;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_SENDSOCK']"
		[Register ("MSP_ERROR_NET_SENDSOCK")]
		public const int MspErrorNetSendsock = (int) 10204;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NET_SSL_HANDSHAKE']"
		[Register ("MSP_ERROR_NET_SSL_HANDSHAKE")]
		public const int MspErrorNetSslHandshake = (int) 10221;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NFL_INNER_ERROR']"
		[Register ("MSP_ERROR_NFL_INNER_ERROR")]
		public const int MspErrorNflInnerError = (int) 10216;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NGX_LOG_MORE_TOTEL_SIZE']"
		[Register ("MSP_ERROR_NGX_LOG_MORE_TOTEL_SIZE")]
		public const int MspErrorNgxLogMoreTotelSize = (int) 18000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NOT_FOUND']"
		[Register ("MSP_ERROR_NOT_FOUND")]
		public const int MspErrorNotFound = (int) 10116;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NOT_IMPLEMENT']"
		[Register ("MSP_ERROR_NOT_IMPLEMENT")]
		public const int MspErrorNotImplement = (int) 10104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NOT_INIT']"
		[Register ("MSP_ERROR_NOT_INIT")]
		public const int MspErrorNotInit = (int) 10111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NOT_SUPPORT']"
		[Register ("MSP_ERROR_NOT_SUPPORT")]
		public const int MspErrorNotSupport = (int) 10103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_DATA']"
		[Register ("MSP_ERROR_NO_DATA")]
		public const int MspErrorNoData = (int) 10118;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_ENOUGH_BUFFER']"
		[Register ("MSP_ERROR_NO_ENOUGH_BUFFER")]
		public const int MspErrorNoEnoughBuffer = (int) 10117;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_GROUP']"
		[Register ("MSP_ERROR_NO_GROUP")]
		public const int MspErrorNoGroup = (int) 10143;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_LICENSE']"
		[Register ("MSP_ERROR_NO_LICENSE")]
		public const int MspErrorNoLicense = (int) 10110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_MORE_DATA']"
		[Register ("MSP_ERROR_NO_MORE_DATA")]
		public const int MspErrorNoMoreData = (int) 10119;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_RESPONSE_DATA']"
		[Register ("MSP_ERROR_NO_RESPONSE_DATA")]
		public const int MspErrorNoResponseData = (int) 10120;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NO_USER']"
		[Register ("MSP_ERROR_NO_USER")]
		public const int MspErrorNoUser = (int) 10142;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_NULL_HANDLE']"
		[Register ("MSP_ERROR_NULL_HANDLE")]
		public const int MspErrorNullHandle = (int) 10112;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_OPEN_FILE']"
		[Register ("MSP_ERROR_OPEN_FILE")]
		public const int MspErrorOpenFile = (int) 10115;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_OUT_OF_MEMORY']"
		[Register ("MSP_ERROR_OUT_OF_MEMORY")]
		public const int MspErrorOutOfMemory = (int) 10101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_OVERFLOW']"
		[Register ("MSP_ERROR_OVERFLOW")]
		public const int MspErrorOverflow = (int) 10113;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_OVERFLOW_IN_GROUP']"
		[Register ("MSP_ERROR_OVERFLOW_IN_GROUP")]
		public const int MspErrorOverflowInGroup = (int) 10144;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_DUPLICATE_GRAMMAR']"
		[Register ("MSP_ERROR_REC_DUPLICATE_GRAMMAR")]
		public const int MspErrorRecDuplicateGrammar = (int) 10704;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_GENERAL']"
		[Register ("MSP_ERROR_REC_GENERAL")]
		public const int MspErrorRecGeneral = (int) 10700;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_GRAMMAR_ERROR']"
		[Register ("MSP_ERROR_REC_GRAMMAR_ERROR")]
		public const int MspErrorRecGrammarError = (int) 10702;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_INACTIVE']"
		[Register ("MSP_ERROR_REC_INACTIVE")]
		public const int MspErrorRecInactive = (int) 10701;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_INVALID_LANGUAGE']"
		[Register ("MSP_ERROR_REC_INVALID_LANGUAGE")]
		public const int MspErrorRecInvalidLanguage = (int) 10706;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_INVALID_MEDIA_TYPE']"
		[Register ("MSP_ERROR_REC_INVALID_MEDIA_TYPE")]
		public const int MspErrorRecInvalidMediaType = (int) 10705;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_NO_ACTIVE_GRAMMARS']"
		[Register ("MSP_ERROR_REC_NO_ACTIVE_GRAMMARS")]
		public const int MspErrorRecNoActiveGrammars = (int) 10703;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_PROC_MOD']"
		[Register ("MSP_ERROR_REC_PROC_MOD")]
		public const int MspErrorRecProcMod = (int) 10710;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_URI_FETCH_ERROR']"
		[Register ("MSP_ERROR_REC_URI_FETCH_ERROR")]
		public const int MspErrorRecUriFetchError = (int) 10709;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_URI_NOT_FOUND']"
		[Register ("MSP_ERROR_REC_URI_NOT_FOUND")]
		public const int MspErrorRecUriNotFound = (int) 10707;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_REC_URI_TIMEOUT']"
		[Register ("MSP_ERROR_REC_URI_TIMEOUT")]
		public const int MspErrorRecUriTimeout = (int) 10708;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_DATA']"
		[Register ("MSP_ERROR_RES_DATA")]
		public const int MspErrorResData = (int) 10510;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_FREE']"
		[Register ("MSP_ERROR_RES_FREE")]
		public const int MspErrorResFree = (int) 10502;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_GENERAL']"
		[Register ("MSP_ERROR_RES_GENERAL")]
		public const int MspErrorResGeneral = (int) 10500;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_HEAD']"
		[Register ("MSP_ERROR_RES_HEAD")]
		public const int MspErrorResHead = (int) 10509;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_INVALID_ID']"
		[Register ("MSP_ERROR_RES_INVALID_ID")]
		public const int MspErrorResInvalidId = (int) 10505;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_INVALID_IMG']"
		[Register ("MSP_ERROR_RES_INVALID_IMG")]
		public const int MspErrorResInvalidImg = (int) 10506;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_INVALID_NAME']"
		[Register ("MSP_ERROR_RES_INVALID_NAME")]
		public const int MspErrorResInvalidName = (int) 10504;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_LEAK']"
		[Register ("MSP_ERROR_RES_LEAK")]
		public const int MspErrorResLeak = (int) 10508;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_LOAD']"
		[Register ("MSP_ERROR_RES_LOAD")]
		public const int MspErrorResLoad = (int) 10501;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_MISSING']"
		[Register ("MSP_ERROR_RES_MISSING")]
		public const int MspErrorResMissing = (int) 10503;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_SKIP']"
		[Register ("MSP_ERROR_RES_SKIP")]
		public const int MspErrorResSkip = (int) 10511;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_RES_WRITE']"
		[Register ("MSP_ERROR_RES_WRITE")]
		public const int MspErrorResWrite = (int) 10507;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TIME_OUT']"
		[Register ("MSP_ERROR_TIME_OUT")]
		public const int MspErrorTimeOut = (int) 10114;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TTS_GENERAL']"
		[Register ("MSP_ERROR_TTS_GENERAL")]
		public const int MspErrorTtsGeneral = (int) 10600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TTS_LTTS_ERROR']"
		[Register ("MSP_ERROR_TTS_LTTS_ERROR")]
		public const int MspErrorTtsLttsError = (int) 10603;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TTS_TEXTEND']"
		[Register ("MSP_ERROR_TTS_TEXTEND")]
		public const int MspErrorTtsTextend = (int) 10601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TTS_TEXT_EMPTY']"
		[Register ("MSP_ERROR_TTS_TEXT_EMPTY")]
		public const int MspErrorTtsTextEmpty = (int) 10602;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TUV_CFGFILE']"
		[Register ("MSP_ERROR_TUV_CFGFILE")]
		public const int MspErrorTuvCfgfile = (int) 10903;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TUV_GENERAL']"
		[Register ("MSP_ERROR_TUV_GENERAL")]
		public const int MspErrorTuvGeneral = (int) 10900;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TUV_GETHIDPARAM']"
		[Register ("MSP_ERROR_TUV_GETHIDPARAM")]
		public const int MspErrorTuvGethidparam = (int) 10901;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TUV_RECV_CONTENT']"
		[Register ("MSP_ERROR_TUV_RECV_CONTENT")]
		public const int MspErrorTuvRecvContent = (int) 10904;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TUV_TOKEN']"
		[Register ("MSP_ERROR_TUV_TOKEN")]
		public const int MspErrorTuvToken = (int) 10902;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_TUV_VERFAIL']"
		[Register ("MSP_ERROR_TUV_VERFAIL")]
		public const int MspErrorTuvVerfail = (int) 10905;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_USER_ACTIVE_ABORT']"
		[Register ("MSP_ERROR_USER_ACTIVE_ABORT")]
		public const int MspErrorUserActiveAbort = (int) 10136;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_USER_CANCELLED']"
		[Register ("MSP_ERROR_USER_CANCELLED")]
		public const int MspErrorUserCancelled = (int) 10131;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_VALID_IMAGE_SIZE']"
		[Register ("MSP_ERROR_VALID_IMAGE_SIZE")]
		public const int MspErrorValidImageSize = (int) 11705;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROR_VERSION_CHECK']"
		[Register ("MSP_ERROR_VERSION_CHECK")]
		public const int MspErrorVersionCheck = (int) 10125;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_ERROT_CLIENT_TIME_OUT']"
		[Register ("MSP_ERROT_CLIENT_TIME_OUT")]
		public const int MspErrotClientTimeOut = (int) 10218;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='MSP_MODEL_NEED_UPDATE']"
		[Register ("MSP_MODEL_NEED_UPDATE")]
		public const int MspModelNeedUpdate = (int) 10031;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='SPEECH_ERROR_IVW_INVALID_RESTYPE']"
		[Register ("SPEECH_ERROR_IVW_INVALID_RESTYPE")]
		public const int SpeechErrorIvwInvalidRestype = (int) 25002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='SPEECH_ERROR_MFV_INVALID_RESTYPE']"
		[Register ("SPEECH_ERROR_MFV_INVALID_RESTYPE")]
		public const int SpeechErrorMfvInvalidRestype = (int) 26002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/ErrorCode", typeof (ErrorCode));
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

		protected ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.cloud']/class[@name='ErrorCode']/constructor[@name='ErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCode ()
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

	}
}
