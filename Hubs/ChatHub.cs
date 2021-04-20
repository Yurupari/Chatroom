using Chatroom.Models;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatroom.Hubs
{
    public class ChatHub : Hub
    {

        private readonly IBus _bus;

        public ChatHub(IBus bus)
        {
            _bus = bus;
        }

        public async Task Send(string user, string message)
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.UserName = user;
                ticket.Boarding = message;
                ticket.BookedOn = DateTime.Now;
                Uri uri = new Uri("rabbitmq://localhost/ticketQueue");
                var endpoint = await _bus.GetSendEndpoint(uri);
                await endpoint.Send(ticket);
                await Clients.All.SendAsync("Send", user, message);
            }
            catch (Exception ex)
            {
                await Clients.All.SendAsync("HandleException", ex.Message);
            }
        }
    }
}
