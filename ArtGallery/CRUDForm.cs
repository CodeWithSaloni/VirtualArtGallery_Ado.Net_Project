using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class CRUDForm : Form
    {
        
        public CRUDForm()
        {
            InitializeComponent();
            LoadData();
        }

        // Method to load data into DataGridView
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-00PFQG9S\\SQLEXPRESS;Initial Catalog=ArtGallery;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ArtPieces", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt; // Set data source
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Add Button Click Handler
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string artist = txtArtist.Text;
            int year;
            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }
            string description = txtDescription.Text;

            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-00PFQG9S\\SQLEXPRESS;Initial Catalog=ArtGallery;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ArtPieces (Title, Artist, Year, Description) VALUES (@Title, @Artist, @Year, @Description)", conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Artist", artist);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Art added successfully!");

                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // View Button Click Handler
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData(); // Reload data from the database
        }

        // Update Button Click Handler
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int artID;
            if (!int.TryParse(txtArtID.Text, out artID))
            {
                MessageBox.Show("Please enter a valid Art ID.");
                return;
            }

            string title = txtTitle.Text;
            string artist = txtArtist.Text;
            int year;
            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }
            string description = txtDescription.Text;

            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-00PFQG9S\\SQLEXPRESS;Initial Catalog=ArtGallery;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ArtPieces SET Title=@Title, Artist=@Artist, Year=@Year, Description=@Description WHERE ArtID=@ArtID", conn);
                    cmd.Parameters.AddWithValue("@ArtID", artID);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Artist", artist);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Art updated successfully!");

                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Delete Button Click Handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int artID;
            if (!int.TryParse(txtArtID.Text, out artID))
            {
                MessageBox.Show("Please enter a valid Art ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-00PFQG9S\\SQLEXPRESS;Initial Catalog=ArtGallery;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ArtPieces WHERE ArtID=@ArtID", conn);
                    cmd.Parameters.AddWithValue("@ArtID", artID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Art deleted successfully!");

                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CRUDForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artGalleryDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.artGalleryDataSet.Users);
            // TODO: This line of code loads data into the 'artGalleryDataSet.ArtPieces' table. You can move, or remove it, as needed.
            this.artPiecesTableAdapter.Fill(this.artGalleryDataSet.ArtPieces);

        }
    }  
}


