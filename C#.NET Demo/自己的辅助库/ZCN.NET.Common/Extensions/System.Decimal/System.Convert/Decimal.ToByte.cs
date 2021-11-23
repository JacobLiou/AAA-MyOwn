namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�� System.decimal ��ֵת��Ϊ��Ч�� 8 λ�޷���������
        /// �������С�� <see cref="F:System.Byte.MinValue" /> ����� <see cref="F:System.Byte.MaxValue" /> �򷵻�0
        /// </summary>
        /// <param name="value">��չ���󡣴��� <see cref="F:System.Byte.MinValue" /> ��С�� <see cref="F:System.Byte.MaxValue" /></param>
        /// <returns>��Ч�� value �� 8 λ�޷�������</returns>
        public static byte ToByte(this decimal value)
        {
            try
            {
                return decimal.ToByte(value);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� System.decimal ��ֵת��Ϊ��Ч�� 8 λ�з�������
        /// �������С�� <see cref="F:System.SByte.MinValue" /> ����� <see cref="F:System.SByte.MaxValue" /> �򷵻�0
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>��Ч�� value �� 8 λ�з������������� <see cref="F:System.SByte.MinValue" /> ��С�� <see cref="F:System.SByte.MaxValue" /></returns>
        public static sbyte ToSByte(this decimal value)
        {
            try
            {
                return decimal.ToSByte(value);
            }
            catch
            {
                return 0;
            }
        }
    }
}