using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��Ƿ� attributeType ��һ������ʵ��Ӧ���ڴ˳�Ա
        /// </summary>
        /// <param name="element">��չ����</param>
        /// <param name="attributeType">�Զ�������Ӧ���ڵ� Type ����</param>
        /// <returns></returns>
        public static bool IsDefined(this Assembly element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///  �Զ�����չ������ȷ���Ƿ������Զ�������Ӧ���ڳ��򼯡�����ָ�����򼯡�Ҫ�������Զ������Ե������Լ����Ե�����ѡ��
        /// </summary>
        /// <param name="element">��չ����</param>
        /// <param name="attributeType">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">ָ���Ƿ������ó�Ա�ļ̳����Բ�����Щ����</param>
        /// <returns></returns>
        public static bool IsDefined(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
    }
}