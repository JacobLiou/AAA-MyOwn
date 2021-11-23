using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 412
        ///  (Precondition Failed ����ͷ��ָ����һЩǰ������ʧ��)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusPreconditionFailed(this HttpResponse @this)
        {
            @this.StatusCode = 412;
            //@this.StatusDescription = "Precondition Failed ����ͷ��ָ����һЩǰ������ʧ��";
        }
    }
}