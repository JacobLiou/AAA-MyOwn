
namespace ZCN.NET.CommonX.Http
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