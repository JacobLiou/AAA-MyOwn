using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ���ֽ��������ʽ����ָ���� 32 λ�з�������ֵ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns></returns>
        public static byte[] GetBytes(this Int32 value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}