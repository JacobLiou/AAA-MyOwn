using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷�������������ת��Ϊ���� Base64 ���ֱ���ĵ�Ч�ַ�����ʾ��ʽ
        /// </summary>
        /// <param name="inArray">һ�� 8 λ�޷�����������</param>
        /// <returns> inArray �����ݵ��ַ�����ʾ��ʽ���� Base64 ��ʾ</returns>
        public static string ToBase64String(this byte[] inArray)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray);
        }

        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷�������������ת��Ϊ���� Base64 ���ֱ���ĵ�Ч�ַ�����ʾ��ʽ������ָ���Ƿ��ڷ���ֵ�в�����з�
        /// </summary>
        /// <param name="inArray">һ�� 8 λ�޷�����������</param>
        /// <param name="options">���ÿ 76 ���ַ�����һ�����з�����ʹ�� System.Base64FormattingOptions.InsertLineBreaks��
        /// �����������з�����ʹ��System.Base64FormattingOptions.None</param>
        /// <returns> inArray �����ݵ��ַ�����ʾ��ʽ���� Base64 ��ʾ</returns>
        public static string ToBase64String(this byte[] inArray, Base64FormattingOptions options)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray, options);
        }

        /// <summary>
        /// �Զ�����չ������ �� 8 λ�޷�������������Ӽ�ת��Ϊ���� Base64 ���ֱ���ĵ�Ч�ַ�����ʾ��ʽ��
        /// �������Ӽ�ָ��Ϊ���������е�ƫ������������Ҫת����Ԫ����
        /// </summary>
        /// <param name="inArray">һ�� 8 λ�޷�����������</param>
        /// <param name="offset">inArray �е�ƫ����</param>
        /// <param name="length">Ҫת���� inArray ��Ԫ����</param>
        /// <returns></returns>
        public static string ToBase64String(this byte[] inArray, int offset, int length)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray, offset, length);
        }

        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷�������������Ӽ�ת��Ϊ���� Base64 ���ֱ���ĵ�Ч�ַ�����ʾ��ʽ��
        /// ����ָ����Ϊ����������ƫ�������Ӽ���������Ҫת����Ԫ�����Լ��Ƿ��ڷ���ֵ�в�����з�
        /// </summary>
        /// <param name="inArray">һ�� 8 λ�޷�����������</param>
        /// <param name="offset">inArray �е�ƫ����</param>
        /// <param name="length">Ҫת���� inArray ��Ԫ����</param>
        /// <param name="options">���ÿ 76 ���ַ�����һ�����з�����ʹ�� System.Base64FormattingOptions.InsertLineBreaks��
        /// �����������з�����ʹ��System.Base64FormattingOptions.None</param>
        /// <returns></returns>
        public static string ToBase64String(this byte[] inArray, int offset, int length, Base64FormattingOptions options)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray, offset, length, options);
        }

#if NETSTANDARD2_1

        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷���������ָ����Χת��Ϊ���� Base64 ���ֱ���ĵ�Ч�ַ�����ʾ��ʽ
        /// </summary>
        /// <param name="bytes">һ�� 8 λ�޷�����������</param>
        /// <returns> inArray �����ݵ��ַ�����ʾ��ʽ���� Base64 ��ʾ</returns>
        public static string ToBase64String(this ReadOnlySpan<byte> bytes)
        {
            if (bytes == null)
                return null;

            return Convert.ToBase64String(bytes);
        }

#endif
    }
}