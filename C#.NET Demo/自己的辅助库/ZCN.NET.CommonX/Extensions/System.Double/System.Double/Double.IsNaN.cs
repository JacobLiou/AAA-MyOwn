namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ�����ֵļ������Ƿ�Ϊ�������� (System.Double.NaN) ��ֵ
        /// </summary>
        /// <param name="d">��չ����˫���ȸ�����</param>
        /// <returns>������Ϊ System.Double.NaN����Ϊ true������Ϊ false</returns>
        public static bool IsNaN(this double d)
        {
            return double.IsNaN(d);
        }
    }
}