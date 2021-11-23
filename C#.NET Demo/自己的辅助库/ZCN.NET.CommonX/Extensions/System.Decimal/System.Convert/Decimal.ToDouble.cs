namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定 System.Decimal 的值转换为等效的双精度浮点数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns> 等效于decimal值的双精度浮点数</returns>
        public static double ToDouble(this decimal value)
        {
            return (double)value;
        }
    }
}