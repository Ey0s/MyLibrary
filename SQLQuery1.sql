IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'libraryDB')
BEGIN
    CREATE DATABASE libraryDB;
END
GO

USE LibraryDB;
GO

-- Drop tables if they exist to allow for clean re-creation
IF OBJECT_ID('IssuedBooks', 'U') IS NOT NULL DROP TABLE IssuedBooks;
IF OBJECT_ID('Books', 'U') IS NOT NULL DROP TABLE Books;
IF OBJECT_ID('Borrowers', 'U') IS NOT NULL DROP TABLE Borrowers;
IF OBJECT_ID('Users', 'U') IS NOT NULL DROP TABLE Users;
GO

-- Create Users Table for Login
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL
);

-- Create Books Table
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255) NOT NULL,
    Year INT,
    AvailableCopies INT NOT NULL DEFAULT 0
);

-- Create Borrowers Table
CREATE TABLE Borrowers (
    BorrowerID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Phone NVARCHAR(20) NOT NULL
);

-- Create IssuedBooks Table
CREATE TABLE IssuedBooks (
    IssueID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT NOT NULL,
    BorrowerID INT NOT NULL,
    IssueDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    Returned BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (BorrowerID) REFERENCES Borrowers(BorrowerID)
);

-- Add admin user with plaintext password (FOR DEVELOPMENT ONLY)
INSERT INTO Users (Username, PasswordHash) 
VALUES ('admin', 'password');

PRINT 'libraryDB database created successfully. Admin user: username=admin, password=password';
GO