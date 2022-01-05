
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revanth.MessageBus
{
  public  class AzureServiceBusMessageBus:IMessageBus
    {
        private string connectionString = "Endpoint=sb://revanthrestaurant.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=Y8YGcbQSabOlXwmfv2nVaDGvXugmCGRDMxea6O4i+DY=";

        public async Task PublishMessage(BaseMessage message, string topicName)
        {

            //await using var client = new ServiceBusClient(connectionString);

            //ServiceBusSender sender = client.CreateSender(topicName);
            //ISenderClient senderClient = new TopicClient(connectionString, topicName);
            //var jsonMessage = JsonConvert.SerializeObject(message);
            //var finalMessage = new Message(Encoding.UTF8.GetBytes(jsonMessage))
            //{
            //    CorrelationId = Guid.NewGuid().ToString()
            //};

            ////await sender.SendMessageAsync(finalMessage);

            ////await client.DisposeAsync();

            //await senderClient.SendAsync(finalMessage);
            //await senderClient.CloseAsync();

            await using var client = new ServiceBusClient(connectionString);

            ServiceBusSender sender = client.CreateSender(topicName);

            var jsonMessage = JsonConvert.SerializeObject(message);
            ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding.UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString()
            };

            await sender.SendMessageAsync(finalMessage);

            await client.DisposeAsync();
        }
    }
}
