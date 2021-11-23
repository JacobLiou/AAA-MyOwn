namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 DataType 或 DataType.Name 类型转换为 CSharp 对应的类型名称的字符串形式
        /// </summary>
        /// <param name="dataTypeName">数据类型名称</param>
        /// <param name="isNullable">是否转换为Nullable类型。默认值为true</param>
        /// <returns></returns>
        public static string ToCSharpTypeName(this string dataTypeName,bool isNullable = true)
        {
            string result = "";

            if(dataTypeName.IsNotNullAndWhiteSpace())
            {
                if(dataTypeName.StartsWith("System."))
                {
                    dataTypeName = dataTypeName.Replace("System.","");
                }

                if(dataTypeName == "Byte")
                {
                    result = "byte";
                }
                else if(dataTypeName == "Byte[]")
                {
                    result = "byte[]";
                }
                else if(dataTypeName == "Boolean")
                {
                    result = isNullable ? "bool?" : "bool";
                }
                else if(dataTypeName == "Char")
                {
                    result = isNullable ? "char?" : "bool";
                }
                else if(dataTypeName == "DateTime")
                {
                    result = isNullable ? "DateTime?" : "DateTime";
                }
                else if(dataTypeName == "Decimal")
                {
                    result = isNullable ? "decimal?" : "decimal";
                }
                else if(dataTypeName == "Double")
                {
                    result = isNullable ? "double?" : "double";
                }
                else if(dataTypeName == "Guid")
                {
                    result = isNullable ? "Guid?" : "Guid";
                }
                else if(dataTypeName.StartsWith("Int"))
                {
                    // Int16、 In32、Int64
                    result = isNullable ? dataTypeName + "?" : dataTypeName;
                }
                else if(dataTypeName == "Single")
                {
                    result = isNullable ? "float?" : "float";
                }
                else if(dataTypeName == "String")
                {
                    result = "string";
                }
                else
                {
                    result = "object";
                }

            }

            return result;
        }
    }
}