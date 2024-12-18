using System;
using System.Windows.Forms;

namespace ArtGallery
{
    partial class MainForm
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
            this.SuspendLayout();
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            
                this.btnRegister = new Button();
                this.btnLogin = new Button();
                

                // btnRegister
                this.btnRegister.Location = new System.Drawing.Point(100, 50);
                this.btnRegister.Name = "btnRegister";
                this.btnRegister.Size = new System.Drawing.Size(75, 23);
                this.btnRegister.Text = "Register";
                this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

                // btnLogin
                this.btnLogin.Location = new System.Drawing.Point(100, 100);
                this.btnLogin.Name = "btnLogin";
                this.btnLogin.Size = new System.Drawing.Size(75, 23);
                this.btnLogin.Text = "Login";
                this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

                // MainForm
                this.ClientSize = new System.Drawing.Size(284, 161);
                this.Controls.Add(this.btnRegister);
                this.Controls.Add(this.btnLogin);
               
                
        }
        

        #endregion
    }
}

