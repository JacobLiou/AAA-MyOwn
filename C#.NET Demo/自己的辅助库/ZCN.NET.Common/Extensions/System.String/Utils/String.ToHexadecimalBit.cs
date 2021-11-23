using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region 各进制数间转换

        /// <summary>
        /// 自定义扩展方法：实现各进制数间的转换。ConvertBase("15",10,16)表示将十进制数15转换为16进制的数
        /// </summary>
        /// <param name="value">要转换的值,即原值</param>
        /// <param name="fromHexadecimalBit">原值的进制</param>
        /// <param name="toHexadecimalBit">目标进制</param>
        public static string ToHexadecimalBit(this string value, int fromHexadecimalBit, int toHexadecimalBit)
        {
            int intValue = Convert.ToInt32(value, fromHexadecimalBit);           //先转成10进制
            string result = Convert.ToString(intValue, toHexadecimalBit);  //再转成目标进制
            if (toHexadecimalBit == 2)
            {
                int resultLength = result.Length;  //获取二进制的长度
                switch (resultLength)
                {
                    case 7:
                        result = "0" + result;
                        break;
                    case 6:
                        result = "00" + result;
                        break;
                    case 5:
                        result = "000" + result;
                        break;
                    case 4:
                        result = "0000" + result;
                        break;
                    case 3:
                        result = "00000" + result;
                        break;
                }
            }

            return result;
        }

        #endregion
    }
}