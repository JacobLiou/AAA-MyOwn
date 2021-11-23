using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� DataTable ������ת��ΪT���͵�ʵ����󼯺�
        /// ���÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        [Obsolete("�÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ")]
        public static IEnumerable<T> ToEntityList<T>(this DataTable @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            foreach (DataRow dr in @this.Rows)
            {
                T entity = new T();

                foreach (PropertyInfo property in properties)
                {
                    if (@this.Columns.Contains(property.Name))
                    {
                        Type valueType = property.PropertyType;
                        property.SetValue(entity, dr[property.Name].ConvertTo(valueType), null);
                    }
                }

                foreach (FieldInfo field in fields)
                {
                    if (@this.Columns.Contains(field.Name))
                    {
                        Type valueType = field.FieldType;
                        field.SetValue(entity, dr[field.Name].ConvertTo(valueType));
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}