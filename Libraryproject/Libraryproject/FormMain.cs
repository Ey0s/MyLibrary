using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Libraryproject
{
    public partial class FormMain : Form
    {
        // Database connection string
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;";

        // Variables to hold selected IDs for editing/deleting
        private int selectedBookId = -1;
        private int selectedBorrowerId = -1;
        private int selectedIssueId = -1;

        public FormMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; 

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadBorrowers();
            LoadIssuedBooks();
            PopulateBookComboBox();
            PopulateBorrowerComboBox();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    // More specific error message for database issues
                    MessageBox.Show($"Database operation failed: {ex.Message}\n\n" +
                                    "Please check your database connection and ensure data integrity rules are met.",
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Book Management Tab ---

        private void LoadBooks(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT BookID, Title, Author, Year, AvailableCopies FROM Books";
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " WHERE Title LIKE @SearchTerm OR Author LIKE @SearchTerm";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DgvBooks.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error loading books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearBookFields();
            PopulateBookComboBox(); // Refresh book combo box after any book changes
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvBooks.SelectedRows[0];
                // Ensure the cell value is not DBNull before converting
                if (selectedRow.Cells["BookID"].Value != DBNull.Value)
                {
                    selectedBookId = Convert.ToInt32(selectedRow.Cells["BookID"].Value);
                    TxtBookTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                    TxtBookAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                    TxtBookYear.Text = selectedRow.Cells["Year"].Value.ToString();
                    TxtBookCopies.Text = selectedRow.Cells["AvailableCopies"].Value.ToString();
                }
            }
            else
            {
                ClearBookFields();
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBookTitle.Text) || string.IsNullOrWhiteSpace(TxtBookAuthor.Text) ||
                string.IsNullOrWhiteSpace(TxtBookYear.Text) || string.IsNullOrWhiteSpace(TxtBookCopies.Text))
            {
                MessageBox.Show("Please fill all book fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtBookYear.Text, out int year) || !int.TryParse(TxtBookCopies.Text, out int copies))
            {
                MessageBox.Show("Year and Copies must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Books (Title, Author, Year, AvailableCopies) VALUES (@Title, @Author, @Year, @AvailableCopies)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Title", TxtBookTitle.Text.Trim()),
                new SqlParameter("@Author", TxtBookAuthor.Text.Trim()),
                new SqlParameter("@Year", year),
                new SqlParameter("@AvailableCopies", copies)
            };
            ExecuteNonQuery(query, parameters);
            MessageBox.Show("Added success fully");
            LoadBooks();
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtBookTitle.Text) || string.IsNullOrWhiteSpace(TxtBookAuthor.Text) ||
                string.IsNullOrWhiteSpace(TxtBookYear.Text) || string.IsNullOrWhiteSpace(TxtBookCopies.Text))
            {
                MessageBox.Show("Please fill all book fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtBookYear.Text, out int year) || !int.TryParse(TxtBookCopies.Text, out int copies))
            {
                MessageBox.Show("Year and Copies must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Books SET Title = @Title, Author = @Author, Year = @Year, AvailableCopies = @AvailableCopies WHERE BookID = @BookID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Title", TxtBookTitle.Text.Trim()),
                new SqlParameter("@Author", TxtBookAuthor.Text.Trim()),
                new SqlParameter("@Year", year),
                new SqlParameter("@AvailableCopies", copies),
                new SqlParameter("@BookID", selectedBookId)
            };
            ExecuteNonQuery(query, parameters);
            LoadBooks();
            MessageBox.Show("Bppk edited successfully");
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book to delete from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Check for existing issued books before deleting (foreign key constraint check)
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string checkQuery = "SELECT COUNT(1) FROM IssuedBooks WHERE BookID = @BookID AND Returned = 0";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@BookID", selectedBookId);
                            int issuedCount = (int)checkCommand.ExecuteScalar();
                            if (issuedCount > 0)
                            {
                                MessageBox.Show("Cannot delete book: There are still unreturned copies of this book. Please return all copies before deleting.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error checking issued books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // If no unreturned books, proceed with deletion
                // First, delete any *returned* issued book records associated with this book
                string deleteReturnedIssuedBooksQuery = "DELETE FROM IssuedBooks WHERE BookID = @BookID AND Returned = 1";
                SqlParameter[] deleteReturnedIssuedBooksParams = new SqlParameter[]
                {
                    new SqlParameter("@BookID", selectedBookId)
                };
                ExecuteNonQuery(deleteReturnedIssuedBooksQuery, deleteReturnedIssuedBooksParams);


                string deleteBookQuery = "DELETE FROM Books WHERE BookID = @BookID";
                SqlParameter[] deleteBookParams = new SqlParameter[]
                {
                    new SqlParameter("@BookID", selectedBookId)
                };
                ExecuteNonQuery(deleteBookQuery, deleteBookParams);

                LoadBooks(); // Refresh book list
                LoadIssuedBooks(); // Refresh issued books list
            }
        }

        private void BtnClearBookFields_Click(object sender, EventArgs e)
        {
            ClearBookFields();
        }

        private void ClearBookFields()
        {
            selectedBookId = -1;
            TxtBookTitle.Clear();
            TxtBookAuthor.Clear();
            TxtBookYear.Clear();
            TxtBookCopies.Clear();
            DgvBooks.ClearSelection(); // Deselect any rows
        }

        private void BtnSearchBooks_Click(object sender, EventArgs e)
        {
            LoadBooks(TxtBookSearch.Text.Trim());
        }

        // --- Borrower Management Group Box ---

        private void LoadBorrowers(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT BorrowerID, Name, Email, Phone FROM Borrowers";
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " WHERE Name LIKE @SearchTerm OR Email LIKE @SearchTerm OR Phone LIKE @SearchTerm";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DgvBorrowers.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error loading borrowers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearBorrowerFields();
            PopulateBorrowerComboBox(); // Refresh borrower combo box after any borrower changes
        }

        private void DgvBorrowers_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBorrowers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvBorrowers.SelectedRows[0];
                if (selectedRow.Cells["BorrowerID"].Value != DBNull.Value)
                {
                    selectedBorrowerId = Convert.ToInt32(selectedRow.Cells["BorrowerID"].Value);
                    TxtBorrowerName.Text = selectedRow.Cells["Name"].Value.ToString();
                    TxtBorrowerEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                    TxtBorrowerPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                }
            }
            else
            {
                ClearBorrowerFields();
            }
        }

        private void BtnAddBorrower_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBorrowerName.Text) || string.IsNullOrWhiteSpace(TxtBorrowerEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtBorrowerPhone.Text))
            {
                MessageBox.Show("Please fill all borrower fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Borrowers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", TxtBorrowerName.Text.Trim()),
                new SqlParameter("@Email", TxtBorrowerEmail.Text.Trim()),
                new SqlParameter("@Phone", TxtBorrowerPhone.Text.Trim())
            };
            ExecuteNonQuery(query, parameters);
            LoadBorrowers();
            MessageBox.Show("Borrower added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditBorrower_Click(object sender, EventArgs e)
        {
            if (selectedBorrowerId == -1)
            {
                MessageBox.Show("Please select a borrower to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtBorrowerName.Text) || string.IsNullOrWhiteSpace(TxtBorrowerEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtBorrowerPhone.Text))
            {
                MessageBox.Show("Please fill all borrower fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Borrowers SET Name = @Name, Email = @Email, Phone = @Phone WHERE BorrowerID = @BorrowerID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", TxtBorrowerName.Text.Trim()),
                new SqlParameter("@Email", TxtBorrowerEmail.Text.Trim()),
                new SqlParameter("@Phone", TxtBorrowerPhone.Text.Trim()),
                new SqlParameter("@BorrowerID", selectedBorrowerId)
            };
            MessageBox.Show("Borrower edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExecuteNonQuery(query, parameters);
            LoadBorrowers();
        }

        private void BtnDeleteBorrower_Click(object sender, EventArgs e)
        {
            if (selectedBorrowerId == -1)
            {
                MessageBox.Show("Please select a borrower to delete from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this borrower? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Check for existing issued books before deleting (foreign key constraint check)
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string checkQuery = "SELECT COUNT(1) FROM IssuedBooks WHERE BorrowerID = @BorrowerID AND Returned = 0";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@BorrowerID", selectedBorrowerId);
                            int issuedCount = (int)checkCommand.ExecuteScalar();
                            if (issuedCount > 0)
                            {
                                MessageBox.Show("Cannot delete borrower: This borrower has unreturned books. Please ensure all books are returned before deleting the borrower.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error checking issued books for borrower: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // If no unreturned books, proceed with deletion
                // First, delete any *returned* issued book records associated with this borrower
                string deleteReturnedIssuedBooksQuery = "DELETE FROM IssuedBooks WHERE BorrowerID = @BorrowerID AND Returned = 1";
                SqlParameter[] deleteReturnedIssuedBooksParams = new SqlParameter[]
                {
                    new SqlParameter("@BorrowerID", selectedBorrowerId)
                };
                ExecuteNonQuery(deleteReturnedIssuedBooksQuery, deleteReturnedIssuedBooksParams);

                string deleteBorrowerQuery = "DELETE FROM Borrowers WHERE BorrowerID = @BorrowerID";
                SqlParameter[] deleteBorrowerParams = new SqlParameter[]
                {
                    new SqlParameter("@BorrowerID", selectedBorrowerId)
                };
                ExecuteNonQuery(deleteBorrowerQuery, deleteBorrowerParams);
                MessageBox.Show("Borrower deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowers(); // Refresh borrower list
                LoadIssuedBooks(); // Refresh issued books list
            }
        }

        private void BtnClearBorrowerFields_Click(object sender, EventArgs e)
        {
            ClearBorrowerFields();
        }

        private void ClearBorrowerFields()
        {
            selectedBorrowerId = -1;
            TxtBorrowerName.Clear();
            TxtBorrowerEmail.Clear();
            TxtBorrowerPhone.Clear();
            DgvBorrowers.ClearSelection();
        }

        private void BtnSearchBorrowers_Click(object sender, EventArgs e) // Corrected parameter name
        {
            LoadBorrowers(TxtBorrowerSearch.Text.Trim());
            MessageBox.Show("Borrowers searched successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Issued Book Management Group Box ---

        private void LoadIssuedBooks(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            ib.IssueID,
                            b.Title AS BookTitle,
                            br.Name AS BorrowerName,
                            ib.IssueDate,
                            ib.DueDate,
                            ib.Returned
                        FROM IssuedBooks ib
                        JOIN Books b ON ib.BookID = b.BookID
                        JOIN Borrowers br ON ib.BorrowerID = br.BorrowerID";

                    string whereClause = "";
                    if (!ChkShowReturned.Checked)
                    {
                        whereClause = " WHERE ib.Returned = 0";
                    }

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        if (string.IsNullOrWhiteSpace(whereClause))
                        {
                            whereClause = " WHERE";
                        }
                        else
                        {
                            whereClause += " AND";
                        }
                        whereClause += " (b.Title LIKE @SearchTerm OR br.Name LIKE @SearchTerm)";
                    }

                    query += whereClause;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DgvIssuedBooks.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error loading issued books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearIssuedBookFields();
        }

        private void DgvIssuedBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvIssuedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvIssuedBooks.SelectedRows[0];
                if (selectedRow.Cells["IssueID"].Value != DBNull.Value)
                {
                    selectedIssueId = Convert.ToInt32(selectedRow.Cells["IssueID"].Value);

                    // Find the book and borrower in the combo boxes
                    string bookTitle = selectedRow.Cells["BookTitle"].Value.ToString();
                    string borrowerName = selectedRow.Cells["BorrowerName"].Value.ToString();

                    // Safely set selected index for ComboBoxes
                    int bookIndex = CmbBooks.FindStringExact(bookTitle);
                    if (bookIndex != -1) CmbBooks.SelectedIndex = bookIndex;
                    else CmbBooks.SelectedIndex = -1; // Clear selection if not found

                    int borrowerIndex = CmbBorrowers.FindStringExact(borrowerName);
                    if (borrowerIndex != -1) CmbBorrowers.SelectedIndex = borrowerIndex;
                    else CmbBorrowers.SelectedIndex = -1; // Clear selection if not found


                    DtpIssueDate.Value = Convert.ToDateTime(selectedRow.Cells["IssueDate"].Value);
                    DtpDueDate.Value = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);

                    bool isReturned = Convert.ToBoolean(selectedRow.Cells["Returned"].Value);
                    BtnReturnBook.Enabled = !isReturned; // Enable return button only if not already returned
                    
                }
            }
            else
            {
                ClearIssuedBookFields();
            }
            
        }

        private void BtnIssueBook_Click(object sender, EventArgs e)
        {
            if (CmbBooks.SelectedValue == null || CmbBorrowers.SelectedValue == null)
            {
                MessageBox.Show("Please select a book and a borrower.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(CmbBooks.SelectedValue);
            int borrowerId = Convert.ToInt32(CmbBorrowers.SelectedValue);
            DateTime issueDate = DtpIssueDate.Value.Date;
            DateTime dueDate = DtpDueDate.Value.Date;

            if (issueDate > dueDate)
            {
                MessageBox.Show("Issue date cannot be after due date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if book is available
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string checkAvailabilityQuery = "SELECT AvailableCopies FROM Books WHERE BookID = @BookID";
                    using (SqlCommand checkCommand = new SqlCommand(checkAvailabilityQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@BookID", bookId);
                        int availableCopies = (int)checkCommand.ExecuteScalar();
                        if (availableCopies <= 0)
                        {
                            MessageBox.Show("Selected book has no available copies.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error checking book availability: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string query = "INSERT INTO IssuedBooks (BookID, BorrowerID, IssueDate, DueDate, Returned) VALUES (@BookID, @BorrowerID, @IssueDate, @DueDate, 0)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", bookId),
                new SqlParameter("@BorrowerID", borrowerId),
                new SqlParameter("@IssueDate", issueDate),
                new SqlParameter("@DueDate", dueDate)
            };
            ExecuteNonQuery(query, parameters);

            // Decrement AvailableCopies in Books table
            ExecuteNonQuery("UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID",
                            new SqlParameter[] { new SqlParameter("@BookID", bookId) });
            MessageBox.Show("Issued successfully.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadIssuedBooks();
            LoadBooks(); // Refresh books grid as copies changed
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            if (selectedIssueId == -1)
            {
                MessageBox.Show("Please select an issued book to return.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to mark this book as returned?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Get BookID associated with the issued book before updating
                int bookIdToReturn = -1;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string getBookIdQuery = "SELECT BookID FROM IssuedBooks WHERE IssueID = @IssueID";
                        using (SqlCommand getBookIdCommand = new SqlCommand(getBookIdQuery, connection))
                        {
                            getBookIdCommand.Parameters.AddWithValue("@IssueID", selectedIssueId);
                            object bookIdObj = getBookIdCommand.ExecuteScalar();
                            if (bookIdObj != null)
                            {
                                bookIdToReturn = Convert.ToInt32(bookIdObj);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error getting book ID for return: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (bookIdToReturn != -1)
                {
                    string query = "UPDATE IssuedBooks SET Returned = 1 WHERE IssueID = @IssueID";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@IssueID", selectedIssueId)
                    };
                    ExecuteNonQuery(query, parameters);

                    // Increment AvailableCopies in Books table
                    ExecuteNonQuery("UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID",
                                    new SqlParameter[] { new SqlParameter("@BookID", bookIdToReturn) });
                    MessageBox.Show("Book returned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIssuedBooks();
                    LoadBooks(); // Refresh books grid as copies changed
                }
            }
        }

        private void BtnSearchIssuedBooks_Click(object sender, EventArgs e)
        {
            LoadIssuedBooks(TxtIssuedBookSearch.Text.Trim());
            MessageBox.Show("Issued books searched successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChkShowReturned_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssuedBooks(TxtIssuedBookSearch.Text.Trim());
        }

        private void ClearIssuedBookFields()
        {
            selectedIssueId = -1;
            CmbBooks.SelectedIndex = -1; // Clear selection
            CmbBorrowers.SelectedIndex = -1; // Clear selection
            DtpIssueDate.Value = DateTime.Now;
            DtpDueDate.Value = DateTime.Now.AddDays(14); // Default due date 14 days from now
            BtnReturnBook.Enabled = false;
            DgvIssuedBooks.ClearSelection();
        }

        // --- ComboBox Population Methods ---

        private void PopulateBookComboBox()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT BookID, Title FROM Books WHERE AvailableCopies > 0 ORDER BY Title";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        CmbBooks.DisplayMember = "Title";
                        CmbBooks.ValueMember = "BookID";
                        CmbBooks.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error populating book combo box: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopulateBorrowerComboBox()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT BorrowerID, Name FROM Borrowers ORDER BY Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        CmbBorrowers.DisplayMember = "Name";
                        CmbBorrowers.ValueMember = "BorrowerID";
                        CmbBorrowers.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error populating borrower combo box: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 loginForm = new Form1();
            loginForm.Show(); 
        }
    }
}
