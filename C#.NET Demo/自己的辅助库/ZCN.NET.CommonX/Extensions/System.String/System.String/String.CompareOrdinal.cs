namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ͨ������ÿ���ַ�������Ӧ System.Char �������ֵ���Ƚ�����ָ���� System.string ����
        /// </summary>
        /// <param name="strA">Ҫ�Ƚϵĵ�һ���ַ���</param>
        /// <param name="strB">Ҫ�Ƚϵĵڶ����ַ���</param>
        /// <returns>
        ///    ֵ����С�����ʾ strA С�� strB���������ʾ strA �� strB ��ȡ��������ʾ strA ���� strB
        /// </returns>
        public static int CompareOrdinal(this string strA, string strB)
        {
            return string.CompareOrdinal(strA, strB);
        }

        /// <summary>
        ///   ͨ����������ָ���� System.string �����ÿ�����ַ�������Ӧ System.Char �������ֵ�Ƚ����ַ���
        /// </summary>
        /// <param name="strA">Ҫ�ڱȽ���ʹ�õĵ�һ���ַ���</param>
        /// <param name="indexA"> strA �����ַ�������ʼ����</param>
        /// <param name="strB">Ҫ�ڱȽ���ʹ�õĵڶ����ַ���</param>
        /// <param name="indexB">strB �����ַ�������ʼ����</param>
        /// <param name="length">Ҫ�Ƚϵ����ַ������ַ����������</param>
        /// <returns>
        ///   һ�� 32 λ������������ָʾ�����Ƚ���֮��Ĵʷ���ϵ��
        ///  ֵ����С�����ʾ strA �е����ַ���С�� strB �е����ַ�����
        ///          �����ַ�����ȣ����� length Ϊ�㡣
        ///          ������ strA �е����ַ������� strB �е����ַ���
        /// </returns>
        public static int CompareOrdinal(this string strA, int indexA, string strB, int indexB, int length)
        {
            return string.CompareOrdinal(strA, indexA, strB, indexB, length);
        }
    }
}