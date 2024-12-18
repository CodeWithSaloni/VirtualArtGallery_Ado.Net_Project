using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class LoginForm : Form
    {
      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the user exists and the password matches
            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Redirect to another form or dashboard
                this.Hide(); // Optionally hide the login form after success
                             // Show another form, for example:
                             // new DashboardForm().Show();

                // Show the CRUDForm
                CRUDForm crudForm = new CRUDForm();
                crudForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        // Validate the user credentials against the database
        private bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-00PFQG9S\\SQLEXPRESS;Initial Catalog=ArtGallery;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }

        }

    }
}
