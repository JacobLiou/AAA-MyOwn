namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 将 UTF-16 编码的代理项对的值转换为 Unicode 码位
        /// </summary>
        /// <param name="highSurrogate">高代理项码位（即码位从 U+D800 到 U+DBFF）</param>
        /// <param name="lowSurrogate">低代理项码位（即码位从 U+DC00 到 U+DFFF）</param>
        /// <returns> 高代理项码位和低代理项码位参数表示的 21 位 Unicode 码位</returns>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate)
        {
            return char.ConvertToUtf32(highSurrogate, lowSurrogate);
        }
    }
}