using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class Book_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_management));
            this.lb1 = new System.Windows.Forms.Label();
            this.bt_book_list = new System.Windows.Forms.Button();
            this.bt_insert_book = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_query = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uc_bookList1 = new Form_LMS.uc_BookList();
            this.uc_BookQuery1 = new Form_LMS.uc_BookQuery();
            this.uc_UpdateBook1 = new Form_LMS.uc_BookUpdate();
            this.uc_insertBook1 = new Form_LMS.uc_BookInsert();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(797, 39);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(324, 78);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Book Management";
            // 
            // bt_book_list
            // 
            this.bt_book_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_book_list.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_book_list.Location = new System.Drawing.Point(10, 196);
            this.bt_book_list.Name = "bt_book_list";
            this.bt_book_list.Size = new System.Drawing.Size(196, 57);
            this.bt_book_list.TabIndex = 1;
            this.bt_book_list.Text = "Book List";
            this.bt_book_list.UseVisualStyleBackColor = true;
            this.bt_book_list.Click += new System.EventHandler(this.bt_book_list_Click);
            // 
            // bt_insert_book
            // 
            this.bt_insert_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_insert_book.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_insert_book.Location = new System.Drawing.Point(10, 133);
            this.bt_insert_book.Name = "bt_insert_book";
            this.bt_insert_book.Size = new System.Drawing.Size(196, 57);
            this.bt_insert_book.TabIndex = 0;
            this.bt_insert_book.Text = "Insert New Book";
            this.bt_insert_book.UseVisualStyleBackColor = true;
            this.bt_insert_book.Click += new System.EventHandler(this.bt_insert_book_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_query);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bt_insert_book);
            this.panel1.Controls.Add(this.bt_book_list);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 956);
            this.panel1.TabIndex = 0;
            // 
            // bt_update
            // 
            this.bt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_update.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_update.Location = new System.Drawing.Point(10, 259);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(196, 57);
            this.bt_update.TabIndex = 2;
            this.bt_update.Text = "Update Information";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_query
            // 
            this.bt_query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_query.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_query.Location = new System.Drawing.Point(10, 322);
            this.bt_query.Name = "bt_query";
            this.bt_query.Size = new System.Drawing.Size(196, 57);
            this.bt_query.TabIndex = 3;
            this.bt_query.Text = "Query";
            this.bt_query.UseVisualStyleBackColor = true;
            this.bt_query.Click += new System.EventHandler(this.bt_query_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form_LMS.Properties.Resources.LMS1;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // uc_bookList1
            // 
            this.uc_bookList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_bookList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_bookList1.Location = new System.Drawing.Point(225, 0);
            this.uc_bookList1.Name = "uc_bookList1";
            this.uc_bookList1.Size = new System.Drawing.Size(1478, 956);
            this.uc_bookList1.TabIndex = 9;
            // 
            // uc_BookQuery1
            // 
            this.uc_BookQuery1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_BookQuery1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_BookQuery1.Location = new System.Drawing.Point(225, 0);
            this.uc_BookQuery1.Name = "uc_BookQuery1";
            this.uc_BookQuery1.Size = new System.Drawing.Size(1152, 702);
            this.uc_BookQuery1.TabIndex = 11;
            // 
            // uc_UpdateBook1
            // 
            this.uc_UpdateBook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_UpdateBook1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_UpdateBook1.Location = new System.Drawing.Point(225, 0);
            this.uc_UpdateBook1.Name = "uc_UpdateBook1";
            this.uc_UpdateBook1.Size = new System.Drawing.Size(943, 956);
            this.uc_UpdateBook1.TabIndex = 10;
            // 
            // uc_insertBook1
            // 
            this.uc_insertBook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_insertBook1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_insertBook1.Location = new System.Drawing.Point(225, 0);
            this.uc_insertBook1.Name = "uc_insertBook1";
            this.uc_insertBook1.Size = new System.Drawing.Size(835, 514);
            this.uc_insertBook1.TabIndex = 8;
            // 
            // Book_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1700, 956);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_insertBook1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.uc_bookList1);
            this.Controls.Add(this.uc_BookQuery1);
            this.Controls.Add(this.uc_UpdateBook1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Book_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_management";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Book_management_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private Button bt_book_list;
        private Button bt_insert_book;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button bt_query;
        private Button bt_update;
        private uc_BookInsert uc_insertBook1;
        private uc_BookList uc_bookList1;
        private uc_BookUpdate uc_UpdateBook1;
        private uc_BookQuery uc_BookQuery1;
    }
}