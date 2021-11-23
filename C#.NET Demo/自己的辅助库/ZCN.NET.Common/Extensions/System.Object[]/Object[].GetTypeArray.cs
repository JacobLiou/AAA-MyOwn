using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///     自定义扩展方法：获取指定数组中对象的类型
        /// </summary>
        /// <param name="args">要确定其类型的对象数组</param>
        /// <returns>表示 args 中相应元素的类型的 System.Type 对象数组</returns>
        public static Type[] GetTypeArray(this object[] args)
        {
            return Type.GetTypeArray(args);
        }
    }
}