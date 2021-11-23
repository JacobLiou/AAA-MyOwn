using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��Ƿ� attributeType ��һ������ʵ��Ӧ���ڴ˳�Ա
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="attributeType">�Զ�������Ӧ���ڵ� Type ����</param>
        /// <param name="inherit">ָ���Ƿ������ó�Ա�ļ̳����Բ�����Щ����</param>
        /// <returns></returns>
        public static bool IsAttributeDefined(this object @this,Type attributeType,bool inherit)
        {
            return @this.GetType().IsDefined(attributeType,inherit);
        }

        /// <summary>
        ///  �Զ�����չ�������ж��Ƿ� attributeType ��һ������ʵ��Ӧ���ڴ˳�Ա
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="inherit">ָ���Ƿ������ó�Ա�ļ̳����Բ�����Щ����</param>
        /// <returns></returns>
        public static bool IsAttributeDefined<T>(this object @this,bool inherit) where T : Attribute
        {
            return @this.GetType().IsDefined(typeof(T),inherit);
        }
    }
}