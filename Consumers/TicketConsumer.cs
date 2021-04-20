using Chatroom.Models;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatroom.Consumers
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        public Task Consume(ConsumeContext<Ticket> context)
        {
            var data = context.Message;
            throw new NotImplementedException();
        }
    }
}
