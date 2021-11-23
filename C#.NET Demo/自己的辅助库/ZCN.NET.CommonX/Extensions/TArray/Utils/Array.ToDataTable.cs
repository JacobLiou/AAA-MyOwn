using System;
using System.Data;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    /// �Զ�����չ��
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///  �Զ�����չ��������һά����ת��Ϊ DataTable
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ���󡣴��㿪ʼ��һά����</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this T[] @this)
        {
            Type type = typeof (T);

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public|BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public|BindingFlags.Instance);

            var dt = new DataTable();

            foreach(PropertyInfo property in properties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }

            foreach(FieldInfo field in fields)
            {
                dt.Columns.Add(field.Name, field.FieldType);
            }

            foreach(T item in @this)
            {
                DataRow dr = dt.NewRow();

                foreach(PropertyInfo property in properties)
                {
                    dr[property.Name] = property.GetValue(item, null);
                }

                foreach(FieldInfo field in fields)
                {
                    dr[field.Name] = field.GetValue(item);
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}