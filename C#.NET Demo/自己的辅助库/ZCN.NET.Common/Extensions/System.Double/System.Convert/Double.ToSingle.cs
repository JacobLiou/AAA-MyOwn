using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定的双精度浮点数的值转换为等效的单精度浮点数。
        /// 使用“舍入为最接近的数字”规则对 <paramref name="value" /> 进行舍入。 例如，当舍入为两位小数时，值 2.345 变成 2.34，而值 2.355 变成 2.36。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>
        public static float ToSingle(this double value)
        {
            return (float)value;
        }
    }
}