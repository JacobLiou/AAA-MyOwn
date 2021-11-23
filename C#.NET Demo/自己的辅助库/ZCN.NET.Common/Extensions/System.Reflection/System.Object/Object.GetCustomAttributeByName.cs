using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ͨ����������������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this object @this,string name)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ������ͨ����������������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this object @this,string name,bool inherit)
        {
            var type = @this.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(@this.ToString())
                                       .GetCustomAttributes(inherit)
                                       .Where(x => x.GetType().Name == name)
                                       .ToArray()
                                 : type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                 string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ������ͨ����������������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this MemberInfo @this,string name)
        {
            var attributes = @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
            if(attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ������ͨ����������������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object GetCustomAttributeByName(this MemberInfo @this,string name,bool inherit)
        {
            var attributes = @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                 string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }
    }
}