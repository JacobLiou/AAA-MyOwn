using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定数目的字节从起始于特定偏移量的源数组复制到起始于特定偏移量的目标数组
        /// </summary>
        /// <param name="src">源缓冲区</param>
        /// <param name="srcOffset">源缓冲区中从零开始的字节偏移量</param>
        /// <param name="dst">目标缓冲区</param>
        /// <param name="dstOffset">目标缓冲区中从零开始的字节偏移量</param>
        /// <param name="count">要复制的字节数</param>
        public static void BlockCopy(this Array src, int srcOffset, Array dst, int dstOffset, int count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }
    }
}