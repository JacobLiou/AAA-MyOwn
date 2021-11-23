using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值(以@开头)的起始位置提取单引号后的字符串。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的单引号后的字符串</returns>
        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this)
        {
            return @this.ExtractStringArobasSingleQuote(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值(以@开头)的起始位置提取单引号后的字符串。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的单引号后的字符串在扩展对象的值中的结束位置</param>
        /// <returns>提取的单引号后的字符串</returns>
        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractStringArobasSingleQuote(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值(以@开头)的指定位置提取单引号后的字符串。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的单引号后的字符串</returns>
        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractStringArobasSingleQuote(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值(以@开头)的指定位置提取单引号后的字符串
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的单引号后的字符串在扩展对象的值中的结束位置</param>
        /// <returns>提取的单引号后的字符串</returns>
        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this,
            int startIndex,
            out int endIndex)
        {
            var sb = new StringBuilder();

            if(@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];

                if(ch1 == '@'&&ch2 == '\'')
                {
                    // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                    // @'my string'

                    var pos = startIndex + 2;

                    while(pos < @this.Length)
                    {
                        var ch = @this[pos];
                        pos++;

                        if(ch == '\''&&pos < @this.Length&&@this[pos] == '\'')
                        {
                            sb.Append(ch);
                            pos++; // Treat as escape character for @'abc''def'
                        }
                        else if(ch == '\'')
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