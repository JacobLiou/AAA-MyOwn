using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 100
        ///  (Continue ��ʼ�������Ѿ����ܣ��ͻ�Ӧ������������������ಿ��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusContinue(this HttpResponse @this)
        {
            @this.StatusCode = 100;
            //@this.StatusDescription = @"Continue ��ʼ�������Ѿ����ܣ��ͻ�Ӧ������������������ಿ��";
        }
    }
}