using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ظ�������֧�ֵ����Ե�ֵ������Ҳ����򷵻� null 
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="propertyName">Ҫ��ȡ���������Ե�����</param>
        /// <returns>������ʵ����ӳ������ֵ�Ķ���</returns>
        public static object GetPropertyValue<T>(this T @this, string propertyName)
        {
            Type type = @this.GetType();
            PropertyInfo property = type.GetProperty(propertyName,
                BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);

            return property.GetValue(@this, null);
        }
    }
}