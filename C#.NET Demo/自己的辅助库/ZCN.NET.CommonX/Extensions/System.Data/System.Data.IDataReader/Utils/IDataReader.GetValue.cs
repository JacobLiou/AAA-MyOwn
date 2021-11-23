using System;
using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region GetValue 

        #region GetBoolean

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊbool��������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static bool GetBoolean(this IDataReader dataReader, string columnName, bool defaultValueIfNull = false)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            bool.TryParse(dataReader[columnName].ToString(), out bool result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊbool�������ݡ�
        ///  �ǡ���true��false��Y��N��Yes��no(���Դ�Сд)������������ת���ɹ�(С�ڵ���0������ת��Ϊ false������0������ת��Ϊ true)��
        ///  ��� value Ϊ null ���� DBNull����˷������� false��
        ///  ���ת��ʧ���򷵻� bool ���͵�Ĭ��ֵ
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static bool GetBoolean2(this IDataReader dataReader, string columnName, bool defaultValueIfNull = false)
        {
            string str = dataReader[columnName].ToString();
            return str.ToBooleanExtend();
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊbool��������(�ɿ�)
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ8λ�޷�������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static byte GetByte(this IDataReader dataReader, string columnName, byte defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            byte.TryParse(dataReader[columnName].ToString(), out byte result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ8λ�޷�������(�ɿ�)
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static byte? GetByteNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            byte.TryParse(dataReader[columnName].ToString(), out byte result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ8λ�޷�����������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��ΪDateTime��������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static DateTime GetDateTime(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetDateTime(columnName, Convert.ToDateTime("1900/01/01 00:00:00"));
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��ΪDateTime��������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static DateTime GetDateTime(this IDataReader dataReader, string columnName, DateTime defaultValueIfNull)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            DateTime.TryParse(dataReader[columnName].ToString(), out DateTime result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��ΪDateTime��������(�ɿ�)
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊdecimal��������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static decimal GetDecimal(this IDataReader dataReader, string columnName, decimal defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            decimal.TryParse(dataReader[columnName].ToString(), out decimal result);
            return result;
        }

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊdecimal�������ݡ�
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ˫���ȸ�����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static double GetDouble(this IDataReader dataReader, string columnName, double defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            double.TryParse(dataReader[columnName].ToString(), out double result);
            return result;
        }

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ˫���ȸ�����(�ɿ�)
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊfloat(Single)�������ݡ�
        /// �÷�����ͬ��GetSingle()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static float GetFloat(this IDataReader dataReader, string columnName, float defaultValueIfNull = 0)
        {
            return dataReader.GetSingle(columnName, defaultValueIfNull);
        }

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊfloat(Single)�������ݡ�
        ///  �÷�����ͬ��GetSingleNullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static float? GetFloatNullable(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetSingleNullable(columnName);
        }

        #endregion

        #region GetGuid

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��ΪGuid��������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static Guid GetGuid(this IDataReader dataReader, string columnName, string defaultValueIfNull = "00000000-0000-0000-0000-000000000000")
        {
            if (dataReader.IsDBNull(columnName))
                return Guid.Parse(defaultValueIfNull);

            Guid.TryParse(dataReader[columnName].ToString(), out Guid result);
            return result;
        }

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��ΪGuid��������(�ɿ�)��
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static Guid? GetGuidNullable(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            Guid.TryParse(dataReader[columnName].ToString(), out Guid result);
            return result;
        }

        #endregion

        #region GetInt16 ��ͬ�� GetShort

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ16λ�з���������
        ///  �÷�����ͬ��GetShort()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static Int16 GetInt16(this IDataReader dataReader, string columnName, Int16 defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            Int16.TryParse(dataReader[columnName].ToString(), out Int16 result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ16λ�з�������(�ɿ�)��
        /// �÷�����ͬ��GetShortNullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ32λ�з�������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static int GetInt32(this IDataReader dataReader, string columnName, Int32 defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            Int32.TryParse(dataReader[columnName].ToString(), out Int32 result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ16λ�з�������(�ɿ�)
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ64λ�з���������
        /// �÷�����ͬ��GetLongNullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static Int64 GetInt64(this IDataReader dataReader, string columnName, Int64 defaultValueIfNull = 0)
        {
            return dataReader.GetLong(columnName, defaultValueIfNull);
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ64λ�з�������(�ɿ�)
        /// �÷�����ͬ��GetLongNullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static Int64? GetInt64Nullable(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetLongNullable(columnName);
        }

        #endregion

        #region  GetLong ��ͬ�� GetInt64

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ64λ�з���������
        /// �÷�����ͬ��GetInt64()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static long GetLong(this IDataReader dataReader, string columnName, long defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            long.TryParse(dataReader[columnName].ToString(), out long result);
            return result;
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ64λ�з���������
        /// �÷�����ͬ��GetInt64Nullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ16λ�з���������
        /// �÷�����ͬ��GetInt16()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static short GetShort(this IDataReader dataReader, string columnName, short defaultValueIfNull = 0)
        {
            return dataReader.GetInt16(columnName, defaultValueIfNull);
        }

        /// <summary>
        /// �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ16λ�з�������(�ɿ�)��
        /// �÷�����ͬ��GetInt16Nullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static short? GetShortNullable(this IDataReader dataReader, string columnName)
        {
            return dataReader.GetInt16Nullable(columnName);
        }
        #endregion

        #region GetSingle ��ͬ�� GetFloat

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ�����ȸ�������
        ///  �÷�����ͬ��GetFloat()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
        /// <returns></returns>
        public static Single GetSingle(this IDataReader dataReader, string columnName, Single defaultValueIfNull = 0)
        {
            if (dataReader.IsDBNull(columnName))
                return defaultValueIfNull;

            Single.TryParse(dataReader[columnName].ToString(), out float result);
            return result;
        }

        /// <summary>
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��Ϊ�����ȸ�������
        ///  �÷�����ͬ��GetFloatNullable()����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
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
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ����ת��ΪString��������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <param name="defaultValueIfNull">Ĭ��ֵ</param>
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
        ///  �Զ�����չ��������ȡָ�������ƶ�Ӧ��ֵ
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="columnName">�е�����</param>
        /// <returns></returns>
        public static object GetValue(this IDataReader dataReader, string columnName)
        {
            if (dataReader.IsDBNull(columnName))
                return null;

            return dataReader.GetValue(dataReader.GetOrdinal(columnName));
        }

        #endregion

        #endregion

        #region ����

        /// <summary>
        /// ͨ���е������жϸ��е�ֵ�Ƿ�Ϊ DBNull
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="i">�е�����</param>
        /// <returns></returns>
        public static bool IsDbNull(this IDataReader dataReader, int i)
        {
            return dataReader.IsDBNull(i);
        }

        /// <summary>
        ///  ͨ���е�������ȡ�е�����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="i">�е�����</param>
        /// <returns></returns>
        public static string GetName(this IDataReader dataReader, int i)
        {
            return dataReader.GetName(i);
        }

        /// <summary>
        ///  ���������ֶε�����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="name">�е�����</param>
        /// <returns></returns>
        public static int GetOrdinal(this IDataReader dataReader, string name)
        {
            return dataReader.GetOrdinal(name);
        }

        /// <summary>
        /// ����һ�� System.Data.DataTable�������� System.Data.IDataReader ����Ԫ����
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <returns></returns>
        public static DataTable GetSchemaTable(this IDataReader dataReader)
        {
            return dataReader.GetSchemaTable();
        }

        /// <summary>
        ///  ��ȡָ���ֶε�����������Ϣ
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="i">�е�����</param>
        /// <returns>ָ���ֶε�����������Ϣ</returns>
        public static string GetDataTypeName(this IDataReader dataReader, int i)
        {
            return dataReader.GetDataTypeName(i);
        }

        /// <summary>
        ///  ��ȡָ���ֶε�����������Ϣ
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="name">�е�����</param>
        /// <returns>ָ���ֶε�����������Ϣ</returns>
        public static string GetDataTypeName(this IDataReader dataReader, string name)
        {
            return GetDataTypeName(dataReader, dataReader.GetOrdinal(name));
        }

        /// <summary>
        ///  ��ȡ������Ӧ���е�ֵ����������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="i">�е�����</param>
        /// <returns></returns>
        public static Type GetFieldType(this IDataReader dataReader, int i)
        {
            return dataReader.GetFieldType(i);
        }

        /// <summary>
        ///  ��ȡ������Ӧ���е�ֵ����������
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="name">�е�����</param>
        /// <returns></returns>
        public static Type GetFieldType(this IDataReader dataReader, string name)
        {
            return dataReader.GetFieldType(dataReader.GetOrdinal(name));
        }

        /// <summary>
        ///  ����ָ��������ŵ� System.Data.IDataReader
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="i">�е�����</param>
        /// <returns></returns>
        public static IDataReader GetData(this IDataReader dataReader, int i)
        {
            return dataReader.GetData(i);
        }

        /// <summary>
        ///  ͨ���е����ƣ�����ָ��������ŵ� System.Data.IDataReader
        /// </summary>
        /// <param name="dataReader">��չ����</param>
        /// <param name="name">�е�����</param>
        /// <returns></returns>
        public static IDataReader GetData(this IDataReader dataReader, string name)
        {
            return GetData(dataReader, dataReader.GetOrdinal(name));
        }

        #endregion
    }
}