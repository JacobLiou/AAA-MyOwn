using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ���ı��ļ�����ȡ�ļ��������У�Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static string ReadAllText(this FileInfo @this)
        {
            return File.ReadAllText(@this.FullName);
        }

        /// <summary>
        ///  �Զ�����չ��������һ���ļ�����ָ�������ȡ�ļ��������У�Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="encoding">Ӧ�õ��ļ����ݵı���</param>
        /// <returns></returns>
        public static string ReadAllText(this FileInfo @this, Encoding encoding)
        {
            return File.ReadAllText(@this.FullName, encoding);
        }
    }
}