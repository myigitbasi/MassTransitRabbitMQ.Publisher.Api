using MassTranRabbitMQ.Contracts;
using MassTransit;

namespace MassTranRabitMQ.Consumer.Api.Consumers
{
    public class EmailMessageConsumer : IConsumer<EMailModel>
    {
        public Task Consume(ConsumeContext<EMailModel> context)
        {
            Console.WriteLine(context.Message.Message);
            return Task.CompletedTask;
        }
    }
}
