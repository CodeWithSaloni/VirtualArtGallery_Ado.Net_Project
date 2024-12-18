using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class MainForm : Form
    {
        private Button btnRegister;
        private Button btnLogin;
        public MainForm()
        {
            InitializeComponent();
            {
                
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
