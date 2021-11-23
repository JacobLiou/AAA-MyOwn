using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的起始位置提取令牌(包含：Keyword、Literal、Operator、String、Integer、Real等)。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的令牌</returns>
        public static StringBuilder ExtractToken(this StringBuilder @this)
        {
            return @this.ExtractToken(0);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的起始位置提取令牌。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的令牌在扩展对象的值中的结束位置</param>
        /// <returns>提取的令牌</returns>
        public static StringBuilder ExtractToken(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractToken(0, out endIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的指定位置提取令牌(包含：Keyword、Literal、Operator、String、Integer、Real等)。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的令牌</returns>
        public static StringBuilder ExtractToken(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractToken(startIndex, out int endIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的指定位置提取令牌(包含：Keyword、Literal、Operator、String、Integer、Real等)
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的令牌在扩展对象的值中的结束位置</param>
        /// <returns>提取的令牌</returns>
        public static StringBuilder ExtractToken(this StringBuilder @this, int startIndex, out int endIndex)
        {
            /* A token can be:
             * - Keyword / Literal
             * - Operator
             * - String
             * - Integer
             * - Real
             */

            // CHECK first which type is the token
            var ch1 = @this[startIndex];
            var pos = startIndex + 1;

            switch(ch1)
            {
                case '@':
                    if(pos < @this.Length&&@this[pos] == '"')
                    {
                        return @this.ExtractStringArobasDoubleQuote(startIndex, out endIndex);
                    }
                    if(pos < @this.Length&&@this[pos] == '\'')
                    {
                        return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
                    }

                    break;
                case '"':
                    return @this.ExtractStringDoubleQuote(startIndex, out endIndex);
                case '\'':
                    return @this.ExtractStringSingleQuote(startIndex, out endIndex);
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
                    return @this.ExtractOperator(startIndex, out endIndex);
                case '0':
                    if(pos < @this.Length&&(@this[pos] == 'x'||@this[pos] == 'X'))
                    {
                        return @this.ExtractHexadecimal(startIndex, out endIndex);
                    }

                    return @this.ExtractNumber(startIndex, out endIndex);
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return @this.ExtractNumber(startIndex, out endIndex);
                default:
                    if((ch1 >= 'a'&&ch1 <= 'z')||(ch1 >= 'A'&&ch1 <= 'Z'))
                    {
                        return @this.ExtractKeyword(startIndex, out endIndex);
                    }

                    endIndex = -1;
                    return null;
            }

            throw new System.Exception("无效的 token。");
        }
    }
}