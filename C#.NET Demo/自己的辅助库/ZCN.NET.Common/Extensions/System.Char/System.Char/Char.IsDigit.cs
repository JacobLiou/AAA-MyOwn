namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ�����ʮ�����������
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsDigit(this char c)
        {
            return char.IsDigit(c);
        }
    }
}