using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：通过使用相应类型的默认相等比较器对序列的元素进行比较，以确定两个序列是否相等。
        ///  如果根据相应类型的默认相等比较器，两个源序列的长度相等，且其相应元素相等，则为 true；否则为 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="targetString">目标字符串</param>
        /// <returns></returns>
        public static bool IsSequenceEqual(this string @this,string targetString)
        {
            // Anagram:由颠倒字母顺序而构成的字[短语]
            return @this.OrderBy(c => c)
                        .SequenceEqual(targetString.OrderBy(c => c));
        }
    }
}