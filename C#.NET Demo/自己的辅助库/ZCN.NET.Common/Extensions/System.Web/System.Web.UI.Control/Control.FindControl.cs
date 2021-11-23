#if NETFRAMEWORK

using System.Web.UI;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：在当前的命名容器中搜索带指定 id 参数的服务器控件。
        ///  返回指定的控件，或为 null（如果指定的控件不存在的话）
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象，</param>
        /// <param name="id">控件的id</param>
        /// <returns>指定的控件，或为 null（如果指定的控件不存在的话）</returns>
        public static T FindControl<T>(this Control @this, string id) where T : class
        {
            return (@this.FindControl(id) as T);
        }
    }
}

#endif