using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：(四舍六入五取偶)将双精度浮点值舍入到最接近的整数值。
        /// 如果 double 的值的小数部分正好处于两个整数中间，其中一个整数为偶数，另一个整数为奇数，则返回偶数
        /// (10.4 返回 10；10.5 返回 10；10.6 返回 11)。
        /// 请注意，此方法返回 System.Double，而不是整数类型
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns>最接近参数 d 的整数</returns>
        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        /// <summary>
        /// 自定义扩展方法：(四舍六入五取偶)将双精度浮点值按指定的小数位数舍入
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <param name="decimals">返回值中的小数位数</param>
        /// <returns>其小数数字等于 decimals 的值的最接近的数字</returns>
        public static double Round(this double d,int decimals)
        {
            return Math.Round(d,decimals);
        }

        /// <summary>
        ///  自定义扩展方法：(四舍六入五取偶)将双精度浮点值舍入到最接近的整数。
        ///  参数 MidpointRounding，指定当一个值正好处于另两个数中间时如何舍入这个值
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <param name="mode">在两个数字之间时如何舍入的规范</param>
        /// <returns>最接近 double 的值的整数。如果 double 的值是两个数字的中值，这两个数字一个为偶数，另一个为奇数，
        /// 则 mode 确定返回两个数字中的哪一个</returns>
        public static double Round(this double d,MidpointRounding mode)
        {
            return Math.Round(d,mode);
        }

        /// <summary>
        /// 自定义扩展方法：(四舍六入五取偶)将双精度浮点值按指定的小数位数舍入。
        /// 参数 MidpointRounding，指定当一个值正好处于另两个数中间时如何舍入这个值
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <param name="decimals">返回值中的小数位数</param>
        /// <param name="mode">在两个数字之间时如何舍入的规范</param>
        /// <returns>最接近 double 值的 decimals 位小数的数字。如果 double值 的小数数字小于 decimals，则返回的 d 保持不变</returns>
        public static double Round(this double d,int decimals,MidpointRounding mode)
        {
            return Math.Round(d,decimals,mode);
        }

        /// <summary>
        /// 自定义扩展方法：(真正的中国式四舍五入)将双精度浮点值按指定的小数位数舍入
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <param name="decimals">返回值中的小数位数</param>
        /// <returns>其小数数字等于 decimals 的值的最接近的数字</returns>
        public static double Round2(this double d,int decimals)
        {
            return Math.Round(d,decimals,MidpointRounding.AwayFromZero);
        }
    }
}