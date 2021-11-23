using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：随机产生 Decimal 类型的数值(小数位数介于1到18之间)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="minValue">返回的随机数的下界（随机数可取该下界值）</param>
        /// <param name="maxValue">返回的随机数的上界（随机数不能取该上界值）。maxValue 必须大于或等于 minValue</param>
        /// <param name="digit">小数位数。必须大于0,小于等于18</param>
        /// <returns></returns>
        public static decimal NextDecimal(this Random @this, int minValue, int maxValue, int digit)
        {
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException("maxValue", "NextDecimal()方法中参数 maxValue 必须大于或等于 minValue");

            if (digit <= 0 || digit > 18)
                throw new ArgumentOutOfRangeException("digit", "NextDecimal()方法中参数 digit 必须大于0");

            //先产生整数部分
            string value1 = @this.Next(minValue, maxValue).ToString();
            string value2 = "0";

            //再产生小数部分
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
                // 9位数 + 1位数
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
                // 9位数 + 2位数
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
                // 9位数 + 3位数
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
                // 9位数 + 4位数
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
                // 9位数 + 5位数
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
                // 9位数 + 6位数
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
                // 9位数 + 7位数
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
                // 9位数 + 8位数
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
                // 9位数 + 9位数
                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue1 = @this.Next(minValue2, maxValue2).ToString();

                minValue2 = 100000000;
                maxValue2 = 999999999;
                tempValue2 = @this.Next(minValue2, maxValue2).ToString();

                value2 = tempValue1 + tempValue2;
            }

            //整数部分 加上 小数部分

            return (value1 + "." + value2).ToDecimal();
        }
    }
}