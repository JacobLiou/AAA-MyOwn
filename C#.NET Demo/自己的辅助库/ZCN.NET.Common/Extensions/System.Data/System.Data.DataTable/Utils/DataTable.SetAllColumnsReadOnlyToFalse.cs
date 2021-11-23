using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：设置 DataTable 中所有的列的 ReadOnly 属性为 false。
        /// 如果 DataTable 为 null 或者数据行数为0则返回 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static DataTable SetAllColumnsReadOnlyToFalse(this DataTable @this)
        {
            if(@this.IsNotNullAndEmpty())
            {
                foreach(DataColumn column in @this.Columns)
                {
                    column.ReadOnly = false; //设置列为可编辑状态
                }
            }

            return @this;
        }

        /// <summary>
        /// 自定义扩展方法：设置 DataTable 中所有的列的 ReadOnly 属性为 true。
        /// 如果 DataTable 为 null 或者数据行数为0则返回 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static DataTable SetAllColumnsReadOnlyToTrue(this DataTable @this)
        {
            if (@this.IsNotNullAndEmpty())
            {
                foreach (DataColumn column in @this.Columns)
                {
                    column.ReadOnly = true; //设置列为不可编辑状态
                }
            }

            return @this;
        }
    }
}