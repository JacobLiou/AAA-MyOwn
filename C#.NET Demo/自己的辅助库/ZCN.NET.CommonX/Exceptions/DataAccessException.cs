using System;

namespace ZCN.NET.CommonX.Exceptions
{
    /// <summary>
    ///     自定义数据访问层异常类，用于封装数据访问组件引发的异常以及数据库返回的异常，以供业务逻辑层抓取
    /// </summary>
    [Serializable]
    public class DataAccessException : BaseException
    {
        /// <summary>
        ///    使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="isDbException">是否是数据库返回警告或错误时引发的异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public DataAccessException(string message, bool isDbException = false, bool log = true)
            : base(isDbException ? "[数据访问组件异常]" + message : "[数据库返回警告或错误时引发的异常]" + message, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="isDbException">是否是数据库返回警告或错误时引发的异常</param>
        /// <param name="log">是否记录日志。默认为true</param>
        public DataAccessException(string message, System.Exception innerException, bool isDbException = false, bool log = true)
            : base(isDbException ? "[数据访问组件异常]" + message : "[数据库返回警告或错误时引发的异常]" + message, innerException, log)
        {

        }
    }
}