
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region 判断数据类型

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否是可变长度字符串类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool IsVariableString(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            return (dataType == "VARCHAR2" ||
                    dataType == "NVARCHAR2" ||
                    dataType == "NVARCHAR" ||
                    dataType == "VARCHAR" ||
                    dataType == "LONG VARCHAR" ||
                    dataType == "CHARACTER VARYING" ||
                    dataType == "TEXT" ||
                    dataType == "NTEXT" ||
                    dataType == "CHAR VARYING");
        }

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否是固定长度字符串类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool IsFixedLengthString(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            return (dataType == "NCHAR" ||
                    dataType == "CHAR" ||
                    dataType == "BPCHAR" ||
                    dataType == "CHARACTER");
        }

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否是长字符串类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool IsLongString(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();
            return (dataType == "TEXT" ||
                    dataType == "CLOB" ||
                    dataType == "DBCLOB" ||
                    dataType == "NTEXT");
        }

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否是二进制类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool IsBinary(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            return (dataType == "VARBINARY" ||
                    dataType == "RAW" ||
                    dataType == "LONG RAW" ||
                    dataType == "TINYBLOB" ||
                    dataType == "BYTEA" ||
                    dataType == "GRAPHIC" ||
                    dataType == "VARGRAPHIC" ||
                    dataType == "LONG VARGRAPHIC");
        }

        /// <summary>
        /// 自定义扩展方法：判数据库中的断数据类型是否是 Blob 类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public static bool IsBlob(this string dataType, int? length)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            //special case SQLServer
            if (dataType == "VARBINARY" && length == -1)
            {
                return true; //VARBINARY(MAX)
            }

            return (dataType == "BLOB" ||
                    dataType == "MEDIUMBLOB" ||
                    dataType == "LONGBLOB" ||
                    dataType == "IMAGE" ||
                    dataType == "OID");
        }

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否有精度
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool HasPrecision(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            return (dataType == "DEC" ||
                    dataType == "DECIMAL" ||
                    dataType == "NUMBER" ||
                    dataType == "NUMERIC" ||
                    dataType == "FLOAT" ||
                    dataType == "DOUBLE" ||
                    dataType == "DOUBLE PRECISION");
        }

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否是 DateTime 类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool IsDateTime(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            return (dataType == "DATETIME" ||
                    dataType == "DATETIME2" ||
                    dataType == "TIMESTAMP" ||
                    dataType == "SMALLDATETIME");
        }

        /// <summary>
        /// 自定义扩展方法：判断数据库中的数据类型是否是 Integer 类型
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns></returns>
        public static bool IsInteger(this string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                return false;
            }

            dataType = dataType.ToUpper();

            return (dataType == "INTEGER" ||
                    dataType == "INT" ||
                    dataType == "BIGINT" ||
                    dataType == "SMALLINT" ||
                    dataType == "TINYINT");
        }

        /// <summary>
        /// 自定义扩展方法：将 Oracle 数据库类型 Number 转换为字符串形式数据类型名称
        /// </summary>
        /// <param name="precision">精度</param>
        /// <param name="scale">数值范围</param>
        /// <returns></returns>
        public static string OracleNumberConversion(int? precision, int? scale)
        {
            //这是 Oracle NUMBER (不是普通的 NUMERIC)
            if (precision < 38 && scale == 0) return "INTEGER";
            if (precision == 1 && scale == 0) return "BIT";
            if (precision == 18 && scale == 0) return "DECIMAL";
            if (precision == 15 && scale == 4) return "MONEY";
            return "NUMERIC";
        }

        #endregion
    }
}