namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ�������ĸ
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsLetter(this char c)
        {
            return char.IsLetter(c);
        }
    }
}