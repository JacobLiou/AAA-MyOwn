using System;
using System.Data;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� DataRow ������ת��ΪT���͵�ʵ�����
        /// ���÷���ʹ�÷������ʵ�֣����ܽϵ͡��Ƽ�ʹ��Emitʵ�ַ�ʽ��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        [Obsolete("�÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ")]
        public static T ToEntity<T>(this DataRow @this) where T : new()
        {
            Type type = typeof (T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public|BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public|BindingFlags.Instance);

            var entity = new T();

            foreach(PropertyInfo property in properties)
            {
                if(@this.Table.Columns.Contains(property.Name))
                {
                    Type valueType = property.PropertyType;
                    property.SetValue(entity, @this[property.Name].ConvertTo(valueType), null);
                }
            }

            foreach(FieldInfo field in fields)
            {
                if(@this.Table.Columns.Contains(field.Name))
                {
                    Type valueType = field.FieldType;
                    field.SetValue(entity, @this[field.Name].ConvertTo(valueType));
                }
            }

            return entity;
        }
    }
}