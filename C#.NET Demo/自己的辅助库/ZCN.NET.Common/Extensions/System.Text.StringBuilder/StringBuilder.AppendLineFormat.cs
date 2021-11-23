using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ʽ������ַ���׷�ӵ���չ�����β(���л��з���) 
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="format">��ʽ���ַ���</param>
        /// <param name="args">��ʽ������</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, params object[] args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }

        /// <summary>
        ///  �Զ�����չ����������ʽ������ַ���׷�ӵ���չ�����β(���л��з���) 
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="format">��ʽ���ַ���</param>
        /// <param name="args">��ʽ������</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format,
            List<IEnumerable<object>> args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }
    }
}