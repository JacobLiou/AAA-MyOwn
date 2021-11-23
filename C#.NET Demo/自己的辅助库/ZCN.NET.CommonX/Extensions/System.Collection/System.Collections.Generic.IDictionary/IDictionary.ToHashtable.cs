using System.Collections;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将字典转换为 Hashtable 对象
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Hashtable ToHashtable(this IDictionary @this)
        {
            return new Hashtable(@this);
        }
    }
}