using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    /// <summary>
    /// The Hub class manages connections, groups, and messaging.
    /// SignalR的Hub提供了所有的抽象封装
    /// </summary>
    public class Chathub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
