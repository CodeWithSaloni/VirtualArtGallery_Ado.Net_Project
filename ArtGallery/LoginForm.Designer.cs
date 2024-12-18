using System;
using System.Windows.Forms;

namespace ArtGallery
{
    partial class LoginForm
    {
        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "LoginForm";


            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 30); // Position of the Username label
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 80); // Position of the Password label
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(120, 30); // Position of the Username text box
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 2;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(120, 80); // Position of the Password text box
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true; // Hide password text

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(120, 130); // Position of the Login button
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(245, 130); // Position of the Register button
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            

            // LoginForm
            this.ClientSize = new System.Drawing.Size(384, 211); // Size of the form
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Name = "LoginForm";
            

        }

        #endregion
    }
}