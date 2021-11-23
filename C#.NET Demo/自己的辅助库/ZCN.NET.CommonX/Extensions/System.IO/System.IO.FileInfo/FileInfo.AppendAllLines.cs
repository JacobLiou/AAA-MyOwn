using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ���ļ���׷���ı��У�Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫ׷�ӵ��ļ��е��ı���</param>
        public static void AppendAllLines(this FileInfo @this,IEnumerable<string> contents)
        {
            File.AppendAllLines(@this.FullName,contents);
        }

        /// <summary>
        ///  �Զ�����չ������ ��ָ��������һ���ļ���׷���ı��У�Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫ׷�ӵ��ļ��е��ı���</param>
        /// <param name="encoding">Ҫʹ�õ��ַ�����</param>
        public static void AppendAllLines(this FileInfo @this,IEnumerable<string> contents,Encoding encoding)
        {
            File.AppendAllLines(@this.FullName,contents,encoding);
        }
    }
}