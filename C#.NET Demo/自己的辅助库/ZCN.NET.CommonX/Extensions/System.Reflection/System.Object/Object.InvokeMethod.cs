using System;
using System.Linq;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定参数调用当前实例所表示的方法或构造函数
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="obj">扩展对象</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">方法的参数</param>
        /// <returns></returns>
        public static object InvokeMethod<T>(this T obj,string methodName,params object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName,parameters.Select(o => o.GetType()).ToArray());

            return method.Invoke(obj,parameters);
        }

        /// <summary>
        ///  自定义扩展方法：将指定参数调用当前实例所表示的方法或构造函数
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="obj">扩展对象</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">方法的参数</param>
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