using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///    自定义扩展方法：判断指定类型是否为64位有符号整数类型
        /// </summary>
        /// <param name="type">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsInt64Type(this Type type)
        {
            if(type == null)
                return false;

            return type == typeof(Int64);
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为64位有符号整数类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsInt64Type(this string typeName)
        {
            if(string.IsNullOrWhiteSpace(typeName))
                return false;

            Type type = Type.GetType(typeName);
            return type.IsInt64Type();
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型是否为64位无符号整数类型
        /// </summary>
        /// <param name="type">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsUInt64Type(this Type type)
        {
            if (type == null)
                return false;

            return type == typeof(UInt64);
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为64位无符号整数类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsUInt64Type(this string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                return false;

            Type type = Type.GetType(typeName);
            return type.IsUInt64Type();
        }
    }
}