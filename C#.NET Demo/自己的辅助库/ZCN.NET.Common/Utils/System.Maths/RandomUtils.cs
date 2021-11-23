using System;
using ZCN.NET.Common.Extensions;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///  自定义类：扩展 Random 随机方法
    /// </summary>
    public static partial class RandomUtils
    {
        /// <summary>
        ///  随机生成一个整数。
        ///  第三个参数，如果传递一个不为null的对象(并且该对象定义在循环之外)，则在同一个循环中可以避免产生全部相同的结果。
        ///  如果不传递该值，则同一个循环中会产生全部相同的结果。
        /// </summary>
        /// <param name="lowerBound">区间范围下限值</param>
        /// <param name="upperBound">区间范围上限值</param>
        /// <param name="random">Random对象</param>
        /// <returns></returns>
        public static int CreateRandomInt(int lowerBound, int upperBound, Random random = null)
        {
            if (random == null)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
            }

            return random.Next(lowerBound, upperBound);
        }

        /// <summary>
        ///  随机生成一个双精度浮点数。
        ///  第1个参数，如果传递一个不为null的对象(并且该对象定义在循环之外)，则在同一个循环中可以避免产生全部相同的结果。
        ///  如果不传递该值，则同一个循环中会产生全部相同的结果。
        /// </summary>
        /// <param name="random">Random对象</param>
        /// <returns></returns>
        public static double CreateRandomDouble(Random random = null)
        {
            if (random == null)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
            }

            return random.NextDouble();
        }

        /// <summary>
        ///  随机生成一个Decimal类型数字,1位小数。
        ///  第4个参数，如果传递一个不为null的对象(并且该对象定义在循环之外)，则在同一个循环中可以避免产生全部相同的结果。
        ///  如果不传递该值，则同一个循环中会产生全部相同的结果。
        /// </summary>
        /// <param name="lowerBound">区间范围下限值</param>
        /// <param name="upperBound">区间范围上限值</param>
        /// <param name="length">小数点后的小数位数，大于0</param>
        /// <param name="random">Random对象</param>
        /// <returns></returns>
        public static decimal CreateRandomDecimal(int lowerBound, int upperBound, int length, Random random = null)
        {
            if (random == null)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
            }

            int numInt = CreateRandomInt(lowerBound, upperBound, random);

            if (length <= 0)
            {
                return (numInt + 0.0).ToString().ToDecimal();
            }

            string tempDouble = "";

            for (int i = 0; i < length; i++)
            {
                //获取介于0.0与1.0之间的随机数字
                double numDouble = CreateRandomDouble(random);

                tempDouble = tempDouble + numDouble.ToString().Substring(2);//截取小数点后面的数字并转换为字符串
            }

            //拼接为带小数点的字符串，并转换为 decimal数字
            return (numInt + "." + tempDouble).ToDecimal();
        }

        /// <summary>
        ///   根据传入的字符串数组，随机返回其中的一个字符串。
        ///   第2个参数，如果传递一个不为null的对象(并且该对象定义在循环之外)，则在同一个循环中可以避免产生全部相同的结果。
        ///   如果不传递该值，则同一个循环中会产生全部相同的结果。
        /// </summary>
        /// <param name="arrStr">字符串数组</param>
        /// <param name="random">Random对象</param>
        /// <returns></returns>
        public static string CreateRandomString(string[] arrStr, Random random = null)
        {
            if (arrStr == null)
            {
                return "";
            }

            int length = arrStr.Length;

            if (length == 0)
            {
                return "";
            }

            if (length == 1)
            {
                return arrStr[0];
            }

            if(random == null)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
            }

            int index = CreateRandomInt(0, length, random);

            return arrStr[index];
        }
    }
}