using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ǰĿ¼���ļ���ȫ�����������е�·��ƴ����һ�𣬷����µ��ļ���Ϣ����
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="paths">Ŀ¼����</param>
        /// <returns></returns>
        public static FileInfo PathCombineFile(this DirectoryInfo @this, params string[] paths)
        {
            List<string> list = paths.ToList();
            list.Insert(0, @this.FullName);
            return new FileInfo(Path.Combine(list.ToArray()));
        }
    }
}