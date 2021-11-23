using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ַ������ַ���������ϳ�һ��·��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="paths">�ַ�������</param>
        /// <returns></returns>
        public static string PathCombine(this string @this, params string[] paths)
        {
            List<string> list = paths.ToList();
            list.Insert(0, @this);
            return Path.Combine(list.ToArray());
        }
    }
}