using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ͨ������������������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByName(this object @this, string name)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>
        ///  �Զ�����չ������ͨ������������������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByName(this object @this, string name, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString())
                    .GetCustomAttributes(inherit)
                    .Where(x => x.GetType().Name == name)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>
        ///  �Զ�����չ������ͨ������������������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributesByName(this MemberInfo @this, string name)
        {
            return @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>
        ///  �Զ�����չ������ͨ������������������Զ�������
        /// </summary>
        /// <exception cref="Exception">�������쳣����ʱ�׳�</exception>
        /// <param name="this">��չ����</param>
        /// <param name="name">��Ա����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object[] GetCustomAttributesByName(this MemberInfo @this, string name, bool inherit)
        {
            return @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
        }
    }
}