using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ��ָ�� 64 λ�з�������ת����˫���ȸ�����
        /// </summary>
        /// <param name="value">��չ����Ҫת��������</param>
        /// <returns></returns>
        public static double Int64BitsToDouble(this Int64 value)
        {
            return BitConverter.Int64BitsToDouble(value);
        }
    }
}