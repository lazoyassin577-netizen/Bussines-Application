USE Bad;
GO

-- =============================================
-- ١. سڕینەوەی خشتە کۆنەکان بەپێی ڕیزبەندی پەیوەندییەکان
-- =============================================
IF OBJECT_ID('dbo.Transaction', 'U') IS NOT NULL DROP TABLE dbo.[Transaction];
IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL DROP TABLE dbo.Products;
IF OBJECT_ID('dbo.Categories', 'U') IS NOT NULL DROP TABLE dbo.Categories;
IF OBJECT_ID('dbo.Customers', 'U') IS NOT NULL DROP TABLE dbo.Customers;
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL DROP TABLE dbo.Users;
GO

-- =============================================
-- ٢. دروستکردنەوەی خشتەی Users
-- =============================================
CREATE TABLE dbo.Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NULL,
    UserName NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Contact NVARCHAR(50) NULL,
    Gender NVARCHAR(20) NULL,
    Address NVARCHAR(250) NULL,
    UserType NVARCHAR(50) NOT NULL
);
GO

-- =============================================
-- ٣. دروستکردنەوەی خشتەی Categories
-- =============================================
CREATE TABLE dbo.Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL UNIQUE,
    Description NVARCHAR(500) NULL
);
GO

-- =============================================
-- ٤. دروستکردنەوەی خشتەی Customers
-- =============================================
CREATE TABLE dbo.Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Type NVARCHAR(50) NULL,
    Name NVARCHAR(100) NOT NULL,
    Contact NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(250) NULL
);
GO

-- =============================================
-- ٥. دروستکردنەوەی خشتەی Products
-- =============================================
CREATE TABLE dbo.Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(150) NOT NULL,
    Category NVARCHAR(150) NULL,
    Description NVARCHAR(500) NULL,
    Quantity INT DEFAULT 0,
    AddedDate DATETIME DEFAULT GETDATE(),
    OrderBy NVARCHAR(100) NULL
);
GO

-- =============================================
-- ٦. دروستکردنەوەی خشتەی Transaction (کڕین و فرۆشتن)
-- =============================================
CREATE TABLE dbo.[Transaction] (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100) NULL,
    CustomerPhone NVARCHAR(50) NULL,
    CustomerEmail NVARCHAR(100) NULL,
    CustomerAddress NVARCHAR(250) NULL,
    ProductID INT NULL,
    ProductName NVARCHAR(150) NULL,
    Category NVARCHAR(150) NULL,
    Price DECIMAL(18,2) DEFAULT 0.00,
    Quantity INT DEFAULT 1,
    Total DECIMAL(18,2) DEFAULT 0.00,
    SubTotal DECIMAL(18,2) DEFAULT 0.00,
    Discount DECIMAL(18,2) DEFAULT 0.00,
    GrandTotal DECIMAL(18,2) DEFAULT 0.00,
    PaidAmount DECIMAL(18,2) DEFAULT 0.00,
    ReturnAmount DECIMAL(18,2) DEFAULT 0.00,
    AddedDate DATETIME DEFAULT GETDATE(),
    AddedBy NVARCHAR(100) NULL
);
GO

-- =============================================
-- ٧. تێکردنی داتای سەرەتایی (Seed Data)
-- =============================================

-- بەکارهێنەری سەرەکی (Admin و User)
INSERT INTO dbo.Users (FirstName, LastName, Email, UserName, Password, Contact, Gender, Address, UserType)
VALUES 
('System', 'Admin', 'admin@app.com', 'Admin', 'Admin@123', '07700000000', 'Male', 'Sulaymaniyah', 'Administrator'),
('Staff', 'User', 'staff@app.com', 'User1', 'User@1234', '07500000000', 'Female', 'Sulaymaniyah', 'User');

-- پۆلەکان (Categories)
INSERT INTO dbo.Categories (Title, Description) 
VALUES 
('Electronics', 'Electronic devices and gadgets'),
('Hardware', 'Computer hardware and desktop components'),
('Accessories', 'Cables, peripherals, and extra gear');

-- کڕیارانی سەرەتایی (Customers)
INSERT INTO dbo.Customers (Type, Name, Contact, Email, Address)
VALUES
('Customer', 'Ahmad Ali', '07701234567', 'ahmad@gmail.com', 'Ashti, Sulaymaniyah'),
('Dealer', 'Karwan Tech', '07509876543', 'karwan@info.com', 'Salim St, Sulaymaniyah');

-- بەرهەمەکان (Products)
INSERT INTO dbo.Products (ProductName, Category, Description, Quantity, AddedDate, OrderBy)
VALUES 
('Logitech G Pro Mouse', 'Hardware', 'Wireless gaming mouse with HERO sensor', 15, GETDATE(), 'Admin'),
('Mechanical Keyboard', 'Hardware', 'RGB mechanical keyboard with red switches', 25, GETDATE(), 'Admin'),
('Dell UltraSharp 27"', 'Hardware', '4K IPS display monitor with USB-C hub', 8, GETDATE(), 'Admin'),
('Samsung 1TB NVMe SSD', 'Electronics', 'PCIe 4.0 high speed internal solid state drive', 40, GETDATE(), 'Admin'),
('Sony WH-1000XM5', 'Electronics', 'Noise canceling wireless over-ear headphones', 12, GETDATE(), 'Admin'),
('Kingston 16GB DDR5 RAM', 'Hardware', '5600MHz CL36 desktop memory stick', 30, GETDATE(), 'Admin');


INSERT INTO dbo.Customers (Type, Name, Contact, Email, Address)
VALUES
('Customer', N'ئاراس کەریم', '07701548962', 'aras.karim@gmail.com', N'سلێمانی - ڕاپەڕین'),
('Dealer', N'کۆمپانیای ئاسۆ بۆ ئایتی', '07503321458', 'aso.tech@outlook.com', N'سلێمانی - شەقامی سالم'),
('Customer', N'ڕەهێڵ مەحموود', '07718952341', 'rahel.m98@yahoo.com', N'سلێمانی - بەختیاری'),
('Dealer', N'کۆگای دیجیتاڵ پڵەس', '07514478965', 'digital.plus@gmail.com', N'سلێمانی - کاسۆ مۆڵ'),
('Customer', N'دابان عوسمان', '07709845123', 'daban.o@gmail.com', N'سلێمانی - سەرچنار'),
('Customer', N'هەڵمەت عەلی', '07508821963', 'halmat.ali@yahoo.com', N'سلێمانی - تووی مەلیک'),
('Dealer', N'نەورۆز سیستەم', '07726541289', 'newroz.sys@outlook.com', N'سلێمانی - ئیسکان'),
('Customer', N'سۆران حەمەسوور', '07501147852', 'soran.h@gmail.com', N'سلێمانی - عەقاری'),
('Customer', N'شوان تەها', '07703216598', 'shwan.taha@yahoo.com', N'سلێمانی - چوارچرا'),
('Dealer', N'فۆکەس تەکنەلۆجی', '07519963258', 'focus.tech@gmail.com', N'سلێمانی - بازاڕی زانکۆ');
GO

USE Bad;
SELECT UserID, UserName, Password, UserType FROM Users;

GO