namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ�����������չ����Ϊ���ַ���������Ĭ��ֵ�����򷵻ر���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="defaultValue">Ĭ��ֵ</param>
        /// <returns>�����չ����Ϊ���ַ������򷵻ر������򷵻�Ĭ��ֵ</returns>
        public static string IfEmpty(this string @this,string defaultValue)
        {
            return @this.IsEmpty() ? defaultValue : @this;
        }
    }
}