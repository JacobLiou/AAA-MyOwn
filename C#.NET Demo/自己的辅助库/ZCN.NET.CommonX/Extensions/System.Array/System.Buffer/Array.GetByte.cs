using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：在指定数组中检索指定位置处的字节
        /// </summary>
        /// <param name="array">一个数组</param>
        /// <param name="index">数组中的位置</param>
        /// <returns></returns>
        public static byte GetByte(this Array array, int index)
        {
            return Buffer.GetByte(array, index);
        }
    }
}