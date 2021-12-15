global using System;

using Confluent.Kafka;
using System.Net;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Producer 生产者
var config = new ProducerConfig
{
    BootstrapServers = "host1:9092, host2:9092",
    ClientId = Dns.GetHostName(),
};

using (var producer = new ProducerBuilder<Null, string>(config).Build())
{
    await producer.ProduceAsync("weblog", new Message<Null, string> { Value = "a log message"});
}


//消费者
var config_Comsumer = new ConsumerConfig
{
    BootstrapServers = "host1:9002, host2:9092",
    GroupId = "foo",
    AutoOffsetReset = AutoOffsetReset.Earliest,
};

using (var consumer = new ConsumerBuilder<Ignore, string>(config_Comsumer).Build())
{
    consumer.Subscribe(new List<string>());
}
