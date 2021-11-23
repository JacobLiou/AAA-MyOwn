using System;

namespace ZCN.NET.Common.Id
{
    /// <summary>
    /// C#版的雪花ID生成器(性能极高，适用于分布式集群环境)
    /// </summary>
    public class SnowflakeIdCreator
    {
        /*雪花算法SnowFlake的简单说明与使用，参考博客：https://blog.csdn.net/qq_43307934/article/details/108097655*/

        private static long _workerId = 1;     //机器ID
        private static long _twepoch = 68020L; //唯一时间，这是一个避免重复的随机量，自行设定不要大于当前时间戳
        private static long _sequence = 0L;
        private static int _workerIdBits = 4;                                   //机器码字节数。4个字节用来保存机器码(定义为Long类型会出现，最大偏移64位，所以左移64位没有意义)
        private static long _maxWorkerId = -1L ^ -1L << _workerIdBits;          //最大机器ID
        private static int _sequenceBits = 10;                                  //计数器字节数，10个字节用来保存计数码
        private static int _workerIdShift = _sequenceBits;                      //机器码数据左移位数，就是后面计数器占用的位数
        private static int _timestampLeftShift = _sequenceBits + _workerIdBits; //时间戳左移动位数就是机器码和计数器总字节数
        private static long _sequenceMask = -1L ^ -1L << _sequenceBits;         //一微秒内可以产生计数，如果达到该值则等到下一微妙在进行生成
        private static long _lastTimestamp = -1L;
        private static object _lockObj = new object();

        /// <summary>
        /// 设置机器码
        /// </summary>
        /// <param name="id">机器码</param>
        public static void SetWorkerId(long id)
        {
            if (id > _maxWorkerId || id < 0)
                throw new Exception(string.Format("机器Id不能大于 {0} 或者小于 0。", id));

            SnowflakeIdCreator._workerId = id;
        }

        /// <summary>
        ///  生成一个Id
        /// </summary>
        /// <returns></returns>
        public static long NextId()
        {
            lock (_lockObj)
            {
                long timestamp = GenTime();
                if (_lastTimestamp == timestamp)
                { 
                    //同一微妙中生成ID
                    SnowflakeIdCreator._sequence = (SnowflakeIdCreator._sequence + 1) & SnowflakeIdCreator._sequenceMask; //用&运算符计算该微秒内产生的计数是否已经到达上限
                    if (SnowflakeIdCreator._sequence == 0)
                    {
                        //一微妙内产生的ID计数已达上限，等待下一微妙
                        timestamp = TillNextMillis(_lastTimestamp);
                    }
                }
                else
                { //不同微秒生成ID
                    SnowflakeIdCreator._sequence = 0; //计数清0
                }

                if (timestamp < _lastTimestamp)
                { //如果当前时间戳比上一次生成ID时时间戳还小，抛出异常，因为不能保证现在生成的ID之前没有生成过
                    throw new Exception(string.Format("时钟向后移动。拒绝生成Id达 {0} 毫秒", _lastTimestamp - timestamp));
                }

                _lastTimestamp = timestamp; //把当前时间戳保存为最后生成ID的时间戳
                long nextId = (timestamp - _twepoch << _timestampLeftShift) | SnowflakeIdCreator._workerId << SnowflakeIdCreator._workerIdShift | SnowflakeIdCreator._sequence;
                return nextId;
            }
        }

        /// <summary>
        /// 获取下一微秒时间戳
        /// </summary>
        /// <param name="lastTimestamp"></param>
        /// <returns></returns>
        private static long TillNextMillis(long lastTimestamp)
        {
            long timestamp = GenTime();
            while (timestamp <= lastTimestamp)
            {
                timestamp = GenTime();
            }
            return timestamp;
        }

        /// <summary>
        /// 生成当前时间戳
        /// </summary>
        /// <returns></returns>
        private static long GenTime()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }
    }
}