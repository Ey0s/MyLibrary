namespace Libraryproject
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabBookManagement = new System.Windows.Forms.TabPage();
            this.panelBookControls = new System.Windows.Forms.Panel();
            this.BtnClearBookFields = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnEditBook = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.panelBookFields = new System.Windows.Forms.Panel();
            this.TxtBookCopies = new System.Windows.Forms.TextBox();
            this.LblBookCopies = new System.Windows.Forms.Label();
            this.TxtBookYear = new System.Windows.Forms.TextBox();
            this.LblBookYear = new System.Windows.Forms.Label();
            this.TxtBookAuthor = new System.Windows.Forms.TextBox();
            this.LblBookAuthor = new System.Windows.Forms.Label();
            this.TxtBookTitle = new System.Windows.Forms.TextBox();
            this.LblBookTitle = new System.Windows.Forms.Label();
            this.panelBookSearch = new System.Windows.Forms.Panel();
            this.BtnSearchBooks = new System.Windows.Forms.Button();
            this.TxtBookSearch = new System.Windows.Forms.TextBox();
            this.LblBookSearch = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.TabBorrowManagement = new System.Windows.Forms.TabPage();
            this.groupBoxBorrowers = new System.Windows.Forms.GroupBox();
            this.panelBorrowerControls = new System.Windows.Forms.Panel();
            this.BtnClearBorrowerFields = new System.Windows.Forms.Button();
            this.BtnDeleteBorrower = new System.Windows.Forms.Button();
            this.BtnEditBorrower = new System.Windows.Forms.Button();
            this.BtnAddBorrower = new System.Windows.Forms.Button();
            this.panelBorrowerFields = new System.Windows.Forms.Panel();
            this.TxtBorrowerPhone = new System.Windows.Forms.TextBox();
            this.LblBorrowerPhone = new System.Windows.Forms.Label();
            this.TxtBorrowerEmail = new System.Windows.Forms.TextBox();
            this.LblBorrowerEmail = new System.Windows.Forms.Label();
            this.TxtBorrowerName = new System.Windows.Forms.TextBox();
            this.LblBorrowerName = new System.Windows.Forms.Label();
            this.panelBorrowerSearch = new System.Windows.Forms.Panel();
            this.BtnSearchBorrowers = new System.Windows.Forms.Button();
            this.TxtBorrowerSearch = new System.Windows.Forms.TextBox();
            this.LblBorrowerSearch = new System.Windows.Forms.Label();
            this.DgvBorrowers = new System.Windows.Forms.DataGridView();
            this.groupBoxIssuedBooks = new System.Windows.Forms.GroupBox();
            this.panelIssueControls = new System.Windows.Forms.Panel();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnIssueBook = new System.Windows.Forms.Button();
            this.panelIssueFields = new System.Windows.Forms.Panel();
            this.DtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.LblDueDate = new System.Windows.Forms.Label();
            this.DtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.LblIssueDate = new System.Windows.Forms.Label();
            this.CmbBorrowers = new System.Windows.Forms.ComboBox();
            this.LblSelectBorrower = new System.Windows.Forms.Label();
            this.CmbBooks = new System.Windows.Forms.ComboBox();
            this.LblSelectBook = new System.Windows.Forms.Label();
            this.panelIssueSearch = new System.Windows.Forms.Panel();
            this.ChkShowReturned = new System.Windows.Forms.CheckBox();
            this.BtnSearchIssuedBooks = new System.Windows.Forms.Button();
            this.TxtIssuedBookSearch = new System.Windows.Forms.TextBox();
            this.LblIssuedBookSearch = new System.Windows.Forms.Label();
            this.DgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.TabControlMain.SuspendLayout();
            this.TabBookManagement.SuspendLayout();
            this.panelBookControls.SuspendLayout();
            this.panelBookFields.SuspendLayout();
            this.panelBookSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.TabBorrowManagement.SuspendLayout();
            this.groupBoxBorrowers.SuspendLayout();
            this.panelBorrowerControls.SuspendLayout();
            this.panelBorrowerFields.SuspendLayout();
            this.panelBorrowerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowers)).BeginInit();
            this.groupBoxIssuedBooks.SuspendLayout();
            this.panelIssueControls.SuspendLayout();
            this.panelIssueFields.SuspendLayout();
            this.panelIssueSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMain.Controls.Add(this.TabBookManagement);
            this.TabControlMain.Controls.Add(this.TabBorrowManagement);
            this.TabControlMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.Location = new System.Drawing.Point(12, 12);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1200, 720);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabBookManagement
            // 
            this.TabBookManagement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabBookManagement.Controls.Add(this.panelBookControls);
            this.TabBookManagement.Controls.Add(this.panelBookFields);
            this.TabBookManagement.Controls.Add(this.panelBookSearch);
            this.TabBookManagement.Controls.Add(this.DgvBooks);
            this.TabBookManagement.Location = new System.Drawing.Point(4, 37);
            this.TabBookManagement.Name = "TabBookManagement";
            this.TabBookManagement.Padding = new System.Windows.Forms.Padding(10);
            this.TabBookManagement.Size = new System.Drawing.Size(1192, 659);
            this.TabBookManagement.TabIndex = 0;
            this.TabBookManagement.Text = "Book Management";
            // 
            // panelBookControls
            // 
            this.panelBookControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookControls.BackColor = System.Drawing.Color.White;
            this.panelBookControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookControls.Controls.Add(this.BtnClearBookFields);
            this.panelBookControls.Controls.Add(this.BtnDeleteBook);
            this.panelBookControls.Controls.Add(this.BtnEditBook);
            this.panelBookControls.Controls.Add(this.BtnAddBook);
            this.panelBookControls.Location = new System.Drawing.Point(850, 400);
            this.panelBookControls.Name = "panelBookControls";
            this.panelBookControls.Padding = new System.Windows.Forms.Padding(5);
            this.panelBookControls.Size = new System.Drawing.Size(320, 60);
            this.panelBookControls.TabIndex = 16;
            // 
            // BtnClearBookFields
            // 
            this.BtnClearBookFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnClearBookFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClearBookFields.FlatAppearance.BorderSize = 0;
            this.BtnClearBookFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearBookFields.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearBookFields.ForeColor = System.Drawing.Color.Black;
            this.BtnClearBookFields.Location = new System.Drawing.Point(240, 5);
            this.BtnClearBookFields.Name = "BtnClearBookFields";
            this.BtnClearBookFields.Size = new System.Drawing.Size(75, 48);
            this.BtnClearBookFields.TabIndex = 15;
            this.BtnClearBookFields.Text = "Clear";
            this.BtnClearBookFields.UseVisualStyleBackColor = false;
            this.BtnClearBookFields.Click += new System.EventHandler(this.BtnClearBookFields_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnDeleteBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteBook.FlatAppearance.BorderSize = 0;
            this.BtnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteBook.Location = new System.Drawing.Point(160, 5);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(80, 48);
            this.BtnDeleteBook.TabIndex = 14;
            this.BtnDeleteBook.Text = "Delete";
            this.BtnDeleteBook.UseVisualStyleBackColor = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnEditBook
            // 
            this.BtnEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnEditBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEditBook.FlatAppearance.BorderSize = 0;
            this.BtnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBook.ForeColor = System.Drawing.Color.White;
            this.BtnEditBook.Location = new System.Drawing.Point(80, 5);
            this.BtnEditBook.Name = "BtnEditBook";
            this.BtnEditBook.Size = new System.Drawing.Size(80, 48);
            this.BtnEditBook.TabIndex = 13;
            this.BtnEditBook.Text = "Edit";
            this.BtnEditBook.UseVisualStyleBackColor = false;
            this.BtnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnAddBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddBook.FlatAppearance.BorderSize = 0;
            this.BtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBook.ForeColor = System.Drawing.Color.White;
            this.BtnAddBook.Location = new System.Drawing.Point(5, 5);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(75, 48);
            this.BtnAddBook.TabIndex = 12;
            this.BtnAddBook.Text = "Add";
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // panelBookFields
            // 
            this.panelBookFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookFields.BackColor = System.Drawing.Color.White;
            this.panelBookFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookFields.Controls.Add(this.TxtBookCopies);
            this.panelBookFields.Controls.Add(this.LblBookCopies);
            this.panelBookFields.Controls.Add(this.TxtBookYear);
            this.panelBookFields.Controls.Add(this.LblBookYear);
            this.panelBookFields.Controls.Add(this.TxtBookAuthor);
            this.panelBookFields.Controls.Add(this.LblBookAuthor);
            this.panelBookFields.Controls.Add(this.TxtBookTitle);
            this.panelBookFields.Controls.Add(this.LblBookTitle);
            this.panelBookFields.Location = new System.Drawing.Point(850, 100);
            this.panelBookFields.Name = "panelBookFields";
            this.panelBookFields.Padding = new System.Windows.Forms.Padding(10);
            this.panelBookFields.Size = new System.Drawing.Size(320, 290);
            this.panelBookFields.TabIndex = 15;
            // 
            // TxtBookCopies
            // 
            this.TxtBookCopies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBookCopies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookCopies.Location = new System.Drawing.Point(110, 220);
            this.TxtBookCopies.Name = "TxtBookCopies";
            this.TxtBookCopies.Size = new System.Drawing.Size(190, 33);
            this.TxtBookCopies.TabIndex = 11;
            // 
            // LblBookCopies
            // 
            this.LblBookCopies.AutoSize = true;
            this.LblBookCopies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookCopies.Location = new System.Drawing.Point(10, 223);
            this.LblBookCopies.Name = "LblBookCopies";
            this.LblBookCopies.Size = new System.Drawing.Size(75, 28);
            this.LblBookCopies.TabIndex = 10;
            this.LblBookCopies.Text = "Copies:";
            // 
            // TxtBookYear
            // 
            this.TxtBookYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBookYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookYear.Location = new System.Drawing.Point(110, 160);
            this.TxtBookYear.Name = "TxtBookYear";
            this.TxtBookYear.Size = new System.Drawing.Size(190, 33);
            this.TxtBookYear.TabIndex = 9;
            // 
            // LblBookYear
            // 
            this.LblBookYear.AutoSize = true;
            this.LblBookYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookYear.Location = new System.Drawing.Point(10, 163);
            this.LblBookYear.Name = "LblBookYear";
            this.LblBookYear.Size = new System.Drawing.Size(52, 28);
            this.LblBookYear.TabIndex = 8;
            this.LblBookYear.Text = "Year:";
            // 
            // TxtBookAuthor
            // 
            this.TxtBookAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookAuthor.Location = new System.Drawing.Point(110, 100);
            this.TxtBookAuthor.Name = "TxtBookAuthor";
            this.TxtBookAuthor.Size = new System.Drawing.Size(190, 33);
            this.TxtBookAuthor.TabIndex = 7;
            // 
            // LblBookAuthor
            // 
            this.LblBookAuthor.AutoSize = true;
            this.LblBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookAuthor.Location = new System.Drawing.Point(10, 103);
            this.LblBookAuthor.Name = "LblBookAuthor";
            this.LblBookAuthor.Size = new System.Drawing.Size(77, 28);
            this.LblBookAuthor.TabIndex = 6;
            this.LblBookAuthor.Text = "Author:";
            // 
            // TxtBookTitle
            // 
            this.TxtBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBookTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookTitle.Location = new System.Drawing.Point(110, 40);
            this.TxtBookTitle.Name = "TxtBookTitle";
            this.TxtBookTitle.Size = new System.Drawing.Size(190, 33);
            this.TxtBookTitle.TabIndex = 5;
            // 
            // LblBookTitle
            // 
            this.LblBookTitle.AutoSize = true;
            this.LblBookTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookTitle.Location = new System.Drawing.Point(10, 43);
            this.LblBookTitle.Name = "LblBookTitle";
            this.LblBookTitle.Size = new System.Drawing.Size(53, 28);
            this.LblBookTitle.TabIndex = 4;
            this.LblBookTitle.Text = "Title:";
            // 
            // panelBookSearch
            // 
            this.panelBookSearch.BackColor = System.Drawing.Color.White;
            this.panelBookSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookSearch.Controls.Add(this.BtnSearchBooks);
            this.panelBookSearch.Controls.Add(this.TxtBookSearch);
            this.panelBookSearch.Controls.Add(this.LblBookSearch);
            this.panelBookSearch.Location = new System.Drawing.Point(20, 20);
            this.panelBookSearch.Name = "panelBookSearch";
            this.panelBookSearch.Padding = new System.Windows.Forms.Padding(10);
            this.panelBookSearch.Size = new System.Drawing.Size(500, 60);
            this.panelBookSearch.TabIndex = 14;
            // 
            // BtnSearchBooks
            // 
            this.BtnSearchBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSearchBooks.FlatAppearance.BorderSize = 0;
            this.BtnSearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchBooks.ForeColor = System.Drawing.Color.White;
            this.BtnSearchBooks.Location = new System.Drawing.Point(380, 10);
            this.BtnSearchBooks.Name = "BtnSearchBooks";
            this.BtnSearchBooks.Size = new System.Drawing.Size(100, 35);
            this.BtnSearchBooks.TabIndex = 3;
            this.BtnSearchBooks.Text = "Search";
            this.BtnSearchBooks.UseVisualStyleBackColor = false;
            this.BtnSearchBooks.Click += new System.EventHandler(this.BtnSearchBooks_Click);
            // 
            // TxtBookSearch
            // 
            this.TxtBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBookSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookSearch.Location = new System.Drawing.Point(120, 15);
            this.TxtBookSearch.Name = "TxtBookSearch";
            this.TxtBookSearch.Size = new System.Drawing.Size(250, 33);
            this.TxtBookSearch.TabIndex = 2;
            // 
            // LblBookSearch
            // 
            this.LblBookSearch.AutoSize = true;
            this.LblBookSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookSearch.Location = new System.Drawing.Point(10, 18);
            this.LblBookSearch.Name = "LblBookSearch";
            this.LblBookSearch.Size = new System.Drawing.Size(132, 28);
            this.LblBookSearch.TabIndex = 1;
            this.LblBookSearch.Text = "Search Books:";
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBooks.Location = new System.Drawing.Point(20, 100);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.RowHeadersVisible = false;
            this.DgvBooks.RowHeadersWidth = 62;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(800, 550);
            this.DgvBooks.TabIndex = 0;
            this.DgvBooks.SelectionChanged += new System.EventHandler(this.DgvBooks_SelectionChanged);
            // 
            // TabBorrowManagement
            // 
            this.TabBorrowManagement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabBorrowManagement.Controls.Add(this.groupBoxBorrowers);
            this.TabBorrowManagement.Controls.Add(this.groupBoxIssuedBooks);
            this.TabBorrowManagement.Location = new System.Drawing.Point(4, 37);
            this.TabBorrowManagement.Name = "TabBorrowManagement";
            this.TabBorrowManagement.Padding = new System.Windows.Forms.Padding(10);
            this.TabBorrowManagement.Size = new System.Drawing.Size(1192, 679);
            this.TabBorrowManagement.TabIndex = 1;
            this.TabBorrowManagement.Text = "Borrow Management";
            // 
            // groupBoxBorrowers
            // 
            this.groupBoxBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBorrowers.BackColor = System.Drawing.Color.White;
            this.groupBoxBorrowers.Controls.Add(this.panelBorrowerControls);
            this.groupBoxBorrowers.Controls.Add(this.panelBorrowerFields);
            this.groupBoxBorrowers.Controls.Add(this.panelBorrowerSearch);
            this.groupBoxBorrowers.Controls.Add(this.DgvBorrowers);
            this.groupBoxBorrowers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBorrowers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxBorrowers.Name = "groupBoxBorrowers";
            this.groupBoxBorrowers.Size = new System.Drawing.Size(1150, 300);
            this.groupBoxBorrowers.TabIndex = 0;
            this.groupBoxBorrowers.TabStop = false;
            this.groupBoxBorrowers.Text = "Borrower Management";
            // 
            // panelBorrowerControls
            // 
            this.panelBorrowerControls.BackColor = System.Drawing.Color.White;
            this.panelBorrowerControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorrowerControls.Controls.Add(this.BtnClearBorrowerFields);
            this.panelBorrowerControls.Controls.Add(this.BtnDeleteBorrower);
            this.panelBorrowerControls.Controls.Add(this.BtnEditBorrower);
            this.panelBorrowerControls.Controls.Add(this.BtnAddBorrower);
            this.panelBorrowerControls.Location = new System.Drawing.Point(20, 240);
            this.panelBorrowerControls.Name = "panelBorrowerControls";
            this.panelBorrowerControls.Padding = new System.Windows.Forms.Padding(5);
            this.panelBorrowerControls.Size = new System.Drawing.Size(420, 50);
            this.panelBorrowerControls.TabIndex = 16;
            // 
            // BtnClearBorrowerFields
            // 
            this.BtnClearBorrowerFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnClearBorrowerFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClearBorrowerFields.FlatAppearance.BorderSize = 0;
            this.BtnClearBorrowerFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearBorrowerFields.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearBorrowerFields.ForeColor = System.Drawing.Color.Black;
            this.BtnClearBorrowerFields.Location = new System.Drawing.Point(315, 5);
            this.BtnClearBorrowerFields.Name = "BtnClearBorrowerFields";
            this.BtnClearBorrowerFields.Size = new System.Drawing.Size(100, 38);
            this.BtnClearBorrowerFields.TabIndex = 15;
            this.BtnClearBorrowerFields.Text = "Clear";
            this.BtnClearBorrowerFields.UseVisualStyleBackColor = false;
            this.BtnClearBorrowerFields.Click += new System.EventHandler(this.BtnClearBorrowerFields_Click);
            // 
            // BtnDeleteBorrower
            // 
            this.BtnDeleteBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnDeleteBorrower.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteBorrower.FlatAppearance.BorderSize = 0;
            this.BtnDeleteBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteBorrower.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteBorrower.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteBorrower.Location = new System.Drawing.Point(210, 5);
            this.BtnDeleteBorrower.Name = "BtnDeleteBorrower";
            this.BtnDeleteBorrower.Size = new System.Drawing.Size(105, 38);
            this.BtnDeleteBorrower.TabIndex = 14;
            this.BtnDeleteBorrower.Text = "Delete";
            this.BtnDeleteBorrower.UseVisualStyleBackColor = false;
            this.BtnDeleteBorrower.Click += new System.EventHandler(this.BtnDeleteBorrower_Click);
            // 
            // BtnEditBorrower
            // 
            this.BtnEditBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnEditBorrower.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEditBorrower.FlatAppearance.BorderSize = 0;
            this.BtnEditBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditBorrower.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBorrower.ForeColor = System.Drawing.Color.White;
            this.BtnEditBorrower.Location = new System.Drawing.Point(105, 5);
            this.BtnEditBorrower.Name = "BtnEditBorrower";
            this.BtnEditBorrower.Size = new System.Drawing.Size(105, 38);
            this.BtnEditBorrower.TabIndex = 13;
            this.BtnEditBorrower.Text = "Edit";
            this.BtnEditBorrower.UseVisualStyleBackColor = false;
            this.BtnEditBorrower.Click += new System.EventHandler(this.BtnEditBorrower_Click);
            // 
            // BtnAddBorrower
            // 
            this.BtnAddBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnAddBorrower.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddBorrower.FlatAppearance.BorderSize = 0;
            this.BtnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBorrower.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBorrower.ForeColor = System.Drawing.Color.White;
            this.BtnAddBorrower.Location = new System.Drawing.Point(5, 5);
            this.BtnAddBorrower.Name = "BtnAddBorrower";
            this.BtnAddBorrower.Size = new System.Drawing.Size(100, 38);
            this.BtnAddBorrower.TabIndex = 12;
            this.BtnAddBorrower.Text = "Add";
            this.BtnAddBorrower.UseVisualStyleBackColor = false;
            this.BtnAddBorrower.Click += new System.EventHandler(this.BtnAddBorrower_Click);
            // 
            // panelBorrowerFields
            // 
            this.panelBorrowerFields.BackColor = System.Drawing.Color.White;
            this.panelBorrowerFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorrowerFields.Controls.Add(this.TxtBorrowerPhone);
            this.panelBorrowerFields.Controls.Add(this.LblBorrowerPhone);
            this.panelBorrowerFields.Controls.Add(this.TxtBorrowerEmail);
            this.panelBorrowerFields.Controls.Add(this.LblBorrowerEmail);
            this.panelBorrowerFields.Controls.Add(this.TxtBorrowerName);
            this.panelBorrowerFields.Controls.Add(this.LblBorrowerName);
            this.panelBorrowerFields.Location = new System.Drawing.Point(20, 80);
            this.panelBorrowerFields.Name = "panelBorrowerFields";
            this.panelBorrowerFields.Padding = new System.Windows.Forms.Padding(10);
            this.panelBorrowerFields.Size = new System.Drawing.Size(420, 150);
            this.panelBorrowerFields.TabIndex = 15;
            // 
            // TxtBorrowerPhone
            // 
            this.TxtBorrowerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBorrowerPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBorrowerPhone.Location = new System.Drawing.Point(110, 100);
            this.TxtBorrowerPhone.Name = "TxtBorrowerPhone";
            this.TxtBorrowerPhone.Size = new System.Drawing.Size(290, 33);
            this.TxtBorrowerPhone.TabIndex = 11;
            // 
            // LblBorrowerPhone
            // 
            this.LblBorrowerPhone.AutoSize = true;
            this.LblBorrowerPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBorrowerPhone.Location = new System.Drawing.Point(10, 103);
            this.LblBorrowerPhone.Name = "LblBorrowerPhone";
            this.LblBorrowerPhone.Size = new System.Drawing.Size(71, 28);
            this.LblBorrowerPhone.TabIndex = 10;
            this.LblBorrowerPhone.Text = "Phone:";
            // 
            // TxtBorrowerEmail
            // 
            this.TxtBorrowerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBorrowerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBorrowerEmail.Location = new System.Drawing.Point(110, 60);
            this.TxtBorrowerEmail.Name = "TxtBorrowerEmail";
            this.TxtBorrowerEmail.Size = new System.Drawing.Size(290, 33);
            this.TxtBorrowerEmail.TabIndex = 9;
            // 
            // LblBorrowerEmail
            // 
            this.LblBorrowerEmail.AutoSize = true;
            this.LblBorrowerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBorrowerEmail.Location = new System.Drawing.Point(10, 63);
            this.LblBorrowerEmail.Name = "LblBorrowerEmail";
            this.LblBorrowerEmail.Size = new System.Drawing.Size(63, 28);
            this.LblBorrowerEmail.TabIndex = 8;
            this.LblBorrowerEmail.Text = "Email:";
            // 
            // TxtBorrowerName
            // 
            this.TxtBorrowerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBorrowerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBorrowerName.Location = new System.Drawing.Point(110, 20);
            this.TxtBorrowerName.Name = "TxtBorrowerName";
            this.TxtBorrowerName.Size = new System.Drawing.Size(290, 33);
            this.TxtBorrowerName.TabIndex = 5;
            // 
            // LblBorrowerName
            // 
            this.LblBorrowerName.AutoSize = true;
            this.LblBorrowerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBorrowerName.Location = new System.Drawing.Point(10, 23);
            this.LblBorrowerName.Name = "LblBorrowerName";
            this.LblBorrowerName.Size = new System.Drawing.Size(68, 28);
            this.LblBorrowerName.TabIndex = 4;
            this.LblBorrowerName.Text = "Name:";
            // 
            // panelBorrowerSearch
            // 
            this.panelBorrowerSearch.BackColor = System.Drawing.Color.White;
            this.panelBorrowerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorrowerSearch.Controls.Add(this.BtnSearchBorrowers);
            this.panelBorrowerSearch.Controls.Add(this.TxtBorrowerSearch);
            this.panelBorrowerSearch.Controls.Add(this.LblBorrowerSearch);
            this.panelBorrowerSearch.Location = new System.Drawing.Point(20, 20);
            this.panelBorrowerSearch.Name = "panelBorrowerSearch";
            this.panelBorrowerSearch.Padding = new System.Windows.Forms.Padding(10);
            this.panelBorrowerSearch.Size = new System.Drawing.Size(420, 50);
            this.panelBorrowerSearch.TabIndex = 14;
            // 
            // BtnSearchBorrowers
            // 
            this.BtnSearchBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchBorrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSearchBorrowers.FlatAppearance.BorderSize = 0;
            this.BtnSearchBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchBorrowers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchBorrowers.ForeColor = System.Drawing.Color.White;
            this.BtnSearchBorrowers.Location = new System.Drawing.Point(300, 10);
            this.BtnSearchBorrowers.Name = "BtnSearchBorrowers";
            this.BtnSearchBorrowers.Size = new System.Drawing.Size(100, 25);
            this.BtnSearchBorrowers.TabIndex = 3;
            this.BtnSearchBorrowers.Text = "Search";
            this.BtnSearchBorrowers.UseVisualStyleBackColor = false;
            this.BtnSearchBorrowers.Click += new System.EventHandler(this.BtnSearchBorrowers_Click);
            // 
            // TxtBorrowerSearch
            // 
            this.TxtBorrowerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBorrowerSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBorrowerSearch.Location = new System.Drawing.Point(120, 12);
            this.TxtBorrowerSearch.Name = "TxtBorrowerSearch";
            this.TxtBorrowerSearch.Size = new System.Drawing.Size(170, 33);
            this.TxtBorrowerSearch.TabIndex = 2;
            // 
            // LblBorrowerSearch
            // 
            this.LblBorrowerSearch.AutoSize = true;
            this.LblBorrowerSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBorrowerSearch.Location = new System.Drawing.Point(10, 15);
            this.LblBorrowerSearch.Name = "LblBorrowerSearch";
            this.LblBorrowerSearch.Size = new System.Drawing.Size(131, 28);
            this.LblBorrowerSearch.TabIndex = 1;
            this.LblBorrowerSearch.Text = "Search Name:";
            // 
            // DgvBorrowers
            // 
            this.DgvBorrowers.AllowUserToAddRows = false;
            this.DgvBorrowers.AllowUserToDeleteRows = false;
            this.DgvBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBorrowers.BackgroundColor = System.Drawing.Color.White;
            this.DgvBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBorrowers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBorrowers.Location = new System.Drawing.Point(460, 20);
            this.DgvBorrowers.Name = "DgvBorrowers";
            this.DgvBorrowers.ReadOnly = true;
            this.DgvBorrowers.RowHeadersVisible = false;
            this.DgvBorrowers.RowHeadersWidth = 62;
            this.DgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBorrowers.Size = new System.Drawing.Size(680, 270);
            this.DgvBorrowers.TabIndex = 0;
            this.DgvBorrowers.SelectionChanged += new System.EventHandler(this.DgvBorrowers_SelectionChanged);
            // 
            // groupBoxIssuedBooks
            // 
            this.groupBoxIssuedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIssuedBooks.BackColor = System.Drawing.Color.White;
            this.groupBoxIssuedBooks.Controls.Add(this.panelIssueControls);
            this.groupBoxIssuedBooks.Controls.Add(this.panelIssueFields);
            this.groupBoxIssuedBooks.Controls.Add(this.panelIssueSearch);
            this.groupBoxIssuedBooks.Controls.Add(this.DgvIssuedBooks);
            this.groupBoxIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIssuedBooks.Location = new System.Drawing.Point(20, 330);
            this.groupBoxIssuedBooks.Name = "groupBoxIssuedBooks";
            this.groupBoxIssuedBooks.Size = new System.Drawing.Size(1150, 340);
            this.groupBoxIssuedBooks.TabIndex = 1;
            this.groupBoxIssuedBooks.TabStop = false;
            this.groupBoxIssuedBooks.Text = "Book Issuing/Returning";
            // 
            // panelIssueControls
            // 
            this.panelIssueControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIssueControls.BackColor = System.Drawing.Color.White;
            this.panelIssueControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIssueControls.Controls.Add(this.BtnReturnBook);
            this.panelIssueControls.Controls.Add(this.BtnIssueBook);
            this.panelIssueControls.Location = new System.Drawing.Point(740, 240);
            this.panelIssueControls.Name = "panelIssueControls";
            this.panelIssueControls.Padding = new System.Windows.Forms.Padding(5);
            this.panelIssueControls.Size = new System.Drawing.Size(400, 60);
            this.panelIssueControls.TabIndex = 15;
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnReturnBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnReturnBook.Enabled = false;
            this.BtnReturnBook.FlatAppearance.BorderSize = 0;
            this.BtnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnBook.ForeColor = System.Drawing.Color.Black;
            this.BtnReturnBook.Location = new System.Drawing.Point(205, 5);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(190, 48);
            this.BtnReturnBook.TabIndex = 10;
            this.BtnReturnBook.Text = "Return Book";
            this.BtnReturnBook.UseVisualStyleBackColor = false;
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // BtnIssueBook
            // 
            this.BtnIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnIssueBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnIssueBook.FlatAppearance.BorderSize = 0;
            this.BtnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssueBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIssueBook.ForeColor = System.Drawing.Color.White;
            this.BtnIssueBook.Location = new System.Drawing.Point(5, 5);
            this.BtnIssueBook.Name = "BtnIssueBook";
            this.BtnIssueBook.Size = new System.Drawing.Size(200, 48);
            this.BtnIssueBook.TabIndex = 9;
            this.BtnIssueBook.Text = "Issue Book";
            this.BtnIssueBook.UseVisualStyleBackColor = false;
            this.BtnIssueBook.Click += new System.EventHandler(this.BtnIssueBook_Click);
            // 
            // panelIssueFields
            // 
            this.panelIssueFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIssueFields.BackColor = System.Drawing.Color.White;
            this.panelIssueFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIssueFields.Controls.Add(this.DtpDueDate);
            this.panelIssueFields.Controls.Add(this.LblDueDate);
            this.panelIssueFields.Controls.Add(this.DtpIssueDate);
            this.panelIssueFields.Controls.Add(this.LblIssueDate);
            this.panelIssueFields.Controls.Add(this.CmbBorrowers);
            this.panelIssueFields.Controls.Add(this.LblSelectBorrower);
            this.panelIssueFields.Controls.Add(this.CmbBooks);
            this.panelIssueFields.Controls.Add(this.LblSelectBook);
            this.panelIssueFields.Location = new System.Drawing.Point(740, 60);
            this.panelIssueFields.Name = "panelIssueFields";
            this.panelIssueFields.Padding = new System.Windows.Forms.Padding(10);
            this.panelIssueFields.Size = new System.Drawing.Size(400, 170);
            this.panelIssueFields.TabIndex = 14;
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDueDate.Location = new System.Drawing.Point(110, 130);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.Size = new System.Drawing.Size(270, 33);
            this.DtpDueDate.TabIndex = 8;
            // 
            // LblDueDate
            // 
            this.LblDueDate.AutoSize = true;
            this.LblDueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDueDate.Location = new System.Drawing.Point(10, 133);
            this.LblDueDate.Name = "LblDueDate";
            this.LblDueDate.Size = new System.Drawing.Size(97, 28);
            this.LblDueDate.TabIndex = 7;
            this.LblDueDate.Text = "Due Date:";
            // 
            // DtpIssueDate
            // 
            this.DtpIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpIssueDate.Location = new System.Drawing.Point(110, 90);
            this.DtpIssueDate.Name = "DtpIssueDate";
            this.DtpIssueDate.Size = new System.Drawing.Size(270, 33);
            this.DtpIssueDate.TabIndex = 6;
            // 
            // LblIssueDate
            // 
            this.LblIssueDate.AutoSize = true;
            this.LblIssueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssueDate.Location = new System.Drawing.Point(10, 93);
            this.LblIssueDate.Name = "LblIssueDate";
            this.LblIssueDate.Size = new System.Drawing.Size(104, 28);
            this.LblIssueDate.TabIndex = 5;
            this.LblIssueDate.Text = "Issue Date:";
            // 
            // CmbBorrowers
            // 
            this.CmbBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBorrowers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBorrowers.FormattingEnabled = true;
            this.CmbBorrowers.Location = new System.Drawing.Point(110, 50);
            this.CmbBorrowers.Name = "CmbBorrowers";
            this.CmbBorrowers.Size = new System.Drawing.Size(270, 36);
            this.CmbBorrowers.TabIndex = 4;
            // 
            // LblSelectBorrower
            // 
            this.LblSelectBorrower.AutoSize = true;
            this.LblSelectBorrower.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectBorrower.Location = new System.Drawing.Point(10, 53);
            this.LblSelectBorrower.Name = "LblSelectBorrower";
            this.LblSelectBorrower.Size = new System.Drawing.Size(153, 28);
            this.LblSelectBorrower.TabIndex = 3;
            this.LblSelectBorrower.Text = "Select Borrower:";
            // 
            // CmbBooks
            // 
            this.CmbBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBooks.FormattingEnabled = true;
            this.CmbBooks.Location = new System.Drawing.Point(110, 10);
            this.CmbBooks.Name = "CmbBooks";
            this.CmbBooks.Size = new System.Drawing.Size(270, 36);
            this.CmbBooks.TabIndex = 2;
            // 
            // LblSelectBook
            // 
            this.LblSelectBook.AutoSize = true;
            this.LblSelectBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectBook.Location = new System.Drawing.Point(10, 13);
            this.LblSelectBook.Name = "LblSelectBook";
            this.LblSelectBook.Size = new System.Drawing.Size(118, 28);
            this.LblSelectBook.TabIndex = 1;
            this.LblSelectBook.Text = "Select Book:";
            // 
            // panelIssueSearch
            // 
            this.panelIssueSearch.BackColor = System.Drawing.Color.White;
            this.panelIssueSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIssueSearch.Controls.Add(this.ChkShowReturned);
            this.panelIssueSearch.Controls.Add(this.BtnSearchIssuedBooks);
            this.panelIssueSearch.Controls.Add(this.TxtIssuedBookSearch);
            this.panelIssueSearch.Controls.Add(this.LblIssuedBookSearch);
            this.panelIssueSearch.Location = new System.Drawing.Point(20, 20);
            this.panelIssueSearch.Name = "panelIssueSearch";
            this.panelIssueSearch.Padding = new System.Windows.Forms.Padding(10);
            this.panelIssueSearch.Size = new System.Drawing.Size(700, 50);
            this.panelIssueSearch.TabIndex = 13;
            // 
            // ChkShowReturned
            // 
            this.ChkShowReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkShowReturned.AutoSize = true;
            this.ChkShowReturned.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkShowReturned.Location = new System.Drawing.Point(452, 15);
            this.ChkShowReturned.Name = "ChkShowReturned";
            this.ChkShowReturned.Size = new System.Drawing.Size(228, 32);
            this.ChkShowReturned.TabIndex = 14;
            this.ChkShowReturned.Text = "Show Returned Books";
            this.ChkShowReturned.UseVisualStyleBackColor = true;
            this.ChkShowReturned.CheckedChanged += new System.EventHandler(this.ChkShowReturned_CheckedChanged);
            // 
            // BtnSearchIssuedBooks
            // 
            this.BtnSearchIssuedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchIssuedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSearchIssuedBooks.FlatAppearance.BorderSize = 0;
            this.BtnSearchIssuedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchIssuedBooks.ForeColor = System.Drawing.Color.White;
            this.BtnSearchIssuedBooks.Location = new System.Drawing.Point(380, 10);
            this.BtnSearchIssuedBooks.Name = "BtnSearchIssuedBooks";
            this.BtnSearchIssuedBooks.Size = new System.Drawing.Size(100, 25);
            this.BtnSearchIssuedBooks.TabIndex = 13;
            this.BtnSearchIssuedBooks.Text = "Search";
            this.BtnSearchIssuedBooks.UseVisualStyleBackColor = false;
            this.BtnSearchIssuedBooks.Click += new System.EventHandler(this.BtnSearchIssuedBooks_Click);
            // 
            // TxtIssuedBookSearch
            // 
            this.TxtIssuedBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIssuedBookSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIssuedBookSearch.Location = new System.Drawing.Point(120, 12);
            this.TxtIssuedBookSearch.Name = "TxtIssuedBookSearch";
            this.TxtIssuedBookSearch.Size = new System.Drawing.Size(250, 33);
            this.TxtIssuedBookSearch.TabIndex = 12;
            // 
            // LblIssuedBookSearch
            // 
            this.LblIssuedBookSearch.AutoSize = true;
            this.LblIssuedBookSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssuedBookSearch.Location = new System.Drawing.Point(10, 15);
            this.LblIssuedBookSearch.Name = "LblIssuedBookSearch";
            this.LblIssuedBookSearch.Size = new System.Drawing.Size(133, 28);
            this.LblIssuedBookSearch.TabIndex = 11;
            this.LblIssuedBookSearch.Text = "Search Issued:";
            // 
            // DgvIssuedBooks
            // 
            this.DgvIssuedBooks.AllowUserToAddRows = false;
            this.DgvIssuedBooks.AllowUserToDeleteRows = false;
            this.DgvIssuedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvIssuedBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvIssuedBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvIssuedBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvIssuedBooks.Location = new System.Drawing.Point(20, 80);
            this.DgvIssuedBooks.Name = "DgvIssuedBooks";
            this.DgvIssuedBooks.ReadOnly = true;
            this.DgvIssuedBooks.RowHeadersVisible = false;
            this.DgvIssuedBooks.RowHeadersWidth = 62;
            this.DgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIssuedBooks.Size = new System.Drawing.Size(700, 240);
            this.DgvIssuedBooks.TabIndex = 0;
            this.DgvIssuedBooks.SelectionChanged += new System.EventHandler(this.DgvIssuedBooks_SelectionChanged);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(1075, 725);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(120, 35);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 765);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.TabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1240, 800);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TabControlMain.ResumeLayout(false);
            this.TabBookManagement.ResumeLayout(false);
            this.panelBookControls.ResumeLayout(false);
            this.panelBookFields.ResumeLayout(false);
            this.panelBookFields.PerformLayout();
            this.panelBookSearch.ResumeLayout(false);
            this.panelBookSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.TabBorrowManagement.ResumeLayout(false);
            this.groupBoxBorrowers.ResumeLayout(false);
            this.panelBorrowerControls.ResumeLayout(false);
            this.panelBorrowerFields.ResumeLayout(false);
            this.panelBorrowerFields.PerformLayout();
            this.panelBorrowerSearch.ResumeLayout(false);
            this.panelBorrowerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowers)).EndInit();
            this.groupBoxIssuedBooks.ResumeLayout(false);
            this.panelIssueControls.ResumeLayout(false);
            this.panelIssueFields.ResumeLayout(false);
            this.panelIssueFields.PerformLayout();
            this.panelIssueSearch.ResumeLayout(false);
            this.panelIssueSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabBookManagement;
        private System.Windows.Forms.TabPage TabBorrowManagement;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Button BtnSearchBooks;
        private System.Windows.Forms.TextBox TxtBookSearch;
        private System.Windows.Forms.Label LblBookSearch;
        private System.Windows.Forms.Button BtnClearBookFields;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnEditBook;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.TextBox TxtBookCopies;
        private System.Windows.Forms.Label LblBookCopies;
        private System.Windows.Forms.TextBox TxtBookYear;
        private System.Windows.Forms.Label LblBookYear;
        private System.Windows.Forms.TextBox TxtBookAuthor;
        private System.Windows.Forms.Label LblBookAuthor;
        private System.Windows.Forms.TextBox TxtBookTitle;
        private System.Windows.Forms.Label LblBookTitle;
        private System.Windows.Forms.GroupBox groupBoxBorrowers;
        private System.Windows.Forms.Button BtnClearBorrowerFields;
        private System.Windows.Forms.Button BtnDeleteBorrower;
        private System.Windows.Forms.Button BtnEditBorrower;
        private System.Windows.Forms.Button BtnAddBorrower;
        private System.Windows.Forms.TextBox TxtBorrowerPhone;
        private System.Windows.Forms.Label LblBorrowerPhone;
        private System.Windows.Forms.TextBox TxtBorrowerEmail;
        private System.Windows.Forms.Label LblBorrowerEmail;
        private System.Windows.Forms.TextBox TxtBorrowerName;
        private System.Windows.Forms.Label LblBorrowerName;
        private System.Windows.Forms.Button BtnSearchBorrowers;
        private System.Windows.Forms.TextBox TxtBorrowerSearch;
        private System.Windows.Forms.Label LblBorrowerSearch;
        private System.Windows.Forms.DataGridView DgvBorrowers;
        private System.Windows.Forms.GroupBox groupBoxIssuedBooks;
        private System.Windows.Forms.CheckBox ChkShowReturned;
        private System.Windows.Forms.Button BtnSearchIssuedBooks;
        private System.Windows.Forms.TextBox TxtIssuedBookSearch;
        private System.Windows.Forms.Label LblIssuedBookSearch;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnIssueBook;
        private System.Windows.Forms.DateTimePicker DtpDueDate;
        private System.Windows.Forms.Label LblDueDate;
        private System.Windows.Forms.DateTimePicker DtpIssueDate;
        private System.Windows.Forms.Label LblIssueDate;
        private System.Windows.Forms.ComboBox CmbBorrowers;
        private System.Windows.Forms.Label LblSelectBorrower;
        private System.Windows.Forms.ComboBox CmbBooks;
        private System.Windows.Forms.Label LblSelectBook;
        private System.Windows.Forms.DataGridView DgvIssuedBooks;
        private System.Windows.Forms.Panel panelBookControls;
        private System.Windows.Forms.Panel panelBookFields;
        private System.Windows.Forms.Panel panelBookSearch;
        private System.Windows.Forms.Panel panelBorrowerControls;
        private System.Windows.Forms.Panel panelBorrowerFields;
        private System.Windows.Forms.Panel panelBorrowerSearch;
        private System.Windows.Forms.Panel panelIssueControls;
        private System.Windows.Forms.Panel panelIssueFields;
        private System.Windows.Forms.Panel panelIssueSearch;
    }
}