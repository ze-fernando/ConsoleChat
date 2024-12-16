# WebChat via Console com SignalR

Este projeto é um chat de console simples desenvolvido em C#, que utiliza o SignalR para comunicação em tempo real. A aplicação permite que usuários se conectem ao servidor e troquem mensagens instantaneamente, com suporte a múltiplas salas de chat, onde os usuários podem interagir em grupos específicos.

## Funcionalidades

-   **Envio de mensagens em tempo real:** Usuários podem enviar mensagens instantaneamente entre si.
-   **Conexão via SignalR:** Comunicação eficiente e em tempo real entre o servidor e os clientes utilizando o SignalR, uma biblioteca da Microsoft.
-   **Chat por salas:** Os usuários podem se conectar a diferentes salas de chat e interagir apenas com os participantes da mesma sala.
-   **Interface de terminal/console simples:** A interação é feita diretamente no console, sem necessidade de interface gráfica.
-   **Conexão múltipla:** Vários clientes podem se conectar ao servidor e interagir simultaneamente.

## Requisitos

-   .NET 6.0 ou superior
-   Ambiente de desenvolvimento configurado com C# e SignalR
-   Pacote NuGet `Microsoft.AspNetCore.SignalR`

## Como usar

1.  Clone este repositório para sua máquina local:
    
    ```bash
    git clone https://github.com/ze-fernando/ConsoleChat
    
    ```
    
2.  Navegue até o diretório do projeto:
    
    ```bash
    cd ConsoleChat
    
    ```
    
3.  Instale o pacote SignalR no projeto:
    
    ```bash
    dotnet add package Microsoft.AspNetCore.SignalR
    
    ```
    
4.  Compile e execute o projeto:
    
    ```bash
    dotnet run
    
    ```
    
5.  Ao executar o servidor, ele ficará aguardando conexões dos clientes. Para testar, abra múltiplos terminais e execute o cliente em cada um, conectando-se ao servidor via SignalR.
    
6.  **Escolha uma sala de chat:** Ao conectar, o cliente escolhe uma sala de chat. Somente os usuários dentro da mesma sala podem se comunicar.
    
7.  Envie mensagens e veja a interação entre os usuários dentro da mesma sala.
    
## Exemplo de Uso

1.  Execute o servidor:
    
    ```bash
    dotnet run
    
    ```
    
2.  Abra um novo terminal e execute o cliente:
    
    ```bash
    dotnet run
    
    ```
    
3.  O cliente será solicitado a escolher uma sala de chat (exemplo: "Sala1", "Sala2", etc.).
    
4.  Envie mensagens para a sala escolhida. Apenas os clientes conectados à mesma sala receberão as mensagens.
    

## Contribuição

Sinta-se à vontade para contribuir com melhorias ou novas funcionalidades. Para contribuir:

1.  Faça um fork deste repositório.
2.  Crie uma branch para sua feature (`git checkout -b feature/nova-funcionalidade`).
3.  Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`).
4.  Envie a branch para o repositório remoto (`git push origin feature/nova-funcionalidade`).
5.  Abra um pull request.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.
