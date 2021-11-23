using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  将源集合从指定位置开始到指定位置结束的元素复制到目标集合中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">源集合</param>
        /// <param name="destCollection">目标集合</param>
        /// <param name="startIndex">起始位置(从0开始)</param>
        /// <param name="count">需要复制的总记录数</param>
        /// <returns></returns>
        public static void CopyTo<T>(this List<T> @this, List<T> destCollection, int startIndex, int count)
        {
            int length = @this.Count;
            if (startIndex < length)
            {
                count = count > length ? length : count;

                for (int i = startIndex; i < count; i++)
                {
                    destCollection.Add(@this[i]);
                }
            }
        }
    }
}