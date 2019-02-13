
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Lang;

namespace SerialPortDemo
{
    //https://github.com/cepr/android-serialport-api
    //ndk 相关源码在这可以下载自行编译

    [Register("com.example.x6.serial")]
    public class SerialPort : Java.Lang.Object
    {
        private readonly static string TAG = "SerialPort";
        private FileDescriptor mFd;
        private FileInputStream mFileInputStream;
        private FileOutputStream mFileOutputStream;
        private const string Lib = @"serial_port";


        [DllImport(Lib, EntryPoint = "Java_com_example_x6_serial_SerialPort_open")]
        private static extern System.IntPtr Open(System.IntPtr jnienv, System.IntPtr thclass, System.IntPtr path, int baudrate, int flags);


        [DllImport(Lib, EntryPoint = "Java_com_example_x6_serial_SerialPort_close")]
        private static extern void Close(System.IntPtr jnienv, System.IntPtr thclass);

        public SerialPort(File device, int baudrate, int flags)
        {

            //        检查访问权限，如果没有读写权限，进行文件操作，修改文件访问权限
            if (!device.CanRead() || !device.CanWrite())
            {
                try
                {
                    //通过挂在到linux的方式，修改文件的操作权限
                    Java.Lang.Process su = Runtime.GetRuntime().Exec("/system/xbin/su");
                    //一般的都是/system/bin/su路径，有的也是/system/xbin/su
                    var cmd = new Java.Lang.String("chmod 777 " + device.AbsolutePath + "\n" + "exit\n");
                    // Log.e("cmd :", cmd);
                    su.OutputStream.Write(cmd.GetBytes());
                    if ((su.WaitFor() != 0) || !device.CanRead() || !device.CanWrite())
                    {
                        throw new SecurityException();
                    }
                }
                catch (Exception e)
                {
                    //   e.printStackTrace();
                    throw new SecurityException();
                }
            }

            var ptr = Open(Android.Runtime.JNIEnv.Handle, this.Handle, JNIEnv.NewString(device.AbsolutePath), baudrate, flags);
            if (ptr != System.IntPtr.Zero)
                mFd = GetObject<FileDescriptor>(ptr, JniHandleOwnership.DoNotRegister);
            if (mFd == null)
            {
                //  Log.e(TAG, "native open returns null");
                throw new IOException();
            }

            mFileInputStream = new FileInputStream(mFd);
            mFileOutputStream = new FileOutputStream(mFd);

        }

        // Getters and setters
        public InputStream InputStream
        {

            get { return mFileInputStream; }
        }

        public OutputStream OutputStream
        {
            get { return mFileOutputStream; }
        }
    }
}