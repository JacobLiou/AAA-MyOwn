using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ֽ��������ʽ����ָ���� 64 λ�з�������ֵ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns></returns>
        public static byte[] GetBytes(this Int64 value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}