using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 DataTable 排序，返回排序后的 DataTable
        /// </summary>
        /// <param name="dt">扩展对象</param>
        /// <param name="sortsFieldsAndDirection">排序字段与排序顺序</param>
        /// <returns></returns>
        public static DataTable Sort(this DataTable dt, params string[] sortsFieldsAndDirection)
        {
            if (dt.Rows.Count > 0)
            {
                string tmp = "";
                for (int i = 0; i < sortsFieldsAndDirection.Length; i++)
                {
                    tmp = tmp + sortsFieldsAndDirection[i] + ",";
                }

                DataView dv = dt.DefaultView;
                dv.Sort = tmp.TrimEnd(new char[]
                {
                    ','
                });

                return dv.ToTable();
            }

            return dt;
        }
    }
}