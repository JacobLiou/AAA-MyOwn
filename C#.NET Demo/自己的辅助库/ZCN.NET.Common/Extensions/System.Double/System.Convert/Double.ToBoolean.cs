namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定双精度浮点数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。</returns>
        public static bool ToBoolean(this double value)
        {
            return value != 0.0; //Convert.ToBoolean(value); 的内部实现方式
        }
    }
}