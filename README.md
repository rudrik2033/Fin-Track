<p align="center">
  <img src="https://readme-typing-svg.demolab.com?font=Fira+Code&size=30&duration=8000&pause=500&color=1DD5C0&vCenter=true&multiline=true&width=1000&lines=Fin-Track+%F0%9F%93%81;Built+with+.NET+Web+Forms+%7C+SQL+Server+%7C+ADO.NET" alt="Typing SVG" />
</p>
<p align="center">
  <img src="https://readme-typing-svg.herokuapp.com?duration=3000&pause=700&center=true&vCenter=true&width=720&lines=Fin%E2%80%91Track+%F0%9F%92%B0+%7C+Personal+finance+%26+expense+manager;Track+expenses%2C+budgets%2C+categories%2C+and+reports;Built+with+.NET+(C%23)+%2B+SQL+Server;Clean+UI+%2B+Simple+workflow" alt="Animated Header">
</p>

<p align="center">
  <a href="#"><img alt="Status" src="https://img.shields.io/badge/status-active-brightgreen?style=for-the-badge"></a>
  <a href="#"><img alt="Made with C#" src="https://img.shields.io/badge/C%23-.NET-blueviolet?style=for-the-badge&logo=dotnet"></a>
  <a href="#"><img alt="License" src="https://img.shields.io/badge/license-MIT-informational?style=for-the-badge"></a>
  <a href="#"><img alt="PRs welcome" src="https://img.shields.io/badge/PRs-welcome-orange?style=for-the-badge"></a>
</p>

<p align="center">
  <sub>Finance made simple: add expenses, organize by categories, set budgets, and review insights.</sub>
</p>

---

## 📄 Project Overview

**Fin-Track** is a web-based application designed to help users efficiently manage Finance History for clients and services. It allows creation, tracking, editing, and deletion of Finance with integrated database support and a clean UI.

---

## ✨ Features

- ➕ **Add / Edit / Delete** transactions  
- 🗂️ **Categories** to organize spending  
- 🎯 **Budgets** with remaining-amount view  
- 🔎 **Search & filter** by date, category, notes  
- 📈 **Summary cards** (month/year/overall)  
- 💾 **SQL Server** persistence (SQL Server)  
- 🛡️ **Validation** for safe inputs  

---

## 🧱 Tech Stack

- **.NET (C#)** application  
- **SQL Server for storage  
- **Razor Pages and MVC**
- **Bootstrap + a bit of JavaScript** for interactivity  

---

## 📁 Project Structure (high-level)

```bash
Fin-Track/
│
├─ FinanceApp.sln
├─ FinanceApp/ # Main application project
│ ├─ Models/ # C# models (Transaction, Category, Budget, etc.)
│ ├─ Data/ # Db context / repository / SQL helpers
│ ├─ Controllers/ or Pages/ # MVC Controllers and razor pages
│ ├─ Views/ or *.aspx # UI (Razor views or Web Forms)
│ ├─ wwwroot/ or Content/ # CSS/JS/static assets
│ ├─ appsettings.json or Web.config # Connection string & config
│ └─ ...
└─ README.md
```


---

## ⚙️ Setup & Run (Visual Studio)

> **Prereqs:** Visual Studio 2019+ (or 2022), SQL Server/LocalDB, .NET SDK matching your solution.

1. **Clone**
   ```bash
   git clone https://github.com/rudrik2033/Fin-Track.git
   
2. **Open in Visual Studio**
   ```bash
    File → Open → Project/Solution… and select FinanceApp.sln.
    ```
   
3. **Set Startup Project**
   ```bash
    In Solution Explorer, right-click the main web project (e.g., FinanceApp) → Set as Startup Project.
    ```
   
4. **Restore NuGet Packages**
   ```bash
   Build → Restore NuGet Packages (or right-click solution → Restore).
   ```

5. **Configure Connection String**
   ```bash
    If your project uses appsettings.json (ASP.NET Core):
   "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=FinTrackDb;Trusted_Connection=True;TrustServerCertificate=True"
   }
   ```

7. **Apply Migrations / Create DB**
   
    ASP.NET Core (EF Core):
    Tools → NuGet Package Manager → Package Manager Console
   ```bash
   Update-Database
   ```

7. **Run**

    Press Ctrl + F5 (or F5 for debug).
    
    App will launch at something like https://localhost:xxxx/.

## **📬 Contact**

📧 Email: rudrik.bhatt11@gmail.com

🌐 GitHub: @rudrik2033
  
