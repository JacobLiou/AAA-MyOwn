namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将字符串形式的Sql类型名称转换为 CSharp 对应的类型名称的字符串形式
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string SqlTypeNameToCSharpTypeName(this string @this)
        {
            switch(@this.ToLower())
            {
                case "image": // 34 | "image" | SqlDbType.Image
                    return "byte[]";

                case "text": // 35 | "text" | SqlDbType.Text
                    return "string";

                case "uniqueidentifier": // 36 | "uniqueidentifier" | SqlDbType.UniqueIdentifier
                    return "Guid";

                case "date": // 40 | "date" | SqlDbType.Date
                    return "DateTime";

                case "time": // 41 | "time" | SqlDbType.Time
                    return "DateTime";

                case "datetime2": // 42 | "datetime2" | SqlDbType.DateTime2
                    return "DateTime";

                case "datetimeoffset": // 43 | "datetimeoffset" | SqlDbType.DateTimeOffset
                    return "DateTimeOffset";

                case "tinyint": // 48 | "tinyint" | SqlDbType.TinyInt
                    return "byte";

                case "smallint": // 52 | "smallint" | SqlDbType.SmallInt
                    return "short";

                case "int": // 56 | "int" | SqlDbType.Int
                    return "int";

                case "smalldatetime": // 58 | "smalldatetime" | SqlDbType.SmallDateTime
                    return "DateTime";

                case "real": // 59 | "real" | SqlDbType.Real
                    return "Single";

                case "money": // 60 | "money" | SqlDbType.Money
                    return "decimal";

                case "datetime": // 61 | "datetime" | SqlDbType.DateTime
                    return "DateTime";

                case "float": // 62 | "float" | SqlDbType.Float
                    return "double";

                case "sql_variant": // 98 | "sql_variant" | SqlDbType.Variant
                    return "object";

                case "ntext": // 99 | "ntext" | SqlDbType.NText
                    return "string";

                case "bit": // 104 | "bit" | SqlDbType.Bit
                    return "bool";

                case "decimal": // 106 | "decimal" | SqlDbType.Decimal
                    return "decimal";

                case "numeric": // 108 | "numeric" | SqlDbType.Decimal
                    return "numeric";

                case "smallmoney": // 122 | "smallmoney" | SqlDbType.SmallMoney
                    return "Single";

                case "bigint": // 127 | "bigint" | SqlDbType.BigInt
                    return "long";

                case "varbinary": // 165 | "varbinary" | SqlDbType.VarBinary
                    return "byte[]";

                case "varchar": // 167 | "varchar" | SqlDbType.VarChar
                    return "string";

                case "binary": // 173 | "binary" | SqlDbType.Binary
                    return "byte[]";

                case "char": // 175 | "char" | SqlDbType.Char
                    return "string";

                case "timestamp": // 189 | "timestamp" | SqlDbType.Timestamp
                    return "object";

                case "nvarchar": // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                    return "string";
                case "sysname": // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                    return "string";

                case "nchar": // 239 | "nchar" | SqlDbType.NChar
                    return "string";

                case "hierarchyid": // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                    return "object";
                case "geometry": // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                    return "object";
                case "geography": // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                    return "object";

                case "xml": // 241 | "xml" | SqlDbType.Xml
                    return "string";

                default:
                    throw new System.Exception(string.Format("暂不支持该类型: {0}", @this));
            }
        }
    }
}