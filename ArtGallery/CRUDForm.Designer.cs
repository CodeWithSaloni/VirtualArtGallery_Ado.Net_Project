using System;
using System.Windows.Forms;

namespace ArtGallery
{
    partial class CRUDForm
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtArtID;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtYear;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnView;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView;
        private Label lblArtID;
        private Label lblTitle;
        private Label lblArtist;
        private Label lblYear;
        private Label lblDescription;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>1
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
            this.txtArtID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.artIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artPiecesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artGalleryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artGalleryDataSet = new ArtGallery.ArtGalleryDataSet();
            this.artPiecesTableAdapter = new ArtGallery.ArtGalleryDataSetTableAdapters.ArtPiecesTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ArtGallery.ArtGalleryDataSetTableAdapters.UsersTableAdapter();
            this.lblArtID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artPiecesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artGalleryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artGalleryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArtID
            // 
            this.txtArtID.Location = new System.Drawing.Point(150, 30);
            this.txtArtID.Name = "txtArtID";
            this.txtArtID.Size = new System.Drawing.Size(200, 22);
            this.txtArtID.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(150, 110);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(200, 22);
            this.txtArtist.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(150, 150);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 22);
            this.txtYear.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 190);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(396, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(396, 66);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(80, 30);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(396, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(396, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.artPiecesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(50, 270);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(700, 300);
            this.dataGridView.TabIndex = 9;
            // 
            // artIDDataGridViewTextBoxColumn
            // 
            this.artIDDataGridViewTextBoxColumn.DataPropertyName = "ArtID";
            this.artIDDataGridViewTextBoxColumn.HeaderText = "ArtID";
            this.artIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artIDDataGridViewTextBoxColumn.Name = "artIDDataGridViewTextBoxColumn";
            this.artIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.artIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // artPiecesBindingSource
            // 
            this.artPiecesBindingSource.DataMember = "ArtPieces";
            this.artPiecesBindingSource.DataSource = this.artGalleryDataSetBindingSource;
            // 
            // artGalleryDataSetBindingSource
            // 
            this.artGalleryDataSetBindingSource.DataSource = this.artGalleryDataSet;
            this.artGalleryDataSetBindingSource.Position = 0;
            // 
            // artGalleryDataSet
            // 
            this.artGalleryDataSet.DataSetName = "ArtGalleryDataSet";
            this.artGalleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artPiecesTableAdapter
            // 
            this.artPiecesTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.artGalleryDataSetBindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lblArtID
            // 
            this.lblArtID.Location = new System.Drawing.Point(50, 30);
            this.lblArtID.Name = "lblArtID";
            this.lblArtID.Size = new System.Drawing.Size(80, 20);
            this.lblArtID.TabIndex = 10;
            this.lblArtID.Text = "ArtID:";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(50, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 20);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title:";
            // 
            // lblArtist
            // 
            this.lblArtist.Location = new System.Drawing.Point(50, 110);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(80, 20);
            this.lblArtist.TabIndex = 12;
            this.lblArtist.Text = "Artist:";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(50, 150);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(80, 20);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(50, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 30);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // CRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblArtID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtArtID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView);
            this.Name = "CRUDForm";
            this.Text = "CRUDForm";
            this.Load += new System.EventHandler(this.CRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artPiecesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artGalleryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artGalleryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private BindingSource artGalleryDataSetBindingSource;
        private ArtGalleryDataSet artGalleryDataSet;
        private BindingSource artPiecesBindingSource;
        private ArtGalleryDataSetTableAdapters.ArtPiecesTableAdapter artPiecesTableAdapter;
        private BindingSource usersBindingSource;
        private ArtGalleryDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private DataGridViewTextBoxColumn artIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}