namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ����ڴ�д��ĸ���
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsUpper(this char c)
        {
            return char.IsUpper(c);
        }
    }
}