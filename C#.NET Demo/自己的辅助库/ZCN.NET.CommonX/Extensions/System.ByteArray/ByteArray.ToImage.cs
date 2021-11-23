using System.Drawing;
using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /* Ŀǰ.Net Core��û�� System.Drawing �����⡣
         * ����ʹ�� System.Drawing.Common ��ImageProcessor��CoreCompat �ȴ���
         */

        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷�������������ת��Ϊͼ��
        /// </summary>
        /// <param name="this">��չ����8 λ�޷�������������</param>
        /// <returns></returns>
        public static Image ToImage(this byte[] @this)
        {
            using (var ms = new MemoryStream(@this))
            {
                return Image.FromStream(ms);
            }
        }
    }
}