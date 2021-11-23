using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：把字符串按每行多少个字断行
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="lineCount">每行多少个字</param>
        /// <returns></returns>
        public static string BreakText(this string @this, int lineCount)
        {
            var idx = 0;
            var textLength = @this.Length;
            var sb = new StringBuilder();
            while (idx < textLength)
            {
                if (idx > 0)
                {
                    sb.Append('\n');
                }

                if (idx + lineCount >= textLength)
                {
                    sb.Append(@this.Substring(idx));
                }
                else
                {
                    sb.Append(@this.Substring(idx, lineCount));
                }

                idx += lineCount;
            }

            return sb.ToString();
        }
    }
}