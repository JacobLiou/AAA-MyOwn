using System;
using System.Text;
using System.Web;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        ///  �Զ�����չ������ʹ��ָ���ı������� URL �ַ������б���
        /// </summary>
        /// <param name="str">Ҫ������ı�</param>
        /// <returns>һ���ѱ�����ַ���</returns>
        public static String UrlEncode(this String str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        ///  �Զ�����չ������ʹ��ָ���ı������� URL �ַ������б���
        /// </summary>
        /// <param name="str">Ҫ������ı�</param>
        /// <param name="e">ָ�����뷽���� System.Text.Encoding ����</param>
        /// <returns>һ���ѱ�����ַ���</returns>
        public static String UrlEncode(this String str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }
    }
}