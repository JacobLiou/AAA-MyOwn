namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的 Unicode 字符是否属于控制字符类别
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }
    }
}