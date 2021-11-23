using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将数组的大小更改为指定的新大小
        /// </summary>
        /// <param name="this">扩展对象。要调整大小的一维数组，该数组从零开始；如果为 null 则新建具有指定大小的数组</param>
        /// <param name="newSize">新数组的大小</param>
        /// <returns></returns>
        public static byte[] Resize(this byte[] @this, int newSize)
        {
            Array.Resize(ref @this, newSize);
            return @this;
        }
    }
}