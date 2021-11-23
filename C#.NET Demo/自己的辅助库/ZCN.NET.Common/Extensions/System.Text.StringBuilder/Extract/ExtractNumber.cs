using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的数字</returns>
        public static StringBuilder ExtractNumber(this StringBuilder @this)
        {
            return @this.ExtractNumber(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的数字在扩展对象的值中的结束位置</param>
        /// <returns>提取的数字</returns>
        public static StringBuilder ExtractNumber(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractNumber(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的数字</returns>
        public static StringBuilder ExtractNumber(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractNumber(startIndex, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的数字在扩展对象的值中的结束位置</param>
        /// <returns>提取的数字</returns>
        public static StringBuilder ExtractNumber(this StringBuilder @this, int startIndex, out int endIndex)
        {
            /*此方法支持.NET运行时编译器的自定义运算符，
            * 运算符可以是任何支持运算符字符的序列。
            */
            var sb = new StringBuilder();

            var hasNumber = false;
            var hasDot = false;
            var hasSuffix = false;

            var pos = startIndex;

            while(pos < @this.Length)
            {
                var ch = @this[pos];
                pos++;

                if(ch >= '0'&&ch <= '9'&&!hasSuffix)
                {
                    hasNumber = true;
                    sb.Append(ch);
                }
                else if(ch == '.'&&!hasSuffix&&!hasDot)
                {
                    hasDot = true;
                    sb.Append(ch);
                }
                else if((ch >= 'a'&&ch <= 'z')||(ch >= 'A'&&ch <= 'Z'))
                {
                    hasSuffix = true;
                    sb.Append(ch);
                }
                else
                {
                    pos -= 2;
                    break;
                }
            }

            if(hasNumber)
            {
                endIndex = pos;
                return sb;
            }

            endIndex = -1;
            return null;
        }
    }
}