using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断是否 attributeType 的一个或多个实例应用于此成员
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="attributeType">自定义特性应用于的 Type 对象</param>
        /// <param name="inherit">指定是否搜索该成员的继承链以查找这些特性</param>
        /// <returns></returns>
        public static bool IsAttributeDefined(this object @this,Type attributeType,bool inherit)
        {
            return @this.GetType().IsDefined(attributeType,inherit);
        }

        /// <summary>
        ///  自定义扩展方法：判断是否 attributeType 的一个或多个实例应用于此成员
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="inherit">指定是否搜索该成员的继承链以查找这些特性</param>
        /// <returns></returns>
        public static bool IsAttributeDefined<T>(this object @this,bool inherit) where T : Attribute
        {
            return @this.GetType().IsDefined(typeof(T),inherit);
        }
    }
}