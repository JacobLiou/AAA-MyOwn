using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region DeepClone 深度拷贝

        /* 深拷贝：
         * 指的是拷贝一个对象时，不仅仅把对象的引用进行复制，还把该对象引用的值也一起拷贝。
         * 这样进行深拷贝后的拷贝对象就和源对象互相独立，其中任何一个对象的改动都不会对另外一个对象造成影响。
         * 举个例子，一个人叫张三，然后使用克隆技术以张三来克隆另外一个人叫李四，
         * 这样张三和李四就是相互独立的，不管张三缺胳膊还是李四少腿了都不会影响另外一个人。
         * 在.NET领域，值对象就是典型的例子，如int, Double以及结构体和枚举等。
         * 例如：
         * int source = 123;
         * int copy = source; // 值类型赋值内部执行深拷贝
         * copy = 234;        // 对拷贝对象进行赋值不会改变源对象的值
         * source = 345;      // 同样对源对象赋值也不会改变拷贝对象的值。
         * 
         * 实现深拷贝的方式有：反射、反序列化和表达式树
         */

        /// <summary>
        ///  自定义扩展方法：（该方法的转化性能较低，请使用DeepCloneByExpressionTree()方法）
        ///  利用二进制序列化和反序列实现深度拷贝一个对象，返回拷贝后的对象
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        [Obsolete("该方法的转化性能较低，请使用DeepCloneByExpressionTree()方法")]
        public static T DeepCloneByBinarySerialize<T>(this T @this)
        {
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);

                return (T)formatter.Deserialize(stream);
            }
        }

        /// <summary>
        ///  自定义扩展方法： （该方法的转化性能较低，请使用DeepCloneByExpressionTree()方法）
        ///  利用XML序列化和反序列化实现深度拷贝一个对象，返回拷贝后的对象
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        [Obsolete("该方法的转化性能较低，请使用DeepCloneByExpressionTree()方法")]
        public static T DeepCloneByXmlSerializer<T>(this T @this)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);

                return (T)xml.Deserialize(stream);
            }
        }

        /// <summary>
        ///  自定义扩展方法： （该方法的转化性能较低，请使用DeepCloneByExpressionTree()方法）
        ///  利用 DataContractSerializer 序列化和反序列化实现深度拷贝一个对象，返回拷贝后的对象
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        [Obsolete("该方法的转化性能较低，请使用DeepCloneByExpressionTree()方法")]
        public static T DeepCloneByDataContractSerializer<T>(this T @this)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(T));
                ser.WriteObject(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);

                return (T)ser.ReadObject(stream);
            }
        }

        #endregion

        #region ShallowCopy 浅拷贝
        /* 浅拷贝：
         * 指的是拷贝一个对象时，仅仅拷贝对象的引用进行拷贝，但是拷贝对象和源对象还是引用同一份实体。
         * 此时，其中一个对象的改变都会影响到另一个对象。
         * 例如，一个人一开始叫张三，后来改名字为张老三了，
         * 可是他们还是同一个人，不管张三缺胳膊还是张老三少腿，都反应在同一个人身上。
         * 在.NET中引用类型就是一个例子。如类类型。
         * 例如：
         * public class Person
           {
             public string Name { get; set; }
           }

           class Program
           {
                static void Main(string[] args)
                {
                    Person sourceP = new Person() { Name = "张三" };
                    Person copyP = sourceP; // 浅拷贝
                    copyP.Name = "张老三"; // 拷贝对象改变Name值
                    
                    // 结果都是"张老三",因为实现的是浅拷贝，一个对象的改变都会影响到另一个对象
                    Console.WriteLine("Person.Name: [SourceP: {0}] [CopyP:{1}]", sourceP.Name, copyP.Name);
                    Console.Read();
                }
            }
         */

        /// <summary>
        ///  自定义扩展方法：浅拷贝一个对象，返回拷贝后的对象
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T ShallowCopy<T>(this T @this)
        {
            /*所有对象的父对象都是System.Object对象，这个父对象中有一个MemberwiseClone方法，该方法就可以用来实现浅拷贝*/
            MethodInfo method = @this.GetType().GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);

            return (T)method.Invoke(@this, null);
        }

        #endregion
    }
}
