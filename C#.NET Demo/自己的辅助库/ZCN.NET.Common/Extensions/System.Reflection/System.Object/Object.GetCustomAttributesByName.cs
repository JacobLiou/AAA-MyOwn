using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByName(this object @this, string name)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByName(this object @this, string name, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString())
                    .GetCustomAttributes(inherit)
                    .Where(x => x.GetType().Name == name)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByName(this MemberInfo @this, string name)
        {
            return @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的名称来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="name">成员名称</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByName(this MemberInfo @this, string name, bool inherit)
        {
            return @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
        }
    }
}