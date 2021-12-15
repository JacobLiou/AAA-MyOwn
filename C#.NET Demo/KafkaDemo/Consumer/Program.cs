using System.Collections.Generic;
using Confluent.Kafka;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ConsumerConfig config = new ConsumerConfig();
config.BootstrapServers = "192.168.209.133:9092,192.168.209.134:9092,192.168.209.135:9092";
config.GroupId = "group.1";
config.AutoOffsetReset = AutoOffsetReset.Earliest;
config.EnableAutoCommit = false;

var builder = new ConsumerBuilder<string, object>(config);
//builder.SetValueDeserializer(typeof(string), typeof(string));
var consumer = builder.Build();
consumer.Subscribe("test");

while (true)
{
    //消费
    var result = consumer.Consume();
    Console.WriteLine(result);
    //提交消费确认 动提交，如果上面的EnableAutoCommit=true表示自动提交，则无需调用Commit方法
    consumer.Commit(result);
}