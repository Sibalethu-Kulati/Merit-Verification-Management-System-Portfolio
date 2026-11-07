# Merit Verification Management System

## Project Overview

The Merit Verification System is a C# Windows Forms desktop application designed to streamline the management and verification of learners' academic merits and certificates.

It provides role-based access for schools and verifying organisations, enabling authorised users to manage learner records and support the verification process through a centralised system.

## Key Features

- Secure user authentication.
- Role-based access control.
- Learner record management.
- School and organisation management.
- Institutional access requests.
- Application approval and rejection.
- Merit and certificate verification.
- Email notifications.

## Technologies Used

| Technology | Purpose |
|---|---|
| C# | Application development |
| Windows Forms (.NET 10) | Desktop user interface |
| Microsoft SQL Server | Database management |
| ADO.NET | Database connectivity and operations |
| BCrypt | Password hashing |
| Gmail SMTP | Email notifications |
| Visual Studio | Development environment |

## User Roles

The system supports the following user roles:

1. System Administrator
2. School IT Administrator
3. Organisation IT Administrator
4. School Clerk
5. Learner
6. Verifier Representative

Each role has access to specific functionalities based on its responsibilities and permissions.

## System Architecture

The application follows a layered architecture to separate responsibilities and improve maintainability.

- **Presentation Layer:** Handles the user interface, forms and visual components.
- **Navigation Layer:** Manages navigation between application screens.
- **Business Logic Layer:** Handles application rules, processes and operations.
- **Data Access Layer:** Manages database communication and SQL queries.

## System Requirements

- Windows 10 or Windows 11.
- Visual Studio 2022 or later.
- .NET 10 SDK.
- Microsoft SQL Server.
- SQL Server Management Studio (SSMS).

## Installation and Setup

### 1. Clone the Repository

```bash
git clone https://github.com/Sibalethu-Kulati/Merit-Verification-Management-System-Portfolio.git
```

### 2. Open the Project

Open the solution or project in Visual Studio.

### 3. Set Up the Database

- Open SQL Server Management Studio.
- Connect to your local SQL Server instance.
- Open `DATABASE_SETUP.sql`.
- Execute the script to create the `merit_cert_verification` database and its tables.

### 4. Configure the Database Connection

Open the database connection class and update the connection string to match your local SQL Server instance.

### 5. Configure Email Settings

- Locate `emailSettings.example.json` in the project folder.
- Make a copy of the file.
- Rename the copy to `emailSettings.json`.
- Enter your own Gmail address and Gmail App Password.

**Important:** Keep your actual email credentials private. The real settings file is excluded from Git through `.gitignore`.

A Gmail App Password is required for email notifications to work.

### 6. Build and Run

Open the project in Visual Studio, build the solution and run the application.

## Contributors

**Sibalethu Kulati**

GitHub: https://github.com/Sibalethu-Kulati

**Lamla July**

GitHub: https://github.com/lamlajuly68

---

Developed as an academic software development project.