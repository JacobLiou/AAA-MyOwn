using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ø�������֧�ֵ��ֶ�ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="fieldName">�ֶ�����</param>
        /// <param name="value">������ֶε�ֵ</param>
        /// <returns></returns>
        public static void SetFieldValue<T>(this T @this, string fieldName, object value)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField(fieldName,
                BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);
            field.SetValue(@this, value);
        }
    }
}