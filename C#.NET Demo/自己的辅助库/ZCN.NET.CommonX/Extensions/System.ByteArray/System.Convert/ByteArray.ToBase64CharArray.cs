using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷�������������Ӽ�ת��Ϊ�� Base64 ���ֱ���� Unicode �ַ�����ĵȼ��Ӽ���
        /// �������Ӽ�ָ��Ϊ�������������е�ƫ����������������Ҫת����Ԫ������
        /// �������Ϊnull���򷵻�0
        /// </summary>
        /// <param name="inArray">8 λ�޷�����������������</param>
        /// <param name="offsetIn">inArray �ڵ�һ��λ��</param>
        /// <param name="length">Ҫת���� inArray ��Ԫ����</param>
        /// <param name="outArray">Unicode �ַ����������</param>
        /// <param name="offsetOut">outArray �ڵ�һ��λ��</param>
        /// <returns>���� outArray �е��ֽ����� 32 λ�з�������</returns>
        public static int ToBase64CharArray(this byte[] inArray,
            int offsetIn,
            int length,
            char[] outArray,
            int offsetOut)
        {
            if (inArray == null)
                return 0;
            
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
        }

        /// <summary>
        /// �Զ�����չ������ �� 8 λ�޷�������������Ӽ�ת��Ϊ�� Base64 ���ֱ���� Unicode �ַ�����ĵȼ��Ӽ���
        /// ����ָ����Ϊ��������������ƫ�������Ӽ�������������Ҫת����Ԫ�����Լ��Ƿ�����������в�����з���
        /// �������Ϊnull���򷵻�0
        /// </summary>
        /// <param name="inArray">8 λ�޷�����������������</param>
        /// <param name="offsetIn">inArray �ڵ�һ��λ��</param>
        /// <param name="length">Ҫת���� inArray ��Ԫ����</param>
        /// <param name="outArray">Unicode �ַ����������</param>
        /// <param name="offsetOut">outArray �ڵ�һ��λ��</param>
        /// <param name="options">���ÿ 76 ���ַ�����һ�����з�����ʹ�� System.Base64FormattingOptions.InsertLineBreaks��
        /// �����������з�����ʹ��System.Base64FormattingOptions.None</param>
        /// <returns></returns>
        public static int ToBase64CharArray(this byte[] inArray,
            int offsetIn,
            int length,
            char[] outArray,
            int offsetOut,
            Base64FormattingOptions options)
        {
            if (inArray == null)
                return 0;

            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
        }
    }
}