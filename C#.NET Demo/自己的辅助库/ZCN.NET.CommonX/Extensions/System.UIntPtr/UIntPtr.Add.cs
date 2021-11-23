using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static UIntPtr Add(this UIntPtr pointer, Int32 offset)
        {
            return UIntPtr.Add(pointer, offset);
        }
    }
}