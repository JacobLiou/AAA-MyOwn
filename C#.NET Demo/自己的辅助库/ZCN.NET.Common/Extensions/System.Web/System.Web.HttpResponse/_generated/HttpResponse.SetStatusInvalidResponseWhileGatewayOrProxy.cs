#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 502
        ///  (Bad Gateway ��������Ϊ���ػ��ߴ���ʱ��Ϊ��������������һ�������������÷����������˷Ƿ���Ӧ�� 
        ///   ����˵Web �������������ػ���������ʱ�յ�����Ч��Ӧ)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusInvalidResponseWhileGatewayOrProxy(this HttpResponse @this)
        {
            @this.StatusCode = 502;
            //@this.StatusDescription = @"Bad Gateway ��������Ϊ���ػ��ߴ���ʱ��Ϊ��������������һ�������������÷����������˷Ƿ���Ӧ�� ����˵Web �������������ػ���������ʱ�յ�����Ч��Ӧ";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 502
        ///  (Bad Gateway ��������Ϊ���ػ��ߴ���ʱ��Ϊ��������������һ�������������÷����������˷Ƿ���Ӧ�� 
        ///   ����˵Web �������������ػ���������ʱ�յ�����Ч��Ӧ)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusInvalidResponseWhileGatewayOrProxy(this HttpResponse @this)
        {
            @this.StatusCode = 502;
            @this.StatusDescription = @"Bad Gateway ��������Ϊ���ػ��ߴ���ʱ��Ϊ��������������һ�������������÷����������˷Ƿ���Ӧ�� ����˵Web �������������ػ���������ʱ�յ�����Ч��Ӧ";
        }
    }
}

#endif