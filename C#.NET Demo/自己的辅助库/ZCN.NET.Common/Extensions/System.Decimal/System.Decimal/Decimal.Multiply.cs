namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：乘法运算。  
        ///  两个指定的 System.Decimal 值相乘
        /// </summary>
        /// <param name="d1">被乘数</param>
        /// <param name="d2">乘数</param>
        /// <returns>d1 和 d2 相乘的结果</returns>
        public static decimal Multiply(this decimal d1, decimal d2)
        {
            return decimal.Multiply(d1, d2);
        }
    }
}