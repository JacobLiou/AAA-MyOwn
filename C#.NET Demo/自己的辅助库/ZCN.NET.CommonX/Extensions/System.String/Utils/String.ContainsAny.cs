using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��ַ������Ƿ�����ַ������е���һԪ��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="values">�ַ�����</param>
        /// <returns>��������һ������true�����򷵻�false</returns>
        public static bool ContainsAny(this string @this, params string[] values)
        {
            foreach(string value in values)
            {
                if(@this.IndexOf(value, StringComparison.Ordinal) != -1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///  �Զ�����չ�������ж��ַ������Ƿ�����ַ������е���һԪ��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="comparisonType">ָ�����������ö��ֵ֮һ</param>
        /// <param name="values">�ַ�����</param>
        /// <returns>��������һ������true�����򷵻�false</returns>
        public static bool ContainsAny(this string @this, StringComparison comparisonType, params string[] values)
        {
            foreach(string value in values)
            {
                if(@this.IndexOf(value, comparisonType) != -1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}