-- Create the database
CREATE DATABASE POS;
GO

-- Switch to the database
USE POS;
GO

-- Create Admin table
CREATE TABLE Admin (
    AdminID INT NOT NULL IDENTITY(1,1),
    Username VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    PRIMARY KEY (AdminID)
);
GO

-- Create Employee table
CREATE TABLE Employee (
    EmployeeID VARCHAR(20) NOT NULL,
    Username VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL, 
	Name VARCHAR(100) NOT NULL,
    AdminID INT NOT NULL DEFAULT -1,
    PRIMARY KEY (EmployeeID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO

-- Create Supplier table
CREATE TABLE Supplier (
    SupplierID VARCHAR(20) NOT NULL,
    SupplierName VARCHAR(100) NOT NULL,
    ContactNumber VARCHAR(20),
    AdminID INT NOT NULL DEFAULT -1,
    PRIMARY KEY (SupplierID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);

GO

CREATE TABLE SupplierItem (
    SupplierID VARCHAR(20) NOT NULL,
    ItemName VARCHAR(50) NOT NULL,
    WholeSaleQuantity INT NOT NULL DEFAULT 0,
    WholeSaleUnit INT NOT NULL DEFAULT 0,
    WholeSaleUnitPrice DECIMAL(18, 2) NOT NULL,
    PRIMARY KEY (SupplierID, ItemName),
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
GO

CREATE TABLE Store(
		StoreID VARCHAR(20) NOT NULL,
		StoreName VARCHAR(100) NOT NULL UNIQUE,
		Address VARCHAR(255) NOT NULL,
		ContactNumber VARCHAR(20) NOT NULL,
		AdminID INT NOT NULL DEFAULT -1,
		PRIMARY KEY (StoreID),
		FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO
-- Create Item table
CREATE TABLE Item (
    ItemID VARCHAR(20) NOT NULL,
	ItemName VARCHAR(50) NOT NULL,
	Barcode BIGINT NOT NULL, 
	RetailQuantity INT NOT NULL DEFAULT 0, 
	RetailUnit INT NOT NULL DEFAULT 0,
    RetailUnitPrice DECIMAL(18, 2) NOT NULL, 
	Stock INT NOT NULL DEFAULT 0,
	Description VARCHAR(255),
    AdminID INT NOT NULL DEFAULT -1,
	SupplierID VARCHAR(20) NOT NULL DEFAULT -1,
    PRIMARY KEY (ItemID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
	FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
GO

-- Create Customer table
CREATE TABLE LoyaltyCustomer (
    CustomerID VARCHAR(20) NOT NULL,
    Name VARCHAR(50) NULL, 
	CustomerCardNumber VARCHAR(20) NOT NULL UNIQUE,
    Points INT DEFAULT 0,
    EmployeeID VARCHAR(20) NOT NULL,
    PRIMARY KEY (CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO

-- Create Bill table
CREATE TABLE Bill (
    BillID INT IDENTITY(1,1) NOT NULL,
    Total DECIMAL(18, 2) NOT NULL DEFAULT 0, 
	TotalProfit DECIMAL(18, 2) NOT NULL DEFAULT 0, 
    DiscountPercenatge DECIMAL(5, 2) DEFAULT 0, 
	CustomerPoints DECIMAL(5, 2) DEFAULT 0, 
	TotalDiscount DECIMAL(5, 2) DEFAULT 0, 
    Date DATE NOT NULL, 
    Time TIME NOT NULL, 
    EmployeeID VARCHAR(20) NOT NULL,
	CustomerCardNumber VARCHAR(20),
	StoreID VARCHAR(20) NOT NULL,
    PRIMARY KEY (BillID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
	FOREIGN KEY (CustomerCardNumber) REFERENCES LoyaltyCustomer(CustomerCardNumber)
        ON DELETE NO ACTION
        ON UPDATE CASCADE,
	FOREIGN KEY (StoreID) REFERENCES Store(StoreID)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);
GO

-- Create BillItem table
CREATE TABLE BillItem (
    BillItemID INT IDENTITY(1,1) NOT NULL,
    Total DECIMAL(18, 2) NOT NULL DEFAULT 0,
    CustomerQuantity INT NOT NULL DEFAULT 0,
	ItemProfit DECIMAL(18, 2) NOT NULL DEFAULT 0, 
	CustomerUnit INT NOT NULL DEFAULT 0,
    BillID INT NOT NULL,
	ItemID VARCHAR(20),
    PRIMARY KEY (BillItemID),
    FOREIGN KEY (BillID) REFERENCES Bill(BillID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

-- Insert Part 
INSERT INTO Admin (Username, Password)
VALUES 
    ('admin1', 'Admin123'), 
    ('admin2', 'Admin456'); 

INSERT INTO Employee (EmployeeID, Username, Password,Name, AdminID)
VALUES 
    ('E00', 'employeeAdmin', 'Employee000','Employee', 1);

INSERT INTO Store (StoreID, StoreName, Address, ContactNumber, AdminID)
VALUES ('S01','Store','123','1234567890',1);