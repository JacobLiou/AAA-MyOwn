using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取(单双)引号后的字符串。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的(单双)引号后的字符串</returns>
        public static StringBuilder ExtractString(this StringBuilder @this)
        {
            return @this.ExtractString(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取(单双)引号后的字符串。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的(单双)引号后的字符串在扩展对象的值中的结束位置</param>
        /// <returns>提取的(单双)引号后的字符串</returns>
        public static StringBuilder ExtractString(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractString(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取(单双)引号后的字符串。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的(单双)引号后的字符串</returns>
        public static StringBuilder ExtractString(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractString(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取(单双)引号后的字符串
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的(单双)引号后的字符串在扩展对象的值中的结束位置</param>
        /// <returns>提取的(单双)引号后的字符串</returns>
        public static StringBuilder ExtractString(this StringBuilder @this, int startIndex, out int endIndex)
        {
            if(@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];

                if(ch1 == '@'&&ch2 == '"')
                {
                    // @"my string"

                    return @this.ExtractStringArobasDoubleQuote(startIndex, out endIndex);
                }

                if(ch1 == '@'&&ch2 == '\'')
                {
                    // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                    // @'my string'

                    return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
                }

                if(ch1 == '"')
                {
                    // "my string"

                    return @this.ExtractStringDoubleQuote(startIndex, out endIndex);
                }

                if(ch1 == '\'')
                {
                    // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                    // 'my string'

                    return @this.ExtractStringSingleQuote(startIndex, out endIndex);
                }
            }

            endIndex = -1;
            return null;
        }
    }
}