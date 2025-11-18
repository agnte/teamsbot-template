# TeamsBot

## Configuration

Before running the bot, configure your Bot Framework credentials in `appsettings.json`:

```json
{
  "Teams" : {
    "ClientId": "",
    "TenantId": "",
    "ClientSecret": ""
  }
}
```


## Running the Bot

Build and run the bot:

```bash
dotnet build
dotnet run --no-restore --no-build -- --urls "http://localhost:3978"
```

The bot will start on `http://localhost:3978`

