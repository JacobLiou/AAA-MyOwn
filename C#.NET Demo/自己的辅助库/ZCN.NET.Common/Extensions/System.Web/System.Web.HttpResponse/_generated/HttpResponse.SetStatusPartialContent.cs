#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 206
        ///  (Partial Content �ͻ�������һ������Rangeͷ��GET���󣨷ֿ����󣩣��������������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusPartialContent(this HttpResponse @this)
        {
            @this.StatusCode = 206;
            //@this.StatusDescription = "Partial Content �ͻ�������һ������Rangeͷ��GET���󣨷ֿ����󣩣��������������";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 206
        ///  (Partial Content �ͻ�������һ������Rangeͷ��GET���󣨷ֿ����󣩣��������������)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusPartialContent(this HttpResponse @this)
        {
            @this.StatusCode = 206;
            @this.StatusDescription = "Partial Content �ͻ�������һ������Rangeͷ��GET���󣨷ֿ����󣩣��������������";
        }
    }
}

#endif