using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定数字是计算为负无穷大还是正无穷大。
        /// 如果计算结果为 System.float.PositiveInfinity 或 System.float.NegativeInfinity，则为true；否则为 false
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsInfinity(this float d)
        {
            return float.IsInfinity(d);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定数字是计算是否为负无穷大
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsNegativeInfinity(this float d)
        {
            return float.IsNegativeInfinity(d);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定数字是计算是否为正无穷大
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsPositiveInfinity(this float d)
        {
            return float.IsPositiveInfinity(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否为有限值（零、不正常或正常）。
        /// 如果该值为有限值（零、不正常或正常），则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsFinite(this float d)
        {
            return float.IsFinite(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否为负值。
        /// 如果该值为负值，则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsNegative(this float d)
        {
            return float.IsNegative(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否不正常。
        /// 如果该值不正常，则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsSubnormal(this float d)
        {
            return float.IsSubnormal(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否正常。
        /// 如果该值正常，则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsNormal(this float d)
        {
            return float.IsNormal(d);
        }
    }
}