using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ���ļ���������׷��ָ�����ַ�����Ȼ��رո��ļ���
        ///  ����ļ������ڣ��˷�������һ���ļ�����ָ���ַ���д���ļ���Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫ׷�ӵ��ļ��е��ַ���</param>
        public static void AppendAllText(this FileInfo @this, string contents)
        {
            File.AppendAllText(@this.FullName, contents);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�����뽫ָ���ַ���׷�ӵ��ļ��У�����ļ����������򴴽����ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫ׷�ӵ��ļ��е��ַ���</param>
        /// <param name="encoding">Ҫʹ�õ��ַ�����</param>
        public static void AppendAllText(this FileInfo @this, string contents, Encoding encoding)
        {
            File.AppendAllText(@this.FullName, contents, encoding);
        }
    }
}