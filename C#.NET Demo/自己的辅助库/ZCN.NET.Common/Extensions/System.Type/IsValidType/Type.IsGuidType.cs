using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///    自定义扩展方法：判断指定类型是否为 System.Guid 类型
        /// </summary>
        /// <param name="type">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsGuidType(this Type type)
        {
            if(type == null)
                return false;

            return type == typeof(Guid);
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为 System.Guid 类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsGuidType(this string typeName)
        {
            if(string.IsNullOrWhiteSpace(typeName))
                return false;

            Type type = Type.GetType(typeName);
            return type.IsGuidType();
        }
    }
}