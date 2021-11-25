using System;
using System.Web;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
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