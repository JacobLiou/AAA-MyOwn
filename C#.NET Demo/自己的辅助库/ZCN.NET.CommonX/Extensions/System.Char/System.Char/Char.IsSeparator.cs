namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ����ڷָ������
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsSeparator(this char c)
        {
            return char.IsSeparator(c);
        }
    }
}