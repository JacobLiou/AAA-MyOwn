using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ�������Ǽ���Ϊ����������������
        /// ���������Ϊ System.float.PositiveInfinity �� System.float.NegativeInfinity����Ϊtrue������Ϊ false
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsInfinity(this float d)
        {
            return float.IsInfinity(d);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ�������Ǽ����Ƿ�Ϊ�������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsNegativeInfinity(this float d)
        {
            return float.IsNegativeInfinity(d);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ�������Ǽ����Ƿ�Ϊ�������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsPositiveInfinity(this float d)
        {
            return float.IsPositiveInfinity(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�Ϊ����ֵ���㡢����������������
        /// �����ֵΪ����ֵ���㡢������������������Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsFinite(this float d)
        {
            return float.IsFinite(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�Ϊ��ֵ��
        /// �����ֵΪ��ֵ����Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsNegative(this float d)
        {
            return float.IsNegative(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�������
        /// �����ֵ����������Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsSubnormal(this float d)
        {
            return float.IsSubnormal(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�������
        /// �����ֵ��������Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsNormal(this float d)
        {
            return float.IsNormal(d);
        }
    }
}