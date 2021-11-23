using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取.Net关键字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的.Net关键字</returns>
        public static StringBuilder ExtractKeyword(this StringBuilder @this)
        {
            return @this.ExtractKeyword(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取.Net关键字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的.Net关键字在扩展对象的值中的结束位置</param>
        /// <returns>提取的.Net关键字</returns>
        public static StringBuilder ExtractKeyword(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractKeyword(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取.Net关键字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的.Net关键字</returns>
        public static StringBuilder ExtractKeyword(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractKeyword(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取.Net关键字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的.Net关键字在扩展对象的值中的结束位置</param>
        /// <returns>提取的.Net关键字</returns>
        public static StringBuilder ExtractKeyword(this StringBuilder @this, int startIndex, out int endIndex)
        {
            /*此方法支持.NET运行时编译器的自定义运算符，
            * 运算符可以是任何支持运算符字符的序列。
            */
            var sb = new StringBuilder();

            var pos = startIndex;
            var hasCharacter = false;

            while(pos < @this.Length)
            {
                var ch = @this[pos];
                pos++;

                if((ch >= 'a'&&ch <= 'z')||(ch >= 'A'&&ch <= 'Z'))
                {
                    hasCharacter = true;
                    sb.Append(ch);
                }
                else if(ch == '@')
                {
                    sb.Append(ch);
                }
                else if(ch >= '0'&&ch <= '9'&&hasCharacter)
                {
                    sb.Append(ch);
                }
                else
                {
                    pos -= 2;
                    break;
                }
            }

            if(hasCharacter)
            {
                endIndex = pos;
                return sb;
            }

            endIndex = -1;
            return null;
        }
    }
}