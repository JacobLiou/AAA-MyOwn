namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ�������Ǽ���Ϊ����������������
        /// ���������Ϊ System.Double.PositiveInfinity �� System.Double.NegativeInfinity����Ϊtrue������Ϊ false
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsInfinity(this double d)
        {
            return double.IsInfinity(d);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ�������Ǽ����Ƿ�Ϊ�������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsNegativeInfinity(this double d)
        {
            return double.IsNegativeInfinity(d);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ�������Ǽ����Ƿ�Ϊ�������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsPositiveInfinity(this double d)
        {
            return double.IsPositiveInfinity(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�Ϊ����ֵ���㡢����������������
        /// �����ֵΪ����ֵ���㡢������������������Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsFinite(this double d)
        {
            return double.IsFinite(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�Ϊ��ֵ��
        /// �����ֵΪ��ֵ����Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsNegative(this double d)
        {
            return double.IsNegative(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�������
        /// �����ֵ����������Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsSubnormal(this double d)
        {
            return double.IsSubnormal(d);
        }

        /// <summary>
        /// �Զ�����չ������ȷ��ָ��ֵ�Ƿ�������
        /// �����ֵ��������Ϊ true������Ϊ false��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns></returns>
        public static bool IsNormal(this double d)
        {
            return double.IsNormal(d);
        }
    }
}