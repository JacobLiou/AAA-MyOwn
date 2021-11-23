using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的起始位置提取双引号后的字符串。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的双引号后的字符串</returns>
        public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this)
        {
            return @this.ExtractStringDoubleQuote(0);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的起始位置提取双引号后的字符串。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的双引号后的字符串在扩展对象的值中的结束位置</param>
        /// <returns>提取的双引号后的字符串</returns>
        public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractStringDoubleQuote(0, out endIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的指定位置提取双引号后的字符串。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的双引号后的字符串</returns>
        public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractStringDoubleQuote(startIndex, out int endIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的指定位置提取双引号后的字符串
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的双引号后的字符串在扩展对象的值中的结束位置</param>
        /// <returns>提取的双引号后的字符串</returns>
        public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this, int startIndex, out int endIndex)
        {
            var sb = new StringBuilder();

            if(@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];

                if(ch1 == '"')
                {
                    // "my string"

                    var pos = startIndex + 1;

                    while(pos < @this.Length)
                    {
                        var ch = @this[pos];
                        pos++;

                        char nextChar;
                        if(ch == '\\'&&pos < @this.Length&&((nextChar = @this[pos]) == '\\'||nextChar == '"'))
                        {
                            sb.Append(nextChar);
                            pos++; // Treat as escape character for \\ or \"
                        }
                        else if(ch == '"')
                        {
                            endIndex = pos;
                            return sb;
                        }
                        else
                        {
                            sb.Append(ch);
                        }
                    }

                    throw new System.Exception("Unclosed string starting at position: " + startIndex);
                }
            }

            endIndex = -1;
            return null;
        }
    }
}