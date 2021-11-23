namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ���ȫ��ת��

        /// <summary>
        /// �Զ�����չ������תȫ�ǵĺ���(SBC case)
        /// </summary>
        /// <param name="this">��չ����,�����ַ���</param>
        /// <returns>ȫ���ַ���</returns>
        ///<remarks>
        ///ȫ�ǿո�Ϊ12288����ǿո�Ϊ32
        ///�����ַ����(33-126)��ȫ��(65281-65374)�Ķ�Ӧ��ϵ�ǣ������65248
        ///</remarks>
        public static string ConvertToToSBC(this string @this)
        {
            //���תȫ�ǣ�
            char[] c = @this.ToCharArray();
            for(int i = 0;i < c.Length;i++)
            {
                if(c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if(c[i] < 127)
                {
                    c[i] = (char)(c[i] + 65248);
                }
            }
            return new string(c);
        }

        /// <summary>
        /// �Զ�����չ������ת��ǵĺ���(SBC case)
        /// </summary>
        /// <param name="this">��չ����,�����ַ���</param>
        /// <returns>ȫ���ַ���</returns>
        ///<remarks>
        ///ȫ�ǿո�Ϊ12288����ǿո�Ϊ32
        ///�����ַ����(33-126)��ȫ��(65281-65374)�Ķ�Ӧ��ϵ�ǣ������65248
        ///</remarks>
        public static string ConvertToDBC(string @this)
        {
            char[] c = @this.ToCharArray();
            for(int i = 0;i < c.Length;i++)
            {
                if(c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if(c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }

        #endregion
    }
}