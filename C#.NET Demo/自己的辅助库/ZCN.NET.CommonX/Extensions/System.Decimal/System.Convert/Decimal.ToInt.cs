using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 16 λ�з���������
        ///  ������� С�� <see cref="F:System.Int16.MinValue" /> ����� <see cref="F:System.Int16.MaxValue" />�򷵻� default(Int16)��
        /// </summary>
        /// <param name="value">��չ���� С�� <see cref="F:System.Int16.MinValue" /> ����� <see cref="F:System.Int16.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 16 λ�з�������</returns>
        public static short ToShort(this decimal value)
        {
            if (value < Int16.MinValue || value > Int16.MaxValue)
                return default(Int16);

            return Decimal.ToInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 16 λ�޷�������
        ///  ������� С�� <see cref="F:System.UInt16.MinValue" /> ����� <see cref="F:System.UInt16.MaxValue" />���򷵻� default(UInt16)��
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.UInt16.MinValue" /> ����� <see cref="F:System.UInt16.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 16 λ�޷�������</returns>
        public static ushort ToUShort(this decimal value)
        {
            if (value < UInt16.MinValue || value > UInt16.MaxValue)
                return default(UInt16);

            return Decimal.ToUInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 16 λ�з���������
        ///  ������� С�� <see cref="F:System.Int16.MinValue" /> ����� <see cref="F:System.Int16.MaxValue" />�򷵻� default(Int16)��
        /// </summary>
        /// <param name="value">��չ���� С�� <see cref="F:System.Int16.MinValue" /> ����� <see cref="F:System.Int16.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 16 λ�з�������</returns>
        public static int ToInt16(this decimal value)
        {
            if (value < Int16.MinValue || value > Int16.MaxValue)
                return default(Int16);

            return Decimal.ToInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 16 λ�޷�������
        ///  ������� С�� <see cref="F:System.UInt16.MinValue" /> ����� <see cref="F:System.UInt16.MaxValue" />���򷵻� default(UInt16)��
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.UInt16.MinValue" /> ����� <see cref="F:System.UInt16.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 16 λ�޷�������</returns>
        public static uint ToUInt16(this decimal value)
        {
            if (value < UInt16.MinValue || value > UInt16.MaxValue)
                return default(UInt16);

            return Decimal.ToUInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 32 λ�з���������
        ///  �������С�� Int32.MinValue ����� Int32.MaxValue���򷵻� default(Int32)
        /// </summary>
        /// <returns> ��Ч��decimalֵ�� 32 λ�з�������</returns>
        public static int ToInt32(this decimal value)
        {
            if (value < Int32.MinValue || value > Int32.MaxValue)
                return default(Int32); //0

            return Decimal.ToInt32(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 32 λ�޷�������
        ///  �������С�� UInt32.MinValue ����� UInt32.MaxValue���򷵻� default(UInt32)ֵ
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.UInt32.MinValue" /> ����� <see cref="F:System.UInt32.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 32 λ�޷�������</returns>
        public static uint ToUInt32(this decimal value)
        {
            if (value < UInt32.MinValue || value > UInt32.MaxValue)
                return default(UInt32); //0

            return Decimal.ToUInt32(value);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 64 λ�з���������
        ///  �������С�� <see cref="F:System.Int64.MinValue" /> ����� <see cref="F:System.Int64.MaxValue" />���򷵻� default(Int64)
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.Int64.MinValue" /> ����� <see cref="F:System.Int64.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 64 λ�з�������</returns>
        public static long ToInt64(this decimal value)
        {
            if (value < Int64.MinValue || value > Int64.MaxValue)
                return default(Int64); //0

           return Decimal.ToInt64(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 64 λ�޷�������
        ///  �������С�� <see cref="F:System.UInt64.MinValue" /> ����� <see cref="F:System.UInt64.MaxValue" />���򷵻� default(UInt64)
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.UInt64.MinValue" /> ����� <see cref="F:System.UInt64.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 64 λ�޷�������</returns>
        public static long ToUInt64(this decimal value)
        {
            if (value < UInt64.MinValue || value > UInt64.MaxValue)
                return default(Int64); //0

            return Decimal.ToInt64(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 64 λ�з�������
        ///  �������С�� <see cref="F:System.Int64.MinValue" /> ����� <see cref="F:System.Int64.MaxValue" />���򷵻� default(Int64)
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.Int64.MinValue" /> ����� <see cref="F:System.Int64.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 64 λ�з�������</returns>
        public static long ToLong2(this decimal value)
        {
            if (value < Int64.MinValue || value > Int64.MaxValue)
                return default(Int64); //0

           return Decimal.ToInt64(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� System.decimal ֵת��Ϊ��Ч�� 64 λ�޷�������
        ///  �������С�� <see cref="F:System.UInt64.MinValue" /> ����� <see cref="F:System.UInt64.MaxValue" />���򷵻� default(UInt64)
        /// </summary>
        /// <param name="value">��չ����С�� <see cref="F:System.UInt64.MinValue" /> ����� <see cref="F:System.UInt64.MaxValue" /></param>
        /// <returns> ��Ч��decimalֵ�� 64 λ�޷�������</returns>
        public static ulong ToULong(this decimal value)
        {
            if (value < UInt64.MinValue || value > UInt64.MaxValue)
                return default(UInt64); //0

            return Decimal.ToUInt64(Decimal.Round(value, 0));
        }
    }
}