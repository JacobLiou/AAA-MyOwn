using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ���������õ�ǰʵ������ʾ�ķ������캯��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="obj">��չ����</param>
        /// <param name="methodName">��������</param>
        /// <param name="parameters">�����Ĳ���</param>
        /// <returns></returns>
        public static object InvokeMethod<T>(this T obj,string methodName,params object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName,parameters.Select(o => o.GetType()).ToArray());

            return method.Invoke(obj,parameters);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���������õ�ǰʵ������ʾ�ķ������캯��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="obj">��չ����</param>
        /// <param name="methodName">��������</param>
        /// <param name="parameters">�����Ĳ���</param>
        /// <returns></returns>
        public static T InvokeMethod<T>(this object obj,string methodName,params object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName,parameters.Select(o => o.GetType()).ToArray());

            object value = method.Invoke(obj,parameters);
            return (value is T ? (T)value : default(T));
        }
    }
}