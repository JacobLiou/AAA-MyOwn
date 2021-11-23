using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������� 16 λ�з��ŵ������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� 16 λ�з��ŵ������еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� 16 λ�з��ŵ������еĵڶ���</param>
        /// <returns></returns>
        public static Int16 Min(this Int16 value1, Int16 value2)
        {
            return Math.Min(value1,value2);
        }

        /// <summary>
        ///  �Զ�����չ�������������� 16 λ�޷��ŵ������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� 16 λ�޷��ŵ������еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� 16 λ�޷��ŵ������еĵڶ���</param>
        /// <returns></returns>
        public static UInt16 Min(this UInt16 value1,UInt16 value2)
        {
            return Math.Min(value1,value2);
        }
    }
}