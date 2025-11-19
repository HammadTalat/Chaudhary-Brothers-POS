# Hardware Store Point of Sale (POS) System

A comprehensive Point of Sale system designed for hardware stores with dual interfaces - a C# Windows Forms desktop application for cashiers and owners, backed by a RESTful Spring Boot API connected to SQL Server database.

---

## 📋 Problem / Objective

### Problem Statement
Traditional hardware stores face challenges in managing inventory, tracking sales, generating invoices, and monitoring business performance efficiently. Manual processes lead to errors, inventory mismanagement, and lack of real-time insights into business operations.

### Solution
This project provides a complete POS system that:
- Streamlines sales and billing operations for cashiers
- Provides comprehensive business analytics for store owners
- Automates inventory management with low-stock alerts
- Generates professional PDF invoices for customers
- Tracks sales patterns and forecasts future demand
- Manages customer information and purchase history
- Handles product returns efficiently

### Why This Project Was Created
Developed as a university project for 4th semester (Database & Business Process Engineering) for a real client "Chaudhary Brothers" a hardware retail shop at branthar road lahore, this system demonstrates practical application of:
- Multi-tier architecture (Desktop Client + REST API + Database)
- Database design and stored procedures
- RESTful API development
- Windows Forms application development
- Integration between different technology stacks

---

## 🛠️ Tech Stack / Tools Used

### Frontend (Desktop Application)
- **Language:** C# (.NET Framework 4.7.2)
- **UI Framework:** Windows Forms
- **PDF Generation:** iText7 (v8.0.3)
- **JSON Handling:** Newtonsoft.Json (v13.0.3)
- **HTTP Communication:** System.Net.Http

### Backend (REST API)
- **Language:** Java 21
- **Framework:** Spring Boot 3.2.4
- **Database Access:** Spring Data JPA
- **Build Tool:** Maven
- **Web Framework:** Spring Web

### Database
- **DBMS:** Microsoft SQL Server
- **JDBC Driver:** mssql-jdbc (v12.6.1)

### Key Libraries & Dependencies

#### Backend API (Java)
- Spring Boot Starter Data JPA - Database operations
- Spring Boot Starter Web - RESTful web services
- SQL Server JDBC Driver - Database connectivity

### Development Tools
- Visual Studio (C# development)
- IntelliJ IDEA / Eclipse (Java development)
- SQL Server Management Studio (Database management)
- Maven (Dependency management & build)

---

## ✨ Features

### Core Features

#### For Cashiers
- ✅ **User Authentication:** Secure login system for cashiers
- ✅ **Product Management:** View and search product catalog
- ✅ **Sales & Billing:** 
  - Create invoices with multiple products
  - Automatic tax calculation
  - Real-time inventory updates
  - PDF invoice generation
- ✅ **Customer Management:**
  - Add new customers
  - View customer history
  - Update customer information
- ✅ **Return Processing:** Handle product returns with reason tracking

#### For Owners
- ✅ **Business Analytics Dashboard:**
  - Total inventory value tracking
  - Expected profit calculations
  - Popular items identification
  - Sales trends visualization
- ✅ **Inventory Alerts:** Low stock notifications (≤5 units)
- ✅ **Sales Reports:** 
  - Date-range based reports
  - Product-wise sales analysis
  - Revenue tracking
- ✅ **Expense Tracking:** Monitor business expenses
- ✅ **Cashier Management:** Add, update, delete cashier accounts
- ✅ **Advanced Inventory Control:**
  - Add/update/delete products
  - Bulk inventory updates
  - Company-wise product categorization

#### API Features
- ✅ RESTful endpoints for all CRUD operations
- ✅ Stored procedure integration for complex queries
- ✅ Table-valued parameters for bulk invoice creation
- ✅ Data validation and error handling
- ✅ Cross-origin resource sharing (CORS) support

---

## 🚀 How to Run the Project

### Prerequisites

Before running the project, ensure you have the following installed:

1. **For Backend (API):**
   - Java Development Kit (JDK) 21 or higher
   - Apache Maven 3.6+
   - Microsoft SQL Server 2019 or higher

2. **For Frontend (Desktop App):**
   - Visual Studio 2019 or higher (with .NET Framework 4.7.2)
   - NuGet Package Manager

3. **Database:**
   - SQL Server Management Studio (SSMS) or Azure Data Studio
   - Database file: `Hardware_POS`

---

### Step 1: Database Setup

1. **Install SQL Server** if not already installed

2. **Create the Database:**
   ```sql
   CREATE DATABASE Hardware_POS;
   ```

3. **Restore or Create Database Schema:**
   - Locate the database backup/script file in the project
   - Execute the SQL scripts to create tables and stored procedures
   - The database should include these main tables:
     - `Product`
     - `Customer`
     - `Invoice`
     - `InvoiceProduct`
     - `CashierLogin`
     - `OwnerLogin`
     - `Return`
     - `ForecastedSale`

4. **Create SQL Server User (if using SQL authentication):**
   ```sql
   CREATE LOGIN Hmd WITH PASSWORD = '1234';
   USE Hardware_POS;
   CREATE USER Hmd FOR LOGIN Hmd;
   ALTER ROLE db_owner ADD MEMBER Hmd;
   ```

   > **Note:** You can use Windows Authentication instead by modifying the connection string.

---

### Step 2: Backend API Setup

1. **Navigate to the API directory:**
   ```powershell
   cd "c:\BS(SE) FAST\ALL_PROJECTS\4th_sem(DB+BPE)\API"
   ```

2. **Configure Database Connection:**
   
   Open `src/main/resources/application.properties` and update the database credentials:
   
   ```properties
   spring.datasource.url=jdbc:sqlserver://localhost:1433;databaseName=Hardware_POS;integratedSecurity=false;encrypt=false;
   spring.datasource.username=YOUR_SQL_USERNAME
   spring.datasource.password=YOUR_SQL_PASSWORD
   spring.datasource.driverClassName=com.microsoft.sqlserver.jdbc.SQLServerDriver
   ```

   **Replace:**
   - `YOUR_SQL_USERNAME` with your SQL Server username (e.g., `Hmd`)
   - `YOUR_SQL_PASSWORD` with your SQL Server password (e.g., `1234`)
   
   **For Windows Authentication:**
   ```properties
   spring.datasource.url=jdbc:sqlserver://localhost:1433;databaseName=Hardware_POS;integratedSecurity=true;encrypt=false;
   spring.datasource.username=
   spring.datasource.password=
   ```

3. **Install Dependencies:**
   ```powershell
   mvn clean install
   ```

4. **Run the Spring Boot Application:**
   ```powershell
   mvn spring-boot:run
   ```
   
   Or using the Maven wrapper:
   ```powershell
   .\mvnw.cmd spring-boot:run
   ```

5. **Verify API is Running:**
   - The API should start on `http://localhost:8080`
   - You should see console output indicating successful startup
   - Test endpoint: `http://localhost:8080/getAllProducts`

---

### Step 3: Frontend Desktop Application Setup

1. **Open the Solution in Visual Studio:**
   - Navigate to: `Chaudhary Brothers final_version (GUI)`
   - Open `Chaudhary Brothers.sln`

2. **Restore NuGet Packages:**
   - Visual Studio should automatically restore packages
   - Or manually: Right-click Solution → Restore NuGet Packages

3. **Verify API URL Configuration:**
   
   Check in `Form1.cs` and other form files that API base URL is correct:
   ```csharp
   string baseUrl = "http://localhost:8080";
   ```

4. **Build the Solution:**
   - Press `Ctrl+Shift+B` or
   - Build → Build Solution

5. **Run the Application:**
   - Press `F5` or click Start
   - The login form should appear

---

### Step 4: Testing the Application

#### Login Credentials

**Cashier Login:**
- You need to create cashier accounts first (can be done through Owner interface or database)
- Default format: 
  - Cashier ID: `<integer_id>`
  - Password: `<your_password>`

**Owner Login:**
- Similar to cashier, owner accounts must exist in the database
- Check `OwnerLogin` table for credentials

#### Test Workflow

1. **Login as Cashier:**
   - Test product browsing
   - Create a sample invoice
   - Add products to bill
   - Generate PDF invoice

2. **Login as Owner:**
   - View dashboard analytics
   - Check inventory alerts
   - Generate sales reports
   - Add/update products

---


---

## 📊 API Endpoints Reference

### Authentication
- `GET /CashierLogin?cashierId={id}&password={pwd}` - Cashier login
- `GET /OwnerLogin?ownerId={id}&password={pwd}` - Owner login

### Product Management
- `GET /getAllProducts` - Retrieve all products
- `GET /getProductsName` - Get product names
- `GET /getProductQuantity?productName={name}` - Get stock quantity
- `GET /getProductRate?productName={name}` - Get product price
- `POST /InsertProduct` - Add new product
- `PUT /UpdateProduct/{id}` - Update product details
- `DELETE /DeleteProduct/{id}` - Remove product

### Customer Management
- `GET /getAllCustomers` - List all customers
- `POST /InsertCustomer` - Add new customer
- `PUT /UpdateCustomer/{id}` - Update customer info
- `DELETE /DeleteCustomer/{id}` - Remove customer

### Invoice Operations
- `POST /InsertInvoice1` - Create invoice with products
- `GET /countInvoices` - Get total invoice count
- `GET /getInvoiceDetails?invoiceId={id}` - Get invoice details
- `DELETE /deleteInvoice/{id}` - Delete invoice

### Analytics & Reports
- `GET /getPopularItem` - Most sold product
- `GET /getTotalUnitPrice` - Total inventory cost
- `GET /getTotalSalesPrice` - Total potential revenue
- `GET /getExpectedProfit` - Profit margin
- `GET /getInventoryAlerts` - Low stock items
- `GET /getSalesDetailsByDateRange?startDate={start}&endDate={end}` - Sales report

### Returns
- `POST /InsertReturn` - Process return
- `PUT /UpdateReturn/{id}` - Update return details
- `DELETE /DeleteReturn/{id}` - Delete return record

---

## 🔧 Environment Variables

### Backend (Spring Boot)

No environment variables required by default. Configuration is in `application.properties`:

```properties
# Database Configuration
spring.datasource.url=jdbc:sqlserver://localhost:1433;databaseName=Hardware_POS;integratedSecurity=false;encrypt=false;
spring.datasource.username=<YOUR_SQL_USERNAME>
spring.datasource.password=<YOUR_SQL_PASSWORD>
spring.datasource.driverClassName=com.microsoft.sqlserver.jdbc.SQLServerDriver

# Optional: Server Port (default: 8080)
# server.port=8080
```

### Frontend (C# Application)

API base URL is hardcoded in the application. To change:
- Update the `baseUrl` variable in each form file (e.g., `Form1.cs`):
  ```csharp
  string baseUrl = "http://localhost:8080";
  ```

---

## 🙏 Acknowledgments

- Course: Database Systems & Business Process Engineering
- Institution: FAST-NUCES
- Semester: 4th Semester BS(SE)
- Libraries: iText7, Spring Boot, Microsoft SQL Server

---


