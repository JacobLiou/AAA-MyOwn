using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ��λ�ÿ�ʼ��ȡ��չ����ʵ���е��ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="startIndex">��ʼλ��</param>
        /// <returns>�ַ���</returns>
        public static string Substring(this StringBuilder @this, int startIndex)
        {
            return @this.ToString(startIndex, @this.Length - startIndex);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��λ�ÿ�ʼ��ȡ��չ����ʵ���е��ַ����е�ָ�����ȵ��ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="startIndex">��ʼλ��</param>
        /// <param name="length"></param>
        /// <returns>�ַ���</returns>
        public static string Substring(this StringBuilder @this, int startIndex, int length)
        {
            return @this.ToString(startIndex, length);
        }
    }
}