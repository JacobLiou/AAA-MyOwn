using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������е�·����Ϣ�ַ���ƴ�ӳ�һ��������·���������ظ�·��
        /// </summary>
        /// <param name="this">��չ����·����Ϣ����</param>
        public static string PathCombine(this IEnumerable<string> @this)
        {
            return Path.Combine(@this.ToArray());
        }
    }
}