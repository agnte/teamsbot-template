# Teams Bot Template

A dotnet new template for creating Microsoft Teams bots using the Bot Framework SDK and Teams SDK.

## Installation

Install the template from the local directory:

```bash
dotnet add package Rido.TeamsBot.Template --version
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
dotnet run
```

The bot will start on `https://localhost:5001` and `http://localhost:5000`.

