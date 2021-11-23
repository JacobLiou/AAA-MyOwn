using System;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///  自定义类：扩展 Random 随机方法
    /// </summary>
    public static partial class RandomUtils
    {
        /// <summary>
        ///  随机生成指定位数的编码
        /// </summary>
        /// <param name="codeLen">长度。如果长度小于等于0，则默认返回16位长度</param>
        /// <param name="random">Random对象</param>
        /// <returns></returns>
        public static string CreateRandomCode(int codeLen, Random random = null)
        {
            if (codeLen <= 0)
            {
                codeLen = 16;
            }

            if (random == null)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
            }

            string codeSerial = "1,2,3,4,5,6,7,8,9,0,"
                              + "Q,w,E,R,t,Y,u,I,O,p,"
                              + "A,S,D,f,G,H,J,k,L"
                              + "z,x,C,v,B,N,M"
                              + "=-+#@";

            string[] arr = codeSerial.Split(',');
            string code = "";
            int randValue = -1;

            for (int i = 0; i < codeLen; i++)
            {
                randValue = random.Next(0, arr.Length - 1);
                code += arr[randValue];
            }
            return code;
        }
    }
}



