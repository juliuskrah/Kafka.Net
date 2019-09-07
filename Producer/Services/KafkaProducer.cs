using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer.Services
{
    public class KafkaProducer : IProducer
    {
        public async Task<DeliveryResult<Null, string>> Send()
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using(var p = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var dr = await p.ProduceAsync("some-topic", new Message<Null, string> { Value = "Some value"});
                    return dr;
                } catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }

                return null;
            }
        }
    }
}
