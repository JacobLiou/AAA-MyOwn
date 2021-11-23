using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回 DataTable 的第一行。
        /// 如果 DataTable 为 null 或者数据行数为0则返回 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static DataRow FirstRow(this DataTable @this)
        {
            if (@this.IsNotNullAndEmpty())
            {
                return @this.Rows[0];
            }

            return null;
        }
    }
}