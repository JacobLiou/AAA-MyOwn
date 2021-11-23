using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 404
        ///  (Not Found �޷��ҵ�ָ��λ�õ���Դ)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusNotFound(this HttpResponse @this)
        {
            @this.StatusCode = 404;
            //@this.StatusDescription = " Not Found �޷��ҵ�ָ��λ�õ���Դ";
        }
    }
}