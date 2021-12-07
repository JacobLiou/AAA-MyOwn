using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRBlazor.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //�����˲��ٽ����Լ���������Ϣ
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}