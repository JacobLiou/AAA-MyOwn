using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断 DataTable 是否为 null 或者数据行数量等于0
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this DataTable @this)
        {
            return @this == null || @this.Rows.Count == 0;
        }

        /// <summary>
        ///  自定义扩展方法：判断 DataTable 是否不为 null 且数据行数量大于0。
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty(this DataTable @this)
        {
            return @this != null && @this.Rows.Count > 0;
        }
    }
}