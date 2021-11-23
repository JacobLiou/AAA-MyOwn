#if NETFRAMEWORK

using System.Web;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///  JS 操作工具类。类中的方法适用于WebForm项目中，如果是MVC项目，弹框一般是调用封装的的div层。
    /// </summary>
    public static class JsUtils
    {
        /// <summary>
        /// 弹出提示信息
        /// </summary>
        /// <param name="message">提示信息</param>
        public static void Alert(string message)
        {
            string js = "<script language=javascript>alert('{0}');</script>";
            HttpContext.Current.Response.Write(string.Format(js, message));
        }

        /// <summary>
        /// 弹出提示信息,并跳转到指定页面
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="toUrl">指定页面</param>
        public static void AlertAndRedirect(string message, string toUrl)
        {
            string js = "<script language=javascript>alert('{0}');window.location.replace('{1}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, toUrl));
            HttpContext.Current.Response.End();
        }

        /// <summary>
        /// 弹出提示信息,并返回历史页面
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="value">history.go()具体的返回页面索引</param>
        public static void AlertAndGoHistory(string message, int value)
        {
            string js = @"<Script language='JavaScript'>alert('{0}');history.go({1});</Script>";
            HttpContext.Current.Response.Write(string.Format(js, message, value));
            HttpContext.Current.Response.End();
        }

        /// <summary>
        /// 直接跳转到指定的页面
        /// </summary>
        public static void Redirect(string toUrl)
        {
            string js = @"<script language=javascript>window.location.replace('{0}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, toUrl));
        }

        /// <summary>
        /// 弹出提示信息 并在父窗口中打开指定页面
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="toUrl">指定页面</param>
        public static void AlertAndRedirectToParentUrl(string message, string toUrl)
        {
            string js = "<script language=javascript>alert('{0}');window.top.location.replace('{1}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, toUrl));
        }

        /// <summary>
        /// 在父窗口中打开指定页面
        /// </summary>
        /// <param name="toUrl">指定页面</param>
        public static void RedirectToParentUrl(string toUrl)
        {
            string js = "<script language=javascript>window.top.location.replace('{0}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, toUrl));
        }

        /// <summary>
        /// 返回历史页面
        /// </summary>
        /// <param name="value">history.go()具体的返回页面索引</param>
        public static void GoHistory(int value)
        {
            string js = @"<Script language='JavaScript'>history.go({0});</Script>";
            HttpContext.Current.Response.Write(string.Format(js, value));
            HttpContext.Current.Response.End();
        }

        /// <summary>
        /// 注册脚本块
        /// </summary>
        /// <param name="page">具体的页面对象</param>
        /// <param name="scriptString">脚本内容</param>
        public static void RegisterScriptBlock(System.Web.UI.Page page, string scriptString)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "scriptblock", "<script type='text/javascript'>" + scriptString + "</script>");
        }
    }
}


#endif