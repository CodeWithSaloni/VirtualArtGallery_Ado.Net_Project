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
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Register the user
            if (RegisterUser(username, password))
            {
                MessageBox.Show("Registration successful!");
                this.Close(); // Optionally close the registration form after success
                // You can open the LoginForm after registration if needed
                // new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        // Register the user in the database
        private bool RegisterUser(string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-00PFQG9S\\SQLEXPRESS;Initial Catalog=ArtGallery;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
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
