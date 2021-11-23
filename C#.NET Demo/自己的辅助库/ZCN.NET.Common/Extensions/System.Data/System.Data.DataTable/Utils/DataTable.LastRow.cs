using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������� DataTable �����һ�С�
        /// ��� DataTable Ϊ null ������������Ϊ0�򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DataRow LastRow(this DataTable @this)
        {
            if(@this.IsNotNullAndEmpty())
            {
                return @this.Rows[@this.Rows.Count - 1];
            }

            return null;
        }
    }
}