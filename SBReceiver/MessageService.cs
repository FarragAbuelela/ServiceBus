using Microsoft.Azure.ServiceBus;
using System;
using System.Threading;
using System.Threading.Tasks;
using SBReceiver.Services;
using SBReceiver.Interfaces;

namespace SBReceiver
{
    public class MessageService : IMessageService
    {
        private readonly IQueueClient _queueClient;
        private readonly IService _service;
        public MessageService(QueueClient queueClient, IService service)
        {
            _queueClient = queueClient;
            _service = service;
        }

        public async Task Run()
        {
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };

            _queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);

            Console.ReadLine();

            await _queueClient.CloseAsync();
        }

        private async Task ProcessMessagesAsync(Message message, CancellationToken token)
        {
            _service.Invoke(message);

            await _queueClient.CompleteAsync(message.SystemProperties.LockToken);
        }

        private Task ExceptionReceivedHandler(ExceptionReceivedEventArgs arg)
        {
            Console.WriteLine($"Message handler exception: {arg.Exception}");
            return Task.CompletedTask;
        }

    }

}
