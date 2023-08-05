using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_RecordLoan
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
            this.tB_returnID = new System.Windows.Forms.TextBox();
            this.tB_dueDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_memID = new System.Windows.Forms.TextBox();
            this.tB_loanStatus = new System.Windows.Forms.TextBox();
            this.tB_numLoaned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_loanDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_book_list = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_loanID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dGV_loan_list = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_loan_list)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_returnID
            // 
            this.tB_returnID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_returnID.Location = new System.Drawing.Point(103, 231);
            this.tB_returnID.Name = "tB_returnID";
            this.tB_returnID.Size = new System.Drawing.Size(464, 29);
            this.tB_returnID.TabIndex = 50;
            // 
            // tB_dueDate
            // 
            this.tB_dueDate.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_dueDate.Location = new System.Drawing.Point(380, 93);
            this.tB_dueDate.Name = "tB_dueDate";
            this.tB_dueDate.Size = new System.Drawing.Size(187, 29);
            this.tB_dueDate.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.Location = new System.Drawing.Point(4, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Return ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 10F);
            this.label3.Location = new System.Drawing.Point(287, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Due date:";
            // 
            // tB_memID
            // 
            this.tB_memID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID.Location = new System.Drawing.Point(398, 53);
            this.tB_memID.Name = "tB_memID";
            this.tB_memID.Size = new System.Drawing.Size(169, 29);
            this.tB_memID.TabIndex = 50;
            // 
            // tB_loanStatus
            // 
            this.tB_loanStatus.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_loanStatus.Location = new System.Drawing.Point(118, 183);
            this.tB_loanStatus.Name = "tB_loanStatus";
            this.tB_loanStatus.Size = new System.Drawing.Size(449, 29);
            this.tB_loanStatus.TabIndex = 50;
            // 
            // tB_numLoaned
            // 
            this.tB_numLoaned.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_numLoaned.Location = new System.Drawing.Point(210, 136);
            this.tB_numLoaned.Name = "tB_numLoaned";
            this.tB_numLoaned.Size = new System.Drawing.Size(357, 29);
            this.tB_numLoaned.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.Location = new System.Drawing.Point(4, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Loan status:";
            // 
            // tB_loanDate
            // 
            this.tB_loanDate.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_loanDate.Location = new System.Drawing.Point(104, 93);
            this.tB_loanDate.Name = "tB_loanDate";
            this.tB_loanDate.Size = new System.Drawing.Size(169, 29);
            this.tB_loanDate.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.Location = new System.Drawing.Point(4, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Number of loaned book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 10F);
            this.label1.Location = new System.Drawing.Point(287, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Member ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 10F);
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Loan date:";
            // 
            // dGV_book_list
            // 
            this.dGV_book_list.AllowUserToAddRows = false;
            this.dGV_book_list.AllowUserToDeleteRows = false;
            this.dGV_book_list.AllowUserToResizeRows = false;
            this.dGV_book_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_book_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_book_list.Location = new System.Drawing.Point(23, 37);
            this.dGV_book_list.Name = "dGV_book_list";
            this.dGV_book_list.ReadOnly = true;
            this.dGV_book_list.RowHeadersWidth = 51;
            this.dGV_book_list.RowTemplate.Height = 29;
            this.dGV_book_list.Size = new System.Drawing.Size(590, 243);
            this.dGV_book_list.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGV_book_list);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(657, 561);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 301);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book list";
            // 
            // tB_loanID
            // 
            this.tB_loanID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_loanID.Location = new System.Drawing.Point(89, 53);
            this.tB_loanID.Name = "tB_loanID";
            this.tB_loanID.Size = new System.Drawing.Size(184, 29);
            this.tB_loanID.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.Location = new System.Drawing.Point(4, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Loan ID:";
            // 
            // dGV_loan_list
            // 
            this.dGV_loan_list.AllowUserToAddRows = false;
            this.dGV_loan_list.AllowUserToDeleteRows = false;
            this.dGV_loan_list.AllowUserToResizeRows = false;
            this.dGV_loan_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_loan_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_loan_list.Location = new System.Drawing.Point(20, 28);
            this.dGV_loan_list.Name = "dGV_loan_list";
            this.dGV_loan_list.ReadOnly = true;
            this.dGV_loan_list.RowHeadersWidth = 51;
            this.dGV_loan_list.RowTemplate.Height = 29;
            this.dGV_loan_list.Size = new System.Drawing.Size(1209, 389);
            this.dGV_loan_list.TabIndex = 0;
            this.dGV_loan_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_loan_list_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_returnID);
            this.groupBox3.Controls.Add(this.tB_dueDate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tB_memID);
            this.groupBox3.Controls.Add(this.tB_loanStatus);
            this.groupBox3.Controls.Add(this.tB_numLoaned);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tB_loanDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tB_loanID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(41, 561);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 301);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loan detail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_loan_list);
            this.groupBox2.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(41, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1251, 437);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan record";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(550, 25);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(230, 78);
            this.lb1.TabIndex = 56;
            this.lb1.Text = "Loan Record";
            // 
            // uc_RecordLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb1);
            this.Name = "uc_RecordLoan";
            this.Size = new System.Drawing.Size(1327, 884);
            this.Load += new System.EventHandler(this.uc_RecordLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_loan_list)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tB_returnID;
        private TextBox tB_dueDate;
        private Label label8;
        private Label label3;
        private TextBox tB_memID;
        private TextBox tB_loanStatus;
        private TextBox tB_numLoaned;
        private Label label5;
        private TextBox tB_loanDate;
        private Label label4;
        private Label label6;
        private Label label1;
        private Label label2;
        private DataGridView dGV_book_list;
        private GroupBox groupBox1;
        private TextBox tB_loanID;
        private Label label7;
        private DataGridView dGV_loan_list;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label lb1;
    }
}
