namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ȡһ��ֵ��ͨ����ֵָʾ System.Type �Ƿ�Ϊ����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsArray<T>(this T @this)
        {
            return @this.GetType().IsArray;
        }
    }
}