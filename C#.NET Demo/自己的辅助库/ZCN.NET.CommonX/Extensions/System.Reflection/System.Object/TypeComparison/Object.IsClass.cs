
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ��������ȡһ��ֵ��ͨ����ֵָʾ System.Type �Ƿ���һ���ࣻ��������ֵ���ͻ�ӿ�
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsClass<T>(this T @this)
        {
            return @this.GetType().IsClass;
        }
    }
}