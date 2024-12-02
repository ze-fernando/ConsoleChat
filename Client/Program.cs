using Microsoft.AspNetCore.SignalR.Client;

string uri = "http://localhost:5001/ws";

var connection = new HubConnectionBuilder()
  .WithUrl(uri)
  .Build();


connection.On<string, string>("ReceiveMessage", (user, message) =>
{
    Console.WriteLine($"\n{user}:{message}");
});

try
{
    Console.WriteLine("Concetando ao servidor");
    await connection.StartAsync();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao conectar ao servidor {ex.Message}");
    return;
}

Console.Write("Digite seu nome: ");
string? user = Console.ReadLine();


Console.Write("Digite o nome da room: ");
string? room = Console.ReadLine();


Console.WriteLine("Digite 'quit' para sair a qualquer instante");
await connection.InvokeAsync("AddRoom", room);

while (true)
{
    string? message = Console.ReadLine();

    if (message?.ToLower() == "quit")
    {
        await connection.InvokeAsync("LeftRoom", room);
        break;
    }

    if (string.IsNullOrEmpty(message)) break;

    await connection.InvokeAsync("SendMessage", room, user, message);
}

Console.WriteLine("\nDesconectando...");
await connection.StopAsync();
