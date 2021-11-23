using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定的双精度浮点数的值转换为等效的单精度浮点数。
        ///  使用“舍入为最接近的数字”规则对 <paramref name="value" /> 进行舍入。 例如，当舍入为两位小数时，值 2.345 变成 2.34，而值 2.355 变成 2.36。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns> 等效于decimal值的单精度浮点数</returns>
        public static Single ToSingle(this decimal value)
        {
            return (float)value;
        }

        /// <summary>
        ///  自定义扩展方法：将指定的双精度浮点数的值转换为等效的单精度浮点数。
        ///  使用“舍入为最接近的数字”规则对 <paramref name="value" /> 进行舍入。 例如，当舍入为两位小数时，值 2.345 变成 2.34，而值 2.355 变成 2.36。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns> 等效于decimal值的单精度浮点数</returns>
        public static float ToFloat(this decimal value)
        {
            return (float)value;
        }
    }
}