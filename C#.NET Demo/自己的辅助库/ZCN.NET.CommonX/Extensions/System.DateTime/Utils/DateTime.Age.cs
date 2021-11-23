using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：计算年龄
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static int Age(this DateTime @this)
        {
            if (DateTime.Today.Month < @this.Month ||
               DateTime.Today.Month == @this.Month &&
               DateTime.Today.Day < @this.Day)
            {
                return DateTime.Today.Year - @this.Year - 1;
            }

            return DateTime.Today.Year - @this.Year;
        }
    }
}