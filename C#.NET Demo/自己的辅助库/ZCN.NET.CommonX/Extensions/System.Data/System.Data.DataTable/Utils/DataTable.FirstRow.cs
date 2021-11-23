using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������� DataTable �ĵ�һ�С�
        /// ��� DataTable Ϊ null ������������Ϊ0�򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
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