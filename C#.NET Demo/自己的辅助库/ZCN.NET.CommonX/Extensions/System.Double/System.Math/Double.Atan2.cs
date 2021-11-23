using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回正切值为两个指定数字的商的角度。
        /// 返回角度 θ，以弧度为单位，满足 -π≤θ≤π，且 tan(θ) = y / x，其中 (x, y) 是笛卡尔平面中的一个点。
        /// 请看下面：如果 (x, y) 在第 1 象限，则 0 &lt; θ &lt; π/2。
        /// 如果 (x, y) 在第 2 象限，则 π/2 &lt; θ≤π。
        /// 如果 (x, y) 在第 3 象限，则 -π &lt; θ &lt; -π/2。
        /// 如果 (x, y) 在第 4 象限，则 -π/2 &lt; θ &lt; 0。
        /// 
        /// 如果点在象限的边界上，则返回值如下：
        /// 如果 y 为 0 并且 x 不为负值，则θ = 0。
        /// 如果 y 为 0 并且 x 为负值，则 θ = π。
        /// 如果 y 为正值并且 x 为 0，则 θ = π/2。
        /// 如果 y 负值并且 x 为 0，则θ = -π/2
        /// </summary>
        /// <param name="y">扩展对象。点的 y 坐标</param>
        /// <param name="x">点的 x 坐标</param>
        /// <returns></returns>
        public static double Atan2(this double y, double x)
        {
            return Math.Atan2(y, x);
        }
    }
}