using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region ExtractComment

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractComment(this StringBuilder @this)
        {
            return @this.ExtractComment(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的注释在扩展对象的值中的结束位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractComment(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractComment(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractComment(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractComment(startIndex, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的注释在扩展对象的值中的结束位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractComment(this StringBuilder @this, int startIndex, out int endIndex)
        {
            if(@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];

                if(ch1 == '/'&&ch2 == '/')
                {
                    // 单行注释

                    return @this.ExtractCommentSingleLine(startIndex, out endIndex);
                }

                if(ch1 == '/'&&ch2 == '*')
                {
                    /*
                 * 多行注释
                 */

                    return @this.ExtractCommentMultiLine(startIndex, out endIndex);
                }
            }

            endIndex = -1;
            return null;
        }

        #endregion

        #region ExtractCommentMultiLine

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取多行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this)
        {
            return @this.ExtractCommentMultiLine(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取多行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">输出参数：提取的注释在扩展对象的值中的结束位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractCommentMultiLine(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取多行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractCommentMultiLine(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取多行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">输出参数：提取的注释在扩展对象的值中的结束位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, int startIndex, out int endIndex)
        {
            var sb = new StringBuilder();

            if(@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];

                if(ch1 == '/'&&ch2 == '*')
                {
                    /*
                 * Multi-line comment
                 */

                    sb.Append(ch1);
                    sb.Append(ch2);
                    var pos = startIndex + 2;

                    while(pos < @this.Length)
                    {
                        var ch = @this[pos];
                        pos++;

                        if(ch == '*'&&pos < @this.Length&&@this[pos] == '/')
                        {
                            sb.Append(ch);
                            sb.Append(@this[pos]);
                            endIndex = pos;
                            return sb;
                        }

                        sb.Append(ch);
                    }

                    endIndex = pos;
                    return sb;
                }
            }

            endIndex = -1;
            return null;
        }

        #endregion

        #region ExtractCommentSingleLine

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取单行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this)
        {
            return @this.ExtractCommentSingleLine(0);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的起始位置提取单行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="endIndex">结束位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractCommentSingleLine(0, out endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取单行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this, int startIndex)
        {
            return @this.ExtractCommentSingleLine(startIndex, out int endIndex);
        }

        /// <summary>
        ///  自定义扩展方法：从扩展对象的值的指定位置提取单行注释。
        ///  如果提取不到则返回null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="endIndex">结束位置</param>
        /// <returns>提取的注释</returns>
        public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this, int startIndex, out int endIndex)
        {
            var sb = new StringBuilder();

            if(@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];

                if(ch1 == '/'&&ch2 == '/')
                {
                    // Single line comment

                    sb.Append(ch1);
                    sb.Append(ch2);
                    var pos = startIndex + 2;

                    while(pos < @this.Length)
                    {
                        var ch = @this[pos];
                        pos++;

                        if(ch == '\r'&&pos < @this.Length&&@this[pos] == '\n')
                        {
                            endIndex = pos - 1;
                            return sb;
                        }

                        sb.Append(ch);
                    }

                    endIndex = pos;
                    return sb;
                }
            }

            endIndex = -1;
            return null;
        }

        #endregion
    }
}