using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 503
        ///  (Service Unavailable ���񲻿��ã�����������ά�����߸��ع���δ��Ӧ��
        ///  ���磬Servlet���������ݿ����ӳ�����������·���503������������503ʱ�����ṩһ�� Retry-Afterͷ������������Ϊ IIS 6.0 ��ר��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusServiceUnavailable(this HttpResponse @this)
        {
            @this.StatusCode = 503;
            //@this.StatusDescription = @"Service Unavailable ���񲻿��ã�����������ά�����߸��ع���δ��Ӧ�����磬Servlet���������ݿ����ӳ�����������·���503������������503ʱ�����ṩһ�� Retry-Afterͷ������������Ϊ IIS 6.0 ��ר��";
        }
    }
}