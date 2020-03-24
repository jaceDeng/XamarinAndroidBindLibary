namespace yufeng.XST
{
	using Log = Android.Util.Log;

	/// <summary>
	/// Created by efan on 2017/4/13.
	/// </summary>

	public class Logger
	{

		//设为false关闭日志
		private const bool LOG_ENABLE = true;

		public static void i(string tag, string msg)
		{
			if (LOG_ENABLE)
			{
				Log.Info(tag, msg);
			}
		}
		public static void v(string tag, string msg)
		{
			if (LOG_ENABLE)
			{
				Log.Verbose(tag, msg);
			}
		}
		public static void d(string tag, string msg)
		{
			if (LOG_ENABLE)
			{
				Log.Debug(tag, msg);
			}
		}
		public static void w(string tag, string msg)
		{
			if (LOG_ENABLE)
			{
				Log.Warn(tag, msg);
			}
		}
		public static void e(string tag, string msg)
		{
			if (LOG_ENABLE)
			{
				Log.Error(tag, msg);
			}
		}

	}

}