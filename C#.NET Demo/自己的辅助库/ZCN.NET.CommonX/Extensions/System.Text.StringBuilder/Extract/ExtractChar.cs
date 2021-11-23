using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的字符</returns>
        public static char ExtractChar(this StringBuilder @this)
        {
            return @this.ExtractChar(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的字符在扩展对象的值中的结束位置</param>
        /// <returns>提取的字符</returns>
        public static char ExtractChar(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractChar(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的字符</returns>
        public static char ExtractChar(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractChar(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的字符在扩展对象的值中的结束位置</param>
        /// <returns>提取的字符</returns>
        public static char ExtractChar(this StringBuilder @this, int startIndex, out int endIndex)
        {
            if (@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];
                var ch3 = @this[startIndex + 2];

                if (ch1 == '\'' && ch3 == '\'')
                {
                    endIndex = startIndex + 2;
                    return ch2;
                }
            }

            throw new System.Exception("位置{0}出的字符无效！".Format(startIndex));
        }
    }
}