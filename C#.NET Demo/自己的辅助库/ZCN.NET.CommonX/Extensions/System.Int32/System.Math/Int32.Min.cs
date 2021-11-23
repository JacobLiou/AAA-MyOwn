using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������� 32 λ�з��ŵ������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� 32 λ�з��ŵ������еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� 32 λ�з��ŵ������еĵڶ���</param>
        /// <returns></returns>
        public static int Min(this Int32 value1, Int32 value2)
        {
            return Math.Min(value1,value2);
        }

        /// <summary>
        ///  �Զ�����չ�������������� 32 λ�޷��ŵ������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� 32 λ�޷��ŵ������еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� 32 λ�޷��ŵ������еĵڶ���</param>
        /// <returns></returns>
        public static uint Min(this UInt32 value1,UInt32 value2)
        {
            return Math.Min(value1,value2);
        }
    }
}