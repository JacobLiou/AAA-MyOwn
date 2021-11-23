using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ�������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <returns></returns>
        public static object GetCustomAttributeByFullName(this object @this,string fullName)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString())
                      .GetCustomAttributes()
                      .Where(x => x.GetType().FullName == fullName)
                      .ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();

            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ�������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object GetCustomAttributeByFullName(this object @this,string fullName,bool inherit)
        {
            var type = @this.GetType();
            var attributes = type.IsEnum
                                 ? type.GetField(@this.ToString())
                                       .GetCustomAttributes(inherit)
                                       .Where(x => x.GetType().FullName == fullName)
                                       .ToArray()
                                 : type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();

            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                 string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ�������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <returns></returns>
        public static object GetCustomAttributeByFullName(this MemberInfo @this,string fullName)
        {
            var attributes = @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }

        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ�������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object GetCustomAttributeByFullName(this MemberInfo @this,string fullName,bool inherit)
        {
            var attributes = @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
            if (attributes.Length == 0)
                return null;

            if (attributes.Length == 1)
                return attributes[0];

            throw new System.Exception(
                string.Format("ģ�������ԡ��ҵ�ͬһ���͵Ķ���Զ�������: {0}�����Ա��ҵ���",attributes.Length));
        }
    }
}