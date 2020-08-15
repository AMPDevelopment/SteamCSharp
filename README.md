# SteamCSharp

[![Support Server Invite](https://img.shields.io/discord/695727580950691960.svg?color=7289da&label=AMP%20Development&logo=discord&style=flat-square)](https://discord.gg/WgUDVAk)
[![NuGet version (SteamCSharp)](https://img.shields.io/nuget/v/SteamCSharp.svg?style=flat-square)](https://www.nuget.org/packages/SteamCSharp/)

SteamCSharp is a easy to use API Wrapper for any developement.  
The aim of this project is to simplify the complexity of the [Steam Web API](https://partner.steamgames.com/doc/webapi).

## Get started

### Steam Web API
1. Sign into your [Steam Community](https://steamcommunity.com/login) account
2. Visit the [Steam Web API Key](https://steamcommunity.com/dev/apikey) page  
2.1 Register for a new Steam Web API Key if not already registered.  
2.2 Be sure you have read the [Steam Web API Terms of Use](https://steamcommunity.com/dev/apiterms)!  
    ```
    11. Termination
    Valve may change, suspend or discontinue the Steam Web API and suspend or terminate your use of the Steam Web API, Steam Data, and/or Valve Brand & Links at any time for any reason, without notice. 
    You may also terminate by ceasing to use the Steam Web API, Steam Data, and Valve Brand & Links, removing implementation of the Steam Web API from your Application, and deleting all copies of the Steam Data and Valve Brand & Links.
    ```
    This could be the worst case for your application, so please be aware to follow the [Steam Web API Terms of Use](https://steamcommunity.com/dev/apiterms).
3. The key which you are able to see now is mandatory to use the [Steam Web API](https://partner.steamgames.com/doc/webapi).

**Note:** Protect your key, do not share it, and change it immediately if it is compromised!

## Program Code
```CSharp
using SteamCSharp;

namespace SteamExample
{
    public class Program 
    {
        private Steam steam;
        
        public static void Main(string[] args)
        {
            steam = new Steam("STEAM WEB API KEY");
        }
    }
}
```

## Features / To-do
* [x] Asynchronous support
* [ ] Automated Method Version Detector
* Simplified Steam Games Support (Statistics)
    * [ ] Counter-Strike: Global Offensive
    * [ ] Team Fortress 2
    * *open for requests*
* Readable Entities
    * [ ] Steam User (Community)
    * [ ] Steam User (Statistics)
    * [ ] Steam Game (Statistics)
    * [ ] Steam News
* [ ] Interaction with Steam Users (Chat)  
*Current features / to-do list for the major version.  
Game Server, VAC support and much more coming after Version 1.0.0!* 

## Installation

NuGet Package-Console  
`Install-Package SteamCSharp`

## Contact
**Discord:** `.OnlyOneCookie#1337`  
**Email:** `contact@onlyonecookie.ch`
