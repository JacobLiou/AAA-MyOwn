using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������·���ַ�������չ����
        ///  ���ذ����޸ĵ�·����Ϣ���ַ�����
        ///  �ڻ��� Windows ������ƽ̨�ϣ���� path �� null ����ַ��� ("")���򷵻ص�·����Ϣ��δ�޸ĵġ�
        ///  ��� extension �� null���򷵻ص��ַ�������ָ����·��������չ�����Ƴ���
        ///  ��� path ��������չ�������� extension ���� null���򷵻ص�·���ַ������� extension����׷�ӵ� path �Ľ�β
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="extension">�µ���չ�����л�û��ǰ����㣩��ָ�� null �Դ� path �Ƴ�������չ��</param>
        public static string ChangeExtension(this FileInfo @this, string extension)
        {
            return Path.ChangeExtension(@this.FullName, extension);
        }
    }
}