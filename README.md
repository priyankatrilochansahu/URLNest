#  URLNest

**URLNest** is a simple and intuitive full-stack web application that allows users to search for hardcoded URLs based on a keyword. Built using **Angular** on the frontend and **.NET (C#)** on the backend, this project demonstrates frontend-backend integration and interactive UI behavior using TypeScript.

---

##  Features
  
- Search button triggers a backend request  
- Returns a list of relevant **hardcoded links**  
- Displays results in a **tabular format**  
  - URL Name  
  - URL Address  

---

##  Tech Stack

###  Frontend

- HTML  
- CSS  
- TypeScript  
- **Angular Framework**

###  Backend

- **C#** using **.NET Core**    
- ASP.NET Web API (.NET Framework)

###  Database

-  No external database used  
- Links are **hardcoded** in the backend


##  Backend Setup (Step-by-Step)

###  Step 1: Create Project

1. Open **Visual Studio 2019**
2. Click on **"Create a new project"**
3. Select template: **ASP.NET Web Application (.NET Framework)**
4. Click **Next**
5. Project name
6. In the next window, choose template: **Web API**
7. Click **Create**

---

###  Step 2: Folder Structure

Controllers/

├── searchcontroller.cs
└── ValuesController.cs

searchquery/

├── searchrequest.cs
└── searchoutput.cs

App_Start/

└── WebApiConfig.cs

###  Step 3: Enable CORS

To allow requests from Angular frontend, install the CORS package.
In Visual Studio, go to **Tools > NuGet Package Manager > Package Manager Console**  
Then run:

powershell
```Install-Package Microsoft.AspNet.WebApi.Cors```

---

### ✅ Step 4: Build and Run

1. Build the project.
2. After successful build, click on the **green IIS Express** button to run the backend.
3. Visual Studio will launch your Web API in the browser with a URL like: https://localhost:44349/
4. Copy this URL — you will need it to test the API or connect from frontend.

---

### ✅ Step 5: Test API in Postman

1. Open **Postman**
2. Select method: 'POST'
3. Use the API endpoint with a sample keyword:https://localhost:44349/api/search
4. Click **Send**
5. ✅ You will get a **JSON response** containing filtered hardcoded URLs.


