using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч���ַ�����
        /// ����true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidStringValue(this object value)
        {
            return true;
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ������(һ����ָ��IDataReader��DataTable��DataRow��HashTable�ȼ����л�ȡ���л�����Ļ�����������)��ֵ�Ƿ�����Ч�Ĵ��ı����͵��ַ�����
        /// ����true
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidStringClob(this string value)
        {
            if (value.IsNullOrDBNull())
                return false;

            if (value.Equals("string", StringComparison.OrdinalIgnoreCase))
                return true;

            return Type.GetType(value) == typeof(string);
        }
    }
}