using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������������������ģʽƥ�䲢��ʹ��ĳ��ֵȷ���Ƿ�����Ŀ¼�н��������ĵ�ǰĿ¼���ļ��б�����ļ���С(�ֽ�)
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <returns></returns>
        public static long GetSize(this DirectoryInfo @this)
        {
            return @this.GetFiles("*.*", SearchOption.AllDirectories).Sum(x => x.Length);
        }
    }
}