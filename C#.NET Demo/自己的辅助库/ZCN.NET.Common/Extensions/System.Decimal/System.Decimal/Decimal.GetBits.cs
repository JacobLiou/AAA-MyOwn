using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� System.Decimal ��ָ��ʵ����ֵת��Ϊ���Ч�Ķ����Ʊ�ʾ��ʽ
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns>����decimalֵ�Ķ����Ʊ�ʾ��ʽ�����ĸ�Ԫ����ɵ� 32 λ�з�����������</returns>
        public static int[] GetBits(this decimal d)
        {
            return decimal.GetBits(d);
        }

#if NETSTANDARD2_1

        ///// <summary>
        /////  �Զ�����չ�������� System.Decimal ��ָ��ʵ����ֵת��Ϊ���Ч�Ķ����Ʊ�ʾ��ʽ
        ///// </summary>
        ///// <param name="d">��չ����</param>
        ///// <param name="destination">Ҫ���ڴ洢�����Ʊ�ʾ��ʽ�ķ�Χ</param>
        ///// <returns>����decimalֵ�Ķ����Ʊ�ʾ��ʽ�����ĸ�Ԫ����ɵ� 32 λ�з�����������</returns>
        //public static int GetBits(this decimal d, Span<int> destination)
        //{
        //    return decimal.GetBits(d, destination);
        //}

        ///// <summary>
        /////  �Զ�����չ���������Խ� Decimal ��ָ��ʵ����ֵת��Ϊ���Ч�Ķ����Ʊ�ʾ��ʽ
        ///// </summary>
        ///// <param name="d">��չ����</param>
        ///// <param name="destination">Ҫ���ڴ洢�����Ʊ�ʾ��ʽ�ķ�Χ</param>
        ///// <returns>����decimalֵ�Ķ����Ʊ�ʾ��ʽ�����ĸ�Ԫ����ɵ� 32 λ�з�����������</returns>
        //public static int TryGetBits(this decimal d, Span<int> destination)
        //{
        //    decimal.TryGetBits(d, destination, out int valuesWritten);

        //    return valuesWritten;
        //}

#endif

    }
}