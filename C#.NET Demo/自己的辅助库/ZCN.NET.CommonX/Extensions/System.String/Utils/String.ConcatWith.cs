namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ַ������ַ������Ԫ�����ӳ�һ���ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="values">�ַ���ʵ��������</param>
        /// <returns>A string.</returns>
        public static string ConcatWith(this string @this, params string[] values)
        {
            return string.Concat(@this, string.Concat(values));
        }
    }
}