namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��8λ�޷�������ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidByteValue(this object value)
        {
            return byte.TryParse(value?.ToString(),out byte result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��8λ�޷�������ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidByteValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return byte.TryParse(value.ToString(), out byte result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��8λ�з�������ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidSByteValue(this object value)
        {
            return sbyte.TryParse(value?.ToString(),out sbyte result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��8λ�з�������ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidSByteValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return sbyte.TryParse(value.ToString(), out sbyte result);
        }
    }
}