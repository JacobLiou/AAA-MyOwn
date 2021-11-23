using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取指定对象的 System.TypeCode。
        ///  如果参数为 null，则返回 System.TypeCode.Empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeCode GetTypeCode(this object value)
        {
            return Convert.GetTypeCode(value);
        }
    }
}