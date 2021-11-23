using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ����������ת��

        /// <summary>
        /// �Զ�����չ������ʵ�ָ����������ת����ConvertBase("15",10,16)��ʾ��ʮ������15ת��Ϊ16���Ƶ���
        /// </summary>
        /// <param name="value">Ҫת����ֵ,��ԭֵ</param>
        /// <param name="fromHexadecimalBit">ԭֵ�Ľ���</param>
        /// <param name="toHexadecimalBit">Ŀ�����</param>
        public static string ToHexadecimalBit(this string value, int fromHexadecimalBit, int toHexadecimalBit)
        {
            int intValue = Convert.ToInt32(value, fromHexadecimalBit);           //��ת��10����
            string result = Convert.ToString(intValue, toHexadecimalBit);  //��ת��Ŀ�����
            if (toHexadecimalBit == 2)
            {
                int resultLength = result.Length;  //��ȡ�����Ƶĳ���
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