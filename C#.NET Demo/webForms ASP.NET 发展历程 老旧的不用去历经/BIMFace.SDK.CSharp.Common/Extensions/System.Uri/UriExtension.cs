using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        ///  自定义扩展方法：将 URL 中的参数名称/值编码为合法的格式。
        ///  <para>可以解决类似这样的问题：假设参数名为 tvshow, 参数值为 Tom<c>&amp;</c>Jerry。</para>
        ///  <para>如果不编码，可能得到的网址： http://a.com/?tvshow=Tom<c>&amp;</c>Jerry<c>&amp;</c>year=1965 </para>
        ///  <para>编码后则为：http://a.com/?tvshow=Tom%26Jerry<c>&amp;</c>year=1965 </para>
        ///  <para>还有其他的特殊符号，例如 + 空格 / ? % # & = 等其他特殊符号 </para>
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string UriEscapeDataString(this string @this)
        {
            if (@this == null)
            {
                return null;
            }

            return Uri.EscapeDataString(@this);
        }
    }
}