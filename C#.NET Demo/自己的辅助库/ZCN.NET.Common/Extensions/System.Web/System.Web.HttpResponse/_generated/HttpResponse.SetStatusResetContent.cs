#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 205
        ///  (Reset Content û���µ����ݣ��������Ӧ������������ʾ�����ݡ�����ǿ��������������������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusResetContent(this HttpResponse @this)
        {
            @this.StatusCode = 205;
            //@this.StatusDescription = "Reset Content û���µ����ݣ��������Ӧ������������ʾ�����ݡ�����ǿ��������������������";
        }
    }
}

#elif NETFRAMEWORK

using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 205
        ///  (Reset Content û���µ����ݣ��������Ӧ������������ʾ�����ݡ�����ǿ��������������������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusResetContent(this HttpResponse @this)
        {
            @this.StatusCode = 205;
            @this.StatusDescription = "Reset Content û���µ����ݣ��������Ӧ������������ʾ�����ݡ�����ǿ��������������������";
        }
    }
}

#endif