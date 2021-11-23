using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 204
        ///  (No Content û�����ĵ��������Ӧ�ü�����ʾԭ�����ĵ�������û����ڵ�ˢ��ҳ�棬
        ///   ��Servlet����ȷ���û��ĵ��㹻�£����״̬�����Ǻ����õ�)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusNoContent(this HttpResponse @this)
        {
            @this.StatusCode = 204;
            //@this.StatusDescription = "No Content û�����ĵ��������Ӧ�ü�����ʾԭ�����ĵ�������û����ڵ�ˢ��ҳ�棬��Servlet����ȷ���û��ĵ��㹻�£����״̬�����Ǻ����õ�";
        }
    }
}