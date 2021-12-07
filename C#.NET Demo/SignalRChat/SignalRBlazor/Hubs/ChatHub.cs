using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRBlazor.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //发出端不再接收自己发出的信息
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}