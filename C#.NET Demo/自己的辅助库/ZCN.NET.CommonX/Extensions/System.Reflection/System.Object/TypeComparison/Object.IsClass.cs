
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：获取一个值，通过该值指示 System.Type 是否是一个类；即，不是值类型或接口
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsClass<T>(this T @this)
        {
            return @this.GetType().IsClass;
        }
    }
}