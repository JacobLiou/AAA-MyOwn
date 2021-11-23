using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������(����������ȡż)��˫���ȸ���ֵ���뵽��ӽ�������ֵ��
        /// ��� double ��ֵ��С���������ô������������м䣬����һ������Ϊż������һ������Ϊ�������򷵻�ż��
        /// (10.4 ���� 10��10.5 ���� 10��10.6 ���� 11)��
        /// ��ע�⣬�˷������� System.Double����������������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns>��ӽ����� d ������</returns>
        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        /// <summary>
        /// �Զ�����չ������(����������ȡż)��˫���ȸ���ֵ��ָ����С��λ������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="decimals">����ֵ�е�С��λ��</param>
        /// <returns>��С�����ֵ��� decimals ��ֵ����ӽ�������</returns>
        public static double Round(this double d,int decimals)
        {
            return Math.Round(d,decimals);
        }

        /// <summary>
        ///  �Զ�����չ������(����������ȡż)��˫���ȸ���ֵ���뵽��ӽ���������
        ///  ���� MidpointRounding��ָ����һ��ֵ���ô������������м�ʱ����������ֵ
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="mode">����������֮��ʱ�������Ĺ淶</param>
        /// <returns>��ӽ� double ��ֵ����������� double ��ֵ���������ֵ���ֵ������������һ��Ϊż������һ��Ϊ������
        /// �� mode ȷ���������������е���һ��</returns>
        public static double Round(this double d,MidpointRounding mode)
        {
            return Math.Round(d,mode);
        }

        /// <summary>
        /// �Զ�����չ������(����������ȡż)��˫���ȸ���ֵ��ָ����С��λ�����롣
        /// ���� MidpointRounding��ָ����һ��ֵ���ô������������м�ʱ����������ֵ
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="decimals">����ֵ�е�С��λ��</param>
        /// <param name="mode">����������֮��ʱ�������Ĺ淶</param>
        /// <returns>��ӽ� double ֵ�� decimals λС�������֡���� doubleֵ ��С������С�� decimals���򷵻ص� d ���ֲ���</returns>
        public static double Round(this double d,int decimals,MidpointRounding mode)
        {
            return Math.Round(d,decimals,mode);
        }

        /// <summary>
        /// �Զ�����չ������(�������й�ʽ��������)��˫���ȸ���ֵ��ָ����С��λ������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <param name="decimals">����ֵ�е�С��λ��</param>
        /// <returns>��С�����ֵ��� decimals ��ֵ����ӽ�������</returns>
        public static double Round2(this double d,int decimals)
        {
            return Math.Round(d,decimals,MidpointRounding.AwayFromZero);
        }
    }
}