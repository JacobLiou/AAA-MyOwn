using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：通过对象的全名来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="fullName">System.Type 的完全限定名，包括 System.Type 的命名空间，但不包括程序集</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByFullName(this object @this, string fullName)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString())
                    .GetCustomAttributes()
                    .Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的全名来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="fullName">System.Type 的完全限定名，包括 System.Type 的命名空间，但不包括程序集</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByFullName(this object @this, string fullName, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString())
                    .GetCustomAttributes(inherit)
                    .Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的全名来查找自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="fullName">System.Type 的完全限定名，包括 System.Type 的命名空间，但不包括程序集</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName)
        {
            return @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：通过对象的全名来查找第一个自定义属性
        /// </summary>
        /// <exception cref="Exception">当出现异常错误时抛出</exception>
        /// <param name="this">扩展对象</param>
        /// <param name="fullName">System.Type 的完全限定名，包括 System.Type 的命名空间，但不包括程序集</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName, bool inherit)
        {
            return @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
        }
    }
}