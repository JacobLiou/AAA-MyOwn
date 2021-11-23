using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region ExtractInt16

        /// <summary>
        ///  自定义扩展方法：从字符串中提取 16 位有符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 16 位有符号整数</returns>
        public static short ExtractInt16(this string @this)
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

            return Convert.ToInt16(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个  16 位有符号整数，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 16 位有符号整数</returns>
        public static short[] ExtractInt16Many(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToInt16(x.Value))
                        .ToArray();
        }

        #endregion

        #region ExtractUInt16

        /// <summary>
        ///  自定义扩展方法：从字符串中提取 16 位无符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 16 位有符号整数</returns>
        public static ushort ExtractUInt16(this string @this)
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

            return Convert.ToUInt16(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个  16 位无符号整数，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns> 16 位有符号整数</returns>
        public static ushort[] ExtractUInt16Many(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToUInt16(x.Value))
                        .ToArray();
        }

        #endregion
    }
}