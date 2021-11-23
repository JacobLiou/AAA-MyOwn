namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的双精度浮点数。
        /// </summary>
        /// <param name="value">单精度浮点数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的双精度浮点数。</returns>
        public static double ToDouble(this float value)
        {
            return (double)value;
        }
    }
}