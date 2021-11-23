using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ���ı��ļ�����ȡ�ļ��������У�Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static string[] ReadAllLines(this FileInfo @this)
        {
            return File.ReadAllLines(@this.FullName);
        }

        /// <summary>
        ///  �Զ�����չ��������һ���ļ�����ָ�������ȡ�ļ��������У�Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="encoding">Ӧ�õ��ļ����ݵı���</param>
        /// <returns></returns>
        public static string[] ReadAllLines(this FileInfo @this, Encoding encoding)
        {
            return File.ReadAllLines(@this.FullName, encoding);
        }
    }
}