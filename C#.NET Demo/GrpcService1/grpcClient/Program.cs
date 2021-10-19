using System;
using Grpc.Net.Client;
using GrpcService1;
namespace grpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = client.SayHello(new HelloRequest(){ Name = nameof(AppDomain.CurrentDomain) });
            Console.WriteLine(reply.Message);
            Console.WriteLine("Hello World!");
        }
    }
}
