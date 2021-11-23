using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������������ֵΪ����ָ�����ֵ��̵ĽǶȡ�
        /// ���ؽǶ� �ȣ��Ի���Ϊ��λ������ -�СܦȡܦУ��� tan(��) = y / x������ (x, y) �ǵѿ���ƽ���е�һ���㡣
        /// �뿴���棺��� (x, y) �ڵ� 1 ���ޣ��� 0 &lt; �� &lt; ��/2��
        /// ��� (x, y) �ڵ� 2 ���ޣ��� ��/2 &lt; �ȡܦС�
        /// ��� (x, y) �ڵ� 3 ���ޣ��� -�� &lt; �� &lt; -��/2��
        /// ��� (x, y) �ڵ� 4 ���ޣ��� -��/2 &lt; �� &lt; 0��
        /// 
        /// ����������޵ı߽��ϣ��򷵻�ֵ���£�
        /// ��� y Ϊ 0 ���� x ��Ϊ��ֵ����� = 0��
        /// ��� y Ϊ 0 ���� x Ϊ��ֵ���� �� = �С�
        /// ��� y Ϊ��ֵ���� x Ϊ 0���� �� = ��/2��
        /// ��� y ��ֵ���� x Ϊ 0����� = -��/2
        /// </summary>
        /// <param name="y">��չ���󡣵�� y ����</param>
        /// <param name="x">��� x ����</param>
        /// <returns></returns>
        public static double Atan2(this double y, double x)
        {
            return Math.Atan2(y, x);
        }
    }
}