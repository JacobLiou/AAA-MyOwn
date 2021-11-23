using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this object @this)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes()
                : type.GetCustomAttributes();
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static object[] GetCustomAttributes(this object @this,bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit)
                : type.GetCustomAttributes(inherit);
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this object @this) where T : Attribute
        {
            var type = @this.GetType();

            return (T[])(type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(typeof(T))
                : type.GetCustomAttributes(typeof(T)));
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this object @this,bool inherit) where T : Attribute
        {
            var type = @this.GetType();

            return (T[])(type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(typeof(T),inherit)
                : type.GetCustomAttributes(typeof(T),inherit));
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this MemberInfo @this) where T : Attribute
        {
            return (T[])@this.GetCustomAttributes(typeof(T));
        }

        /// <summary>
        ///  �Զ�����չ����������Ӧ�������ͳ�Ա���Զ������ԡ�����ָ����Ա��Ҫ�������Զ������Ե������Լ��Ƿ�������Ա������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="inherit">���Ϊ true����ָ������ element �������������Զ�������</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this MemberInfo @this,bool inherit) where T : Attribute
        {
            return (T[])@this.GetCustomAttributes(typeof(T),inherit);
        }
    }
}