using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数组中的字节数
        /// </summary>
        /// <param name="array">一个数组</param>
        /// <returns></returns>
        public static int ByteLength(this Array array)
        {
            return Buffer.ByteLength(array);
        }
    }
}