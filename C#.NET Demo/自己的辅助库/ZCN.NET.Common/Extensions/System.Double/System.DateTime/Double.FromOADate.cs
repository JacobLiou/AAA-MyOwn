using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回与指定的 OLE 自动化日期等效的 System.DateTime
        /// </summary>
        /// <param name="d">扩展对象。双精度浮点数</param>
        /// <returns>与双精度浮点数相同的日期和时间</returns>
        public static DateTime FromOADate(this double d)
        {
            return DateTime.FromOADate(d);
        }
    }
}