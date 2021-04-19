using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatroom.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string user, string message)
        {
            try
            {
                await Clients.All.SendAsync("Send", user, message);
            }
            catch (Exception ex)
            {
                await Clients.All.SendAsync("HandleException", ex.Message);
            }
        }
    }
}
