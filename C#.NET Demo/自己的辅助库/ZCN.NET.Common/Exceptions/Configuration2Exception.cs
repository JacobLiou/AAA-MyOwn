using System;

namespace ZCN.NET.Common.Exceptions
{
    /// <summary>
    ///  自定义配置项异常类（一般是指 web.config 、app.config 或其他配置文件中配置项）
    /// </summary>
    [Serializable]
    public class Configuration2Exception : BaseException
    {
        /// <summary>
        ///     使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public Configuration2Exception(string message, bool log = true)
            : base("[配置项异常]" + message, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public Configuration2Exception(string message, System.Exception innerException, bool log = true)
            : base("[配置项异常]" + message, innerException, log)
        {
        }
    }
}
