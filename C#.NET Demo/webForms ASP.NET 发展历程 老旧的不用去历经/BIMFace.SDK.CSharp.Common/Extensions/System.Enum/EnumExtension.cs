using System;
using System.ComponentModel;
using System.Linq;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        ///  自定义扩展发放：在指定枚举中检索具有指定值的常数的名称
        /// </summary>
        /// <param name="this">枚举对象</param>
        /// <param name="value">特定枚举常数的值（根据其基础类型）</param>
        /// <returns></returns>
        public static string GetName(this Enum @this, object value)
        {
            return Enum.GetName(@this.GetType(), value);
        }

        /// <summary>
        ///  自定义扩展方法：获取枚举项第一个自定义的 Description 特性的描述文字
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this Enum @this)
        {
            var attr =
                @this.GetType()
                     .GetField(@this.ToString())
                     .GetCustomAttributes(typeof(DescriptionAttribute), false)
                     .FirstOrDefault() as DescriptionAttribute;

            return attr.Description;
        }

        /// <summary>
        ///  自定义扩展方法：判断枚举值是否在枚举数组中
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="values">枚举数组</param>
        /// <returns></returns>
        public static bool In(this global::System.Enum @this, params global::System.Enum[] values)
        {
            return Array.IndexOf(values, @this) != -1;
        }

        /// <summary>
        ///  自定义扩展方法：判断枚举值是否不在枚举数组中
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="values">枚举数组</param>
        /// <returns></returns>
        public static bool NotIn(this Enum @this, params Enum[] values)
        {
            return Array.IndexOf(values, @this) == -1;
        }
    }
}