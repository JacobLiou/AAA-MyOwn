using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///    自定义扩展方法：判断指定类型是否为 DateTime 类型
        /// </summary>
        /// <param name="type">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsDateTimeType(this Type type)
        {
            if(type == null)
                return false;

            return type == typeof(DateTime);
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为 DateTime 类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsDateTimeType(this string typeName)
        {
            if(string.IsNullOrWhiteSpace(typeName))
                return false;

            Type type = Type.GetType(typeName);
            return type.IsDateTimeType();
        }
    }
}