using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ�������͵ĳ�Ա���Զ������Ե����顣����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <param name="element">��չ����
        ///  һ���� System.Reflection.MemberInfo �������Ķ��󣬸���������Ĺ��캯�����¼����ֶΡ����������Գ�Ա
        /// </param>
        /// <param name="type">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns>һ�� System.Attribute ���飬����Ӧ���� element �� type ���͵��Զ������ԣ�
        ///          ��������ڴ����Զ������ԣ���Ϊ������
        /// </returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element,Type type)
        {
            return Attribute.GetCustomAttributes(element,type);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������͵ĳ�Ա���Զ������Ե����顣����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="element">��չ����
        ///  һ���� System.Reflection.MemberInfo �������Ķ��󣬸���������Ĺ��캯�����¼����ֶΡ����������Գ�Ա
        /// </param>
        /// <param name="type">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element,Type type,Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element,type,inherit);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������͵ĳ�Ա���Զ������Ե�����
        /// </summary>
        /// <param name="element">��չ����
        ///  һ���� System.Reflection.MemberInfo �������Ķ��󣬸���������Ĺ��캯�����¼����ֶΡ����������Գ�Ա
        /// </param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������͵ĳ�Ա���Զ������Ե����顣����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="element">��չ����
        ///  һ���� System.Reflection.MemberInfo �������Ķ��󣬸���������Ĺ��캯�����¼����ֶΡ����������Գ�Ա
        /// </param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element,Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element,inherit);
        }
    }
}