#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 307
        ///  (Temporary Redirect ��302��Found����ͬ������������������Ӧ302Ӧ������ض��򣬼�ʹԭ����������POST��
        ///   ��ʹ��ʵ����ֻ����POST/�����Ӧ����303ʱ �����ض���
        ///   �������ԭ��HTTP 1.1������307���Ա������������ּ���״̬���룺������303Ӧ��ʱ��
        ///   ��������Ը����ض����GET��POST���������307Ӧ���������ֻ �ܸ����GET������ض���)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusTemporaryRedirect(this HttpResponse @this)
        {
            @this.StatusCode = 307;
            //@this.StatusDescription = @"Temporary Redirect ��302��Found����ͬ������������������Ӧ302Ӧ������ض��򣬼�ʹԭ����������POST����ʹ��ʵ����ֻ����POST�����Ӧ����303ʱ �����ض����������ԭ��HTTP 1.1������307���Ա������������ּ���״̬���룺������303Ӧ��ʱ����������Ը����ض����GET��POST���������307Ӧ���������ֻ �ܸ����GET������ض���";
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
        ///  �Զ�����չ���������� ASP.NET �����ķ��ظ��ͻ��˵������ HTTP ״̬���� 307
        ///  (Temporary Redirect ��302��Found����ͬ������������������Ӧ302Ӧ������ض��򣬼�ʹԭ����������POST��
        ///   ��ʹ��ʵ����ֻ����POST/�����Ӧ����303ʱ �����ض���
        ///   �������ԭ��HTTP 1.1������307���Ա������������ּ���״̬���룺������303Ӧ��ʱ��
        ///   ��������Ը����ض����GET��POST���������307Ӧ���������ֻ �ܸ����GET������ض���)
        /// </summary>
        /// <param name="this">��չ����ASP.NET ������ HTTP ��Ӧ��Ϣ����</param>
        public static void SetStatusTemporaryRedirect(this HttpResponse @this)
        {
            @this.StatusCode = 307;
            @this.StatusDescription = @"Temporary Redirect ��302��Found����ͬ������������������Ӧ302Ӧ������ض��򣬼�ʹԭ����������POST����ʹ��ʵ����ֻ����POST�����Ӧ����303ʱ �����ض����������ԭ��HTTP 1.1������307���Ա������������ּ���״̬���룺������303Ӧ��ʱ����������Ը����ض����GET��POST���������307Ӧ���������ֻ �ܸ����GET������ض���";
        }
    }
}

#endif