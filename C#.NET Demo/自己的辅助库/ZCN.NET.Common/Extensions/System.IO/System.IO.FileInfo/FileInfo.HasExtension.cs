using System;
using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ȷ��·���Ƿ�����ļ���չ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static Boolean HasExtension(this FileInfo @this)
        {
            return Path.HasExtension(@this.FullName);
        }
    }
}