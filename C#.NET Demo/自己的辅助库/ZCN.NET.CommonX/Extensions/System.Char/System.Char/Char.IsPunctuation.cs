namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ����ڱ��������
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsPunctuation(this char c)
        {
            return char.IsPunctuation(c);
        }
    }
}