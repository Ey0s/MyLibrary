using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Libraryproject
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            ApplyModernStyling();
        }

        private void ApplyModernStyling()
        {
            // Panel styling
            panelLogin.BackColor = Color.FromArgb(251, 251, 253);
            panelLogin.BorderStyle = BorderStyle.None;

            // Button styling
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 12, 168);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 2, 148);
            btnLogin.Cursor = Cursors.Hand;

            // Textbox styling
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;

            // Label styling
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(37, 117, 252);

            // Set rounded corners
            SetRoundedCorners();
        }

        private void SetRoundedCorners()
        {
            int panelRadius = 15;
            panelLogin.Region = CreateRoundedRegion(panelLogin.ClientRectangle, panelRadius);

            int buttonRadius = 8;
            btnLogin.Region = CreateRoundedRegion(btnLogin.ClientRectangle, buttonRadius);
        }

        private Region CreateRoundedRegion(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            return new Region(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            CenterPanel();
            this.Invalidate();
        }

        private void CenterPanel()
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Modern gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(240, 242, 245),  // Light gray-blue
                Color.FromArgb(255, 255, 255),  // White
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Please enter both username and password.");
                return;
            }

            if (AuthenticateUser(username, password))
            {
                lblErrorMessage.Visible = false;
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FormMain mainForm = new FormMain();
                mainForm.Show();
            }
            else
            {
                ShowErrorMessage("Invalid username or password.");
            }
        }

        private void ShowErrorMessage(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            lblErrorMessage.ForeColor = Color.FromArgb(220, 53, 69); // Bootstrap danger color
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", password);
                        int count = (int)command.ExecuteScalar();
                        isAuthenticated = count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    ShowErrorMessage($"Database error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"An unexpected error occurred: {ex.Message}");
                }
            }
            return isAuthenticated;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; 
            }
        }
    }
}