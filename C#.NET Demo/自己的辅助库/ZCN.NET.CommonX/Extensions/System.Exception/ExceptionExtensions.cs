using System;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///     自定义扩展方法：递归获取所有异常信息（包含异常对象的所有内部异常信息）
        /// </summary>
        /// <param name="ex">表达式</param>
        /// <returns></returns>
        public static string GetAllExceptionMessage(this Exception ex)
        {
            if (ex == null)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            Exception exception = ex;
            while (exception != null)
            {
                sb.AppendLine(exception.Message + " ");
                exception = exception.InnerException;
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}