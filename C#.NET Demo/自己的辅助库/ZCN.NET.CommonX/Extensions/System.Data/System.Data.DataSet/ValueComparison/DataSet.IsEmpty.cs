using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断 DataSet 是否为 null 或者 Tables 数量等于0
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this DataSet @this)
        {
            return @this == null || @this.Tables.Count == 0;
        }

        /// <summary>
        ///  自定义扩展方法：判断 DataSet 是否不为 null 且 Tables 数量大于0。
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty(this DataSet @this)
        {
            return @this != null && @this.Tables.Count > 0;
        }
    }
}