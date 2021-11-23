namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：通过计算每个字符串中相应 System.Char 对象的数值来比较两个指定的 System.string 对象
        /// </summary>
        /// <param name="strA">要比较的第一个字符串</param>
        /// <param name="strB">要比较的第二个字符串</param>
        /// <returns>
        ///    值条件小于零表示 strA 小于 strB。等于零表示 strA 与 strB 相等。大于零表示 strA 大于 strB
        /// </returns>
        public static int CompareOrdinal(this string strA, string strB)
        {
            return string.CompareOrdinal(strA, strB);
        }

        /// <summary>
        ///   通过计算两个指定的 System.string 对象的每个子字符串中相应 System.Char 对象的数值比较子字符串
        /// </summary>
        /// <param name="strA">要在比较中使用的第一个字符串</param>
        /// <param name="indexA"> strA 中子字符串的起始索引</param>
        /// <param name="strB">要在比较中使用的第二个字符串</param>
        /// <param name="indexB">strB 中子字符串的起始索引</param>
        /// <param name="length">要比较的子字符串中字符的最大数量</param>
        /// <returns>
        ///   一个 32 位带符号整数，指示两个比较数之间的词法关系。
        ///  值条件小于零表示 strA 中的子字符串小于 strB 中的子字符串。
        ///          零子字符串相等，或者 length 为零。
        ///          大于零 strA 中的子字符串大于 strB 中的子字符串
        /// </returns>
        public static int CompareOrdinal(this string strA, int indexA, string strB, int indexB, int length)
        {
            return string.CompareOrdinal(strA, indexA, strB, indexB, length);
        }
    }
}