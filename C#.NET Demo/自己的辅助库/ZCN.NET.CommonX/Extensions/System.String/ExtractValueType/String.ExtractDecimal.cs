using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从字符串中提取 decimal 类型数字
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>十进制数字</returns>
        public static decimal ExtractDecimal(this string @this)
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

            return Convert.ToDecimal(sb.ToString());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取多个 decimal 类型数字，返回数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>十进制数组</returns>
        public static decimal[] ExtractDecimalMany(this string @this)
        {
            return Regex.Matches(@this,@"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToDecimal(x.Value))
                        .ToArray();
        }
    }
}