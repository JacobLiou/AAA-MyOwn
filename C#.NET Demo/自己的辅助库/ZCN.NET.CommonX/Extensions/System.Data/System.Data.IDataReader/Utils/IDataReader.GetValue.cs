using System;
using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region GetValue 

        #region GetBoolean

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为bool类型数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static bool GetBoolean(this IDataReader dataReader, string columnName, bool defaultValueIfNull = false)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            bool.TryParse(dataReader[columnName].ToString(), out bool result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为bool类型数据。
        ///  是、否、true、false、Y、N、Yes、no(忽略大小写)、整数都可以转换成功(小于等于0的整数转换为 false，大于0的整数转换为 true)。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回 bool 类型的默认值
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static bool GetBoolean2(this IDataReader dataReader, string columnName, bool defaultValueIfNull = false)
        {
            string str = dataReader[columnName].ToString();
            return str.ToBooleanExtend();
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为bool类型数据(可空)
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static bool? GetBooleanNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            bool.TryParse(dataReader[columnName].ToString(), out bool result);
            return result;
        }

        #endregion

        #region GetByte

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为8位无符号整数
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static byte GetByte(this IDataReader dataReader, string columnName, byte defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            byte.TryParse(dataReader[columnName].ToString(), out byte result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为8位无符号整数(可空)
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static byte? GetByteNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            byte.TryParse(dataReader[columnName].ToString(), out byte result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为8位无符号整数数组
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static byte[] GetBytes(this IDataReader dataReader, string columnName)
        {
            int index = dataReader.GetOrdinal(columnName);
            if (dataReader.IsDBNull(index))
                return null;

            long size = dataReader.GetBytes(index, 0, null, 0, 0);
            byte[] values = new byte[size];
            int bufferSize = 1024;
            long bytesRead = 0;
            int curPos = 0;
            while (bytesRead < size)
            {
                bytesRead += dataReader.GetBytes(index, curPos, values, curPos, bufferSize);
                curPos += bufferSize;
            }
            return values;
        }
        #endregion

        #region GetDateTime

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为DateTime类型数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static DateTime GetDateTime(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetDateTime(columnName, Convert.ToDateTime("1900/01/01 00:00:00"));
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为DateTime类型数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static DateTime GetDateTime(this IDataReader dataReader, string columnName, DateTime defaultValueIfNull)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            DateTime.TryParse(dataReader[columnName].ToString(), out DateTime result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为DateTime类型数据(可空)
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static DateTime? GetDateTimeNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            DateTime.TryParse(dataReader[columnName].ToString(), out DateTime result);
            return result;
        }

        #endregion

        #region GetDecimal

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为decimal类型数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static decimal GetDecimal(this IDataReader dataReader, string columnName, decimal defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            decimal.TryParse(dataReader[columnName].ToString(), out decimal result);
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为decimal类型数据。
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static decimal? GetDecimalNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            decimal.TryParse(dataReader[columnName].ToString(), out decimal result);
            return result;
        }

        #endregion

        #region GetDouble

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为双精度浮点数
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static double GetDouble(this IDataReader dataReader, string columnName, double defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            double.TryParse(dataReader[columnName].ToString(), out double result);
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为双精度浮点数(可空)
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static double? GetDoubleNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            double.TryParse(dataReader[columnName].ToString(), out double result);
            return result;
        }

        #endregion

        #region GetFloat

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为float(Single)类型数据。
        /// 该方法等同于GetSingle()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static float GetFloat(this IDataReader dataReader, string columnName, float defaultValueIfNull = 0)
        {
            return dataReader.GetSingle(columnName, defaultValueIfNull);
        }

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为float(Single)类型数据。
        ///  该方法等同于GetSingleNullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static float? GetFloatNullable(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetSingleNullable(columnName);
        }

        #endregion

        #region GetGuid

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为Guid类型数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static Guid GetGuid(this IDataReader dataReader, string columnName, string defaultValueIfNull = "00000000-0000-0000-0000-000000000000")
        {
            if (dataReader.IsDBNull(columnName))
                return Guid.Parse(defaultValueIfNull);

            Guid.TryParse(dataReader[columnName].ToString(), out Guid result);
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为Guid类型数据(可空)。
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static Guid? GetGuidNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            Guid.TryParse(dataReader[columnName].ToString(), out Guid result);
            return result;
        }

        #endregion

        #region GetInt16 等同于 GetShort

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为16位有符号整数。
        ///  该方法等同于GetShort()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static Int16 GetInt16(this IDataReader dataReader, string columnName, Int16 defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            Int16.TryParse(dataReader[columnName].ToString(), out Int16 result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为16位有符号整数(可空)。
        /// 该方法等同于GetShortNullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static Int16? GetInt16Nullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            Int16.TryParse(dataReader[columnName].ToString(), out Int16 result);
            return result;
        }

        #endregion

        #region GetInt32
        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为32位有符号整数
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static int GetInt32(this IDataReader dataReader, string columnName, Int32 defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            Int32.TryParse(dataReader[columnName].ToString(), out Int32 result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为16位有符号整数(可空)
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static int? GetInt32Nullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            Int32.TryParse(dataReader[columnName].ToString(), out Int32 result);
            return result;
        }

        #endregion

        #region  GetInt64

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为64位有符号整数。
        /// 该方法等同于GetLongNullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static Int64 GetInt64(this IDataReader dataReader, string columnName, Int64 defaultValueIfNull = 0)
        {
            return dataReader.GetLong(columnName, defaultValueIfNull);
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为64位有符号整数(可空)
        /// 该方法等同于GetLongNullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static Int64? GetInt64Nullable(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetLongNullable(columnName);
        }

        #endregion

        #region  GetLong 等同于 GetInt64

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为64位有符号整数。
        /// 该方法等同于GetInt64()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static long GetLong(this IDataReader dataReader, string columnName, long defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            long.TryParse(dataReader[columnName].ToString(), out long result);
            return result;
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为64位有符号整数。
        /// 该方法等同于GetInt64Nullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static long? GetLongNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            long.TryParse(dataReader[columnName].ToString(), out long result);
            return result;
        }

        #endregion

        #region GetShort

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为16位有符号整数。
        /// 该方法等同于GetInt16()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static short GetShort(this IDataReader dataReader, string columnName, short defaultValueIfNull = 0)
        {
            return dataReader.GetInt16(columnName, defaultValueIfNull);
        }

        /// <summary>
        /// 自定义扩展方法：获取指定列名称对应的值，并转换为16位有符号整数(可空)。
        /// 该方法等同于GetInt16Nullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static short? GetShortNullable(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetInt16Nullable(columnName);
        }
        #endregion

        #region GetSingle 等同于 GetFloat

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为单精度浮点数。
        ///  该方法等同于GetFloat()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static Single GetSingle(this IDataReader dataReader, string columnName, Single defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            Single.TryParse(dataReader[columnName].ToString(), out float result);
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为单精度浮点数。
        ///  该方法等同于GetFloatNullable()方法
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static Single? GetSingleNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            Single.TryParse(dataReader[columnName].ToString(), out float result);
            return result;
        }

        #endregion

        #region GetString

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值，并转换为String类型数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <param name="defaultValueIfNull">默认值</param>
        /// <returns></returns>
        public static string GetString(this IDataReader dataReader, string columnName, string defaultValueIfNull = "")
        {
            string result =
                dataReader.IsDBNull(columnName)
                ? defaultValueIfNull
                : dataReader[columnName].ToString();

            return result;
        }
        #endregion

        #region GetValue

        /// <summary>
        ///  自定义扩展方法：获取指定列名称对应的值
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static object GetValue(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            return dataReader.GetValue(dataReader.GetOrdinal(columnName));
        }

        #endregion

        #endregion

        #region 其他

        /// <summary>
        /// 通过列的索引判断该列的值是否为 DBNull
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="i">列的索引</param>
        /// <returns></returns>
        public static bool IsDbNull(this IDataReader dataReader, int i)
        {
            return dataReader.IsDBNull(i);
        }

        /// <summary>
        ///  通过列的索引获取列的名称
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="i">列的索引</param>
        /// <returns></returns>
        public static string GetName(this IDataReader dataReader, int i)
        {
            return dataReader.GetName(i);
        }

        /// <summary>
        ///  返回命名字段的索引
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="name">列的名字</param>
        /// <returns></returns>
        public static int GetOrdinal(this IDataReader dataReader, string name)
        {
            return dataReader.GetOrdinal(name);
        }

        /// <summary>
        /// 返回一个 System.Data.DataTable，它描述 System.Data.IDataReader 的列元数据
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <returns></returns>
        public static DataTable GetSchemaTable(this IDataReader dataReader)
        {
            return dataReader.GetSchemaTable();
        }

        /// <summary>
        ///  获取指定字段的数据类型信息
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="i">列的索引</param>
        /// <returns>指定字段的数据类型信息</returns>
        public static string GetDataTypeName(this IDataReader dataReader, int i)
        {
            return dataReader.GetDataTypeName(i);
        }

        /// <summary>
        ///  获取指定字段的数据类型信息
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="name">列的名称</param>
        /// <returns>指定字段的数据类型信息</returns>
        public static string GetDataTypeName(this IDataReader dataReader, string name)
        {
            return GetDataTypeName(dataReader, dataReader.GetOrdinal(name));
        }

        /// <summary>
        ///  获取索引对应的列的值的数据类型
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="i">列的索引</param>
        /// <returns></returns>
        public static Type GetFieldType(this IDataReader dataReader, int i)
        {
            return dataReader.GetFieldType(i);
        }

        /// <summary>
        ///  获取列名对应的列的值的数据类型
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="name">列的名称</param>
        /// <returns></returns>
        public static Type GetFieldType(this IDataReader dataReader, string name)
        {
            return dataReader.GetFieldType(dataReader.GetOrdinal(name));
        }

        /// <summary>
        ///  返回指定的列序号的 System.Data.IDataReader
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="i">列的索引</param>
        /// <returns></returns>
        public static IDataReader GetData(this IDataReader dataReader, int i)
        {
            return dataReader.GetData(i);
        }

        /// <summary>
        ///  通过列的名称，返回指定的列序号的 System.Data.IDataReader
        /// </summary>
        /// <param name="dataReader">扩展对象</param>
        /// <param name="name">列的名称</param>
        /// <returns></returns>
        public static IDataReader GetData(this IDataReader dataReader, string name)
        {
            return GetData(dataReader, dataReader.GetOrdinal(name));
        }

        #endregion
    }
}