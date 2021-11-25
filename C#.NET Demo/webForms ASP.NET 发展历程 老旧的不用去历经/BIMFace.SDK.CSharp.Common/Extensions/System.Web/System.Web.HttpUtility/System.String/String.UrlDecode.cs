using System;
using System.Text;
using System.Web;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        /// �Զ�����չ���������Ѿ�Ϊ�� URL �д����������ַ���ת��Ϊ������ַ���
        /// </summary>
        /// <param name="str">Ҫ������ַ���</param>
        /// <returns>һ���ѽ�����ַ���</returns>
        public static String UrlDecode(this String str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        /// �Զ�����չ���������Ѿ�Ϊ�� URL �д����������ַ���ת��Ϊ������ַ���
        /// </summary>
        /// <param name="str">Ҫ������ַ���</param>
        /// <param name="e">ָ�����뷽���� System.Text.Encoding</param>
        /// <returns>һ���ѽ�����ַ���</returns>
        public static String UrlDecode(this String str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }
    }
}