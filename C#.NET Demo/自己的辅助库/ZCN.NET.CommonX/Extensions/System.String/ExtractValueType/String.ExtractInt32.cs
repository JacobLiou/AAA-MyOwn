using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region ExtractInt32

        /// <summary>
        ///  自定义扩展方法：从字符串中提取 32 位有符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 32 位有符号整数</returns>
        public static int ExtractInt32(this string @this)
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

            return Convert.ToInt32(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个  32 位有符号整数，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 32 位有符号整数</returns>
        public static int[] ExtractInt32Many(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToInt32(x.Value))
                        .ToArray();
        }

        #endregion

        #region ExtractUInt32

        /// <summary>
        ///  自定义扩展方法：从字符串中提取 32 位无符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 32 位有符号整数</returns>
        public static uint ExtractUInt32(this string @this)
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

            return Convert.ToUInt32(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个  32 位无符号整数，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 32 位有符号整数</returns>
        public static uint[] ExtractUInt32Many(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToUInt32(x.Value))
                        .ToArray();
        }

        #endregion
    }
}