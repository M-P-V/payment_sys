using Grpc.Net.Client;
using Payment.System.Transactions.Contracts;

GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5001");

var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);

Console.WriteLine("Shutting down");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();