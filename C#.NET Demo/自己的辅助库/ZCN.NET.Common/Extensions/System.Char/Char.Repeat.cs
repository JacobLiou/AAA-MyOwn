namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� System.String �����ʵ����ʼ��Ϊ���ظ�ָ��������ָ�� Unicode �ַ�ָʾ��ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="repeatCount">�ظ��Ĵ���</param>
        /// <returns></returns>
        public static string Repeat(this char @this, int repeatCount)
        {
            return new string(@this, repeatCount);
        }
    }
}