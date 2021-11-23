namespace ZCN.NET.CommonX.Logging
{
    /// <summary>
    ///     日志级别
    /// </summary>
    internal enum LogLevel
    {
        /// <summary>
        ///     致命异常
        /// </summary>
        Fatal,

        /// <summary>
        ///     错误
        /// </summary>
        Error,

        /// <summary>
        ///     警告
        /// </summary>
        Warn,

        /// <summary>
        ///     信息
        /// </summary>
        Info,

        /// <summary>
        ///     跟踪(一般用于开发与测试阶段)。Trace 在 Debug 与 Release 状态下都会输出。
        /// </summary>
        Trace,

        /// <summary>
        ///     调试(一般用于开发阶段)。Debug 只在 Debug 状态下会输出。
        /// </summary>
        Debug
    }
}