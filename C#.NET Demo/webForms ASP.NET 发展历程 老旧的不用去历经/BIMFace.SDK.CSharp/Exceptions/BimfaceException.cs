// /* ---------------------------------------------------------------------------------------
//    文件名：BIMFaceException.cs
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

using BIMFace.SDK.CSharp.Common.Exceptions;

namespace BIMFace.SDK.CSharp.Exceptions
{
    /// <summary>
    ///  BIMFace 组件调用异常处理类
    /// </summary>
    public class BIMFaceException : BaseException
    {
        #region 属性
        /// <summary>
        ///  HTTP的响应编码
        /// </summary>
        public int HttpCode { get; set; }

        /// <summary>
        ///  错误编码
        /// </summary>
        public string ErrorCode { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        ///    使用指定错误消息来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="log">是否记录日志</param>
        public BIMFaceException(string message, bool log = true) : base(message, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和对作为此异常原因的内部异常来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="innerException">导致当前异常的异常，即内部异常</param>
        /// <param name="log">是否记录日志</param>
        public BIMFaceException(string message, Exception innerException, bool log = true) : base(message, innerException, log)
        {
        }

        /// <summary>
        ///     使用指定错误消息和HTTP的响应编码来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="httpCode">HTTP的响应编码</param>
        /// <param name="log">是否记录日志</param>
        public BIMFaceException(string message, int httpCode, bool log = true) : this(message)
        {
            HttpCode = httpCode;
        }

        /// <summary>
        ///     使用指定错误消息和错误编码来初始化该类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        /// <param name="errorCode">错误编码</param>
        /// <param name="log">是否记录日志</param>
        public BIMFaceException(string message, string errorCode, bool log = true) : this(message)
        {
            ErrorCode = errorCode;
        }

        #endregion
    }
}