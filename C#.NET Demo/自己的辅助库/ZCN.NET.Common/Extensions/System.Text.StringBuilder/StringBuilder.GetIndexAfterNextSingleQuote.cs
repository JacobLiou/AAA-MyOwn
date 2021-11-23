using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从起始位置开始获取下一个单引号之后的索引
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>下一个单引号后的索引</returns>
        public static int GetIndexAfterNextSingleQuote(this StringBuilder @this)
        {
            return @this.GetIndexAfterNextSingleQuote(0, false);
        }

        /// <summary>
        /// 自定义扩展方法：从起始位置开始获取下一个单引号之后的索引
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="allowEscape">是否允许转义</param>
        /// <returns>下一个单引号后的索引</returns>
        public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, bool allowEscape)
        {
            return @this.GetIndexAfterNextSingleQuote(0, allowEscape);
        }

        /// <summary>
        /// 自定义扩展方法：从指定位置开始获取下一个单引号之后的索引
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>下一个单引号后的索引</returns>
        public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, int startIndex)
        {
            return @this.GetIndexAfterNextSingleQuote(startIndex, false);
        }

        /// <summary>
        /// 自定义扩展方法：从指定位置开始获取下一个单引号之后的索引
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="allowEscape">是否允许转义</param>
        /// <returns>下一个单引号后的索引</returns>
        public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, int startIndex, bool allowEscape)
        {
            while (startIndex < @this.Length)
            {
                char ch = @this[startIndex];
                startIndex++;

                char nextChar;
                if (allowEscape && ch == '\\' && startIndex < @this.Length &&
                   ((nextChar = @this[startIndex]) == '\\' || nextChar == '\''))
                {
                    startIndex++; // Treat as escape character for \\ or \'
                }
                else if (ch == '\'')
                {
                    return startIndex;
                }
            }

            return startIndex;
        }
    }
}