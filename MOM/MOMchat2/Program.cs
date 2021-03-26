using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace MOMchat2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };

            using (var connection = connectionFactory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                while (true)
                {
                    Console.WriteLine("################");
                    Console.WriteLine("Digite sua mensagem:");

                    var teste = Console.ReadLine();
                    Console.WriteLine("###############");

                    string message =
                        $"{DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss")} -" +
                        $"Conteúdo da mensagem: {teste}";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(
                        exchange: "",
                        routingKey: "tests2",
                        basicProperties: null,
                        body: body
                        );

                    channel.QueueDeclare(
                        queue: "tests",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (sender, eventArgs) =>
                    {
                        var body = eventArgs.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);

                        Console.WriteLine(Environment.NewLine + "[Nova mensagem recebida] " + message);
                    };

                    channel.BasicConsume(queue: "tests",
                         autoAck: true,
                         consumer: consumer);
                }
            }
        }
    }
}
