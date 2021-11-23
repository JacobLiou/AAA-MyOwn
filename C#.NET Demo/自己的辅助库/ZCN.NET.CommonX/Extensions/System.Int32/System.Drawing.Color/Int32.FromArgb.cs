using System;
using System.Drawing;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从一个 32 位 ARGB 值创建 System.Drawing.Color 结构
        /// </summary>
        /// <param name="argb">扩展对象。指定 32 位 ARGB 值的值</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb)
        {
            return Color.FromArgb(argb);
        }

        /// <summary>
        /// 自定义扩展方法：从四个 ARGB 分量（alpha、红色、绿色和蓝色）值创建 System.Drawing.Color 结构。
        /// 尽管此方法允许为每个分量传递 32 位值，但每个分量的值仅限于 8 位
        /// </summary>
        /// <param name="argb">扩展对象。alpha 分量。有效值为从 0 到 255</param>
        /// <param name="red">红色分量。有效值为从 0 到 255</param>
        /// <param name="green">绿色分量。有效值为从 0 到 255</param>
        /// <param name="blue">蓝色分量。有效值为从 0 到 255</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb, Int32 red, Int32 green, Int32 blue)
        {
            return Color.FromArgb(argb, red, green, blue);
        }

        /// <summary>
        /// 自定义扩展方法：从指定的 8 位颜色值（红色、绿色和蓝色）创建 System.Drawing.Color 结构。
        /// alpha 值默认为 255（完全不透明）。
        /// 尽管此方法允许为每个颜色分量传递 32 位值，但每个分量的值仅限于 8 位
        /// </summary>
        /// <param name="argb">扩展对象。红色分量。有效值为从 0 到 255</param>
        /// <param name="green">绿色分量。有效值为从 0 到 255</param>
        /// <param name="blue">蓝色分量。有效值为从 0 到 255</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb, Int32 green, Int32 blue)
        {
            return Color.FromArgb(argb, green, blue);
        }

        /// <summary>
        /// 自定义扩展方法： 从指定的 System.Drawing.Color 结构创建 System.Drawing.Color 结构，但要使用新指定的 alpha 值。
        /// 尽管此方法允许为alpha 值传递 32 位值，但该值仅限于 8 位
        /// </summary>
        /// <param name="argb">扩展对象。新 System.Drawing.Color 的 alpha 值。有效值为从 0 到 255</param>
        /// <param name="baseColor">从中创建新 System.Drawing.Color 的 System.Drawing.Color</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb,Color baseColor)
        {
            return Color.FromArgb(argb,baseColor);
        }
    }
}