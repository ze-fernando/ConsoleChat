using Microsoft.AspNetCore.SignalR.Client;

string uri = "http://localhost:5001/ws";

var connection = new HubConnectionBuilder()
  .WithUrl(uri)
  .Build();


connection.On<string, string>("ReceiveMessage", (user, message) =>
{
    Console.WriteLine($"\n{user}: {message}");
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

while (true)
{
    // Console.Write("Message: ");
    string? message = Console.ReadLine();


    if (string.IsNullOrEmpty(message))
        break;

    try
    {
        await connection.InvokeAsync("SendMessage", user, message);
    }
    catch (Exception ex)
    {

        Console.WriteLine($"Erro ao conectar ao servidor {ex.Message}");
        return;
    }
}

Console.WriteLine("\nDesconectando...");
await connection.StopAsync();
