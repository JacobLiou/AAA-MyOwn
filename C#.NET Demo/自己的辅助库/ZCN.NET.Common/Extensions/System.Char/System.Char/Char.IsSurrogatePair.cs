namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�����ָ���� System.Char �����Ƿ��γɴ������
        /// </summary>
        /// <param name="highSurrogate">Ҫ��Ϊ������Եĸߴ�������м�����ַ�</param>
        /// <param name="lowSurrogate"> Ҫ��Ϊ������Եĵʹ�������м�����ַ�</param>
        /// <returns></returns>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate)
        {
            return char.IsSurrogatePair(highSurrogate, lowSurrogate);
        }
    }
}