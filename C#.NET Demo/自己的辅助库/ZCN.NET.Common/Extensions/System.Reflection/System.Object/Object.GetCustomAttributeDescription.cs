using System.ComponentModel;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ȡ�����������Ϣ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this object value)
        {
            var type = value.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute))
                                 : type.GetCustomAttributes(typeof (DescriptionAttribute));
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(
                string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ��������ȡ�����������Ϣ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this object value, bool inherit)
        {
            var type = value.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), inherit)
                                 : type.GetCustomAttributes(typeof (DescriptionAttribute));
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ��������ȡ�����������Ϣ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this MemberInfo value)
        {
            var attributes = value.GetCustomAttributes(typeof (DescriptionAttribute));
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ��������ȡ�����������Ϣ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static string GetCustomAttributeDescription(this MemberInfo value, bool inherit)
        {
            var attributes = value.GetCustomAttributes(typeof (DescriptionAttribute), inherit);
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return ((DescriptionAttribute)attributes[0]).Description;

            throw new System.Exception(
                string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }
    }
}