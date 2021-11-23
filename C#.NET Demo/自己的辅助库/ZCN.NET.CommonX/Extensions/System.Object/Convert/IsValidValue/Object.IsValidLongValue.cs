namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��64λ�з��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidLongValue(this object value)
        {
            return long.TryParse(value?.ToString(), out long result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��64λ�з��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidLongValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return long.TryParse(value.ToString(),out long result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��64λ�޷��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidULongValue(this object value)
        {
            return ulong.TryParse(value?.ToString(),out ulong result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��64λ�޷��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidULongValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return ulong.TryParse(value.ToString(),out ulong result);
        }
    }
}