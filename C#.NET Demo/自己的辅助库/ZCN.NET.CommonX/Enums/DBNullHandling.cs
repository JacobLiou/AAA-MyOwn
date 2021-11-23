namespace ZCN.NET.CommonX.Enums
{
    /// <summary>
    ///  IDataReader 转换为实体类时，针对DBNull字段的处理方式
    /// </summary>
    public enum DBNullHandling
    {
        /// <summary>
        ///  设置类型对应的默认值
        /// </summary>
        SetDefaultValue,

        /// <summary>
        ///  忽略，不赋值
        /// </summary>
        Ignore
    }
}