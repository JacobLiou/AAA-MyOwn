#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 203
        ///  (Non-Authoritative Information �ĵ��Ѿ������ط��أ���һЩӦ��ͷ���ܲ���ȷ��
        ///  ��Ϊʹ�õ����ĵ��Ŀ�������Ȩ������Ϣ)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusNonAuthoritativeInformation(this HttpResponse @this)
        {
            @this.StatusCode = 203;
            //@this.StatusDescription = "Non-Authoritative Information �ĵ��Ѿ������ط��أ���һЩӦ��ͷ���ܲ���ȷ����Ϊʹ�õ����ĵ��Ŀ�������Ȩ������Ϣ";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 203
        ///  (Non-Authoritative Information �ĵ��Ѿ������ط��أ���һЩӦ��ͷ���ܲ���ȷ��
        ///  ��Ϊʹ�õ����ĵ��Ŀ�������Ȩ������Ϣ)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusNonAuthoritativeInformation(this HttpResponse @this)
        {
            @this.StatusCode = 203;
            @this.StatusDescription = "Non-Authoritative Information �ĵ��Ѿ������ط��أ���һЩӦ��ͷ���ܲ���ȷ����Ϊʹ�õ����ĵ��Ŀ�������Ȩ������Ϣ��";
        }
    }
}

#endif