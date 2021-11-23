using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///    自定义扩展方法：判断指定类型是否为字符串类型
        /// </summary>
        /// <param name="type">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsStringType(this Type type)
        {
            if(type == null)
                return false;

            return type == typeof(string);
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为字符串类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsStringType(this string typeName)
        {
            if(string.IsNullOrWhiteSpace(typeName))
                return false;

            if (typeName.Equals("string",StringComparison.OrdinalIgnoreCase))
                return true;

            Type type = Type.GetType(typeName);
            return type.IsStringType();
        }

        /// <summary>
        ///    自定义扩展方法：判断指定类型名称是否为大文本字符串类型
        /// </summary>
        /// <param name="typeName">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsStringClobType(this string typeName)
        {
            if(typeName.IsStringType() == false)
                return false;

            return typeName.EndsWith("text",StringComparison.OrdinalIgnoreCase) ||
                   typeName.EndsWith("CLOB",StringComparison.OrdinalIgnoreCase);

        }
    }
}