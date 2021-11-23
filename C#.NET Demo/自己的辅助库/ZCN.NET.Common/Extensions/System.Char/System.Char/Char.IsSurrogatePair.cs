namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断两个指定的 System.Char 对象是否形成代理项对
        /// </summary>
        /// <param name="highSurrogate">要作为代理项对的高代理项进行计算的字符</param>
        /// <param name="lowSurrogate"> 要作为代理项对的低代理项进行计算的字符</param>
        /// <returns></returns>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate)
        {
            return char.IsSurrogatePair(highSurrogate, lowSurrogate);
        }
    }
}