using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_TransLoan
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
            this.tB_memID1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_membership1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_max_book = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_max_day = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_memName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.dGV_book_list = new System.Windows.Forms.DataGridView();
            this.tB_bookID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dTP_loanDate = new System.Windows.Forms.DateTimePicker();
            this.bt_Finish = new System.Windows.Forms.Button();
            this.tB_memName2 = new System.Windows.Forms.TextBox();
            this.tB_memID2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_dueDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tB_numBook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book_list)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(510, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 78);
            this.label1.TabIndex = 14;
            this.label1.Text = "Loan";
            // 
            // tB_memID1
            // 
            this.tB_memID1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memID1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID1.Location = new System.Drawing.Point(249, 43);
            this.tB_memID1.Name = "tB_memID1";
            this.tB_memID1.Size = new System.Drawing.Size(217, 29);
            this.tB_memID1.TabIndex = 50;
            this.tB_memID1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_memID1_KeyDown);
            this.tB_memID1.Leave += new System.EventHandler(this.tB_memID1_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 10F);
            this.label3.Location = new System.Drawing.Point(138, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Member ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 10F);
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Membership:";
            // 
            // tB_membership1
            // 
            this.tB_membership1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_membership1.Enabled = false;
            this.tB_membership1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_membership1.Location = new System.Drawing.Point(249, 122);
            this.tB_membership1.Name = "tB_membership1";
            this.tB_membership1.Size = new System.Drawing.Size(217, 29);
            this.tB_membership1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Maximum number of books:";
            // 
            // tB_max_book
            // 
            this.tB_max_book.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_max_book.Enabled = false;
            this.tB_max_book.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_max_book.Location = new System.Drawing.Point(249, 161);
            this.tB_max_book.Name = "tB_max_book";
            this.tB_max_book.Size = new System.Drawing.Size(217, 29);
            this.tB_max_book.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.Location = new System.Drawing.Point(23, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Maximum number of days:";
            // 
            // tB_max_day
            // 
            this.tB_max_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_max_day.Enabled = false;
            this.tB_max_day.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_max_day.Location = new System.Drawing.Point(249, 200);
            this.tB_max_day.Name = "tB_max_day";
            this.tB_max_day.Size = new System.Drawing.Size(217, 29);
            this.tB_max_day.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_memName1);
            this.groupBox1.Controls.Add(this.tB_memID1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tB_max_day);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tB_max_book);
            this.groupBox1.Controls.Add(this.tB_membership1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(16, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 270);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // tB_memName1
            // 
            this.tB_memName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memName1.Enabled = false;
            this.tB_memName1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memName1.Location = new System.Drawing.Point(249, 82);
            this.tB_memName1.Name = "tB_memName1";
            this.tB_memName1.Size = new System.Drawing.Size(217, 29);
            this.tB_memName1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 10F);
            this.label6.Location = new System.Drawing.Point(114, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Member name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Delete);
            this.groupBox2.Controls.Add(this.bt_Add);
            this.groupBox2.Controls.Add(this.dGV_book_list);
            this.groupBox2.Controls.Add(this.tB_bookID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(540, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 353);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan book list";
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Crimson;
            this.bt_Delete.ForeColor = System.Drawing.Color.SeaShell;
            this.bt_Delete.Location = new System.Drawing.Point(467, 297);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(98, 35);
            this.bt_Delete.TabIndex = 51;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Add.Location = new System.Drawing.Point(287, 298);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(82, 35);
            this.bt_Add.TabIndex = 51;
            this.bt_Add.Text = "Add";
            this.bt_Add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // dGV_book_list
            // 
            this.dGV_book_list.AllowUserToAddRows = false;
            this.dGV_book_list.AllowUserToDeleteRows = false;
            this.dGV_book_list.AllowUserToResizeRows = false;
            this.dGV_book_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_book_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_book_list.Location = new System.Drawing.Point(14, 28);
            this.dGV_book_list.Name = "dGV_book_list";
            this.dGV_book_list.ReadOnly = true;
            this.dGV_book_list.RowHeadersWidth = 51;
            this.dGV_book_list.RowTemplate.Height = 29;
            this.dGV_book_list.Size = new System.Drawing.Size(551, 252);
            this.dGV_book_list.TabIndex = 0;
            this.dGV_book_list.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dGV_book_list_RowPrePaint);
            this.dGV_book_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGV_book_list_KeyDown);
            // 
            // tB_bookID
            // 
            this.tB_bookID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_bookID.Location = new System.Drawing.Point(90, 301);
            this.tB_bookID.Name = "tB_bookID";
            this.tB_bookID.Size = new System.Drawing.Size(193, 29);
            this.tB_bookID.TabIndex = 50;
            this.tB_bookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_bookID_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.Location = new System.Drawing.Point(5, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Book ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dTP_loanDate);
            this.groupBox3.Controls.Add(this.bt_Finish);
            this.groupBox3.Controls.Add(this.tB_memName2);
            this.groupBox3.Controls.Add(this.tB_memID2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tB_dueDate);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tB_numBook);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1130, 196);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loan detail";
            // 
            // dTP_loanDate
            // 
            this.dTP_loanDate.Font = new System.Drawing.Font("Play", 10F);
            this.dTP_loanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_loanDate.Location = new System.Drawing.Point(166, 89);
            this.dTP_loanDate.Name = "dTP_loanDate";
            this.dTP_loanDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dTP_loanDate.Size = new System.Drawing.Size(217, 27);
            this.dTP_loanDate.TabIndex = 53;
            this.dTP_loanDate.ValueChanged += new System.EventHandler(this.dTP_loanDate_ValueChanged);
            // 
            // bt_Finish
            // 
            this.bt_Finish.BackColor = System.Drawing.Color.DarkGray;
            this.bt_Finish.Font = new System.Drawing.Font("Lora", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Finish.Location = new System.Drawing.Point(864, 75);
            this.bt_Finish.Name = "bt_Finish";
            this.bt_Finish.Size = new System.Drawing.Size(178, 58);
            this.bt_Finish.TabIndex = 51;
            this.bt_Finish.Text = "Finish";
            this.bt_Finish.UseVisualStyleBackColor = false;
            this.bt_Finish.Click += new System.EventHandler(this.bt_Finish_Click);
            // 
            // tB_memName2
            // 
            this.tB_memName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memName2.Enabled = false;
            this.tB_memName2.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memName2.Location = new System.Drawing.Point(556, 46);
            this.tB_memName2.Name = "tB_memName2";
            this.tB_memName2.Size = new System.Drawing.Size(217, 29);
            this.tB_memName2.TabIndex = 50;
            // 
            // tB_memID2
            // 
            this.tB_memID2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memID2.Enabled = false;
            this.tB_memID2.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID2.Location = new System.Drawing.Point(166, 46);
            this.tB_memID2.Name = "tB_memID2";
            this.tB_memID2.Size = new System.Drawing.Size(217, 29);
            this.tB_memID2.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.Location = new System.Drawing.Point(421, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Member name:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lora", 10F);
            this.label9.Location = new System.Drawing.Point(55, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Member ID:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lora", 10F);
            this.label10.Location = new System.Drawing.Point(9, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "Number of books:";
            // 
            // tB_dueDate
            // 
            this.tB_dueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_dueDate.Enabled = false;
            this.tB_dueDate.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_dueDate.Location = new System.Drawing.Point(556, 90);
            this.tB_dueDate.Name = "tB_dueDate";
            this.tB_dueDate.Size = new System.Drawing.Size(217, 29);
            this.tB_dueDate.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lora", 10F);
            this.label13.Location = new System.Drawing.Point(66, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Loan date:";
            // 
            // tB_numBook
            // 
            this.tB_numBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_numBook.Enabled = false;
            this.tB_numBook.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_numBook.Location = new System.Drawing.Point(166, 136);
            this.tB_numBook.Name = "tB_numBook";
            this.tB_numBook.Size = new System.Drawing.Size(217, 29);
            this.tB_numBook.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lora", 10F);
            this.label12.Location = new System.Drawing.Point(463, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Due date:";
            // 
            // uc_TransLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "uc_TransLoan";
            this.Size = new System.Drawing.Size(1130, 696);
            this.Load += new System.EventHandler(this.uc_TransLoan_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_TransLoan_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book_list)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tB_memID1;
        private Label label3;
        private Label label2;
        private TextBox tB_membership1;
        private Label label4;
        private TextBox tB_max_book;
        private Label label5;
        private TextBox tB_max_day;
        private GroupBox groupBox1;
        private TextBox tB_memName1;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dGV_book_list;
        private Button bt_Add;
        private TextBox tB_bookID;
        private Label label7;
        private Button bt_Delete;
        private GroupBox groupBox3;
        private TextBox tB_memName2;
        private TextBox tB_memID2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tB_dueDate;
        private TextBox tB_numBook;
        private Label label12;
        private Label label13;
        private Button bt_Finish;
        private DateTimePicker dTP_loanDate;
    }
}
