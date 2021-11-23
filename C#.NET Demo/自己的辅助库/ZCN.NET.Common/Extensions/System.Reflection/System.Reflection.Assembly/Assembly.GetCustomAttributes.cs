using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <param name="element">��չ����</param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="element">��չ����</param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <param name="element">��չ����</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="element">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }
    }
}