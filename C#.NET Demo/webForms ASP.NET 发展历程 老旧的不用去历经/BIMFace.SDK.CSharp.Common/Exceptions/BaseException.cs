// /* ---------------------------------------------------------------------------------------
//    文件名：BaseException.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁  （QQ：905442693  微信：savionzhang）
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/
using System;

using BIMFace.SDK.CSharp.Common.Log;

namespace BIMFace.SDK.CSharp.Common.Exceptions
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
        /// <param name="log">是否记录日志</param>
        public BaseException(string message, bool log = true)
            : this(message, null, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志</param>
        public BaseException(string message, Exception innerException, bool log = true)
            : base(message, innerException)
        {
            if (log)
            {
                LogUtility.Error(message, innerException);
            }
        }
    }
}