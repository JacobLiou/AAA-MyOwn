using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������򼯵ĵ�һ���Զ������ԡ����û���򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static T GetAttribute<T>(this Assembly @this) where T : Attribute
        {
            object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof(T), false);
            if (configAttributes != null && configAttributes.Length > 0)
                return (T)configAttributes[0];

            return null;
        }
    }
}