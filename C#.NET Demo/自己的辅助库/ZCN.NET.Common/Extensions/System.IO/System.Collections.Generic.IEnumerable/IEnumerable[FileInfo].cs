using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ɾ�������е��ļ���Ϣ
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        public static void Delete(this IEnumerable<FileInfo> @this)
        {
            foreach (FileInfo t in @this)
            {
                t.Delete();
            }
        }

        /// <summary>
        ///  �Զ�����չ������ѭ�����ļ���Ϣ�����еĶ�����Ϊ��������ָ���ķ����в�ִ�з�������󷵻��ļ���Ϣ����
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="action"></param>
        public static IEnumerable<FileInfo> ForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
        {
            var fileInfos = @this as FileInfo[] ?? @this.ToArray();
            foreach (FileInfo t in fileInfos)
            {
                action(t);
            }
            return fileInfos;
        }
    }
}