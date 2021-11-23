using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 408
        ///  (Request Timeout �ڷ�������ɵĵȴ�ʱ���ڣ��ͻ�һֱû�з����κ����󡣿ͻ��������Ժ��ظ�ͬһ����)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusRequestTimedOut(this HttpResponse @this)
        {
            @this.StatusCode = 408;
            //@this.StatusDescription = "Request Timeout �ڷ�������ɵĵȴ�ʱ���ڣ��ͻ�һֱû�з����κ����󡣿ͻ��������Ժ��ظ�ͬһ����";
        }
    }
}