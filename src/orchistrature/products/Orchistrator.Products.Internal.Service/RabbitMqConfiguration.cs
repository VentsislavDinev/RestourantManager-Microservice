using System;
using System.Collections.Generic;
using System.Text;

namespace Orchistrator.Products.Internal.Service
{
    public class RabbitMqConfiguration
    {
        public string Hostname { get; set; }
        public string QueueName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
