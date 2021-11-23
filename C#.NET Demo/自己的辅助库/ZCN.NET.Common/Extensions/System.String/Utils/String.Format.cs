namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ���ַ����е�һ��������ʽ���滻Ϊָ��������ַ�����ʾ��ʽ
        /// </summary>
        /// <param name="this">���ϸ�ʽ�ַ���</param>
        /// <param name="arg0">Ҫ���ø�ʽ�Ķ���</param>
        /// <returns>@this �ĸ��������е��κθ�ʽ����滻Ϊ arg0 ���ַ�����ʾ��ʽ</returns>
        public static string Format(this string @this, object arg0)
        {
            return string.Format(@this, arg0);
        }

        /// <summary>
        /// �Զ�����չ������ ��ָ���ַ����еĸ�ʽ���滻Ϊ����ָ��������ַ�����ʾ��ʽ
        /// </summary>
        /// <param name="this">���ϸ�ʽ�ַ���</param>
        /// <param name="arg0">Ҫ���ø�ʽ�ĵ�һ������</param>
        /// <param name="arg1">Ҫ���ø�ʽ�ĵڶ�������</param>
        /// <returns>@this �ĸ��������еĸ�ʽ���滻Ϊ arg0 �� arg1 ���ַ�����ʾ��ʽ</returns>
        public static string Format(this string @this, object arg0, object arg1)
        {
            return string.Format(@this, arg0, arg1);
        }

        /// <summary>
        /// �Զ�����չ������ ��ָ���ַ����еĸ�ʽ���滻Ϊ����ָ��������ַ�����ʾ��ʽ
        /// </summary>
        /// <param name="this">���ϸ�ʽ�ַ���</param>
        /// <param name="arg0">Ҫ���ø�ʽ�ĵ�һ������</param>
        /// <param name="arg1">Ҫ���ø�ʽ�ĵڶ�������</param>
        /// <param name="arg2">Ҫ���ø�ʽ�ĵ���������</param>
        /// <returns>@this �ĸ��������еĸ�ʽ�����滻Ϊ arg0��arg1 �� arg2 ���ַ�����ʾ��ʽ</returns>
        public static string Format(this string @this, object arg0, object arg1, object arg2)
        {
            return string.Format(@this, arg0, arg1, arg2);
        }

        /// <summary>
        ///  �Զ�����չ������ ��ָ���ַ����еĸ�ʽ���滻Ϊָ����������Ӧ������ַ�����ʾ��ʽ
        /// </summary>
        /// <param name="this">���ϸ�ʽ�ַ���</param>
        /// <param name="args">һ���������飬���а����������Ҫ���ø�ʽ�Ķ���</param>
        /// <returns>@this �ĸ��������еĸ�ʽ�����滻Ϊ args ����Ӧ������ַ�����ʾ��ʽ</returns>
        public static string Format(this string @this, object[] args)
        {
            return string.Format(@this, args);
        }
    }
}