namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：取反运算。
        ///  返回指定的 System.decimal 值乘以 -1 的结果
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns>取反的结果</returns>
        public static decimal Negate(this decimal d)
        {
            return decimal.Negate(d);
        }
    }
}