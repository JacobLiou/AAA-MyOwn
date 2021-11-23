using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������������ԵĿ�ѡ����ֵ���ø����Ե�ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="propertyName">��������</param>
        /// <param name="value">��������Ե�ֵ</param>
        /// <returns></returns>
        public static void SetPropertyValue<T>(this T @this, string propertyName, object value)
        {
            Type type = @this.GetType();
            PropertyInfo property = type.GetProperty(propertyName,
                BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);
            property.SetValue(@this, value, null);
        }
    }
}