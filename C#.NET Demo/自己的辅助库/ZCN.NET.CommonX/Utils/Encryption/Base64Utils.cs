using System;
using System.Text;

using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///  ���ַ�������Base64��ʽ���ܽ��ܹ�����
    /// </summary>
    public static partial class Base64Utils
    {
        #region Base64(�������)

        /// <summary>
        ///  ʹ�� UTF8 �����ʽ�����ַ������н��� Base64 ��ʽ���루���ܣ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>�������ַ���</returns>
        public static string EncryptByBase64(this string @this)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Encoding.UTF8.GetBytes(@this);
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        ///  ʹ�� UTF8 �����ʽ�����ַ������н��� Base64 ��ʽ���루���ܣ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>�������ַ���</returns>
        public static string DecryptByBase64(this string @this)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Convert.FromBase64String(@this);
                return Encoding.UTF8.GetString(bytes);
            }
        }

        /// <summary>
        ///  ʹ���Զ���ı����ʽ�����ַ������н��� Base64 ��ʽ���루���ܣ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="encodingName">���뷽ʽ������ʹ�� EncodingNames ���ȡ��������</param>
        /// <returns>�������ַ���</returns>
        public static string EncryptByBase64(this string @this, string encodingName)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace() || encodingName.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Encoding.GetEncoding(encodingName).GetBytes(@this);
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        ///  ʹ���Զ���ı����ʽ�����ַ������н��� Base64 ��ʽ���루���ܣ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="encodingName">���뷽ʽ����Ҫ�����ʱʹ����ͬ�ı��뷽ʽ</param>
        /// <returns>�������ַ���</returns>
        public static string DecryptByBase64(this string @this, string encodingName)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace() || encodingName.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Convert.FromBase64String(@this);
                return Encoding.GetEncoding(encodingName).GetString(bytes);
            }
        }
        #endregion
    }
}