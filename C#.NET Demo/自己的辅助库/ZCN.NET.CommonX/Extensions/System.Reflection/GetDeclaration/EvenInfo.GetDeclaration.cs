using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取事件的声明信息。包含可见性(public、protected、internal、private、protected internal)，名称。
        ///  返回 null
        /// </summary>
        /// <param name="this">扩展对象。事件信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this EventInfo @this)
        {
            return null;
        }
    }
}