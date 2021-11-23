namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将html标签br 替换为2个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string BrToNewLine(this string @this)
        {
            return @this.Replace("<br />", "\r\n").Replace("<br>", "\r\n");
        }

        /// <summary>
        ///  自定义扩展方法：将2个换行符号替换为html标签br
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string NewLineToBr(this string @this)
        {
            return @this.Replace("\r\n","<br />").Replace("\n","<br />");
        }
    }
}