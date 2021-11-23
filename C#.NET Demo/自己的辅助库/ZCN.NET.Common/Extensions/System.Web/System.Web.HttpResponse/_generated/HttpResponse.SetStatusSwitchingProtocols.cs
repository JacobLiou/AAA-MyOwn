#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 101
        ///  (Switching Protocols ����������ӿͻ�������ת��������һ��Э��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusSwitchingProtocols(this HttpResponse @this)
        {
            @this.StatusCode = 101;
            //@this.StatusDescription = "Switching Protocols ����������ӿͻ�������ת��������һ��Э��";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 101
        ///  (Switching Protocols ����������ӿͻ�������ת��������һ��Э��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusSwitchingProtocols(this HttpResponse @this)
        {
            @this.StatusCode = 101;
            @this.StatusDescription = "Switching Protocols ����������ӿͻ�������ת��������һ��Э��";
        }
    }
}

#endif