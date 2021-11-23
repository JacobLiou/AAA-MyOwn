using System;
using System.Security.Cryptography;

namespace ZCN.NET.CommonX.Id
{
    /// <summary>
    ///  有序 Guid 生成器。解决了多数据库(SQLServer、MySql、PostgreSQL、Oracle)以及集群环境的问题。
    /// </summary>

    public class SequentialGuidGenerator
    {
        /* 重点推荐 SequentialGuid，因为它提供了常见数据库生成有序Guid的解决方案。
           
           关于该框架的设计思路以及针对各个数据库的性能测试，见链接：https://www.codeproject.com/Articles/388157/GUIDs-as-fast-primary-keys-under-multiple-database。
           
           使用方式，建议您参考ABP框架，在ABP中使用SequentialGuid框架来生成有序GUID，关键代码链接：https://github.com/aspnetboilerplate/aspnetboilerplate/blob/b36855f0c238c3592203f058c641862844a0614e/src/Abp/SequentialGuidGenerator.cs#L36-L51。*/

        /// <summary>
        /// 获取 SequentialGuidGenerator 类的唯一实例
        /// </summary>
        public static SequentialGuidGenerator Instance { get; } = new SequentialGuidGenerator();

        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        /// <summary>
        /// 获取或设置目标数据库类型
        /// </summary>
        public SequentialGuidDatabaseType DatabaseType { get; set; }

        /// <summary>
        /// 防止创建类的默认实例。
        /// </summary>
        private SequentialGuidGenerator()
        {
            DatabaseType = SequentialGuidDatabaseType.SqlServer;
        }

        /// <summary>
        /// 根据 SqlServer 数据库中 uniqueidentifier 类型的排序规则，生成一个有序的 Guid 值
        /// </summary>
        /// <returns></returns>
        public Guid Create()
        {
            return Create(DatabaseType);
        }

        /// <summary>
        ///  根据指定的数据库类型，生成一个有序的 Guid 值
        /// </summary>
        /// <param name="databaseType"></param>
        /// <returns></returns>
        public Guid Create(SequentialGuidDatabaseType databaseType)
        {
            switch (databaseType)
            {
                case SequentialGuidDatabaseType.SqlServer:
                    return Create(SequentialGuidType.SequentialAtEnd);
                case SequentialGuidDatabaseType.Oracle:
                    return Create(SequentialGuidType.SequentialAsBinary);
                case SequentialGuidDatabaseType.MySql:
                    return Create(SequentialGuidType.SequentialAsString);
                case SequentialGuidDatabaseType.PostgreSql:
                    return Create(SequentialGuidType.SequentialAsString);
                default:
                    throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// 生成一个有序Guid
        /// </summary>
        /// <param name="guidType">有序Guid的类型枚举</param>
        /// <returns></returns>
        public Guid Create(SequentialGuidType guidType)
        {
            // We start with 16 bytes of cryptographically strong random data.
            // 从16字节的加密强随机数据开始。
            var randomBytes = new byte[10];
            //Rng.Locking(r => r.GetBytes(randomBytes));//ABP框架中实现方式
            _rng.GetBytes(randomBytes);// 官方实现方式

            // 另一种方法：使用通常创建的GUID来获取初始随机数据：
            // byte[] randomBytes = Guid.NewGuid().ToByteArray();
            // 这比使用 RNGCryptoServiceProvider 要快，但我不推荐使用它，因为.NET 框架不能保证 GUID 数据的多样性以及未来版本（或者像Mono这样的不同实现）可能使用不同的方法。

            // 现在有了 GUID 的随机基础。接下来，需要创建6字节块，这将是我们的时间戳。

            // 从 DateTime.MinValue 开始计算生成时间戳。没有必要使用比毫秒更具体的单位，因为 DateTime.Now 已经限制了解决方法。

            // 对48位时间戳使用毫秒分辨率,可以使我们在时间戳溢出和循环之前大约5900年。
            // 希望这对大多数目的来说已经足够了。:
            long timestamp = DateTime.UtcNow.Ticks / 10000L;

            // 然后得到字节数
            byte[] timestampBytes = BitConverter.GetBytes(timestamp);

            // 因为我们是从Int64转换过来的，所以必须在小端系统上反转
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(timestampBytes);
            }

            byte[] guidBytes = new byte[16];

            switch (guidType)
            {
                case SequentialGuidType.SequentialAsString:
                case SequentialGuidType.SequentialAsBinary:

                    // 对于字符串和字节数组版本，首先复制时间戳，然后复制随机数据。
                    Buffer.BlockCopy(timestampBytes, 2, guidBytes, 0, 6);
                    Buffer.BlockCopy(randomBytes, 0, guidBytes, 6, 10);

                    //如果格式化为字符串，必须补偿这个事实：该 .NET 将 Data1 和 Data2 块分别视为 Int32 和 Int16。这意味着它会改变小端系统的顺序。所以再一次，必须逆转。
                    if (guidType == SequentialGuidType.SequentialAsString && BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(guidBytes, 0, 4);
                        Array.Reverse(guidBytes, 4, 2);
                    }

                    break;

                case SequentialGuidType.SequentialAtEnd:

                    // 对于顺序结尾版本，我们首先复制随机数据，然后复制时间戳。
                    Buffer.BlockCopy(randomBytes, 0, guidBytes, 0, 10);
                    Buffer.BlockCopy(timestampBytes, 2, guidBytes, 10, 6);
                    break;
            }

            return new Guid(guidBytes);
        }

    }

    /// <summary>
    ///  有序Guid的类型
    /// </summary>
    public enum SequentialGuidType
    {
        /// <summary>
        /// 使用 Guid.ToString() 格式化 
        /// </summary>
        SequentialAsString,

        /// <summary>
        /// 使用 Guid.ToByteArray() 格式化
        /// </summary>
        SequentialAsBinary,

        /// <summary>
        /// Guid 的顺序部分应该位于 Data4 块的末尾
        /// </summary>
        SequentialAtEnd
    }

    /// <summary>
    /// 生成Guid的数据库类型
    /// </summary>
    public enum SequentialGuidDatabaseType
    {
        SqlServer,

        Oracle,

        MySql,

        PostgreSql,
    }
}