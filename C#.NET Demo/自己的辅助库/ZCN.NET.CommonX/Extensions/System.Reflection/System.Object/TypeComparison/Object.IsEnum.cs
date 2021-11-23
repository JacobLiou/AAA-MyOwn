
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：获取一个值，该值指示当前的 System.Type 是否表示枚举
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsEnum<T>(this T @this)
        {
            return @this.GetType().IsEnum;
        }
    }
}