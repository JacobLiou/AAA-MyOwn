namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ�� System.Decimal ֵת��Ϊ��Ч�� OLE �Զ�������ֵ����ֵ������һ�� 64 λ�з���������
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>���� value �� OLE �Զ�����Чֵ�� 64 λ�з�������</returns>
        public static long ToOACurrency(this decimal value)
        {
            return decimal.ToOACurrency(value);
        }
    }
}