using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccessLayer.Concretes;

namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        SignalRContext _context = new SignalRContext();

        public async Task SendCategoryCount()
        {
            var result = _context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", result);
        }
    }
}
