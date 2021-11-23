using System.Text;

namespace ZCN.NET.CommonX.Exceptions
{
    /// <summary>
    ///     自定义异常信息类
    /// </summary>
    public class ExceptionMessage
    {
        #region 构造函数

        /// <summary>
        ///     以自定义用户信息和异常对象实例化一个异常信息对象
        /// </summary>
        /// <param name="ex">异常对</param>
        /// <param name="userCustomMessage">自定义用户信息</param>
        /// <param name="isHideStackTrace">是否隐藏异常堆栈信息</param>
        public ExceptionMessage(System.Exception ex, string userCustomMessage = null, bool isHideStackTrace = false)
        {
            UserMessage = string.IsNullOrWhiteSpace(userCustomMessage) ? ex.Message : userCustomMessage;
            ExMessage = string.Empty;

            StringBuilder sb = new StringBuilder();

            int count = 0;
            string appString = "";

            while(ex != null)
            {
                if(count > 0)
                {
                    appString += "　";
                }

                ExMessage = ex.Message;

                sb.AppendLine(appString + "异常消息：" + ex.Message);
                sb.AppendLine(appString + "异常类型：" + ex.GetType().FullName);
                sb.AppendLine(appString + "异常方法：" + (ex.TargetSite == null ? null : ex.TargetSite.Name));
                sb.AppendLine(appString + "异常源：" + ex.Source);

                if(!isHideStackTrace && ex.StackTrace != null)
                {
                    sb.AppendLine(appString + "异常堆栈：" + ex.StackTrace);
                }

                if(ex.InnerException != null)
                {
                    sb.AppendLine(appString + "内部异常：");
                    count++;
                }

                ex = ex.InnerException;
            }

            ErrorDetails = sb.ToString();

            sb.Clear();
        }

        #endregion

        #region 字段

        #endregion

        #region 属性

        /// <summary>
        ///     用户信息，用于报告给用户的异常消息
        /// </summary>
        public string UserMessage { get; set; }

        /// <summary>
        ///     直接的Exception异常信息，即ex.Message属性值
        /// </summary>
        public string ExMessage { get; }

        /// <summary>
        ///     异常输出的详细描述，包含异常消息，规模信息，异常类型，异常源，引发异常的方法及内部异常信息
        /// </summary>
        public string ErrorDetails { get; }

        #endregion
    }
}