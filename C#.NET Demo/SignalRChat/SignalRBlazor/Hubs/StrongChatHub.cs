using Microsoft.AspNetCore.SignalR;

namespace SignalRBlazor.Hubs
{
    /// <summary>
    /// Strongly typed hubs
    /// 
    /// Hub类型已经基础废弃  Hub依赖方法名来做RPC映射 很容易出错
    /// 
    /// </summary>
    public class StrongChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }


        //[HubMethodName("修改名字映射")]
        public async Task SendMessageToCaller(string user, string message)
        {
            await Clients.Caller.ReceiveMessage(user, message);
        }
    }
}
