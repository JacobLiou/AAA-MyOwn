using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ���������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByFullName(this object @this, string fullName)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString())
                    .GetCustomAttributes()
                    .Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ���������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByFullName(this object @this, string fullName, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString())
                    .GetCustomAttributes(inherit)
                    .Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ���������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName)
        {
            return @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>
        ///  �Զ�����չ������ͨ�������ȫ�������ҵ�һ���Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="fullName">System.Type ����ȫ�޶��������� System.Type �������ռ䣬������������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName, bool inherit)
        {
            return @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
        }
    }
}