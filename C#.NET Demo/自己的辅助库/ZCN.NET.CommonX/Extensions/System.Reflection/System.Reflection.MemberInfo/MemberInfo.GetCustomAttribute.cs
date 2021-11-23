using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <param name="element">��չ����
        ///  һ���� System.Reflection.MemberInfo �������Ķ��󣬸���������Ĺ��캯�����¼����ֶΡ����������Գ�Ա
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this MemberInfo element,Type attributeType)
        {
            return Attribute.GetCustomAttribute(element,attributeType);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.MemberInfo �������Ķ��󣬸���������Ĺ��캯�����¼����ֶΡ����������Գ�Ա</param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this MemberInfo element,Type attributeType,bool inherit)
        {
            return Attribute.GetCustomAttribute(element,attributeType,inherit);
        }
    }
}