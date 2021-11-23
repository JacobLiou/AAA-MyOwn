using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ز�������չ����ָ��·���ַ������ļ���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtension(this FileInfo @this)
        {
            return Path.GetFileNameWithoutExtension(@this.FullName);
        }
    }
}