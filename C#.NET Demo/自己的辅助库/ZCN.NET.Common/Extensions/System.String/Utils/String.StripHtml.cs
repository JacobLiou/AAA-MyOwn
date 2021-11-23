using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：去除字符串中的HTML标签以及单引号双引号包裹的属性，返回普通的内容
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
                    // 循环处理，直到关闭标签'>'
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
                            // 跳过单引号开始的属性
                            pos = GetIndexAfterNextSingleQuote(path,pos,true);
                        }
                        else if(ch == '"')
                        {
                            // 跳过双引号开始的属性
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