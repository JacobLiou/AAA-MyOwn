using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///    自定义扩展方法：判断指定类型是否为数值类型
        /// </summary>
        /// <param name="type">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsNumericType(this Type type)
        {
            if(type == null)
                return false;

            return    type == typeof(Byte)
                   || type == typeof(SByte)
                   || type == typeof(Int16)
                   || type == typeof(Int32)
                   || type == typeof(Int64)
                   || type == typeof(UInt16)
                   || type == typeof(UInt32)
                   || type == typeof(UInt64)
                   || type == typeof(Decimal)
                   || type == typeof(Double)
                   || type == typeof(Single);
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为数值类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsNumericType(this string typeName)
        {
            if(string.IsNullOrWhiteSpace(typeName))
                return false;

            Type type = Type.GetType(typeName);
            return type.IsNumericType();
        }
    }
}