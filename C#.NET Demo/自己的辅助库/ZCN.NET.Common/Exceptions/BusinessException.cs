using System;

namespace ZCN.NET.Common.Exceptions
{
    /// <summary>
    ///     自定义业务逻辑异常类，用于封装业务逻辑层引发的异常，以供 UI 层抓取
    /// </summary>
    [Serializable]
    public class BusinessException : BaseException
    {
        /// <summary>
        ///     使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public BusinessException(string message, bool log = true)
            : base("[业务逻辑异常]" + message, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public BusinessException(string message, System.Exception innerException, bool log = true)
            : base("[业务逻辑异常]" + message, innerException, log)
        {
        }
    }
}