using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� IDataReader ����ת��ΪΪ DataTable
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DataTable ToDataTable(this IDataReader @this)
        {
            var dt = new DataTable();
            dt.Load(@this);

            return dt;
        }
    }
}