# 📚 Library Management System

A comprehensive **Windows Forms application** built with **C# (.NET Framework 4.7.2)** for managing library operations, including book inventory, borrower management, and book issuing/returning.

---

## ✨ Key Features

### 1. User Authentication & Security
- **Secure Login System**: Users must authenticate with a username and password.
- **Password Visibility Toggle**: Option to show/hide password during login.
- **Error Handling**: Clear error messages for invalid login attempts.

### 2. Book Management
- **Add New Books**: Store book details (Title, Author, Year, Available Copies).
- **Edit & Delete Books**: Modify existing book records or remove them.
- **Search Functionality**: Filter books by title or author.
- **Available Copies Tracking**: Automatically updates on issue/return.

### 3. Borrower Management
- **Add New Borrowers**: Record borrower details (Name, Email, Phone).
- **Edit & Delete Borrowers**: Update borrower info or remove them (if no active loans).
- **Search Functionality**: Find borrowers by name, email, or phone number.

### 4. Book Issuing & Returning
- **Issue Books**: Assign books with issue and due dates.
- **Return Books**: Mark books as returned, updating availability.
- **Overdue Tracking**: Identify late returns.
- **Show Returned Books**: Toggle view to see return history.

### 5. Modern UI & User Experience
- **Responsive Design**: Adapts to various screen sizes.
- **Tab-Based Navigation**: Easy switching between sections.
- **Data Grid Views**: Organized display for books, borrowers, and issued books.
- **Form Validation**: Ensures correct data before submission.

---

## 🛠 Technologies Used

- **Frontend**: Windows Forms (C#)
- **Backend**: .NET Framework 4.7.2
- **Database**: SQL Server (LocalDB)
- **Data Handling**: ADO.NET (SQL queries for CRUD)

---

## 🚀 Setup & Installation

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2
- SQL Server LocalDB (included with Visual Studio)

### Steps to Run

```bash
git clone https://github.com/Ey0s/MyLibrary.git
