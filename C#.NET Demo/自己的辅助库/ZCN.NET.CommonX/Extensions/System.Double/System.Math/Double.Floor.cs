using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������С�ڻ����ָ��˫���ȸ����������������
        /// ����С�ڻ���� ������ �����������
        /// ��� ������ ���� System.Double.NaN��System.Double.NegativeInfinity �� 
        /// System.Double.PositiveInfinity���򷵻ظ�ֵ
        /// </summary>
        /// <param name="d">��չ����˫���ȸ�����</param>
        /// <returns></returns>
        public static double Floor(this double d)
        {
            return Math.Floor(d);
        }
    }
}