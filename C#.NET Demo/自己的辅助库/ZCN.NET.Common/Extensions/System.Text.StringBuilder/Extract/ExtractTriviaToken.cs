using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的起始位置提取琐事令牌。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的琐事令牌</returns>
        public static StringBuilder ExtractTriviaToken(this StringBuilder @this)
        {
            return @this.ExtractTriviaToken(0);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的起始位置提取琐事令牌。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的琐事令牌在扩展对象的值中的结束位置</param>
        /// <returns>提取的琐事令牌</returns>
        public static StringBuilder ExtractTriviaToken(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractTriviaToken(0, out endIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的指定位置提取琐事令牌。
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的琐事令牌</returns>
        public static StringBuilder ExtractTriviaToken(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractTriviaToken(startIndex, out int endIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从扩展对象的值的指定位置提取琐事令牌
        /// 如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的琐事令牌在扩展对象的值中的结束位置</param>
        /// <returns>提取的琐事令牌</returns>
        public static StringBuilder ExtractTriviaToken(this StringBuilder @this, int startIndex, out int endIndex)
        {
            var sb = new StringBuilder();
            var pos = startIndex;

            var isSpace = false;

            while(pos < @this.Length)
            {
                var ch = @this[pos];
                pos++;

                if(ch == ' '||ch == '\r'||ch == '\n'||ch == '\t')
                {
                    isSpace = true;
                    sb.Append(ch);
                }
                else if(ch == '/'&&!isSpace)
                {
                    if(pos < @this.Length)
                    {
                        ch = @this[pos];
                        if(ch == '/')
                        {
                            return @this.ExtractCommentSingleLine(startIndex, out endIndex);
                        }
                        if(ch == '*')
                        {
                            return @this.ExtractCommentMultiLine(startIndex, out endIndex);
                        }

                        // otherwise is probably the divide operator
                        pos--;
                        break;
                    }
                }
                else
                {
                    pos -= 2;
                    break;
                }
            }

            if(isSpace)
            {
                endIndex = pos;
                return sb;
            }

            endIndex = -1;
            return null;
        }
    }
}