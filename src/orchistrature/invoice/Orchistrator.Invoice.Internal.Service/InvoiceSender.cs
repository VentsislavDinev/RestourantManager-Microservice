﻿using Abp.Application.Services;

using Domain.Invoice.Model;

using Microsoft.Extensions.Options;

using Newtonsoft.Json;

using RabbitMQ.Client;

using System;
using System.Collections.Generic;
using System.Text;

namespace Orchistrator.Invoice.Internal.Service
{
    public class InvoiceSender : ApplicationService, IInvoiceSender
    {

        private readonly string _hostname;
        private readonly string _queueName;
        private readonly string _username;
        private readonly string _password;

        public InvoiceSender(IOptions<RabbitMqConfiguration> rabbitMqOptions)
        {
            _hostname = rabbitMqOptions.Value.Hostname;
            _queueName = rabbitMqOptions.Value.QueueName;
            _username = rabbitMqOptions.Value.UserName;
            _password = rabbitMqOptions.Value.Password;
        }

        public void SendWaitList(InvoiceEntity customer)
        {
            var factory = new ConnectionFactory() { HostName = _hostname, UserName = _username, Password = _password };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                var json = JsonConvert.SerializeObject(customer);
                var body = Encoding.UTF8.GetBytes(json);

                channel.BasicPublish(exchange: "", routingKey: _queueName, basicProperties: null, body: body);
            }
        }
    }
}
