# 📱 Mobile Phone Shop – Desktop GUI Application

![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=flat-square&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)

A Windows desktop app for a mobile phone shop. **Customers** can browse phones by brand, place orders and print a bill. **Admins** can add, edit and delete items in the shop's inventory.

---

## ✨ Features

**For customers**
- 🔍 Browse phones by brand: Apple, Samsung, Huawei, Xiaomi
- 📄 View phone details and place an order
- 🧾 Generate and print a bill

**For the shop owner**
- 🔐 Admin login and dashboard
- ✏️ Add, edit and delete items in the inventory

**Other**
- 🎨 Theme switching

---

## 🛠️ Tech Stack

| Part | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI | Windows Forms |
| Database | Microsoft SQL Server (`MobileDB`) |
| Data access | ADO.NET (`SqlConnection`) |

---

## ▶️ How to Run

**You need:** [Visual Studio](https://visualstudio.microsoft.com/vs/community/) (Community edition is free) and [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (free).

1. Restore the `MobileDB` database from the `GUI PROJECT/MobileDB` file.
2. Open `GUI PROJECT/mobile/mobile.sln` in Visual Studio.
3. In `App.config`, change the `connection` connection string so it points to your SQL Server.
4. Press **F5** to build and run.

---

## 📸 Screenshots

<!-- Add 2–3 screenshots here, for example: ![Home screen](screenshots/home.png) -->

---

## 📝 About

Built as a GUI programming project during my studies.
