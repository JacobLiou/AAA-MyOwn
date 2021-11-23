using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������������� Decimal ���͵���ֵ(С��λ������1��18֮��)
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="minValue">���ص���������½磨�������ȡ���½�ֵ��</param>
        /// <param name="maxValue">���ص���������Ͻ磨���������ȡ���Ͻ�ֵ����maxValue ������ڻ���� minValue</param>
        /// <param name="digit">С��λ�����������0,С�ڵ���18</param>
        /// <returns></returns>
        public static decimal NextDecimal(this Random @this, int minValue, int maxValue, int digit)
        {
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException("maxValue", "NextDecimal()�����в��� maxValue ������ڻ���� minValue");

            if (digit <= 0 || digit > 18)
                throw new ArgumentOutOfRangeException("digit", "NextDecimal()�����в��� digit �������0");

            //�Ȳ�����������
            string value1 = @this.Next(minValue, maxValue).ToString();
            string value2 = "0";

            //�ٲ���С������
            int minValue2 = 0;
            int maxValue2 = 9;
            string tempValue1 = "0";
            string tempValue2 = "0";

            if (digit == 1)
            {
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 2)
            {
                minValue2 = 10;
                maxValue2 = 99;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 3)
            {
                minValue2 = 100;
                maxValue2 = 999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 4)
            {
                minValue2 = 1000;
                maxValue2 = 9999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 5)
            {
                minValue2 = 10000;
                maxValue2 = 99999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 6)
            {
                minValue2 = 100000;
                maxValue2 = 999999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 7)
            {
                minValue2 = 1000000;
                maxValue2 = 9999999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 8)
            {
                minValue2 = 10000000;
                maxValue2 = 99999999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 9)
            {
                minValue2 = 100000000;
                maxValue2 = 999999999;
                value2 = @this.Next(minValue2, maxValue2).ToString();
            }
            else if (digit == 10)
            {
                // 9λ�� + 1λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 0;
                maxValue2 = 9;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 11)
            {
                // 9λ�� + 2λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 10;
                maxValue2 = 99;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 12)
            {
                // 9λ�� + 3λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 100;
                maxValue2 = 999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 13)
            {
                // 9λ�� + 4λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 1000;
                maxValue2 = 9999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 14)
            {
                // 9λ�� + 5λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 10000;
                maxValue2 = 99999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 15)
            {
                // 9λ�� + 6λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 100000;
                maxValue2 = 999999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 16)
            {
                // 9λ�� + 7λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 1000000;
                maxValue2 = 9999999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 17)
            {
                // 9λ�� + 8λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 10000000;
                maxValue2 = 999999999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }
            else if (digit == 18)
            {
                // 9λ�� + 9λ��
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }

            //�������� ���� С������

            return (value1 + "." + value2).ToDecimal();
        }
    }
}