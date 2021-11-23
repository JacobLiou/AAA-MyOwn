using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ʼλ�ÿ�ʼ��ȡ��һ��˫����֮�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>��һ��˫���ź������</returns>
        public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this)
        {
            return @this.GetIndexAfterNextDoubleQuote(0, false);
        }

        /// <summary>
        /// �Զ�����չ����������ʼλ�ÿ�ʼ��ȡ��һ��˫����֮�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="allowEscape">�Ƿ�����ת��</param>
        /// <returns>��һ��˫���ź������</returns>
        public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this, bool allowEscape)
        {
            return @this.GetIndexAfterNextDoubleQuote(0, allowEscape);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��λ�ÿ�ʼ��ȡ��һ��˫����֮�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="startIndex">��ʼλ��</param>
        /// <returns>��һ��˫���ź������</returns>
        public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this, int startIndex)
        {
            return @this.GetIndexAfterNextDoubleQuote(startIndex, false);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��λ�ÿ�ʼ��ȡ��һ��˫����֮�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="startIndex">��ʼλ��</param>
        /// <param name="allowEscape">�Ƿ�����ת��</param>
        /// <returns>��һ��˫���ź������</returns>
        public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this, int startIndex, bool allowEscape)
        {
            while (startIndex < @this.Length)
            {
                char ch = @this[startIndex];
                startIndex++;

                char nextChar;
                if (allowEscape && ch == '\\' && startIndex < @this.Length &&
                   ((nextChar = @this[startIndex]) == '\\' || nextChar == '"'))
                {
                    startIndex++; // Treat as escape character for \\ or \"
                }
                else if (ch == '"')
                {
                    return startIndex;
                }
            }

            return startIndex;
        }
    }
}