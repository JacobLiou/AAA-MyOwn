using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ���Ƕȵ�˫������ֵ��
        /// ��� value ���� System.Double.NegativeInfinity����˷������� -1��
        /// ���ֵ���� System.Double.PositiveInfinity����˷������� 1��
        /// ��� value ���� System.Double.NaN����˷������� System.Double.NaN
        /// </summary>
        /// <param name="value">��չ�����Ի���Ϊ��λ�Ľ�</param>
        /// <returns></returns>
        public static double Tanh(this double value)
        {
            return Math.Tanh(value);
        }
    }
}