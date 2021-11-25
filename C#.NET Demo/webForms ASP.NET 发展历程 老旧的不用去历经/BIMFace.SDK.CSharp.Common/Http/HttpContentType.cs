// /* ---------------------------------------------------------------------------------------
//    文件名：HttpContentType.cs
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
    /// HTTP 内容类型(Content-Type)
    /// </summary>
    public class HttpContentType
    {
        /// <summary>
        /// 资源类型：普通文本
        /// </summary>
        public const string TEXT_PLAIN = "text/plain";

        /// <summary>
        /// 资源类型：JSON字符串
        /// </summary>
        public const string APPLICATION_JSON = "application/json; charset=UTF-8";

        /// <summary>
        /// 资源类型：未知类型(数据流)
        /// </summary>
        public const string APPLICATION_OCTET_STREAM = "application/octet-stream";

        /// <summary>
        /// 资源类型：表单数据(键值对)
        /// </summary>
        public const string WWW_FORM_URLENCODED = "application/x-www-form-urlencoded";

        /// <summary>
        /// 资源类型：表单数据(键值对)。编码方式为 gb2312
        /// </summary>
        public const string WWW_FORM_URLENCODED_GB2312 = "application/x-www-form-urlencoded;charset=gb2312";

        /// <summary>
        /// 资源类型：表单数据(键值对)。编码方式为 utf-8
        /// </summary>
        public const string WWW_FORM_URLENCODED_UTF8 = "application/x-www-form-urlencoded;charset=utf-8";

        /// <summary>
        /// 资源类型：多分部数据
        /// </summary>
        public const string MULTIPART_FORM_DATA = "multipart/form-data";
    }
}