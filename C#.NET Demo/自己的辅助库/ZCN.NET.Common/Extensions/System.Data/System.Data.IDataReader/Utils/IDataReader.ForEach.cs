using System;
using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：循环 IDataReader 过程中执行指定的方法。返回源 IDataReader 对象
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="action">方法</param>
        /// <returns></returns>
        public static IDataReader ForEach(this IDataReader @this, Action<IDataReader> action)
        {
            while(@this.Read())
            {
                action(@this);
            }

            return @this;
        }
    }
}