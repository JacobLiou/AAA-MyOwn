namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定 System.Decimal 值转换为等效的 OLE 自动化货币值，该值包含在一个 64 位有符号整数中
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>包含 value 的 OLE 自动化等效值的 64 位有符号整数</returns>
        public static long ToOACurrency(this decimal value)
        {
            return decimal.ToOACurrency(value);
        }
    }
}