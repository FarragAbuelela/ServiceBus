using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using SBShared.Const;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SBSender.Services
{
    public class QueueService : IQueueService
    {
        private readonly IConfiguration _config;

        public QueueService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendMessageAsync<T>(T serviceBusMessage, string queueName, Status action)
        {
            var queueClient = new QueueClient(_config.GetConnectionString("AzureServiceBus"), queueName);
            string messageBody = JsonSerializer.Serialize(serviceBusMessage);
            var message = new Message(Encoding.UTF8.GetBytes(messageBody));
            message.UserProperties.Add("Action", (int)action);
            await queueClient.SendAsync(message);
        }
    }
}
