namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ������ Unicode �ַ�ת��Ϊ˫���ȸ�����
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns>������ַ���ʾ���֣���Ϊ c ����ֵ������Ϊ -1.0</returns>
        public static double GetNumericValue(this char c)
        {
            return char.GetNumericValue(c);
        }
    }
}