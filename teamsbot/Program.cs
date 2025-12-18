using Microsoft.Teams.BotApps;

var teamsApp = TeamsBotApplication.CreateBuilder().Build();

teamsApp.OnMessage = (context, cancellationToken) =>
    context.SendActivityAsync("Hello! How can I assist you today?", cancellationToken);

teamsApp.Run();