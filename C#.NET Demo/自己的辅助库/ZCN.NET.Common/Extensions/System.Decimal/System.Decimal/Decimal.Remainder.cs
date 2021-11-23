namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：取模(余数)运算。
        ///  两个指定的 System.decimal 值相除，返回余数。如果除数为0则返回0
        /// </summary>
        /// <param name="d1">扩展对象。被除数</param>
        /// <param name="d2">除数</param>
        /// <returns>d1 除以 d2 的余数</returns>
        public static decimal Remainder(this decimal d1, decimal d2)
        {
            if(d2 == 0)
                return 0;

            return decimal.Remainder(d1, d2);
        }

        /// <summary>
        ///  自定义扩展方法：两个指定的 System.decimal 值相除，返回余数。如果除数为0则返回0
        /// </summary>
        /// <param name="d1">扩展对象。被除数</param>
        /// <param name="d2">除数</param>
        /// <returns>d1 除以 d2 的余数</returns>
        public static decimal Mode(this decimal d1,decimal d2)
        {
            if(d2 == 0)
                return 0;

            return d1 % d2;
        }
    }
}