using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ȡĿ¼���ļ�������Ŀ¼
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static string GetDirectoryFullName(this FileInfo @this)
        {
            return @this.Directory.FullName;
        }
    }
}