namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���� Unicode �ַ��Ƿ������������
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static bool IsNumber(this char c)
        {
            return char.IsNumber(c);
        }
    }
}