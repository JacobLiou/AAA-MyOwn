using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定值分配给指定数组中特定位置处的字节
        /// </summary>
        /// <param name="array">一个数组</param>
        /// <param name="index">数组中的位置</param>
        /// <param name="value">要分配的值</param>
        public static void SetByte(this Array array,int index,byte value)
        {
            Buffer.SetByte(array,index,value);
        }
    }
}