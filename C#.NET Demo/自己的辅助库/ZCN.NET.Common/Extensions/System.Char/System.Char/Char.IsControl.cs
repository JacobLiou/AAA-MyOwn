namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ����ڿ����ַ����
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }
    }
}