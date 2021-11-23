using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ȷ���Ƿ������Զ�������Ӧ���ڷ�������������ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ������� attributeType ��ĳ���Զ�������Ӧ���� element����Ϊ true������Ϊ false
        /// </summary>
        /// <param name="element"> һ���� System.Reflection.ParameterInfo �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static bool IsDefined(this ParameterInfo element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///  �Զ�����չ������ȷ���Ƿ������Զ�������Ӧ���ڷ�������������ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ������� attributeType ��ĳ���Զ�������Ӧ���� element����Ϊ true������Ϊ false
        /// </summary>
        /// <param name="element"> һ���� System.Reflection.ParameterInfo �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
    }
}