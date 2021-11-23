namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///   windows系统身份认证操作工具类
    /// </summary>
    public static class WindowsIdentityUtility
    {
        /// <summary>
        ///   检查当前系统的登录身份是否是管理员
        /// </summary>
        /// <returns></returns>
        public static bool CheckCurrentLoginUserIsAdministrator()
        {
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
    }
}