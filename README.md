# Teams Bot Template

A dotnet new template for creating Microsoft Teams bots using the Bot Framework SDK and Teams SDK.

## Installation

Install the template from the local directory:

```bash
dotnet new install Rido.TeamsBot.Template.nupkg
```

Or install from a NuGet package (once published):



## Usage

Create a new Teams bot project:

```bash
dotnet new teamsbot -n MyTeamsBot
cd MyTeamsBot
```


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



