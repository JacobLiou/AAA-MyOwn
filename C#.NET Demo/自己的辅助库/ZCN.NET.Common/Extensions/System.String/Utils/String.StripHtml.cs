using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ȥ���ַ����е�HTML��ǩ�Լ�������˫���Ű��������ԣ�������ͨ������
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string StripHtml(this string @this)
        {
            var path = new StringBuilder(@this);
            var sb = new StringBuilder();

            int pos = 0;

            while(pos < path.Length)
            {
                char ch = path[pos];
                pos++;

                if(ch == '<')
                {
                    // ѭ������ֱ���رձ�ǩ'>'
                    while(pos < path.Length)
                    {
                        ch = path[pos];
                        pos++;

                        if(ch == '>')
                        {
                            break;
                        }

                        if(ch == '\'')
                        {
                            // ���������ſ�ʼ������
                            pos = GetIndexAfterNextSingleQuote(path,pos,true);
                        }
                        else if(ch == '"')
                        {
                            // ����˫���ſ�ʼ������
                            pos = GetIndexAfterNextDoubleQuote(path,pos,true);
                        }
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
    }
}