#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 500
        ///  (Internal Server Error ���������������ϲ����������������ɿͻ�������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusInternalServerError(this HttpResponse @this)
        {
            @this.StatusCode = 500;
            //@this.StatusDescription = "Internal Server Error ���������������ϲ����������������ɿͻ�������";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 500
        ///  (Internal Server Error ���������������ϲ����������������ɿͻ�������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusInternalServerError(this HttpResponse @this)
        {
            @this.StatusCode = 500;
            @this.StatusDescription = "Internal Server Error ���������������ϲ����������������ɿͻ�������";
        }
    }
}

#endif