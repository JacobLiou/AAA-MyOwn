namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч�� char ����ֵ��
        ///  �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidCharValue(this object value)
        {
            return char.TryParse(value?.ToString(), out char result);
        }

        /// <summary>
        ///  �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч�� char ����ֵ��
        ///  �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidCharValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return char.TryParse(value.ToString(), out char result);
        }
    }
}