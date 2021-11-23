using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������(����������ȡż)��С��ֵ���뵽��ӽ�������ֵ��
        ///  ��� decimal ��ֵ��С���������ô������������м䣬����һ������Ϊż������һ������Ϊ�������򷵻�ż��
        ///  (10.4 ���� 10��10.5 ���� 10��10.6 ���� 11)��
        ///  ��ע�⣬�˷������� System.decimal����������������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns>��ӽ����� d ������</returns>
        public static decimal Round(this decimal d)
        {
            return Math.Round(d);
        }

        /// <summary>
        ///  �Զ�����չ������(����������ȡż)��С��ֵ��ָ����С��λ������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="decimals">����ֵ�е�С��λ��</param>
        /// <returns>��С�����ֵ��� decimals ��ֵ����ӽ�������</returns>
        public static decimal Round(this decimal d, int decimals)
        {
            return Math.Round(d, decimals);
        }

        /// <summary>
        ///  �Զ�����չ������(����������ȡż)��С��ֵ���뵽��ӽ���������
        ///  ���� MidpointRounding��ָ����һ��ֵ���ô������������м�ʱ����������ֵ
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="mode">����������֮��ʱ�������Ĺ淶</param>
        /// <returns>��ӽ� decimal ��ֵ����������� decimal ��ֵ���������ֵ���ֵ������������һ��Ϊż������һ��Ϊ������
        /// �� mode ȷ���������������е���һ��</returns>
        public static decimal Round(this decimal d, MidpointRounding mode)
        {
            return Math.Round(d, mode);
        }

        /// <summary>
        ///  �Զ�����չ������(����������ȡż)��С��ֵ��ָ����С��λ�����롣
        ///  ���� MidpointRounding��ָ����һ��ֵ���ô������������м�ʱ����������ֵ
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="decimals">����ֵ�е�С��λ��</param>
        /// <param name="mode">����������֮��ʱ�������Ĺ淶</param>
        /// <returns>��ӽ� decimal ֵ�� decimals λС�������֡���� decimalֵ ��С������С�� decimals���򷵻ص� d ���ֲ���</returns>
        public static decimal Round(this decimal d, int decimals, MidpointRounding mode)
        {
            return Math.Round(d, decimals, mode);
        }

        /// <summary>
        /// �Զ�����չ������(�������й�ʽ��������)��С��ֵ��ָ����С��λ������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="decimals">����ֵ�е�С��λ��</param>
        /// <returns>��С�����ֵ��� decimals ��ֵ����ӽ�������</returns>
        public static decimal Round2(this decimal d,int decimals)
        {
            return Math.Round(d,decimals,MidpointRounding.AwayFromZero);
        }
    }
}