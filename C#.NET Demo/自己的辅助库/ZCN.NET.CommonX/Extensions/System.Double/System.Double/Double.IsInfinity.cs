namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定数字是计算为负无穷大还是正无穷大。
        /// 如果计算结果为 System.Double.PositiveInfinity 或 System.Double.NegativeInfinity，则为true；否则为 false
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsInfinity(this double d)
        {
            return double.IsInfinity(d);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定数字是计算是否为负无穷大
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsNegativeInfinity(this double d)
        {
            return double.IsNegativeInfinity(d);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定数字是计算是否为正无穷大
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsPositiveInfinity(this double d)
        {
            return double.IsPositiveInfinity(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否为有限值（零、不正常或正常）。
        /// 如果该值为有限值（零、不正常或正常），则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsFinite(this double d)
        {
            return double.IsFinite(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否为负值。
        /// 如果该值为负值，则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsNegative(this double d)
        {
            return double.IsNegative(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否不正常。
        /// 如果该值不正常，则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsSubnormal(this double d)
        {
            return double.IsSubnormal(d);
        }

        /// <summary>
        /// 自定义扩展方法：确定指定值是否正常。
        /// 如果该值正常，则为 true；否则为 false。
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns></returns>
        public static bool IsNormal(this double d)
        {
            return double.IsNormal(d);
        }
    }
}