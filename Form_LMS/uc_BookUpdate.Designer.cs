using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_BookUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_num_cop = new System.Windows.Forms.TextBox();
            this.tB_pubYear = new System.Windows.Forms.TextBox();
            this.tB_category = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_title1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_book_stock1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_pub_year1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_category1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_author1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bT_save = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.tB_bookID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(311, 28);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(340, 78);
            this.lb1.TabIndex = 14;
            this.lb1.Text = "Update Information";
            // 
            // tB_title
            // 
            this.tB_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_title.Enabled = false;
            this.tB_title.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_title.Location = new System.Drawing.Point(250, 61);
            this.tB_title.Name = "tB_title";
            this.tB_title.ReadOnly = true;
            this.tB_title.Size = new System.Drawing.Size(436, 29);
            this.tB_title.TabIndex = 30;
            // 
            // tB_num_cop
            // 
            this.tB_num_cop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_num_cop.Enabled = false;
            this.tB_num_cop.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_num_cop.Location = new System.Drawing.Point(250, 242);
            this.tB_num_cop.Name = "tB_num_cop";
            this.tB_num_cop.ReadOnly = true;
            this.tB_num_cop.Size = new System.Drawing.Size(436, 29);
            this.tB_num_cop.TabIndex = 34;
            // 
            // tB_pubYear
            // 
            this.tB_pubYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_pubYear.Enabled = false;
            this.tB_pubYear.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_pubYear.Location = new System.Drawing.Point(250, 194);
            this.tB_pubYear.Name = "tB_pubYear";
            this.tB_pubYear.ReadOnly = true;
            this.tB_pubYear.Size = new System.Drawing.Size(436, 29);
            this.tB_pubYear.TabIndex = 33;
            // 
            // tB_category
            // 
            this.tB_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_category.Enabled = false;
            this.tB_category.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_category.Location = new System.Drawing.Point(250, 151);
            this.tB_category.Name = "tB_category";
            this.tB_category.ReadOnly = true;
            this.tB_category.Size = new System.Drawing.Size(436, 29);
            this.tB_category.TabIndex = 32;
            // 
            // tB_author
            // 
            this.tB_author.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_author.Enabled = false;
            this.tB_author.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_author.Location = new System.Drawing.Point(250, 105);
            this.tB_author.Name = "tB_author";
            this.tB_author.ReadOnly = true;
            this.tB_author.Size = new System.Drawing.Size(436, 29);
            this.tB_author.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 12F);
            this.label4.Location = new System.Drawing.Point(127, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Author(s):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 12F);
            this.label5.Location = new System.Drawing.Point(57, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "Number in stock:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 12F);
            this.label3.Location = new System.Drawing.Point(170, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 12F);
            this.label2.Location = new System.Drawing.Point(60, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Publication Year:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 12F);
            this.label1.Location = new System.Drawing.Point(107, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Category(s):";
            // 
            // gB
            // 
            this.gB.Controls.Add(this.tB_title);
            this.gB.Controls.Add(this.label1);
            this.gB.Controls.Add(this.tB_num_cop);
            this.gB.Controls.Add(this.label2);
            this.gB.Controls.Add(this.tB_pubYear);
            this.gB.Controls.Add(this.label3);
            this.gB.Controls.Add(this.tB_category);
            this.gB.Controls.Add(this.label5);
            this.gB.Controls.Add(this.tB_author);
            this.gB.Controls.Add(this.label4);
            this.gB.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.gB.Location = new System.Drawing.Point(92, 170);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(761, 307);
            this.gB.TabIndex = 35;
            this.gB.TabStop = false;
            this.gB.Text = "Former properties";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_title1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tB_book_stock1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tB_pub_year1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tB_category1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tB_author1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(92, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 307);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update properties";
            // 
            // tB_title1
            // 
            this.tB_title1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_title1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_title1.Location = new System.Drawing.Point(250, 61);
            this.tB_title1.Name = "tB_title1";
            this.tB_title1.Size = new System.Drawing.Size(436, 29);
            this.tB_title1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 12F);
            this.label6.Location = new System.Drawing.Point(107, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "Category(s):";
            // 
            // tB_book_stock1
            // 
            this.tB_book_stock1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_book_stock1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_book_stock1.Location = new System.Drawing.Point(250, 242);
            this.tB_book_stock1.Name = "tB_book_stock1";
            this.tB_book_stock1.Size = new System.Drawing.Size(436, 29);
            this.tB_book_stock1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 12F);
            this.label7.Location = new System.Drawing.Point(60, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Publication Year:";
            // 
            // tB_pub_year1
            // 
            this.tB_pub_year1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_pub_year1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_pub_year1.Location = new System.Drawing.Point(250, 194);
            this.tB_pub_year1.Name = "tB_pub_year1";
            this.tB_pub_year1.Size = new System.Drawing.Size(436, 29);
            this.tB_pub_year1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 12F);
            this.label8.Location = new System.Drawing.Point(170, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 30);
            this.label8.TabIndex = 27;
            this.label8.Text = "Title:";
            // 
            // tB_category1
            // 
            this.tB_category1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_category1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_category1.Location = new System.Drawing.Point(250, 151);
            this.tB_category1.Name = "tB_category1";
            this.tB_category1.Size = new System.Drawing.Size(436, 29);
            this.tB_category1.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lora", 12F);
            this.label9.Location = new System.Drawing.Point(57, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Number in stock:";
            // 
            // tB_author1
            // 
            this.tB_author1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_author1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_author1.Location = new System.Drawing.Point(250, 105);
            this.tB_author1.Name = "tB_author1";
            this.tB_author1.Size = new System.Drawing.Size(436, 29);
            this.tB_author1.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lora", 12F);
            this.label10.Location = new System.Drawing.Point(127, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Author(s):";
            // 
            // bT_save
            // 
            this.bT_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bT_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bT_save.Font = new System.Drawing.Font("Yeseva One", 14F);
            this.bT_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bT_save.Location = new System.Drawing.Point(391, 852);
            this.bT_save.Name = "bT_save";
            this.bT_save.Size = new System.Drawing.Size(158, 47);
            this.bT_save.TabIndex = 36;
            this.bT_save.Text = "SAVE";
            this.bT_save.UseVisualStyleBackColor = false;
            this.bT_save.Click += new System.EventHandler(this.bT_save_Click);
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Lora", 10F);
            this.bt_search.Location = new System.Drawing.Point(263, 133);
            this.bt_search.Margin = new System.Windows.Forms.Padding(0);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(33, 33);
            this.bt_search.TabIndex = 39;
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tB_bookID
            // 
            this.tB_bookID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_bookID.Location = new System.Drawing.Point(92, 135);
            this.tB_bookID.Name = "tB_bookID";
            this.tB_bookID.Size = new System.Drawing.Size(168, 29);
            this.tB_bookID.TabIndex = 38;
            this.tB_bookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_bookID_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lora", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(92, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "Enter book ID";
            // 
            // uc_UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tB_bookID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bT_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.lb1);
            this.Name = "uc_UpdateBook";
            this.Size = new System.Drawing.Size(943, 947);
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private TextBox tB_title;
        private TextBox tB_num_cop;
        private TextBox tB_pubYear;
        private TextBox tB_category;
        private TextBox tB_author;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gB;
        private GroupBox groupBox1;
        private TextBox tB_title1;
        private Label label6;
        private TextBox tB_book_stock1;
        private Label label7;
        private TextBox tB_pub_year1;
        private Label label8;
        private TextBox tB_category1;
        private TextBox tB_author1;
        private Label label10;
        private Button bT_save;
        private Label label9;
        private Button bt_search;
        private TextBox tB_bookID;
        private Label label11;
    }
}
