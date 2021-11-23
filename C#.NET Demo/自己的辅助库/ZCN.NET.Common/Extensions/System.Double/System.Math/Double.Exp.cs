using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������� e ��ָ�����ݡ�
        /// �������� e �� d ���ݡ���� d ���� System.Double.NaN �� System.Double.PositiveInfinity���򷵻ظ�ֵ��
        /// ��� d ���� System.Double.NegativeInfinity���򷵻� 0
        /// </summary>
        /// <param name="d">��չ����ָ���ݵ�����</param>
        /// <returns></returns>
        public static double Exp(this double d)
        {
            return Math.Exp(d);
        }
    }
}