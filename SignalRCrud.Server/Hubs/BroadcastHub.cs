using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using SignalRCrud.Shared;

namespace SignalRCrud.Server.Hubs
{
    public class BroadcastHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }

        public async Task BrodcastBook(Book book)
        {
            await Clients.All.SendAsync("ReceiveBook", book);
        }
    }
}