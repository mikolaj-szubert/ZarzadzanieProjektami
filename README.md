# Project Manager
[![.NET](https://github.com/mikolaj-szubert/ZarzadzanieProjektami/actions/workflows/dotnet.yml/badge.svg)](https://github.com/mikolaj-szubert/ZarzadzanieProjektami/actions/workflows/dotnet.yml) [![CodeQL](https://github.com/mikolaj-szubert/ZarzadzanieProjektami/actions/workflows/github-code-scanning/codeql/badge.svg?branch=master)](https://github.com/mikolaj-szubert/ZarzadzanieProjektami/actions/workflows/github-code-scanning/codeql)  
## Roles  
| Role | Capabilities |
| ---|---|
| Unlogged user | Viewing projects |
| Logged in user | Viewing projects, viewing and managing tasks, chatting |
| Moderator | Viewing projects, viewing and managing tasks, chatting, project management |
| Admin | Viewing projects, viewing and managing tasks, chatting, project management, user role management |

## Requirements:
- [Visual Studio 2022](https://visualstudio.microsoft.com/pl/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030)
- .NET 8.0 (installed by default along with Visual Studio 2022)

## Steps to run locally:
1. Download repository from [here](https://github.com/mikolaj-szubert/ZarzadzanieProjektami/releases/latest).
2. Open it with Visual Studio 2022 by double clicking "ZarzadzanieProjektami.sln".
3. Run by clicking "https" at the top bar.

## In case of error with migrations:  
1. Go to Tools -> NuGet package manager -> Package manager console.  
2. Type:  
```sh
Add-Migration "Name of migration"  
Update-Database  
```  
## Contributing  
If you have suggestions for how Project Manager could be improved, or want to report a bug, open an issue!  
All and any contributions are appreciated.  
Please remember that there is a [Code of Conduct](/CODE_OF_CONDUCT.md) that must be adhered to.
## License  
[The Unlicense](/LICENSE.txt) © 2024 [mikolaj-szubert](../../..)
