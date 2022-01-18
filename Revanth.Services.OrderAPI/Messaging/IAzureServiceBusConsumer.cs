using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revanth.Services.OrderAPI.Messaging
{
  public  interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
