namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ�����Сд��ĸ���
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsLower(this char c)
        {
            return char.IsLower(c);
        }
    }
}