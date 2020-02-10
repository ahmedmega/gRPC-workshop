
//using Greet;
using Grpc.Net.Client;
using GrpcServiceNameSpace;
using System;

namespace GrpcConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var channel = GrpcChannel.ForAddress("https://localhost:5003"))
            {

                var client = new Greeter.GreeterClient(channel);
                var reply = client.SayHello(
                                  new HelloRequest { Name = "Ahmed" });
                Console.WriteLine("Greeting: " + reply.Message);

            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
