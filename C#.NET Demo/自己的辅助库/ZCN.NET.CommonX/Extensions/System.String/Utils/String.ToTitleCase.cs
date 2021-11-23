using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ���ַ���ת��Ϊ������ĸ��д��
        ///  ���磺product_no sale ת�����Ϊ Product_No Sale��
        /// <para>�÷����� ToPascalCase()������ͬ</para>
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>����ĸ��д���ַ���</returns>
        public static string ToTitleCase(this string @this)
        {
            return new CultureInfo("en-US").TextInfo.ToTitleCase(@this);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ַ���ת��Ϊ������ĸ��д��
        ///  ���磺product_no sale ת�����Ϊ Product_No Sale
        /// <para>�÷����� ToPascalCase()������ͬ</para>
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="cultureInfo">������Ϣ����</param>
        /// <returns>����ĸ��д���ַ���</returns>
        public static string ToTitleCase(this string @this, CultureInfo cultureInfo)
        {
            return cultureInfo.TextInfo.ToTitleCase(@this);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ַ���ת��Ϊ������ĸ��д��
        ///  ���磺product_no sale ת�����Ϊ Product_No Sale��
        /// <para>�÷����� ToTitleCase()������ͬ</para>
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>����ĸ��д���ַ���</returns>
        public static string ToPascalCase(this string @this)
        {
            return @this.ToTitleCase();
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ַ���ת��Ϊ������ĸ��д(Pascal����)��
        ///  ���磺product_no sale ת�����Ϊ Product_No Sale��
        /// <para>�÷����� ToTitleCase()������ͬ</para>
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="cultureInfo">������Ϣ����</param>
        /// <returns>����ĸ��д���ַ���</returns>
        public static string ToPascalCase(this string @this, CultureInfo cultureInfo)
        {
            return @this.ToTitleCase(cultureInfo);
        }
    }
}