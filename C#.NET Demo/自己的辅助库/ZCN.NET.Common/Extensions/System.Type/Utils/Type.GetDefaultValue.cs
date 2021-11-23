using System;
using System.Data;

using ZCN.NET.Common.Utils;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>  
        /// 自定义扩展方法：获取值为DBNull的字段默认值（一般多用于从IDataReader转换为实体类等场景）  
        /// </summary>  
        /// <param name="dbType">数据类型</param>  
        /// <returns>返回的默认值</returns>  
        public static object GetDBNullDefaultValue(this Type dbType)
        {
            object result = default(DbType);

            if (dbType.IsStringType())
                result = String.Empty;

            if (dbType.IsDateTimeType())
                return DateTimeUtils.MiniValue;

            return result;

            #region 下面的更详细的判断
            //if (dbType.IsBooleanType())
            //    return false;

            //if (dbType.IsCharType())
            //    return '\0';

            //if (dbType.IsStringType())
            //    return "";

            //if (dbType.IsDateTimeType())
            //    return DateTimeUtils.MiniValue;

            //if (dbType.IsNumericType())
            //    return 0;

            //if (dbType.IsDecimalType())
            //    return 0.0m;

            //if (dbType.IsDoubleType())
            //    return 0.0d;

            //if (dbType.IsFloatType())
            //    return 0.0f;

            //if (dbType.IsTimeSpanType())
            //    return default(TimeSpan);

            //if (dbType.IsDateTimeOffsetType())
            //    return default(DateTimeOffset);

            //if (dbType.IsObjectType())
            //    return null;

            //return null;

            #endregion
        }
    }
}