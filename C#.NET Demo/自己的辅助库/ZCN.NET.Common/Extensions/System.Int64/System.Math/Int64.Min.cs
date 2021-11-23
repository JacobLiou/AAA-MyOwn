using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������� 64 λ�з��ŵ������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� 64 λ�з��ŵ������еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� 64 λ�з��ŵ������еĵڶ���</param>
        /// <returns></returns>
        public static Int64 Min(this Int64 value1, Int64 value2)
        {
            return Math.Min(value1,value2);
        }

        /// <summary>
        ///  �Զ�����չ�������������� 64 λ�޷��ŵ������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� 64 λ�޷��ŵ������еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� 64 λ�޷��ŵ������еĵڶ���</param>
        /// <returns></returns>
        public static UInt64 Min(this UInt64 value1,UInt64 value2)
        {
            return Math.Min(value1,value2);
        }
    }
}