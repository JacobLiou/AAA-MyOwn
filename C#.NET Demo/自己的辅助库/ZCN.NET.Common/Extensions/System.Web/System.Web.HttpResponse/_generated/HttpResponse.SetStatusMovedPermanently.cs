#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 405
        ///  (Method Not Allowed ���󷽷���GET��POST��HEAD��DELETE��PUT��TRACE�ȣ���ָ������Դ�����ã�
        ///   �������ʱ�ҳ��� HTTP ν�ʲ�������������������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusMovedPermanently(this HttpResponse @this)
        {
            @this.StatusCode = 301;
            //@this.StatusDescription = "Moved permanently.";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 405
        ///  (Method Not Allowed ���󷽷���GET��POST��HEAD��DELETE��PUT��TRACE�ȣ���ָ������Դ�����ã�
        ///   �������ʱ�ҳ��� HTTP ν�ʲ�������������������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusMovedPermanently(this HttpResponse @this)
        {
            @this.StatusCode = 301;
            @this.StatusDescription = "Moved permanently.";
        }
    }
}

#endif