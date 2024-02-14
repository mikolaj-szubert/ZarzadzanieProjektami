# Zarzadzanie Projektami  
The system has an administrator account that allows access to manage users and allows you to assign permissions.  
Moderator and Admin can edit and delete projects, and any logged-in user can add and edit tasks in a project.  
In addition, any user, even those not logged in, can view projects.  

### Requirements:
- [Visual Studio 2022](https://visualstudio.microsoft.com/pl/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030)
- .NET 8.0 (installed by default along with Visual Studio 2022)

### Steps to run locally:
1. Download repository from [here](https://github.com/mikolaj-szubert/ZarzadzanieProjektami/releases/latest).
2. Open it with Visual Studio 2022 by double clicking "ZarzadzanieProjektami.sln".
3. Run by clicking "https" at the top bar.

### In case of error with migrations:  
1. Go to Tools -> NuGet package manager -> Package manager console.
2. Type:  
Add-Migration "Name of migration"  
Update-Database  
