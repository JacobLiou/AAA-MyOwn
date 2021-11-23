using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ����ģ����Զ������Ե����顣����ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ����һ�� System.Attribute ���飬����Ӧ���� element �� attributeType ���͵��Զ������ԣ���������ڴ����Զ������ԣ���Ϊ������
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Module element,Type attributeType)
        {
            return Attribute.GetCustomAttributes(element,attributeType);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ����ģ����Զ������Ե����顣����ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ����һ�� System.Attribute ���飬����Ӧ���� element �� attributeType ���͵��Զ������ԣ���������ڴ����Զ������ԣ���Ϊ������
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Module element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ����ģ����Զ������Ե����顣����ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ����һ�� System.Attribute ���飬����Ӧ���� element �� attributeType ���͵��Զ������ԣ���������ڴ����Զ������ԣ���Ϊ������
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <param name="inherit">�˲��������ԣ����Ҳ���Ӱ��˷����Ĳ���</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Module element,bool inherit)
        {
            return Attribute.GetCustomAttributes(element,inherit);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ����ģ����Զ������Ե����顣����ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ����һ�� System.Attribute ���飬����Ӧ���� element �� attributeType ���͵��Զ������ԣ���������ڴ����Զ������ԣ���Ϊ������
        /// </summary>
        /// <param name="element">��չ����
        /// һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">�˲��������ԣ����Ҳ���Ӱ��˷����Ĳ���</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Module element,Type attributeType,bool inherit)
        {
            return Attribute.GetCustomAttributes(element,attributeType,inherit);
        }
    }
}