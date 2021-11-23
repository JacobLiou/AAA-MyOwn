using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取特殊符号。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的特殊符号</returns>
        public static StringBuilder ExtractOperator(this StringBuilder @this)
        {
            //(包含`~!#$%^*()-_=+[]{}|:;,.<>?/)
            return @this.ExtractOperator(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取特殊符号。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的特殊符号在扩展对象的值中的结束位置</param>
        /// <returns>提取的特殊符号</returns>
        public static StringBuilder ExtractOperator(this StringBuilder @this, out int endIndex)
        {
            //(包含`~!#$%^*()-_=+[]{}|:;,.<>?/)
            return @this.ExtractOperator(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取特殊符号。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的特殊符号</returns>
        public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex)
        {
            //(包含`~!#$%^*()-_=+[]{}|:;,.<>?/)
            return @this.ExtractOperator(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取特殊符号
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的特殊符号在扩展对象的值中的结束位置</param>
        /// <returns>提取的特殊符号</returns>
        public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex, out int endIndex)
        {
            /*此方法支持.NET运行时编译器的自定义特殊符号，
            * 特殊符号可以是任何支持特殊符号字符的序列。
            */
            var sb = new StringBuilder();

            var pos = startIndex;

            while(pos < @this.Length)
            {
                var ch = @this[pos];
                pos++;

                switch(ch)
                {
                    case '`':
                    case '~':
                    case '!':
                    case '#':
                    case '$':
                    case '%':
                    case '^':
                    case '&':
                    case '*':
                    case '(':
                    case ')':
                    case '-':
                    case '_':
                    case '=':
                    case '+':
                    case '[':
                    case ']':
                    case '{':
                    case '}':
                    case '|':
                    case ':':
                    case ';':
                    case ',':
                    case '.':
                    case '<':
                    case '>':
                    case '?':
                    case '/':
                        sb.Append(ch);
                        break;
                    default:
                        if(sb.Length > 0)
                        {
                            endIndex = pos - 2;
                            return sb;
                        }

                        endIndex = -1;
                        return null;
                }
            }

            if(sb.Length > 0)
            {
                endIndex = pos;
                return sb;
            }

            endIndex = -1;
            return null;
        }
    }
}