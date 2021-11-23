using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region Max

        /// <summary>
        /// �Զ�����չ�������������� 8 λ�޷��������нϴ��һ��
        /// </summary>
        /// <param name="val1">Ҫ�Ƚϵ����� 8 λ�޷��������еĵ�һ��</param>
        /// <param name="val2">Ҫ�Ƚϵ����� 8 λ�޷��������еĵڶ���</param>
        /// <returns></returns>
        public static Byte Max(this Byte val1, Byte val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// �Զ�����չ�������������� 8 λ�з��������нϴ��һ��
        /// </summary>
        /// <param name="val1">Ҫ�Ƚϵ����� 8 λ�з��������еĵ�һ��</param>
        /// <param name="val2">Ҫ�Ƚϵ����� 8 λ�з��������еĵڶ���</param>
        /// <returns></returns>
        public static SByte Max(this SByte val1, SByte val2)
        {
            return Math.Max(val1, val2);
        }

        #endregion

        #region Min
        /// <summary>
        /// �Զ�����չ�������������� 8 λ�޷��������н�С��һ��
        /// </summary>
        /// <param name="val1">Ҫ�Ƚϵ����� 8 λ�޷��������еĵ�һ��</param>
        /// <param name="val2">Ҫ�Ƚϵ����� 8 λ�޷��������еĵڶ���</param>
        /// <returns></returns>
        public static Byte Min(this Byte val1, Byte val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// �Զ�����չ�������������� 8 λ�з��������н�С��һ��
        /// </summary>
        /// <param name="val1">Ҫ�Ƚϵ����� 8 λ�з��������еĵ�һ��</param>
        /// <param name="val2">Ҫ�Ƚϵ����� 8 λ�з��������еĵڶ���</param>
        /// <returns></returns>
        public static SByte Min(this SByte val1, SByte val2)
        {
            return Math.Min(val1, val2);
        }
        #endregion

        /// <summary>
        ///  �Զ�����չ���������� 8 λ�з��������ľ���ֵ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>����ֵ</returns>
        public static SByte Abs(this SByte value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        ///  �Զ�����չ����������һ��ֵ����ֵ��ʾ 8 λ�з��������ķ���
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>һ��ָʾ value �ķ��ŵ����֣����±���ʾ������ֵ����-1value С���㡣0value �����㡣1value ������</returns>
        public static int Sign(this sbyte value)
        {
            return Math.Sign(value);
        }
    }
}