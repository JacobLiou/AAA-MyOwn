namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 System.String 类的新实例初始化为由重复指定次数的指定 Unicode 字符指示的值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="repeatCount">重复的次数</param>
        /// <returns></returns>
        public static string Repeat(this char @this, int repeatCount)
        {
            return new string(@this, repeatCount);
        }
    }
}