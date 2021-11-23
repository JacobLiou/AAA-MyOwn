namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定数字 Unicode 字符转换为双精度浮点数
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns>如果该字符表示数字，则为 c 的数值；否则为 -1.0</returns>
        public static double GetNumericValue(this char c)
        {
            return char.GetNumericValue(c);
        }
    }
}