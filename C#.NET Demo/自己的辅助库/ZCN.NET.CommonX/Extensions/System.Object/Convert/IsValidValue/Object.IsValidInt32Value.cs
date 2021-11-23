namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��32λ�з��ŵ�����ֵ��
        ///  �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidInt32Value(this object value)
        {
            return int.TryParse(value?.ToString(), out int result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��32λ�з��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidInt32NullableValue(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return int.TryParse(value.ToString(), out int result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��32λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUInt32Value(this object value)
        {
            return uint.TryParse(value?.ToString(), out uint result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч��32λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUInt32NullableValue(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return uint.TryParse(value.ToString(), out uint result);
        }
    }
}