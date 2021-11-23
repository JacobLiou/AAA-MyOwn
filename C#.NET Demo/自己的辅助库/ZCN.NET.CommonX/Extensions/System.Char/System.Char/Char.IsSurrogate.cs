namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ�����ַ��Ƿ���д�������λ
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsSurrogate(this char c)
        {
            return char.IsSurrogate(c);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ���� System.char �����Ƿ�Ϊ�ߴ�����
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ���� System.char �����Ƿ�Ϊ�ʹ�����
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }
    }
}