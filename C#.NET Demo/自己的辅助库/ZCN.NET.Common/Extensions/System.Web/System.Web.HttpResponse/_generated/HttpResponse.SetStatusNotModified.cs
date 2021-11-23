#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 304
        ///  (Not Modified �ͻ����л�����ĵ���������һ�������Ե�����һ�����ṩIf-Modified-Sinceͷ��ʾ�ͻ�ֻ���ָ�����ڸ��µ��ĵ�����
        ///   ���������߿ͻ���ԭ��������ĵ������Լ���ʹ��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusNotModified(this HttpResponse @this)
        {
            @this.StatusCode = 304;
            //@this.StatusDescription = "Not Modified �ͻ����л�����ĵ���������һ�������Ե�����һ�����ṩIf-Modified-Sinceͷ��ʾ�ͻ�ֻ���ָ�����ڸ��µ��ĵ��������������߿ͻ���ԭ��������ĵ������Լ���ʹ��";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 304
        ///  (Not Modified �ͻ����л�����ĵ���������һ�������Ե�����һ�����ṩIf-Modified-Sinceͷ��ʾ�ͻ�ֻ���ָ�����ڸ��µ��ĵ�����
        ///   ���������߿ͻ���ԭ��������ĵ������Լ���ʹ��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusNotModified(this HttpResponse @this)
        {
            @this.StatusCode = 304;
            @this.StatusDescription = "Not Modified �ͻ����л�����ĵ���������һ�������Ե�����һ�����ṩIf-Modified-Sinceͷ��ʾ�ͻ�ֻ���ָ�����ڸ��µ��ĵ��������������߿ͻ���ԭ��������ĵ������Լ���ʹ��";
        }
    }
}

#endif