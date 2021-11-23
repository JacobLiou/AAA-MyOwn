using System;
using System.Collections.Generic;
using System.Linq;
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ����Χ�ڵ����������С�
        /// ���磺@this Ϊ A��toCharacter Ϊ D���򷵻� A B C D �ļ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="toCharacter"></param>
        /// <returns></returns>
        public static IEnumerable<char> CreateRange(this char @this, char toCharacter)
        {
            bool reverseRequired = @this > toCharacter; //�Ƿ���Ҫ��ת���������չ�������Ŀ���ַ�

            char first = reverseRequired ? toCharacter : @this;
            char last = reverseRequired ? @this : toCharacter;

            IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }

            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ָ���� Unicode �ַ���ֵת��Ϊ��Ч�� 8 λ�з���������
        /// ����������� SByte.MaxValue ���򷵻� default(short)ֵ
        /// </summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 16 λ������������</returns>
        public static short ToSByte(this char value)
        {
            if (value > SByte.MaxValue)
                return default(short);

            return (sbyte)value;
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� Unicode �ַ���ֵת��Ϊ��Ч�� 16 λ�з���������
        /// ����������� Int16.MaxValue ���򷵻� default(short)ֵ
        /// </summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 16 λ������������</returns>
        public static short ToInt16(this char value)
        {
            if (value > Int16.MaxValue)
                return default(short);

            return (short)value;
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� Unicode �ַ���ֵת��Ϊ��Ч�� 16 λ�޷���������
        /// </summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 16 λ������������</returns>
        public static ushort ToUInt16(this char value)
        {
            return (ushort)value;
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� Unicode �ַ���ֵת��Ϊ��Ч�� 32 λ�з���������
        /// </summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 32 λ������������</returns>
        public static int ToInt32(this char value)
        {
            return (int)value; 
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� Unicode �ַ���ֵת��Ϊ��Ч�� 32 λ�޷���������
        /// </summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 32 λ�޷���������</returns>
        public static uint ToUInt32(this char value)
        {
            return (uint)value;
        }

        /// <summary>�Զ�����չ��������ָ���� Unicode �ַ���ֵת��Ϊ��Ч�� 64 λ�з���������</summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 64 λ������������</returns>
        public static long ToInt64(this char value)
        {
            return (long)value;
        }

        /// <summary>�Զ�����չ�������Զ�����չ��������ָ���� Unicode �ַ���ֵת��Ϊ��Ч�� 64 λ�з���������</summary>
        /// <param name="value">Ҫת���� Unicode �ַ���</param>
        /// <returns>һ���� <paramref name="value" /> ��Ч�� 64 λ������������</returns>
        public static ulong ToUInt64(this char value)
        {
            return (ulong)value;
        }

    }
}