namespace Moss_and_Lichens_Labs.Pages.ScrumValuesChart.Hubs
{
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }    
}
