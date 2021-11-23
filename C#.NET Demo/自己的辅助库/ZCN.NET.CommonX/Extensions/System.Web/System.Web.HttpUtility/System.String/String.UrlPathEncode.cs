using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� URL �ַ�����·�����ֽ��б��룬�Խ��д� Web ���������ͻ��˵Ŀɿ��� HTTP ����
        /// </summary>
        /// <param name="str">Ҫ���� URL ������ı�</param>
        /// <returns> URL ������ı�</returns>
        public static String UrlPathEncode(this String str)
        {
            return HttpUtility.UrlPathEncode(str);
        }
    }
}