# CompanyApp

CompanyApp is a single Windows Forms desktop application that combines a **login/registration
system** with an **Employee Management (CRUD) system**, backed by one SQL Server database.

Originally these were two separate projects — a Login-and-Register app using MS Access, and an
Employee Details app using SQL Server — which have been merged into one unified application.

## What It Does

- **Login** — Users must log in with a username and password before they can access the system.
- **Register** — New users can create an account.
- **Dashboard** — After logging in, the user lands on a dashboard with access to the Employee
  Management screen.
- **Employee Management (CRUD)** — Add, view, update, and delete employee records (Name, Age,
  Contact, Gender). Each employee record shows which user created it.
- **Logout** — Logs the user out and returns to the login screen.

## Tech Stack

- **Language/Framework**: C#, Windows Forms (.NET Framework)
- **Database**: SQL Server (LocalDB), accessed via `System.Data.SqlClient`
- **IDE**: Visual Studio

## Database

One database, `dbCompanyApp`, with two linked tables:

- `Users` — stores login accounts (`UserID`, `Username`, `Password`, `CreatedAt`)
- `Emp_details` — stores employee records (`EmpId`, `EmpName`, `EmpAge`, `EmpContact`,
  `EmpGender`, `CreatedBy`)

`Emp_details.CreatedBy` links to `Users.UserID`, so each employee record is tied to the user who
created it.

## How to Run

1. Open the solution in Visual Studio.
2. Make sure `dbCompanyApp` exists in your SQL Server / LocalDB instance (run `Schema.sql` to
   create it).
3. Update the connection string in `App.config` if needed.
4. Build and run — the app starts on the Login screen.

## Project Structure

- `frmLogin` — Login screen
- `frmRegister` — Registration screen
- `frmDashboard` — Main dashboard after login
- `frmEmployee` — Employee CRUD screen
- `User.cs` — Handles login/registration database logic
- `Employee.cs` — Handles employee database logic
- `Session.cs` — Keeps track of the currently logged-in user
