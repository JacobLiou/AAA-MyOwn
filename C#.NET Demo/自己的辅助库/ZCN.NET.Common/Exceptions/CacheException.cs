using System;

namespace ZCN.NET.Common.Exceptions
{
    /// <summary>
    ///   自定义缓存异常
    /// </summary>
    [Serializable]
    public class CacheException : BaseException
    {
        /// <summary>
        ///     使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public CacheException(string message, bool log = true)
            : base("[缓存异常]" + message, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public CacheException(string message, System.Exception innerException, bool log = true)
            : base("[缓存异常]" + message, innerException, log)
        {
        }
    }
}