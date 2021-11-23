using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ��������ɾ����ǰĿ¼�µ��ļ�
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="predicate">��������</param>
        public static void DeleteFilesWhere(this DirectoryInfo obj,Func<FileInfo,bool> predicate)
        {
            obj.GetFiles().Where(predicate).ForEach(x => x.Delete());
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��������ɾ��Ŀ¼�Լ���Ŀ¼�µ��ļ�
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="predicate">��������</param>
        /// <param name="searchOption">ָ����������ǰĿ¼������������ǰĿ¼����������Ŀ¼</param>
        public static void DeleteFilesWhere(this DirectoryInfo obj,
            Func<FileInfo,bool> predicate,SearchOption searchOption)
        {
            obj.GetFiles("*.*",searchOption).Where(predicate).ForEach(x => x.Delete());
        }
    }
}