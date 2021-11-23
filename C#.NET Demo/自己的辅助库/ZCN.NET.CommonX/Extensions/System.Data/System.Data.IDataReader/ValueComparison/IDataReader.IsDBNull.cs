using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж� IDataReader �������е��ֶ����Ƿ�Ϊ DBNull
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static bool IsDBNull(this IDataReader @this, string columnName)
        {
            return @this.IsDBNull(@this.GetOrdinal(columnName));
        }
    }
}