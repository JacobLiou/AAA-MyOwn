using System.ComponentModel;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取对象的描述信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this object value)
        {
            var type = value.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute))
                                 : type.GetCustomAttributes(typeof (DescriptionAttribute));
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(
                string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }

        /// <summary>
        ///  自定义扩展方法：获取对象的描述信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this object value, bool inherit)
        {
            var type = value.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), inherit)
                                 : type.GetCustomAttributes(typeof (DescriptionAttribute));
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }

        /// <summary>
        ///  自定义扩展方法：获取对象的描述信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this MemberInfo value)
        {
            var attributes = value.GetCustomAttributes(typeof (DescriptionAttribute));
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }

        /// <summary>
        ///  自定义扩展方法：获取对象的描述信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this MemberInfo value, bool inherit)
        {
            var attributes = value.GetCustomAttributes(typeof (DescriptionAttribute), inherit);
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(
                string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }
    }
}