using SBShared.Const;
using System.Threading.Tasks;

namespace SBSender.Services
{
    public interface IQueueService
    {
        Task SendMessageAsync<T>(T serviceBusMessage, string queueName, Status action);
    }
}