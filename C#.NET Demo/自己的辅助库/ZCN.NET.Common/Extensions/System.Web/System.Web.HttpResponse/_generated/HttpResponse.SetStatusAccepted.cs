#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 202(Accepted �Ѿ��������󣬵�������δ���)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusAccepted(this HttpResponse @this)
        {
            @this.StatusCode = 202;
            // @this.StatusDescription = "Accepted �Ѿ��������󣬵�������δ���";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 202(Accepted �Ѿ��������󣬵�������δ���)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusAccepted(this HttpResponse @this)
        {
            @this.StatusCode = 202;
            @this.StatusDescription = "Accepted �Ѿ��������󣬵�������δ���";
        }
    }
}

#endif