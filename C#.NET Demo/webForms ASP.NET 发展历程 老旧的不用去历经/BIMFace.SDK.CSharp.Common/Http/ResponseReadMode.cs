// /* ---------------------------------------------------------------------------------------
//    文件名：ResponseReadMode.cs
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

namespace BIMFace.SDK.CSharp.Common.Http
{
    /// <summary>
    ///  HTTP应内容的读取响模式
    /// </summary>
    public enum ResponseReadMode
    {
        /// <summary>
        ///  二进制方式(一般用于读取响应的文件信息)
        /// </summary>
        Binary,

        /// <summary>
        /// 文件流方式(一般用于读取响应的文本信息)
        /// </summary>
        Stream
    }
}