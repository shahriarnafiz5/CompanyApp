# 🔐 C# Login & Registration System

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET"/>
  <img src="https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server"/>
  <img src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white" alt="Visual Studio"/>
  <img src="https://img.shields.io/badge/WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms"/>
</p>

<p align="center">
  <b>A simple C# Windows Forms Login & Registration application connected to SQL Server.</b>
</p>

---

## 📌 Project Description

This project was developed as part of a **university C# programming assignment**.

The purpose of the assignment is to understand how a C# desktop application communicates with a **SQL Server database using ADO.NET** and to build a functional authentication system.

The application includes user registration, login, logout, password hashing, SQL injection prevention, and displaying registered users.

---

## ✨ Features

* 🔐 User Login
* 📝 User Registration
* 🚪 User Logout
* 👤 User information management
* 🔒 SHA-256 password hashing
* 🛡️ Parameterized SQL queries
* 🚫 SQL Injection prevention
* 🗄️ SQL Server database integration
* 📊 User list using DataGridView
* ⚠️ Input validation and error handling
* 🔄 Proper database connection handling

---

## 🛠️ Technologies Used

| Technology        | Purpose                          |
| ----------------- | -------------------------------- |
| **C#**            | Application programming language |
| **Windows Forms** | Desktop application interface    |
| **.NET**          | Application framework            |
| **SQL Server**    | Database management              |
| **ADO.NET**       | Database connectivity            |
| **Visual Studio** | Development environment          |
| **GitHub**        | Source code management           |

---

## 🗄️ Database

The application uses **SQL Server** as its database.

The database contains a `Users` table for storing registered user information.

The database creation and table structure are provided in:

```text
Schema.sql
```

Passwords are stored as **SHA-256 hashes** instead of plain-text passwords.

---

## 🔄 Application Flow

```text
             ┌──────────────┐
             │     Login    │
             └──────┬───────┘
                    │
          ┌─────────┴─────────┐
          │                   │
       Register             Login
          │                   │
          ▼                   ▼
   ┌──────────────┐    ┌──────────────┐
   │ Registration │    │    Home      │
   │     Form     │    │    Form      │
   └──────────────┘    └──────┬───────┘
                               │
                               ▼
                          ┌─────────┐
                          │ Logout  │
                          └────┬────┘
                               │
                               ▼
                             Login
```

---

## 🔒 Security

The project demonstrates basic security practices for a database-driven application.

### Password Hashing

Passwords are hashed using **SHA-256** before being stored in the database.

The actual password is never stored as plain text.

### SQL Injection Protection

All database queries use **parameterized SQL commands** instead of directly concatenating user input into SQL statements.

This prevents malicious input from being interpreted as SQL code.

---

## 📸 Screenshots

### 🔑 Login Form

*Add your login screenshot here.*

```text
screenshots/login.png
```

### 📝 Registration Form

*Add your registration screenshot here.*

```text
screenshots/registration.png
```

### 🏠 Home Form

*Add your home/dashboard screenshot here.*

```text
screenshots/home.png
```

### 📊 User List

*Add your DataGridView screenshot here.*

```text
screenshots/users.png
```

### 🚪 Logout

*Add your logout screenshot here.*

```text
screenshots/logout.png
```

---

## 📂 Project Structure

```text
C-Sharp/
│
├── LoginSystem/
│   ├── Forms/
│   ├── Classes/
│   ├── Properties/
│   ├── App.config
│   └── Program.cs
│
├── Schema.sql
├── README.md
└── .gitignore
```

---

## 💻 Development

This application was **coded and developed by me** as part of a university assignment.

The project was developed using **C#, Windows Forms, SQL Server, and ADO.NET** in Microsoft Visual Studio.

---

## 🎓 Assignment

This project was completed according to the requirements provided for the university C# / Windows Forms assignment.

The assignment focuses on:

* C# Windows Forms development
* SQL Server database connectivity
* ADO.NET
* Registration and authentication
* Password hashing
* Parameterized queries
* SQL Injection prevention
* Database operations
* Proper resource management

---

## 👨‍💻 Author

### Zarif Al-afraim

**University Student | C# & Windows Forms Project**

<p align="center">
  Made with ❤️ using C# and .NET
</p>
