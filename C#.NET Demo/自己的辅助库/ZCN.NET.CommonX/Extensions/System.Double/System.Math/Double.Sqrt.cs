using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�����ֵ�ƽ������
        /// ��������ֵ�������d ����ƽ��������System.Double.NaN ���� System.Double.NaN��
        /// System.Double.NaN ����System.Double.PositiveInfinity
        /// </summary>
        /// <param name="d">��չ��������</param>
        /// <returns></returns>
        public static double Sqrt(this double d)
        {
            return Math.Sqrt(d);
        }
    }
}