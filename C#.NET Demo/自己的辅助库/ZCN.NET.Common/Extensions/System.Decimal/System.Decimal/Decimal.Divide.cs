
namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：除法运算。
        ///  两个指定的 System.Decimal 值相除。如果除数为0则返回0
        /// </summary>
        /// <param name="d1">扩展对象。被除数</param>
        /// <param name="d2">除数</param>
        /// <returns>d1 除以 d2 的结果</returns>
        public static decimal Divide(this decimal d1, decimal d2)
        {
            if (d2 == 0)
                return 0;

            return decimal.Divide(d1, d2);
        }
    }
}