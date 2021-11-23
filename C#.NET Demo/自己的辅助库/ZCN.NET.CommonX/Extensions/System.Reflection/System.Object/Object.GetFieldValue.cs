using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ظ�������֧�ֵ��ֶε�ֵ��
        ///  ���ҵ�����Ϊ��ʾ����ָ�����ƵĹ����ֶε� System.Reflection.FieldInfo ���󣻷���Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="fieldName">Ҫ��ȡ�������ֶε�����</param>
        /// <returns>������ʵ����ӳ���ֶ�ֵ�Ķ���</returns>
        public static object GetFieldValue<T>(this T @this,string fieldName)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField(fieldName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            return field.GetValue(@this);
        }
    }
}