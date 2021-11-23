using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：循环指定次数，并执行方法
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="action">待执行的方法</param>
        /// <returns></returns>
        public static void ForEach(this Int16 @this,Action action)
        {
            for(int i = 0; i < @this; i++)
            {
                action();
            }
        }
    }
}