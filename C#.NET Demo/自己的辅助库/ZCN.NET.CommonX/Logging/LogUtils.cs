using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ZCN.NET.CommonX.Logging
{
    /// <summary>
    ///     文本类型日志工具类
    /// </summary>
    public partial class LogUtils
    {
        #region 构造函数

        static LogUtils()
        {
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }

            EncodingType = Encoding.Default; //操作系统的当前 ANSI 代码页的编码 //System.Text.Encoding.GetEncoding(EncodingNames.GB2312);//简体中文
        }

        #endregion

        #region 属性

        private static readonly string Separator = "===============================================================";

        /// <summary>
        ///     日志输出目录
        /// </summary>
        private static readonly string LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");

        /// <summary>
        ///     记录日志时使用的编码方式
        /// </summary>
        private static Encoding EncodingType { get; }

        #endregion

        #region 同步方法

        #region WriteInfo

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将提示信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static void WriteInfo(string msg)
        {
            WriteInfo(msg, null, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将提示信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteInfo(string msg, Encoding encoding)
        {
            WriteInfo(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将提示息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static void WriteInfo(string msg, System.Exception ex)
        {
            WriteInfo(msg, ex, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将提示信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteInfo(string msg, System.Exception ex, Encoding encoding)
        {
            Write(msg, ex, encoding, LogLevel.Info);
        }

        #endregion

        #region WriteWarn

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将警告信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static void WriteWarn(string msg)
        {
            WriteWarn(msg, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将警告信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteWarn(string msg, Encoding encoding)
        {
            WriteWarn(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将警告息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static void WriteWarn(string msg, System.Exception ex)
        {
            WriteWarn(msg, ex, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将警告信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteWarn(string msg, System.Exception ex, Encoding encoding)
        {
            Write(msg, ex, encoding, LogLevel.Warn);
        }

        #endregion

        #region WriteError

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将错误信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static void WriteError(string msg)
        {
            WriteError(msg, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将错误信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteError(string msg, Encoding encoding)
        {
            WriteError(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将错误信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static void WriteError(string msg, System.Exception ex)
        {
            WriteError(msg, ex, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将错误信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteError(string msg, System.Exception ex, Encoding encoding)
        {
            Write(msg, ex, encoding, LogLevel.Error);
        }

        #endregion

        #region WriteTrace

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static void WriteTrace(string msg)
        {
            WriteTrace(msg, EncodingType);
        }

        /// <summary>
        ///     使用指定的编码方式将调试信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteTrace(string msg, Encoding encoding)
        {
            WriteTrace(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static void WriteTrace(string msg, System.Exception ex)
        {
            WriteTrace(msg, ex, EncodingType);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteTrace(string msg, System.Exception ex, Encoding encoding)
        {
#if Trace
            Write(msg, ex, encoding, LogLevel.Trace);
#endif
        }

        #endregion

        #region WriteDebug

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static void WriteDebug(string msg)
        {
            WriteDebug(msg, EncodingType);
        }

        /// <summary>
        ///     使用指定的编码方式将调试信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteDebug(string msg, Encoding encoding)
        {
            WriteDebug(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试息与异常信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static void WriteDebug(string msg, System.Exception ex)
        {
            WriteDebug(msg, ex, EncodingType);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息与异常信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static void WriteDebug(string msg, System.Exception ex, Encoding encoding)
        {
#if DEBUG
            Write(msg, ex, encoding, LogLevel.Debug);
#endif
        }

        #endregion

        /// <summary>
        ///     【同步方式】将指定编码方式将自定义信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="exception">异常对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        /// <param name="logLevel">日志类型</param>
        private static void Write(string msg, System.Exception exception, Encoding encoding, LogLevel logLevel = LogLevel.Info)
        {
            string tip = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss.fff]") + "[" + logLevel + "]";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.Append(tip + " Start " + Separator);
            sb.AppendLine();
            sb.AppendLine(msg);

            while (exception != null)
            {
                sb.AppendLine("Exception:" + exception);
                exception = exception.InnerException;
            }

            sb.Append(tip + " End   " + Separator);
            sb.AppendLine();

            string fileName = DateTime.Now.ToString("yyyyMMddHH") + ".log"; //每小时产生一个log文件
            string newPath = Path.Combine(LogPath, DateTime.Now.ToString("yyyyMMdd")); //以天为单位，产生独立的目录
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            string fullPath = Path.Combine(newPath, fileName);

            try
            {
                File.AppendAllText(fullPath, sb.ToString(), encoding);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region 异步方法

        #region WriteInfoAsync

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将提示信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static async Task WriteInfoAsync(string msg)
        {
            await WriteInfoAsync(msg, null, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将提示信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteInfoAsync(string msg, Encoding encoding)
        {
            await WriteInfoAsync(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将提示息与异常信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static async Task WriteInfoAsync(string msg, System.Exception ex)
        {
            await WriteInfoAsync(msg, ex, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将提示信息与异常信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteInfoAsync(string msg, System.Exception ex, Encoding encoding)
        {
            await WriteAsync(msg, ex, encoding, LogLevel.Info);
        }

        #endregion

        #region WriteWarnAsync

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将警告信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static async Task WriteWarnAsync(string msg)
        {
            await WriteWarnAsync(msg, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将警告信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteWarnAsync(string msg, Encoding encoding)
        {
            await WriteWarnAsync(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将警告息与异常信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static async Task WriteWarnAsync(string msg, System.Exception ex)
        {
            await WriteWarnAsync(msg, ex, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将警告信息与异常信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteWarnAsync(string msg, System.Exception ex, Encoding encoding)
        {
            await WriteAsync(msg, ex, encoding, LogLevel.Warn);
        }

        #endregion

        #region WriteErrorAsync

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将错误信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static async Task WriteErrorAsync(string msg)
        {
            await WriteErrorAsync(msg, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将错误信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteErrorAsync(string msg, Encoding encoding)
        {
            await WriteErrorAsync(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将错误信息与异常信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static async Task WriteErrorAsync(string msg, System.Exception ex)
        {
            await WriteErrorAsync(msg, ex, EncodingType);
        }

        /// <summary>
        ///     将指定编码方式将错误信息与异常信息写入文本文件。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteErrorAsync(string msg, System.Exception ex, Encoding encoding)
        {
            await WriteAsync(msg, ex, encoding, LogLevel.Error);
        }

        #endregion

        #region WriteTraceAsync

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static async Task WriteTraceAsync(string msg)
        {
            await WriteTraceAsync(msg, EncodingType);
        }

        /// <summary>
        ///     使用指定的编码方式将调试信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteTraceAsync(string msg, Encoding encoding)
        {
            await WriteTraceAsync(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static async Task WriteTraceAsync(string msg, System.Exception ex)
        {
            await WriteTraceAsync(msg, ex, EncodingType);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteTraceAsync(string msg, System.Exception ex, Encoding encoding)
        {
#if DEBUG
            await WriteAsync(msg, ex, encoding, LogLevel.Debug);
#endif
        }

        #endregion

        #region WriteDebugAsync

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        public static async Task WriteDebugAsync(string msg)
        {
            await WriteDebugAsync(msg, EncodingType);
        }

        /// <summary>
        ///     使用指定的编码方式将调试信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteDebugAsync(string msg, Encoding encoding)
        {
            await WriteDebugAsync(msg, null, encoding);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试息与异常信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        public static async Task WriteDebugAsync(string msg, System.Exception ex)
        {
            await WriteDebugAsync(msg, ex, EncodingType);
        }

        /// <summary>
        ///     使用操作系统的当前ANSI代码页的编码方式将调试信息与异常信息写入文本文件。该方法仅在 Debug 模式下记录日志。
        /// 【在对文件进行异步操作时，对大数据量读写操作使用异步方法的效果更好；而对于数据量较少的读写操作，使用异步方式的速度可能会比同步方式要慢。请根据应用程序的实际情况选择是否使用异步方式操作】
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="ex">异常信息对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        public static async Task WriteDebugAsync(string msg, System.Exception ex, Encoding encoding)
        {
#if DEBUG
            await WriteAsync(msg, ex, encoding, LogLevel.Debug);
#endif
        }

        #endregion

        /// <summary>
        ///     【异步方式】将指定编码方式将自定义信息与异常信息写入文本文件
        /// </summary>
        /// <param name="msg">自定义消息</param>
        /// <param name="exception">异常对象</param>
        /// <param name="encoding">编码方式(建议使用 EncodingNames 编码方式常量类获取不同的编码方式名称)</param>
        /// <param name="logLevel">日志类型</param>
        private static async Task WriteAsync(string msg, System.Exception exception, Encoding encoding, LogLevel logLevel = LogLevel.Info)
        {
            string tip = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss.fff]") + "[" + logLevel + "]";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.Append(tip + " Start " + Separator);
            sb.AppendLine();
            sb.AppendLine(msg);

            while (exception != null)
            {
                sb.AppendLine("Exception:" + exception);
                exception = exception.InnerException;
            }

            sb.Append(tip + " End   " + Separator);
            sb.AppendLine();

            string fileName = DateTime.Now.ToString("yyyyMMddHH") + ".log"; //每小时产生一个log文件
            string newPath = Path.Combine(LogPath, DateTime.Now.ToString("yyyyMMdd")); //以天为单位，产生独立的目录
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            string fullPath = Path.Combine(newPath, fileName);

            try
            {
                /* FileStream 在对文件进行异步操作时，对大数据量读写操作使用 BeginRead()/BeginWrite()、WriteAsync() 方法的效果更好；
                   而对于数据量较少的读写操作，使川异步方式的速度可能会比同步方式要慢。
                   所以，需要针对应用程序的实际情况决定是否要选择异步处理方式。*/

                FileInfo fileInfo = new FileInfo(fullPath);
                if (!fileInfo.Exists)
                {
                    fileInfo.Create();
                }

                byte[] buffer = encoding.GetBytes(msg);
                FileStream fileStream = new FileStream(fullPath, FileMode.Append);
                await fileStream.WriteAsync(buffer, 0, buffer.Length);
                fileStream.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}