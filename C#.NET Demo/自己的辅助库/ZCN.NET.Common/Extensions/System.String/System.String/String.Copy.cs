using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ ����һ����ָ���� System.String ������ֵͬ�� System.String ����ʵ��
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns> ֵ�� str ��ͬ�����ַ���</returns>
        public static string Copy(this string str)
        {
            return String.Copy(str);
        }
    }
}