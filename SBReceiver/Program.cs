using Microsoft.Azure.ServiceBus;
using SBShared.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using SBShared.DTOs;
using SBReceiver.Services;
using SBReceiver.Interfaces;

namespace SBReceiver
{
    class Program
    {

        const string connectionString = "Endpoint=sb://azuremicroservices.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=rSFJQHOrd6XRtK8ZYvybBwZvHMk3kHMsN+ASbKnUf+Q=";
        const string queueName = "personqueue";

        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            //services.AddSingleton<IQueueClient, QueueClient>();
            services.AddSingleton<QueueClient>(provider => new QueueClient(connectionString, queueName));
            services.AddTransient<IMessageService,MessageService>();
            services.AddTransient<IMessageSerializer,MessageSerializer>();
            services.AddTransient<IMessageHandler<AddPersonMessageDTO>, AddPersonMessage>();
            services.AddTransient<IMessageHandler<UpdateAgeMessageDTO>, UpdateAgeMessage>();
            services.AddTransient<IMessageHandler<UpdateNameMessageDTO>, UpdateNameMessage>();
            services.AddTransient<IMessageHandler<DeletePersonMessageDTO>, DeletePersonMessage>();
            services.AddTransient<IMessageHandler<PrintPersonsListMessageDTO>, PrintPersonsListMessage>();
            services.AddSingleton<IMessageServiceProvider,MessageServiceProvider>();
            services.AddSingleton<IService, Service>();
            var serviceProvider = services.BuildServiceProvider();
            var messageServices = serviceProvider.GetRequiredService<IMessageService>();

            messageServices.Run();

        }

        

        
    }

}
