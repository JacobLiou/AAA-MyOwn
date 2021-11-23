namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从数组start开始到指定长度复制一份
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="start">数组的起始位置</param>
        /// <param name="count">指定长度</param>
        /// <returns></returns>
        static public T[] Sub<T>(this T[] array, int start, int count)
        {
            T[] val = new T[count];
            for (var i = 0; i < count; i++)
            {
                val[i] = array[start + i];
            }

            return val;
        }
    }
}