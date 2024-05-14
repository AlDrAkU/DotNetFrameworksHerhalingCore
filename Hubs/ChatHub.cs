using Microsoft.AspNetCore.SignalR;


// defineren van het Hub Klasse voor het verwerken van communicatie tussen client en server
public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}