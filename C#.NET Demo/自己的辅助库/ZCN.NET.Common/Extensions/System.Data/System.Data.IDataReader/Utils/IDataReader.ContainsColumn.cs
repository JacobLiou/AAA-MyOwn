using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж� IDataReader ���������Ƿ����ָ���е�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="columnIndex">ָ���е�����</param>
        /// <returns></returns>
        public static bool ContainsColumn(this IDataReader @this, int columnIndex)
        {
            try
            {
                return @this.FieldCount > columnIndex;
            }
            catch
            {
                try
                {
                    return @this[columnIndex] != null;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        ///  �Զ�����չ�������ж� IDataReader ���������Ƿ����ָ����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static bool ContainsColumn(this IDataReader @this, string columnName)
        {
            try
            {
                return @this.GetOrdinal(columnName) != -1;
            }
            catch
            {
                try
                {
                    return @this[columnName] != null;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}