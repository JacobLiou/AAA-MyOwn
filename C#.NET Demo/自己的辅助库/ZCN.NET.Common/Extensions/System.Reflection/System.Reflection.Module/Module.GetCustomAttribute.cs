using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ����ģ����Զ������ԡ�����ָ��ģ�顢Ҫ�������Զ������Ե������Լ����Ե�����ѡ�
        ///  ����һ�����ã�ָ��Ӧ���� element �� attributeType ���͵ĵ����Զ������ԣ����û�д������ԣ���Ϊ null
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�</param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this Module element,Type attributeType)
        {
            return Attribute.GetCustomAttribute(element,attributeType);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ����ģ����Զ������ԡ�����ָ��ģ�顢Ҫ�������Զ������Ե������Լ����Ե�����ѡ�
        ///  ����һ�����ã�ָ��Ӧ���� element �� attributeType ���͵ĵ����Զ������ԣ����û�д������ԣ���Ϊ null
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�</param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this Module element,Type attributeType,bool inherit)
        {
            return Attribute.GetCustomAttribute(element,attributeType,inherit);
        }
    }
}