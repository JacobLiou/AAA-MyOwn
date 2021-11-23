using System;
using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 SqlDbType 转换为 CSharp 数据类型
        /// </summary>
        /// <param name="sqlDbType">扩展对象</param>
        /// <returns></returns>
        public static Type SqlDbTypeToCSharpType(this SqlDbType sqlDbType)
        {
            switch(sqlDbType)
            {
                case SqlDbType.BigInt:
                    return typeof(long);//Int64
                case SqlDbType.Binary:
                    return typeof(byte[]);//Object
                case SqlDbType.Bit:
                    return typeof(bool);//Boolean
                case SqlDbType.Char:
                    return typeof(string);//String
                case SqlDbType.DateTime:
                    return typeof(DateTime);
                case SqlDbType.Decimal:
                    return typeof(decimal);//Decimal
                case SqlDbType.Float:
                    return typeof(double);//Double
                case SqlDbType.Image:
                    return typeof(byte[]);//Object
                case SqlDbType.Int:
                    return typeof(int);//Int32
                case SqlDbType.Money:
                    return typeof(decimal);//Decimal
                case SqlDbType.NChar:
                    return typeof(string); //String
                case SqlDbType.NText:
                    return typeof(string); //String
                case SqlDbType.NVarChar:
                    return typeof(string); //String
                case SqlDbType.Real:
                    return typeof(Single);//Single
                case SqlDbType.SmallDateTime:
                    return typeof(DateTime);
                case SqlDbType.SmallInt:
                    return typeof(short);//Int16
                case SqlDbType.SmallMoney:
                    return typeof(decimal);//Decimal
                case SqlDbType.Text:
                    return typeof(string);//String
                case SqlDbType.Timestamp:
                    return typeof(object);//Object
                case SqlDbType.TinyInt:
                    return typeof(byte);//Byte
                case SqlDbType.Udt:              //自定义的数据类型
                    return typeof(object);//Object
                case SqlDbType.UniqueIdentifier:
                    return typeof(object);//Object
                case SqlDbType.VarBinary:
                    return typeof(object);//Object
                case SqlDbType.VarChar:
                    return typeof(string);//String
                case SqlDbType.Variant:
                    return typeof(object);//Object
                case SqlDbType.Xml:
                    return typeof(object);//Object
                default:
                    return typeof(object);
            }
        }
    }
}