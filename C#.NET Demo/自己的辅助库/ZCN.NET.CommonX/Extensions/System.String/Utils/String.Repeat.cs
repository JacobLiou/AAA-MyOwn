using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ַ�������ָ���Ĵ����ظ�ƴ����һ��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="repeatCount">�ظ�����</param>
        /// <returns>ƴ�Ӻ���ַ���</returns>
        public static string Repeat(this string @this, int repeatCount)
        {
            if (@this.Length == 1)
            {
                return new string(@this[0], repeatCount);
            }

            var sb = new StringBuilder(repeatCount * @this.Length);
            while (repeatCount-- > 0)
            {
                sb.Append(@this);
            }

            return sb.ToString();
        }
    }
}