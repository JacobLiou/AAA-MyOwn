namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч�� double ˫���ȸ�������ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidDoubleValue(this object value)
        {
            return double.TryParse(value?.ToString(), out double result);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч�� double ˫���ȸ�������ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidDoubleValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return double.TryParse(value.ToString(),out double result);
        }
    }
}