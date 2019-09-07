using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Producer.Services
{
    public class KafkaProducer : IProducer
    {
        private IProducer<string, string> producer;

        public KafkaProducer(IConfiguration configuration)
        {
            var config = new Dictionary<string, string>
            {
                { "bootstrap.servers", configuration.GetValue<string>("Kafka:BootstrapServers") }
            };

            producer = new ProducerBuilder<string, string>(config).Build();
        }

        public async Task<DeliveryResult<string, string>> Send(string key, string value)
        {
            return await producer.ProduceAsync("some-topic", new Message<string, string> { Key = key, Value = value });
        }
    }
}
