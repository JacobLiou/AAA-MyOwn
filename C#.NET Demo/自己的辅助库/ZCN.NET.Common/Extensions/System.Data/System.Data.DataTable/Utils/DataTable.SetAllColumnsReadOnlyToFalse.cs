using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������� DataTable �����е��е� ReadOnly ����Ϊ false��
        /// ��� DataTable Ϊ null ������������Ϊ0�򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DataTable SetAllColumnsReadOnlyToFalse(this DataTable @this)
        {
            if(@this.IsNotNullAndEmpty())
            {
                foreach(DataColumn column in @this.Columns)
                {
                    column.ReadOnly = false; //������Ϊ�ɱ༭״̬
                }
            }

            return @this;
        }

        /// <summary>
        /// �Զ�����չ���������� DataTable �����е��е� ReadOnly ����Ϊ true��
        /// ��� DataTable Ϊ null ������������Ϊ0�򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DataTable SetAllColumnsReadOnlyToTrue(this DataTable @this)
        {
            if (@this.IsNotNullAndEmpty())
            {
                foreach (DataColumn column in @this.Columns)
                {
                    column.ReadOnly = true; //������Ϊ���ɱ༭״̬
                }
            }

            return @this;
        }
    }
}