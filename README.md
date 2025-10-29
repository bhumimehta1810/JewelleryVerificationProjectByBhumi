# JewelleryVerificationProjectByBhumi
A web-based Jewellery Verification System for Uni Design Company. It stores and manages jewellery certification details like company branch, bag/order/design numbers, customer, certificate info, and weight using .NET 9 and SQL Server for secure and efficient data handling.
# 💎 Jewellery Verification Project

### 🏢 Developed for: Uni Design Company  
### 👩‍💻 Developer: [Bhumi Mehta](https://github.com/bhumimehta1810)  
📧 **Email:** 23amtics387@gmail.com  
📘 **Project Type:** College Project  
🗄️ **Database:** SQLite  



## 📖 Overview

The **Jewellery Verification Project** is a .NET 9 MVC-based web application developed for **Uni Design Company**.  
Its primary purpose is to **store, verify, and manage jewellery certification data** efficiently and securely.  
The system allows users to maintain detailed records of jewellery pieces, including their **certificate number, type, purity, weight, and other essential details**.  

By integrating **Entity Framework** with a **SQLite database**, this system ensures smooth data management and reliable storage.  
The project features a **clean user interface**, simple navigation, and secure access, making it a perfect blend of **functionality and design**.



## 🧩 Features

- 📝 Add, update, and view jewellery certification details  
- 🔐 User authentication system (login/logout)  
- 📊 Analytics and reporting for stored jewellery data  
- 🪶 Clean and responsive front-end design  
- 💾 Integration with SQLite database for secure data handling  
- ⚙️ Admin dashboard to monitor and verify jewellery entries  



## 🛠️ Technologies Used

| Category | Technologies |
|-----------|--------------|
| Backend | .NET 9 (C#), ASP.NET MVC |
| Database | SQLite, Entity Framework |
| Frontend | HTML, CSS, JavaScript |
| Tools | Visual Studio, Git, GitHub |



## 🧠 Project Goal

> To verify and manage jewellery authenticity records efficiently for **Uni Design Company**.



## ⚙️ Installation & Setup

Follow these steps to run the project locally:

```bash
# 1️⃣ Clone this repository
git clone https://github.com/bhumimehta1810/JewelleryVerificationProject.git

# 2️⃣ Navigate to the project folder
cd JewelleryVerificationProject

# 3️⃣ Restore dependencies
dotnet restore

# 4️⃣ Build the project
dotnet build

# 5️⃣ Run the project
dotnet run
```

Once running, open your browser and go to:  
👉 **https://localhost:5001**  



## 🧾 Database Information

The application uses **SQLite** as its primary database.  
All jewellery-related data (certificate number, type, purity, and more) are securely stored within the database.  
The database connection string can be configured in the `appsettings.json` file.  



## 📂 Project Structure

```
JewelleryVerificationProject/
│
├── Controllers/
│   ├── AccountControllers.cs
│   ├── AnalyticsControllers.cs
│   ├── DataControllers.cs
│   ├── HomeController.cs
│
├── Models/
│   ├── JewelleryData.cs
│   ├── ErrorViewModel.cs
│
├── Views/
│   ├── Account/
│   ├── Analytics/
│   ├── Data/
│   ├── Home/
│   ├── Shared/
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── images/
│       ├── companylogo.png
│       ├── jewel1.png
│       ├── jewel2.png
│       ├── jewellery-banner.jpg
│       ├── newlogo.png
│
├── appsettings.json
├── Program.cs
├── JewelleryVerificationProject.csproj
└── README.md

## 🚀 Future Enhancements

- ✅ Add export options (PDF/Excel) for certification data  
- ✅ Implement search & filter functionality  
- ✅ Introduce role-based access for admin & staff  
- ✅ Add cloud-based database storage (Azure SQL)  


## 🧑‍💻 Developer Information

**Name:** Bhumi Mehta  
**GitHub:** [github.com/bhumimehta1810](https://github.com/bhumimehta1810)  
**Email:** 23amtics387@gmail.com  

## ⭐ Acknowledgement

This project was created as part of a **college project** to demonstrate the integration of **.NET MVC architecture with database management** for real-world applications in jewellery verification and record maintenance.
