using Confluent.Kafka;
using System.Threading.Tasks;

namespace Producer.Services
{
    public interface IProducer
    {
        Task<DeliveryResult<string, string>> Send(string key, string value);
    }
}
