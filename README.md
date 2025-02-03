# Task Tracker
https://github.com/user-attachments/assets/88341b9c-3591-448f-a0d2-bef99f2ac875

## Description

This project is a task tracker application built with Angular for the frontend and C# for the backend API. The app allows users to manage tasks by displaying them in both grid and list formats. Tasks can be added, edited, and deleted, with essential details such as task name, description, assigned user, and due date. The backend API is built using C# and ASP.NET Core, and data is stored in a MongoDB database. The API is documented with Swagger for easy integration and testing. The application provides a seamless user experience to manage tasks efficiently.

## Technologies Used

* Angular.
* HTML.
* SCSS.
* TypeScript.
* C#.
* ASP.NET Core.
* Swagger.
* MongoDB.

## Installation and Usage

### Backend Setup
**1. Clone the repository**  
git clone https://github.com/AndreiCIlies/Task_Tracker.git

**2. Open the project in Visual Studio**  
Navigate to the folder where you cloned the repository, open the TasksAPI folder, and open the .sln file.

**3. Build the project**  
Click Build in the top menu, then select Build Solution (or press Ctrl+Shift+B).

### Database Setup
**1. Open MongoDB Compass**  
Launch MongoDB Compass for managing your MongoDB database.

**2. Connect to MongoDB**  
- Press the Connect button at the top of the Compass window.  
- Leave the settings as default and click Connect & Save to connect to MongoDB.  

**3. Create Database**  
- Right-click on “localhost” in the left panel and select Create Database.
- Name the database tasksManagement and create it.

**4. Create Collection**  
- Right-click on the newly created tasksManagement database and select Create Collection.
- Name the collection Tasks and create it.

**5. Get Connection URI**  
Right-click on "localhost" in the left panel again and select Show connection URI.

**6. Add MongoDB Configuration in appsettings.Development.json**  
In Visual Studio navigate to appsettings.Development.json, and add the connection URI to ConnectionString.

### Frontend Setup
**1. Navigate to the task-tracker folder**  
cd task-tracker

**2. Install Dependencies**  
npm install

### Usage
**1. Run the API**  
Click the green Start button (or press F5) to run the API.

**2. Run the Angular Frontend**  
ng serve

**3. Access the Application**  
Open the Angular frontend in your browser at http://localhost:4200.
