namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：减法运算。
        ///  从一个 System.decimal 值中减去指定的另一个这种类型的值
        /// </summary>
        /// <param name="d1">扩展对象。被减数</param>
        /// <param name="d2">减数</param>
        /// <returns>d1 减 d2 所得的 System.decimal 结果</returns>
        public static decimal Subtract(this decimal d1, decimal d2)
        {
            return decimal.Subtract(d1, d2);
        }
    }
}