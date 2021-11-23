using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա�ĵ�һ���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="attribute">Ҫ�������Զ������Ե����ͻ������</param>
        /// <returns></returns>
        public static object GetCustomAttribute(this object @this, Type attribute)
        {
            var type = @this.GetType();

            return type.IsEnum
                       ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute)
                       : Attribute.GetCustomAttribute(type, attribute);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա�ĵ�һ���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="attribute">Ҫ�������Զ������Ե����ͻ������</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object GetCustomAttribute(this object @this, Type attribute, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                       ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute, inherit)
                       : Attribute.GetCustomAttribute(type, attribute, inherit);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա�ĵ�һ���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this object @this) where T : Attribute
        {
            var type = @this.GetType();

            return (T) (type.IsEnum
                            ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T))
                            : Attribute.GetCustomAttribute(type, typeof(T)));
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա�ĵ�һ���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this object @this, bool inherit) where T : Attribute
        {
            var type = @this.GetType();

            return (T) (type.IsEnum
                            ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T), inherit)
                            : Attribute.GetCustomAttribute(type, typeof(T), inherit));
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա�ĵ�һ���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this MemberInfo @this) where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(@this, typeof(T));
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա�ĵ�һ���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this MemberInfo @this, bool inherit) where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(@this, typeof(T), inherit);
        }
    }
}