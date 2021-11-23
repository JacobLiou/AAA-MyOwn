namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的字符是否具有代理项码位
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsSurrogate(this char c)
        {
            return char.IsSurrogate(c);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定的 System.char 对象是否为高代理项
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定的 System.char 对象是否为低代理项
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }
    }
}