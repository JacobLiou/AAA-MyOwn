using System.Drawing;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///     自定义扩展方法：将指定 System.Drawing.Color 结构翻译成 HTML 字符串颜色表示形式
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static string ToHtml(this Color c)
        {
            return ColorTranslator.ToHtml(c);
        }

        /// <summary>
        ///     自定义扩展方法：将指定 System.Drawing.Color 结构翻译成 OLE 颜色
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static int ToOle(this Color c)
        {
            return ColorTranslator.ToOle(c);
        }

        /// <summary>
        ///     自定义扩展方法：将指定 System.Drawing.Color 结构翻译成 Windows 颜色
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static int ToWin32(this Color c)
        {
            return ColorTranslator.ToWin32(c);
        }
    }
}