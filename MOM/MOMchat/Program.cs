using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace MOMchat
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
                Password = "guest",
            };
            using (var connection = connectionFactory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                while (true)
                {
                    Console.WriteLine("Digite sua mensagem:");

                    var teste = Console.ReadLine();

                    channel.QueueDeclare(
                        queue: "tests",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                        );

                    string message =
                        $"{DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss")} - " +
                        $"Conteúdo da mensagem: {teste}";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(
                        exchange: "",
                        routingKey: "tests",
                        basicProperties: null,
                        body: body
                        );

                    channel.QueueDeclare(
                        queue: "tests2",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                        );
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (sender, EventArgs) =>
                    {
                        var body = EventArgs.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);

                        Console.WriteLine(Environment.NewLine + "[Nova mensagem recebida] " + message);
                    };

                    channel.BasicConsume(
                        queue: "tests2",
                        autoAck: true,
                        consumer: consumer
                        );
                }
            }
        }
    }
}
