# Teams Bot Template

A dotnet new template for creating Microsoft Teams bots using the Bot Framework SDK and Teams SDK.

## Installation

Install the template from the local directory:

```bash
dotnet new install ./
```

Or install from a NuGet package (once published):

```bash
dotnet new install TeamsBot.Template
```

## Usage

Create a new Teams bot project:

```bash
dotnet new teamsbot -n MyTeamsBot
cd MyTeamsBot
```

Optionally specify the target framework:

```bash
dotnet new teamsbot -n MyTeamsBot --Framework net9.0
```

## Configuration

Before running the bot, configure your Bot Framework credentials in `appsettings.json`:

```json
{
  "MicrosoftAppType": "MultiTenant",
  "MicrosoftAppId": "your-app-id",
  "MicrosoftAppPassword": "your-app-password",
  "MicrosoftAppTenantId": "your-tenant-id"
}
```

To get these credentials:
1. Register your bot at https://dev.botframework.com/
2. Create an Azure AD app registration
3. Copy the App ID and generate a client secret

## Running the Bot

Build and run the bot:

```bash
dotnet build
dotnet run
```

The bot will start on `https://localhost:5001` and `http://localhost:5000`.

## Testing with Bot Framework Emulator

1. Download the [Bot Framework Emulator](https://github.com/microsoft/BotFramework-Emulator/releases)
2. Open the emulator and connect to `http://localhost:5000/api/messages`
3. Enter your Microsoft App ID and Password if configured
4. Start chatting with your bot!

## Testing in Microsoft Teams

1. Use [ngrok](https://ngrok.com/) to create a public URL for your local bot:
   ```bash
   ngrok http 5000
   ```

2. Update your bot's messaging endpoint in the Azure Portal to the ngrok URL + `/api/messages`

3. Create a Teams app manifest and sideload it to Teams

## Features

This template includes:

- **Echo Bot**: A simple bot that echoes messages back to the user
- **Teams Activity Handler**: Extends TeamsActivityHandler for Teams-specific functionality
- **Error Handling**: Custom adapter with error handling and logging
- **Dependency Injection**: Properly configured services in Program.cs
- **Configuration**: Support for appsettings.json and environment variables

## Project Structure

```
MyTeamsBot/
├── Controllers/
│   └── BotController.cs          # API endpoint for bot messages
├── Properties/
│   └── launchSettings.json       # Development launch settings
├── AdapterWithErrorHandler.cs    # Bot adapter with error handling
├── TeamsBot.cs                   # Main bot implementation
├── Program.cs                    # Application entry point
├── appsettings.json             # Configuration file
└── MyTeamsBot.csproj            # Project file
```

## Customizing Your Bot

### Adding New Message Handlers

Override methods in `TeamsBot.cs`:

```csharp
protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
{
    // Your custom logic here
    await turnContext.SendActivityAsync(MessageFactory.Text("Hello!"), cancellationToken);
}
```

### Adding Teams-Specific Features

The bot extends `TeamsActivityHandler`, which provides Teams-specific methods:

- `OnTeamsChannelCreatedAsync`
- `OnTeamsChannelDeletedAsync`
- `OnTeamsMembersAddedAsync`
- `OnTeamsMembersRemovedAsync`

## Uninstalling the Template

```bash
dotnet new uninstall TeamsBot.Template
```

## License

See the [LICENSE](LICENSE) file for license rights and limitations.