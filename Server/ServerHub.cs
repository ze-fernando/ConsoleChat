using Microsoft.AspNetCore.SignalR;

public class ServerHub : Hub
{
    public async Task SendMessage(string room, string user, string message)
    {
        await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
    }

    public async Task AddRoom(string room, string user)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, room);
        await Clients.Group(room).SendAsync("ReceiveMessage", "Server: ", $"{user} entrou na sala {room}");
    }

    public async Task LeftRoom(string room, string user)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, room);
        await Clients.Group(room).SendAsync("ReceiveMessage", "Server: ", $"{user} saiu da sala {room}");
    }
}
