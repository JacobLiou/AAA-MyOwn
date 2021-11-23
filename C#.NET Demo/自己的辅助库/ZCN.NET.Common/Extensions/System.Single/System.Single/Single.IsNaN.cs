using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定数字的计算结果是否为不是数字 (System.Single.NaN) 的值
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns>计算结果为 System.Single.NaN，则为 true；否则为 false</returns>
        public static bool IsNaN(this float d)
        {
            return Single.IsNaN(d);
        }
    }
}