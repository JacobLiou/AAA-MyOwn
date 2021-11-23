using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从无符号指针的值中减去偏移量 
        /// </summary>
        /// <param name="pointer">扩展对象。要为其增加偏移量的无符号指针</param>
        /// <param name="offset">要增加的偏移量</param>
        /// <returns></returns>
        public static UIntPtr Subtract(this UIntPtr pointer,Int32 offset)
        {
            return UIntPtr.Subtract(pointer,offset);
        }
    }
}