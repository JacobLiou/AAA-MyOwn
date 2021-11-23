using System;
using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������Ŀ¼�µ������ļ��Լ�Ŀ¼
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ</param>
        public static void Clear(this DirectoryInfo obj)
        {
            Array.ForEach(obj.GetFiles(), x => x.Delete());
            Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
        }
    }
}