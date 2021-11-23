using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取十六进制数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的十六进制数字</returns>
        public static StringBuilder ExtractHexadecimal(this StringBuilder @this)
        {
            return @this.ExtractHexadecimal(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取十六进制数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">结束位置</param>
        /// <returns>提取的十六进制数字</returns>
        public static StringBuilder ExtractHexadecimal(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractHexadecimal(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取十六进制数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的十六进制数字</returns>
        public static StringBuilder ExtractHexadecimal(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractHexadecimal(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取十六进制数字。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">结束位置</param>
        /// <returns>提取的十六进制数字</returns>
        public static StringBuilder ExtractHexadecimal(this StringBuilder @this, int startIndex, out int endIndex)
        {
            /* 此方法支持.NET运行时编译器的自定义运算符
             * 运算符可以是任何支持运算符字符的序列
             */

            if (startIndex + 1 < @this.Length && @this[startIndex] == '0'
               && (@this[startIndex + 1] == 'x' || @this[startIndex + 1] == 'X'))
            {
                var sb = new StringBuilder();

                var hasNumber = false;
                var hasSuffix = false;

                sb.Append(@this[startIndex]);
                sb.Append(@this[startIndex + 1]);

                var pos = startIndex + 2;

                while (pos < @this.Length)
                {
                    var ch = @this[pos];
                    pos++;

                    if (((ch >= '0' && ch <= '9')
                        || (ch >= 'a' && ch <= 'f')
                        || (ch >= 'A' && ch <= 'F'))
                       && !hasSuffix)
                    {
                        hasNumber = true;
                        sb.Append(ch);
                    }
                    else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
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

                if (hasNumber)
                {
                    endIndex = pos;
                    return sb;
                }
            }

            endIndex = -1;
            return null;
        }
    }
}