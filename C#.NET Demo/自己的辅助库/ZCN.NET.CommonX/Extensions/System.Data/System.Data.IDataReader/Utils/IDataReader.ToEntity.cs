using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

using ZCN.NET.CommonX.Enums;
using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� IDataReader ����ת��Ϊһ��ʵ�����
        /// ���÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="handling">���DBNull�ֶεĴ���ʽ</param>
        /// <returns></returns>
        //[Obsolete("�÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ")]
        public static T ToEntity<T>(this IDataReader @this, DBNullHandling handling = DBNullHandling.SetDefaultValue) where T : new()
        {
            if (@this == null || @this.Read() == false)
                return default(T);

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();
            var hash = new HashSet<string>(@this.GetColumnNames());

            foreach (PropertyInfo property in properties)
            {
                if (!property.CanWrite)
                    continue;

                if (hash.Contains(property.Name))
                {
                    //Type valueType = property.PropertyType;
                    //property.SetValue(entity, @this[property.Name].ConvertTo(valueType), null);

                    object value = @this[property.Name];
                    if (value is DBNull)
                    {
                        if (handling == DBNullHandling.SetDefaultValue)
                        {
                            value = property.PropertyType.GetDBNullDefaultValue();
                        }
                        else
                        {
                            continue;
                        }
                    }
                    property.SetValue(entity, value, null);
                }
            }

            return entity;
        }

        /// <summary>
        ///  �Զ�����չ�������� IDataReader ����ת��Ϊʵ����󼯺�
        /// ���÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="handling">���DBNull�ֶεĴ���ʽ</param>
        /// <returns></returns>
        [Obsolete("�÷���ʹ�÷������ʵ�֣����ܽϵ͡���������ʱ�Ƽ�ʹ��Emitʵ�ַ�ʽ")]
        public static IEnumerable<T> ToEntityList<T>(this IDataReader @this, DBNullHandling handling = DBNullHandling.SetDefaultValue) where T : new()
        {
            if (@this == null || @this.Read() == false)
                return new List<T>();

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();
            var hash = new HashSet<string>(@this.GetColumnNames());

            while (@this.Read())
            {
                var entity = new T();

                foreach (PropertyInfo property in properties)
                {
                    if (hash.Contains(property.Name))
                    {
                        //Type valueType = property.PropertyType;
                        //property.SetValue(entity,@this[property.Name].ConvertTo(valueType),null);

                        object value = @this[property.Name];
                        if (value is DBNull)
                        {
                            if (handling == DBNullHandling.SetDefaultValue)
                            {
                                value = property.PropertyType.GetDBNullDefaultValue();
                            }
                            else
                            {
                                continue;
                            }
                        }

                        property.SetValue(entity, value, null);
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}