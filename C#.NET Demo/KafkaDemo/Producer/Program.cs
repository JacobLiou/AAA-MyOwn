using Confluent.Kafka;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ProducerConfig config = new ProducerConfig();
config.BootstrapServers = "192.168.209.133:9092,192.168.209.134:9092,192.168.209.135:9092";
//ProducerBuilder <,> 类构造，有两个泛型参数，第一个是路由Key的类型，第二个是消息的类型
  var builder = new ProducerBuilder<string, object>(config);
//设置序列化方式
//builder.SetValueSerializer(new KafkaConverter())
var producer = builder.Build();
producer.Produce("test", new Message<string, object> { Key = "Test", Value="Hello World"});
Console.ReadKey();


