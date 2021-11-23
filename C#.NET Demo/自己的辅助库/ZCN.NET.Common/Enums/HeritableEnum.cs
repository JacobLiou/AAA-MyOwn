
using System;
using System.Collections;
using System.Collections.Generic;

namespace ZCN.NET.Common.Enums
{
    /// <summary>
    ///  可以供枚举继承的类。
    ///  可以比较大小，可以转化成string，可以与int互转，值传递的效果。还比原生的enum多了ForEach功能。
    /// </summary>
    public class HeritableEnum : IComparable<HeritableEnum>, IEquatable<HeritableEnum>
    {
        #region 字段属性

        static int counter = -1;                                  //默认数值计数器
        private static Hashtable hashTable = new Hashtable();     //不重复数值集合
        protected static List<HeritableEnum> members = new List<HeritableEnum>(); //所有实例集合
        private string Name { get; set; }
        private int Value { get; set; }

        #endregion

        #region 构造函数

        /* 此类的所有构造方法必须是protected，以防止在类之外构造实例。它的子类也必须这样。
         * 示例参考：https://www.cnblogs.com/BillySir/archive/2012/02/15/2353395.html
         */

        /// <summary>
        /// 不指定数值构造实例
        /// </summary>
        /// <param name="name">枚举项的名称</param>
        protected HeritableEnum(string name)
        {
            this.Name = name;
            this.Value = ++counter;
            members.Add(this);
            if (!hashTable.ContainsKey(this.Value))
            {
                hashTable.Add(this.Value, this);
            }
        }

        /// <summary>
        /// 指定数值构造实例
        /// </summary>
        /// <param name="name">枚举项的名称</param>
        /// <param name="value">枚举项对应的数值</param>
        protected HeritableEnum(string name, int value)
            : this(name)
        {
            this.Value = value;
            counter = value;
        }


        #endregion

        #region 接口成员实现

        #region IComparable 接口成员

        /// <summary>
        ///   将当前实例与同一类型的另一个对象进行比较，并返回一个整数，该整数指示当前实例在排序顺序中的位置是位于另一个对象之前、之后还是与其位置相同。
        /// </summary>
        /// <param name="other">与此实例进行比较的对象。</param>
        /// <returns>
        /// 一个值，指示要比较的对象的相对顺序。
        ///  返回值的含义如下：
        ///         值
        ///         含义
        ///         小于零
        ///         此实例在排序顺序中位于 <paramref name="other" /> 之前。
        ///         零
        ///         此实例中出现的相同位置在排序顺序中是 <paramref name="other" />。
        ///         大于零
        ///         此实例在排序顺序中位于 <paramref name="other" /> 之后。
        ///       </returns>
        public int CompareTo(HeritableEnum other)
        {
            return this.Value.CompareTo(other.Value);
        }

        #endregion

        #region IEquatable 接口成员

        /// <summary>指示当前对象是否等于同一类型的另一个对象。</summary>
        /// <param name="other">一个与此对象进行比较的对象。</param>
        /// <returns>
        ///   如果当前对象等于 <paramref name="other" /> 参数，则为 <see langword="true" />；否则为 <see langword="false" />。
        /// </returns>
        public bool Equals(HeritableEnum other)
        {
            return this.Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is HeritableEnum))
                return false;

            return this.Value == ((HeritableEnum)obj).Value;
        }

        #endregion

        /// <summary>
        /// 向string转换
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name.ToString();
        }

        public override int GetHashCode()
        {
            HeritableEnum std = (HeritableEnum)hashTable[this.Value];
            if (std.Name == this.Name)
                return base.GetHashCode();

            return std.GetHashCode();
        }

        #endregion

        #region 方法（比较操作符）

        /// <summary>
        /// 显式强制从int转换
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static explicit operator HeritableEnum(int i)
        {
            if (hashTable.ContainsKey(i))
            {
                return (HeritableEnum)members[i];
            }
            return new HeritableEnum(i.ToString(), i);
        }

        /// <summary>
        /// 显式强制向int转换
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static explicit operator int(HeritableEnum e)
        {
            return e.Value;
        }

        public static void ForEach(Action<HeritableEnum> action)
        {
            foreach (HeritableEnum item in members)
            {
                action(item);
            }
        }

        public static bool operator !=(HeritableEnum e1, HeritableEnum e2)
        {
            return e1.Value != e2.Value;
        }

        public static bool operator <(HeritableEnum e1, HeritableEnum e2)
        {
            return e1.Value < e2.Value;
        }

        public static bool operator <=(HeritableEnum e1, HeritableEnum e2)
        {
            return e1.Value <= e2.Value;
        }

        public static bool operator ==(HeritableEnum e1, HeritableEnum e2)
        {
            return e1.Value == e2.Value;
        }

        public static bool operator >(HeritableEnum e1, HeritableEnum e2)
        {
            return e1.Value > e2.Value;
        }

        public static bool operator >=(HeritableEnum e1, HeritableEnum e2)
        {
            return e1.Value >= e2.Value;
        }

        #endregion
    }

    #region 测试示例

    class EnumUse1 : HeritableEnum
    {
        protected EnumUse1(string name) : base(name) { }

        protected EnumUse1(string name, int value) : base(name, value) { }

        public static EnumUse1 A = new EnumUse1("A");
        public static EnumUse1 B = new EnumUse1("B", 2);
        public static EnumUse1 C = new EnumUse1("C", 2);
        public static EnumUse1 D = new EnumUse1("D");
    }

    //enum EnumUse1
    //{
    //    A,
    //    B = 2,
    //    C = 2,
    //    D
    //}

    class EnumUse2 : EnumUse1
    {
        protected EnumUse2(string name) : base(name) { }

        protected EnumUse2(string name, int value) : base(name, value) { }

        public static EnumUse2 E = new EnumUse2("E");
    }

    class HeritableEnumTest
    {
        static void Main_Test(string[] args)
        {
            bool b = EnumUse1.D >= EnumUse1.A;
            Console.WriteLine(b.ToString());
            Show(EnumUse2.E);
            HeritableEnum.ForEach((x) => Console.WriteLine("{0} = {1},", x, (int)x));
        }

        static void Show(HeritableEnum e)
        {
            Console.WriteLine(@"{0} = {1},""{2}""", e, (int)e, e.ToString());
        }
    }

    #endregion
}