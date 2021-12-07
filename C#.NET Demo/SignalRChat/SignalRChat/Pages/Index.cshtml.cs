using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;

namespace SignalRChat.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IHubContext<Chathub> _hubContext;


        public IndexModel(IHubContext<Chathub> hubContext, ILogger<IndexModel> logger)
        {
            _hubContext = hubContext;
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}