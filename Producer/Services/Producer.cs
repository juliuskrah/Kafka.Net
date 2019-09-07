using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer.Services
{
    public interface IProducer
    {
        Task<DeliveryResult<Null, string>> Send();
    }
}
