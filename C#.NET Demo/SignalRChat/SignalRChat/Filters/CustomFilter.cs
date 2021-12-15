using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Filters
{

    /// <summary>
    /// 作为一个整合的通信框架
    /// RPC框架 
    /// 首先知晓6W1H
    /// 学会用
    /// 之后去熟悉底层
    /// 
    /// 
    /// 不管gRPC WCF SignalR Thrift ...
    /// </summary>
    public class CustomFilter : IHubFilter
    {
        public async ValueTask<object> InvokeMethodAsync(HubInvocationContext invocationContext,
            Func<HubInvocationContext, ValueTask<object>> next)
        {
            Console.WriteLine($"Calling hub method '{invocationContext.HubMethodName}'");
            try
            {
                return await next(invocationContext);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
