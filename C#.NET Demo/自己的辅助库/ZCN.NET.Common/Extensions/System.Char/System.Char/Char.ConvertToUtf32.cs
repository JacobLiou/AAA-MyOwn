namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �� UTF-16 ����Ĵ�����Ե�ֵת��Ϊ Unicode ��λ
        /// </summary>
        /// <param name="highSurrogate">�ߴ�������λ������λ�� U+D800 �� U+DBFF��</param>
        /// <param name="lowSurrogate">�ʹ�������λ������λ�� U+DC00 �� U+DFFF��</param>
        /// <returns> �ߴ�������λ�͵ʹ�������λ������ʾ�� 21 λ Unicode ��λ</returns>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate)
        {
            return char.ConvertToUtf32(highSurrogate, lowSurrogate);
        }
    }
}