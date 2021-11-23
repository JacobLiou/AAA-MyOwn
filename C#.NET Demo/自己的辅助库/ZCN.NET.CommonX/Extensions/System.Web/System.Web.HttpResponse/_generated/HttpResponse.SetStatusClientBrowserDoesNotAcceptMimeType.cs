using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 406
        ///  (Not Acceptable ָ������Դ�Ѿ��ҵ���������MIME���ͺͿͻ���Acceptͷ����ָ���Ĳ����ݣ�
        ///   �ͻ��������������������ҳ���MIME ����)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusClientBrowserDoesNotAcceptMimeType(this HttpResponse @this)
        {
            @this.StatusCode = 406;
            //@this.StatusDescription = @"Not Acceptable ָ������Դ�Ѿ��ҵ���������MIME���ͺͿͻ���Acceptͷ����ָ���Ĳ����ݣ��ͻ��������������������ҳ���MIME ����";
        }
    }
}