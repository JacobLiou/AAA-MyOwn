using System;

using ZCN.NET.Common.Logging;

namespace ZCN.NET.Common.Exceptions
{
    /// <summary>
    ///     自定义异常基类
    /// </summary>
    [Serializable]
    public class BaseException : ApplicationException
    {
        /// <summary>
        ///    使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public BaseException(string message, bool log = true)
            : this(message, null, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public BaseException(string message, System.Exception innerException, bool log = true) : base(message, innerException)
        {
            if (log)
            {
                LogUtils.WriteError(message, innerException);
            }
        }
    }
}