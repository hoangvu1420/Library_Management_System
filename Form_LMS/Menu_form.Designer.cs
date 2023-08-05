using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class Menu_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_form));
            this.lb1 = new System.Windows.Forms.Label();
            this.bt_book_management = new System.Windows.Forms.Button();
            this.bt_member_management = new System.Windows.Forms.Button();
            this.bt_trans_record = new System.Windows.Forms.Button();
            this.bt_add_trans = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(124, 30);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(502, 78);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Library Manangement System";
            // 
            // bt_book_management
            // 
            this.bt_book_management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_book_management.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_book_management.Font = new System.Drawing.Font("Lora", 12F, System.Drawing.FontStyle.Bold);
            this.bt_book_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_book_management.Location = new System.Drawing.Point(155, 211);
            this.bt_book_management.Name = "bt_book_management";
            this.bt_book_management.Size = new System.Drawing.Size(434, 57);
            this.bt_book_management.TabIndex = 3;
            this.bt_book_management.Text = "Book Management";
            this.bt_book_management.UseVisualStyleBackColor = true;
            this.bt_book_management.Click += new System.EventHandler(this.bt_book_management_Click);
            // 
            // bt_member_management
            // 
            this.bt_member_management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_member_management.Font = new System.Drawing.Font("Lora", 12F, System.Drawing.FontStyle.Bold);
            this.bt_member_management.Location = new System.Drawing.Point(155, 274);
            this.bt_member_management.Name = "bt_member_management";
            this.bt_member_management.Size = new System.Drawing.Size(434, 57);
            this.bt_member_management.TabIndex = 3;
            this.bt_member_management.Text = "Member Management";
            this.bt_member_management.UseVisualStyleBackColor = true;
            this.bt_member_management.Click += new System.EventHandler(this.bt_member_management_Click);
            // 
            // bt_trans_record
            // 
            this.bt_trans_record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_trans_record.Font = new System.Drawing.Font("Lora", 12F, System.Drawing.FontStyle.Bold);
            this.bt_trans_record.Location = new System.Drawing.Point(155, 400);
            this.bt_trans_record.Name = "bt_trans_record";
            this.bt_trans_record.Size = new System.Drawing.Size(434, 57);
            this.bt_trans_record.TabIndex = 3;
            this.bt_trans_record.Text = "Transaction Record";
            this.bt_trans_record.UseVisualStyleBackColor = true;
            this.bt_trans_record.Click += new System.EventHandler(this.bt_trans_record_Click);
            // 
            // bt_add_trans
            // 
            this.bt_add_trans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_trans.Font = new System.Drawing.Font("Lora", 12F, System.Drawing.FontStyle.Bold);
            this.bt_add_trans.Location = new System.Drawing.Point(155, 337);
            this.bt_add_trans.Name = "bt_add_trans";
            this.bt_add_trans.Size = new System.Drawing.Size(434, 57);
            this.bt_add_trans.TabIndex = 3;
            this.bt_add_trans.Text = "Transaction";
            this.bt_add_trans.UseVisualStyleBackColor = true;
            this.bt_add_trans.Click += new System.EventHandler(this.bt_add_trans_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form_LMS.Properties.Resources.LMS1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Form_LMS.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(650, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(732, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_add_trans);
            this.Controls.Add(this.bt_trans_record);
            this.Controls.Add(this.bt_member_management);
            this.Controls.Add(this.bt_book_management);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Menu_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb1;
        private Button bt_book_management;
        private Button bt_member_management;
        private Button bt_trans_record;
        private Button bt_add_trans;
        private PictureBox pictureBox2;
    }
}

