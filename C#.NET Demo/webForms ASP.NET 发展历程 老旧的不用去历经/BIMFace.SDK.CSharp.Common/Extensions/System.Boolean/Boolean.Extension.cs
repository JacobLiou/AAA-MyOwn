using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        /// 自定义扩展方法：如果扩展对象的值为 true 则返回 trueValue；
        /// 如果扩展对象的值为 false 则返回 falseValue
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="trueValue">如果这个值为 true，则返回的真正值</param>
        /// <param name="falseValue">如果这个值是 false，则返回的false值</param>
        /// <returns></returns>
        public static string ToString(this bool @this, string trueValue = "true", string falseValue = "false")
        {
            return @this ? trueValue : falseValue;
        }

        /// <summary>
        /// 自定义扩展方法：如果扩展对象的值为 true 则返回 trueValue；
        /// 如果扩展对象的值为 false 则返回 falseValue
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="trueValue">如果这个值为 true，则返回的真正值</param>
        /// <param name="falseValue">如果这个值是 false，则返回的false值</param>
        /// <returns></returns>
        public static string ToString(this bool? @this, string trueValue = "true", string falseValue = "false")
        {
            return @this.ToBoolean() ? trueValue : falseValue;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的布尔值转换为等效的 8 位无符号整数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>8 位无符号整数</returns>
        public static byte ToBinary(this bool @this)
        {
            return Convert.ToByte(@this);
        }
    }
}