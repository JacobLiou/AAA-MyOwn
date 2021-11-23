namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的 Unicode 字符分类是字母还是十进制数字
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static bool IsLetterOrDigit(this char c)
        {
            return char.IsLetterOrDigit(c);
        }
    }
}