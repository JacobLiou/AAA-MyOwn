
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ��������ȡһ��ֵ����ֵָʾ��ǰ�� System.Type �Ƿ��ʾö��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsEnum<T>(this T @this)
        {
            return @this.GetType().IsEnum;
        }
    }
}