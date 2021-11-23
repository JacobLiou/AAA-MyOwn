using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 反序列化一个 64 位二进制值，并重新创建序列化的 System.DateTime 初始对象
        /// </summary>
        /// <param name="dateData">扩展对象。64 位有符号整数，它对 2 位字段的 System.DateTime.Kind 属性以及 
        /// 62 位字段的 System.DateTime.Ticks 属性进行了编码</param>
        /// <returns></returns>
        public static DateTime FromBinary(this Int64 dateData)
        {
            return DateTime.FromBinary(dateData);
        }
    }
}