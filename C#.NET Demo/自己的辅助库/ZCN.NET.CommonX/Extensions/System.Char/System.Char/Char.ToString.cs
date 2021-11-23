namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将字符穿转为字符串
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static string ToString2(this char c)
        {
            return char.ToString(c);
        }
    }
}