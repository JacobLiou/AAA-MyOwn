// /* ---------------------------------------------------------------------------------------
//    文件名：TransferStatus.cs
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

namespace BIMFace.SDK.CSharp.Constants
{
    /// <summary>
    ///     文件转换状态枚举
    /// </summary>
    public enum TransferStatus
    {
        /// <summary>
        ///     准备中
        /// </summary>
        PREPARE = 1,

        /// <summary>
        ///     转换中
        /// </summary>
        PROCESSING = 2,

        /// <summary>
        ///     转换成功
        /// </summary>
        SUCCESS = 3,

        /// <summary>
        ///     转换失败
        /// </summary>
        FAILED = 0,

        /// <summary>
        ///     未知状态
        /// </summary>
        UNRESOLVED = -1
    }
}