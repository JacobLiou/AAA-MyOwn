using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ExtractInt64

        /// <summary>
        ///  自定义扩展方法：从字符串中提取 64 位有符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 64 位有符号整数</returns>
        public static long ExtractInt64(this string @this)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i < @this.Length;i++)
            {
                if(Char.IsDigit(@this[i]) || @this[i] == '.')
                {
                    if(sb.Length == 0 && i > 0 && @this[i - 1] == '-')
                    {
                        sb.Append('-');
                    }
                    sb.Append(@this[i]);
                }
            }

            return Convert.ToInt64(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个  64 位有符号整数，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 64 位有符号整数</returns>
        public static long[] ExtractInt64Many(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToInt64(x.Value))
                        .ToArray();
        }

        #endregion

        #region ExtractUInt64

        /// <summary>
        ///  自定义扩展方法：从字符串中提取 64 位无符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 64 位有符号整数</returns>
        public static ulong ExtractUInt64(this string @this)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i < @this.Length;i++)
            {
                if(Char.IsDigit(@this[i]) || @this[i] == '.')
                {
                    if(sb.Length == 0 && i > 0 && @this[i - 1] == '-')
                    {
                        sb.Append('-');
                    }
                    sb.Append(@this[i]);
                }
            }

            return Convert.ToUInt64(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个  64 位无符号整数，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 64 位有符号整数</returns>
        public static ulong[] ExtractUInt64Many(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToUInt64(x.Value))
                        .ToArray();
        }

        #endregion
    }
}