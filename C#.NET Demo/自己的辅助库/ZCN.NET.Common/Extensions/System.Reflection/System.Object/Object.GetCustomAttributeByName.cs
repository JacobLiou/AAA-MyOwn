using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找第一个自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this object @this,string name)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找第一个自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this object @this,string name,bool inherit)
        {
            var type = @this.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(@this.ToString())
                                       .GetCustomAttributes(inherit)
                                       .Where(x => x.GetType().Name == name)
                                       .ToArray()
                                 : type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                 string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找第一个自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this MemberInfo @this,string name)
        {
            var attributes = @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找第一个自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this MemberInfo @this,string name,bool inherit)
        {
            var attributes = @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                 string.Format("模糊的属性。找到同一类型的多个自定义属性: {0}个属性被找到！",attributes.Length));
        }
    }
}