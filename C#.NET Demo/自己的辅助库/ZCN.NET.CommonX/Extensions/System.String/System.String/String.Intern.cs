using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ����ϵͳ��ָ�� System.String ������
        /// </summary>
        /// <param name="str">Ҫ���ݴ�����������ַ���</param>
        /// <returns>����ݴ��� str���򷵻�ϵͳ��������ã����򷵻ض�ֵΪ str ���ַ�����������</returns>
        public static string Intern(this String str)
        {
            return String.Intern(str);
        }
    }
}