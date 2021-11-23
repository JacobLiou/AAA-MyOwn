using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ȷ���Ƿ�ָ�����͵��κ��Զ�������Ӧ����ģ�顣����ָ��ģ���Ҫ�������Զ������Ե����͡�
        ///  ������� attributeType ��ĳ���Զ�������Ӧ���� element����Ϊ true������Ϊ false
        /// </summary>
        /// <param name="element"> һ���� System.Reflection.Module �������Ķ��󣬸�����������ֲ�Ŀ�ִ���ļ�
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static bool IsDefined(this Module element,Type attributeType)
        {
            return Attribute.IsDefined(element,attributeType);
        }

        /// <summary>
        ///  �Զ�����չ������ȷ���Ƿ������Զ�������Ӧ�������ͳ�Ա������ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա�����ȡ�
        ///  ������� attributeType ��ĳ���Զ�������Ӧ���� element����Ϊ true������Ϊ false
        /// </summary>
        /// <param name="element">һ���� System.Reflection.MemberInfo �������Ķ���
        ///  ����������Ĺ��캯�����¼����ֶΡ����������ͻ����Գ�Ա
        /// </param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static bool IsDefined(this Module element,Type attributeType,bool inherit)
        {
            return Attribute.IsDefined(element,attributeType,inherit);
        }
    }
}