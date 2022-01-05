using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revanth.Services.Email.Messaging
{
  public  interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
