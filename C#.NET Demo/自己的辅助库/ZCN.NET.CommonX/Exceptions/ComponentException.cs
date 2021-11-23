using System;

namespace ZCN.NET.CommonX.Exceptions
{
    /// <summary>
    ///     自定义组件异常类
    /// </summary>
    [Serializable]
    public class ComponentException : BaseException
    {
        /// <summary>
        ///    使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public ComponentException(string message, bool log = true)
            : base("[组件异常]" + message, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public ComponentException(string message, System.Exception innerException, bool log = true)
            : base("[组件异常]" + message, innerException, log)
        {
        }
    }
}