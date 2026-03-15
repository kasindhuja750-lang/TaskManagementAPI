# Task Management Application

A full-stack Task Management application built using **ASP.NET Core Web API** with **JWT Authentication** and a simple **HTML, CSS, JavaScript frontend**.

This application allows users to create, manage, update, and delete tasks easily through a clean and professional interface.

---

## Features

- User Registration
- User Login
- JWT Authentication
- Create Task
- View All Tasks
- Update Task Status
- Delete Task
- Professional Frontend UI
- Clean Architecture

---

## Technologies Used

### Backend
- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- JWT Authentication

### Frontend
- HTML
- CSS
- JavaScript

### Tools
- Visual Studio
- Swagger
- GitHub

---

## Project Architecture

The project follows **clean layered architecture**:
Controllers → API endpoints
Services → Business logic
Repositories → Database operations
DTOs → Data transfer objects
Models → Database entities
Mappings → AutoMapper configuration
Data → DbContext configuration

---

## API Endpoints

### Authentication

Register User
POST /api/users/register

Login User
POST /api/users/login

---

### Tasks

Get All Tasks
GET /api/tasks

Create Task
POST /api/tasks

Update Task
PUT /api/tasks/{id}

Delete Task
DELETE /api/tasks/{id}

---

## Frontend

A simple frontend is created using **HTML, CSS, and JavaScript**.

Features:

- Add new task
- View tasks
- Update task status
- Delete task
- Professional UI with background image

---

## How to Run the Project

1. Clone the repository
git clone https://github.com/yourusername/TaskManagementAPI.git

2. Open the project in **Visual Studio**

3. Configure the **SQL Server connection string** in
appsettings.json

4. Run the project

5. Open Swagger
https://localhost:7109/swagger
or 
open frontend
https://localhost:7109/index.html
---

## Future Improvements

- Task filtering
- Task priority levels
- User dashboard
- Responsive mobile UI
- Cloud deployment

---

## Author

Developed by **Sindhuja*

ASP.NET Core Web API Developer
