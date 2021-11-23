using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 501
        ///  (Not Implemented ��������֧��ʵ����������Ҫ�Ĺ��ܣ�ҳüֵָ����δʵ�ֵ����á����磬�ͻ�������һ����������֧�ֵ�PUT����)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusInvalidHeaderValueConfiguration(this HttpResponse @this)
        {
            @this.StatusCode = 501;
            //@this.StatusDescription = "Not Implemented ��������֧��ʵ����������Ҫ�Ĺ��ܣ�ҳüֵָ����δʵ�ֵ����á����磬�ͻ�������һ����������֧�ֵ�PUT����";
        }
    }
}