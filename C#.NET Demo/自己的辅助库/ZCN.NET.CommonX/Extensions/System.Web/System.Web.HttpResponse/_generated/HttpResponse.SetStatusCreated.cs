using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 210
        ///  (Created �������Ѿ��������ĵ���Locationͷ����������URL)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusCreated(this HttpResponse @this)
        {
            @this.StatusCode = 201;
            //@this.StatusDescription = "Created �������Ѿ��������ĵ���Locationͷ����������URL";
        }
    }
}