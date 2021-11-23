using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
       
        /// <summary>
        ///  自定义扩展方法，返回32位有符号整数的绝对值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Abs(this Int32 value)
        {
            return Math.Abs(value);
        }
    }
}