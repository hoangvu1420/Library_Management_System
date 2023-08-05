using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_BookList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_book = new System.Windows.Forms.DataGridView();
            this.gB_list = new System.Windows.Forms.GroupBox();
            this.gB_detail = new System.Windows.Forms.GroupBox();
            this.tB_created_time = new System.Windows.Forms.TextBox();
            this.tB_num_cop = new System.Windows.Forms.TextBox();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_updated_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_pub_year = new System.Windows.Forms.TextBox();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.tB_searchTitle = new System.Windows.Forms.TextBox();
            this.tB_searchCategory = new System.Windows.Forms.TextBox();
            this.tB_searchAuthor = new System.Windows.Forms.TextBox();
            this.tB_searchStockNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tB_searchPubYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_searchBookID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book)).BeginInit();
            this.gB_list.SuspendLayout();
            this.gB_detail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(643, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 78);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book List";
            // 
            // dGV_book
            // 
            this.dGV_book.AllowUserToAddRows = false;
            this.dGV_book.AllowUserToDeleteRows = false;
            this.dGV_book.AllowUserToResizeRows = false;
            this.dGV_book.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dGV_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_book.Location = new System.Drawing.Point(6, 26);
            this.dGV_book.Name = "dGV_book";
            this.dGV_book.RowHeadersWidth = 51;
            this.dGV_book.RowTemplate.Height = 29;
            this.dGV_book.Size = new System.Drawing.Size(1428, 508);
            this.dGV_book.TabIndex = 13;
            this.dGV_book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_book_CellContentClick);
            this.dGV_book.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV_book_CellPainting);
            // 
            // gB_list
            // 
            this.gB_list.Controls.Add(this.dGV_book);
            this.gB_list.Font = new System.Drawing.Font("Lora", 10F);
            this.gB_list.ForeColor = System.Drawing.Color.Black;
            this.gB_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gB_list.Location = new System.Drawing.Point(14, 178);
            this.gB_list.Name = "gB_list";
            this.gB_list.Size = new System.Drawing.Size(1440, 540);
            this.gB_list.TabIndex = 14;
            this.gB_list.TabStop = false;
            this.gB_list.Text = "List";
            // 
            // gB_detail
            // 
            this.gB_detail.Controls.Add(this.tB_created_time);
            this.gB_detail.Controls.Add(this.tB_num_cop);
            this.gB_detail.Controls.Add(this.tB_ID);
            this.gB_detail.Controls.Add(this.tB_author);
            this.gB_detail.Controls.Add(this.label8);
            this.gB_detail.Controls.Add(this.label14);
            this.gB_detail.Controls.Add(this.label9);
            this.gB_detail.Controls.Add(this.label7);
            this.gB_detail.Controls.Add(this.label4);
            this.gB_detail.Controls.Add(this.tB_updated_time);
            this.gB_detail.Controls.Add(this.label6);
            this.gB_detail.Controls.Add(this.tB_category);
            this.gB_detail.Controls.Add(this.label5);
            this.gB_detail.Controls.Add(this.tB_pub_year);
            this.gB_detail.Controls.Add(this.tB_title);
            this.gB_detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gB_detail.Font = new System.Drawing.Font("Lora", 10F);
            this.gB_detail.ForeColor = System.Drawing.Color.Black;
            this.gB_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gB_detail.Location = new System.Drawing.Point(0, 742);
            this.gB_detail.Name = "gB_detail";
            this.gB_detail.Size = new System.Drawing.Size(1467, 228);
            this.gB_detail.TabIndex = 15;
            this.gB_detail.TabStop = false;
            this.gB_detail.Text = "Detail information";
            // 
            // tB_created_time
            // 
            this.tB_created_time.Location = new System.Drawing.Point(547, 184);
            this.tB_created_time.Name = "tB_created_time";
            this.tB_created_time.Size = new System.Drawing.Size(315, 29);
            this.tB_created_time.TabIndex = 12;
            // 
            // tB_num_cop
            // 
            this.tB_num_cop.Location = new System.Drawing.Point(200, 184);
            this.tB_num_cop.Name = "tB_num_cop";
            this.tB_num_cop.Size = new System.Drawing.Size(315, 29);
            this.tB_num_cop.TabIndex = 12;
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(201, 55);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(315, 29);
            this.tB_ID.TabIndex = 12;
            // 
            // tB_author
            // 
            this.tB_author.Location = new System.Drawing.Point(199, 119);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(315, 29);
            this.tB_author.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(201, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Number in stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lora", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(202, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(547, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Created time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(200, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author(s):";
            // 
            // tB_updated_time
            // 
            this.tB_updated_time.Location = new System.Drawing.Point(897, 184);
            this.tB_updated_time.Name = "tB_updated_time";
            this.tB_updated_time.Size = new System.Drawing.Size(314, 29);
            this.tB_updated_time.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(896, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lastest update time:";
            // 
            // tB_category
            // 
            this.tB_category.Location = new System.Drawing.Point(547, 119);
            this.tB_category.Name = "tB_category";
            this.tB_category.Size = new System.Drawing.Size(315, 29);
            this.tB_category.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(548, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Category(s):";
            // 
            // tB_pub_year
            // 
            this.tB_pub_year.Location = new System.Drawing.Point(896, 119);
            this.tB_pub_year.Name = "tB_pub_year";
            this.tB_pub_year.Size = new System.Drawing.Size(315, 29);
            this.tB_pub_year.TabIndex = 12;
            // 
            // tB_title
            // 
            this.tB_title.Location = new System.Drawing.Point(547, 55);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(664, 29);
            this.tB_title.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(555, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Publication Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(157, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_go);
            this.groupBox1.Controls.Add(this.tB_searchTitle);
            this.groupBox1.Controls.Add(this.tB_searchCategory);
            this.groupBox1.Controls.Add(this.tB_searchAuthor);
            this.groupBox1.Controls.Add(this.tB_searchStockNum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tB_searchPubYear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tB_searchBookID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1440, 94);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // bt_go
            // 
            this.bt_go.Location = new System.Drawing.Point(9, 50);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(45, 32);
            this.bt_go.TabIndex = 14;
            this.bt_go.Text = "Go";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // tB_searchTitle
            // 
            this.tB_searchTitle.Location = new System.Drawing.Point(161, 52);
            this.tB_searchTitle.Name = "tB_searchTitle";
            this.tB_searchTitle.Size = new System.Drawing.Size(395, 29);
            this.tB_searchTitle.TabIndex = 13;
            // 
            // tB_searchCategory
            // 
            this.tB_searchCategory.Location = new System.Drawing.Point(985, 52);
            this.tB_searchCategory.Name = "tB_searchCategory";
            this.tB_searchCategory.Size = new System.Drawing.Size(304, 29);
            this.tB_searchCategory.TabIndex = 13;
            // 
            // tB_searchAuthor
            // 
            this.tB_searchAuthor.Location = new System.Drawing.Point(684, 52);
            this.tB_searchAuthor.Name = "tB_searchAuthor";
            this.tB_searchAuthor.Size = new System.Drawing.Size(298, 29);
            this.tB_searchAuthor.TabIndex = 13;
            // 
            // tB_searchStockNum
            // 
            this.tB_searchStockNum.Location = new System.Drawing.Point(1292, 52);
            this.tB_searchStockNum.Name = "tB_searchStockNum";
            this.tB_searchStockNum.Size = new System.Drawing.Size(120, 29);
            this.tB_searchStockNum.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lora", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(1288, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Number in stock:";
            // 
            // tB_searchPubYear
            // 
            this.tB_searchPubYear.Location = new System.Drawing.Point(560, 52);
            this.tB_searchPubYear.Name = "tB_searchPubYear";
            this.tB_searchPubYear.Size = new System.Drawing.Size(120, 29);
            this.tB_searchPubYear.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lora", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(54, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Book ID:";
            // 
            // tB_searchBookID
            // 
            this.tB_searchBookID.Location = new System.Drawing.Point(58, 52);
            this.tB_searchBookID.Name = "tB_searchBookID";
            this.tB_searchBookID.Size = new System.Drawing.Size(99, 29);
            this.tB_searchBookID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lora", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(680, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Author(s):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lora", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(981, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Category(s):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lora", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(548, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 11;
            this.label14.Text = "Title:";
            // 
            // uc_BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gB_list);
            this.Controls.Add(this.gB_detail);
            this.Name = "uc_BookList";
            this.Size = new System.Drawing.Size(1467, 970);
            this.Load += new System.EventHandler(this.uc_bookList_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_bookList_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book)).EndInit();
            this.gB_list.ResumeLayout(false);
            this.gB_detail.ResumeLayout(false);
            this.gB_detail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dGV_book;
        private GroupBox gB_list;
        private GroupBox gB_detail;
        private TextBox tB_title;
        private Label label3;
        private TextBox tB_author;
        private TextBox tB_pub_year;
        private Label label2;
        private TextBox tB_created_time;
        private Label label7;
        private TextBox tB_updated_time;
        private Label label6;
        private TextBox tB_category;
        private Label label5;
        private TextBox tB_num_cop;
        private Label label8;
        private TextBox tB_ID;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox tB_searchBookID;
        private Label label4;
        private Button bt_go;
        private TextBox tB_searchTitle;
        private TextBox tB_searchCategory;
        private TextBox tB_searchAuthor;
        private TextBox tB_searchStockNum;
        private Label label13;
        private TextBox tB_searchPubYear;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
    }
}
