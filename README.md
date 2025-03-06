# 🛠️ TechFix Procurement Management System

A Service-Oriented Computing (SOC) application designed to optimize TechFix’s hardware procurement process. This system integrates with supplier APIs to automate quotation requests, track inventory in real-time, and manage order placements — all through a centralized, user-friendly client application.

## 🚀 **Features**

-   **Quotation Management:** Request and compare supplier quotations in real time.
-   **Inventory Tracking:** View up-to-date stock levels to avoid order delays.
-   **Order Automation:** Place and track orders directly through the platform.
-   **Modular Architecture:** Decoupled services for enhanced maintainability and scalability.
-   **API Integration:** Seamless communication with supplier systems via RESTful APIs.
-   **Error Handling & Logging:** Comprehensive exception management and log tracking.
-   **Unit & Integration Testing:** Reliable test coverage to ensure system stability.

## 🏗️ **Project Structure**
TechFix-Procurement-System/
├── QuotationService/
│   ├── Controllers/
│   ├── Services/
│   ├── Models/
│   └── Data/
├── InventoryService/
│   ├── Controllers/
│   ├── Services/
│   ├── Models/
│   └── Data/
├── OrderManagementService/
│   ├── Controllers/
│   ├── Services/
│   ├── Models/
│   └── Data/
├── ClientApp/
│   ├── Pages/
│   ├── Components/
│   └── Styles/
├── README.md
└── .gitignore

## 📘 **Installation & Setup**

1.  **Clone the Repository:**

    ```bash
    git clone [https://github.com/YourUsername/TechFix-Procurement-System.git](https://www.google.com/search?q=https://github.com/YourUsername/TechFix-Procurement-System.git)
    cd TechFix-Procurement-System
    ```

2.  **Backend Setup:**

    -   Install dependencies for each service (e.g., ASP.NET Core or Node.js).
    -   Configure the database connection string.
    -   Run migrations to set up the database.

3.  **Run Services:**

    -   Launch each service separately:

        ```bash
        dotnet run --project QuotationService
        dotnet run --project InventoryService
        dotnet run --project OrderManagementService
        ```

4.  **Client Application:**

    -   Install frontend dependencies:

        ```bash
        npm install
        ```

    -   Run the development server:

        ```bash
        npm start
        ```

## 📊 **API Documentation**

API documentation is generated using Swagger.

Once the services are running, you can access the documentation at:

-   `http://localhost:5001/swagger` (Quotation Service)
-   `http://localhost:5002/swagger` (Inventory Service)
-   `http://localhost:5003/swagger` (Order Management Service)

## ✅ **Testing**

Unit and integration tests are included for each service.

Run tests using:

Markdown

# 🛠️ TechFix Procurement Management System

A Service-Oriented Computing (SOC) application designed to optimize TechFix’s hardware procurement process. This system integrates with supplier APIs to automate quotation requests, track inventory in real-time, and manage order placements — all through a centralized, user-friendly client application.

## 🚀 **Features**

-   **Quotation Management:** Request and compare supplier quotations in real time.
-   **Inventory Tracking:** View up-to-date stock levels to avoid order delays.
-   **Order Automation:** Place and track orders directly through the platform.
-   **Modular Architecture:** Decoupled services for enhanced maintainability and scalability.
-   **API Integration:** Seamless communication with supplier systems via RESTful APIs.
-   **Error Handling & Logging:** Comprehensive exception management and log tracking.
-   **Unit & Integration Testing:** Reliable test coverage to ensure system stability.

## 🏗️ **Project Structure**

TechFix-Procurement-System/
├── QuotationService/
│   ├── Controllers/
│   ├── Services/
│   ├── Models/
│   └── Data/
├── InventoryService/
│   ├── Controllers/
│   ├── Services/
│   ├── Models/
│   └── Data/
├── OrderManagementService/
│   ├── Controllers/
│   ├── Services/
│   ├── Models/
│   └── Data/
├── ClientApp/
│   ├── Pages/
│   ├── Components/
│   └── Styles/
├── README.md
└── .gitignore


## 📘 **Installation & Setup**

1.  **Clone the Repository:**

    ```bash
    git clone [https://github.com/YourUsername/TechFix-Procurement-System.git](https://www.google.com/search?q=https://github.com/YourUsername/TechFix-Procurement-System.git)
    cd TechFix-Procurement-System
    ```

2.  **Backend Setup:**

    -   Install dependencies for each service (e.g., ASP.NET Core or Node.js).
    -   Configure the database connection string.
    -   Run migrations to set up the database.

3.  **Run Services:**

    -   Launch each service separately:

        ```bash
        dotnet run --project QuotationService
        dotnet run --project InventoryService
        dotnet run --project OrderManagementService
        ```

4.  **Client Application:**

    -   Install frontend dependencies:

        ```bash
        npm install
        ```

    -   Run the development server:

        ```bash
        npm start
        ```

## 📊 **API Documentation**

API documentation is generated using Swagger.

Once the services are running, you can access the documentation at:

-   `http://localhost:5001/swagger` (Quotation Service)
-   `http://localhost:5002/swagger` (Inventory Service)
-   `http://localhost:5003/swagger` (Order Management Service)

## ✅ **Testing**

Unit and integration tests are included for each service.

Run tests using:



## Version Control
Main Branch: Stable, production-ready code.
Dev Branch: Active development and feature integration.

## Deployment
Containerized with Docker for consistent environments.
Kubernetes for orchestration, scaling, and automated deployments.

## Contributors
Pahan Sanjana – Lead Developer

## License
This project is licensed under the MIT License.
