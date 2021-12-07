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

        /// <summary>
        /// SignalR中的分组 用户 概念
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendPrivateMessage(string user, string message)
        {
            await Clients.User(user).SendAsync("ReceiveMessage", message);
        }


        //广播 多播 单播
        //Groups are ideal for something like a chat application,
        //SignalR 非常适合聊天 IM程序
       // WebSockets  或者 SignalR

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Send",
                $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName); 
            await Clients.Groups(groupName).SendAsync("Send",
                $"{Context.ConnectionId} has left the group {groupName}.");
        }
    }
}
