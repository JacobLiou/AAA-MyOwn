using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ����˫���ȸ�������ֵת��Ϊ��Ч�ĵ����ȸ�������
        ///  ʹ�á�����Ϊ��ӽ������֡������ <paramref name="value" /> �������롣 ���磬������Ϊ��λС��ʱ��ֵ 2.345 ��� 2.34����ֵ 2.355 ��� 2.36��
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns> ��Ч��decimalֵ�ĵ����ȸ�����</returns>
        public static Single ToSingle(this decimal value)
        {
            return (float)value;
        }

        /// <summary>
        ///  �Զ�����չ��������ָ����˫���ȸ�������ֵת��Ϊ��Ч�ĵ����ȸ�������
        ///  ʹ�á�����Ϊ��ӽ������֡������ <paramref name="value" /> �������롣 ���磬������Ϊ��λС��ʱ��ֵ 2.345 ��� 2.34����ֵ 2.355 ��� 2.36��
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns> ��Ч��decimalֵ�ĵ����ȸ�����</returns>
        public static float ToFloat(this decimal value)
        {
            return (float)value;
        }
    }
}