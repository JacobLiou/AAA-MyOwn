namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：对XML文档中特殊的字符进行转义
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>转义后的字符串</returns>
        public static string EscapeXml(this string @this)
        {
            return @this.Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&apos;");
        }
    }
}