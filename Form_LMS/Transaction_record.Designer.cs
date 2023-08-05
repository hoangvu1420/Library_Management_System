using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class Transaction_record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_Statistics = new System.Windows.Forms.Button();
            this.bt_fine_record = new System.Windows.Forms.Button();
            this.bt_payment_record = new System.Windows.Forms.Button();
            this.bt_member_list = new System.Windows.Forms.Button();
            this.bt_loan_re = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.uc_RecordStatistics1 = new Form_LMS.uc_RecordStatistics();
            this.uc_RecordLoan1 = new Form_LMS.uc_RecordLoan();
            this.uc_RecordFine1 = new Form_LMS.uc_RecordFine();
            this.uc_RecordReturn1 = new Form_LMS.uc_RecordReturn();
            this.uc_RecordPayment1 = new Form_LMS.uc_RecordPayment();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bt_Statistics);
            this.panel1.Controls.Add(this.bt_fine_record);
            this.panel1.Controls.Add(this.bt_payment_record);
            this.panel1.Controls.Add(this.bt_member_list);
            this.panel1.Controls.Add(this.bt_loan_re);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 966);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form_LMS.Properties.Resources.LMS1;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // bt_Statistics
            // 
            this.bt_Statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Statistics.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_Statistics.Location = new System.Drawing.Point(15, 392);
            this.bt_Statistics.Name = "bt_Statistics";
            this.bt_Statistics.Size = new System.Drawing.Size(202, 57);
            this.bt_Statistics.TabIndex = 9;
            this.bt_Statistics.Text = "Statistics";
            this.bt_Statistics.UseVisualStyleBackColor = true;
            this.bt_Statistics.Click += new System.EventHandler(this.bt_Statistics_Click);
            // 
            // bt_fine_record
            // 
            this.bt_fine_record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fine_record.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_fine_record.Location = new System.Drawing.Point(15, 329);
            this.bt_fine_record.Name = "bt_fine_record";
            this.bt_fine_record.Size = new System.Drawing.Size(202, 57);
            this.bt_fine_record.TabIndex = 9;
            this.bt_fine_record.Text = "Fine Record";
            this.bt_fine_record.UseVisualStyleBackColor = true;
            this.bt_fine_record.Click += new System.EventHandler(this.bt_fine_record_Click);
            // 
            // bt_payment_record
            // 
            this.bt_payment_record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_payment_record.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_payment_record.Location = new System.Drawing.Point(15, 266);
            this.bt_payment_record.Name = "bt_payment_record";
            this.bt_payment_record.Size = new System.Drawing.Size(202, 57);
            this.bt_payment_record.TabIndex = 9;
            this.bt_payment_record.Text = "Payment Record";
            this.bt_payment_record.UseVisualStyleBackColor = true;
            this.bt_payment_record.Click += new System.EventHandler(this.bt_payment_record_Click);
            // 
            // bt_member_list
            // 
            this.bt_member_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_member_list.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_member_list.Location = new System.Drawing.Point(15, 203);
            this.bt_member_list.Name = "bt_member_list";
            this.bt_member_list.Size = new System.Drawing.Size(202, 57);
            this.bt_member_list.TabIndex = 9;
            this.bt_member_list.Text = "Return Record";
            this.bt_member_list.UseVisualStyleBackColor = true;
            this.bt_member_list.Click += new System.EventHandler(this.bt_member_list_Click);
            // 
            // bt_loan_re
            // 
            this.bt_loan_re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_loan_re.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_loan_re.Location = new System.Drawing.Point(15, 140);
            this.bt_loan_re.Name = "bt_loan_re";
            this.bt_loan_re.Size = new System.Drawing.Size(202, 57);
            this.bt_loan_re.TabIndex = 9;
            this.bt_loan_re.Text = "Loan Record";
            this.bt_loan_re.UseVisualStyleBackColor = true;
            this.bt_loan_re.Click += new System.EventHandler(this.bt_loan_re_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(813, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(337, 78);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Transaction Record";
            // 
            // uc_RecordStatistics1
            // 
            this.uc_RecordStatistics1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_RecordStatistics1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_RecordStatistics1.Location = new System.Drawing.Point(241, 0);
            this.uc_RecordStatistics1.Name = "uc_RecordStatistics1";
            this.uc_RecordStatistics1.Size = new System.Drawing.Size(1467, 970);
            this.uc_RecordStatistics1.TabIndex = 8;
            // 
            // uc_RecordLoan1
            // 
            this.uc_RecordLoan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_RecordLoan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_RecordLoan1.Location = new System.Drawing.Point(241, 0);
            this.uc_RecordLoan1.Name = "uc_RecordLoan1";
            this.uc_RecordLoan1.Size = new System.Drawing.Size(1327, 884);
            this.uc_RecordLoan1.TabIndex = 5;
            // 
            // uc_RecordFine1
            // 
            this.uc_RecordFine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_RecordFine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_RecordFine1.Location = new System.Drawing.Point(241, 0);
            this.uc_RecordFine1.Name = "uc_RecordFine1";
            this.uc_RecordFine1.Size = new System.Drawing.Size(1327, 884);
            this.uc_RecordFine1.TabIndex = 4;
            // 
            // uc_RecordReturn1
            // 
            this.uc_RecordReturn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_RecordReturn1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_RecordReturn1.Location = new System.Drawing.Point(241, 0);
            this.uc_RecordReturn1.Name = "uc_RecordReturn1";
            this.uc_RecordReturn1.Size = new System.Drawing.Size(1327, 884);
            this.uc_RecordReturn1.TabIndex = 7;
            // 
            // uc_RecordPayment1
            // 
            this.uc_RecordPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_RecordPayment1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_RecordPayment1.Location = new System.Drawing.Point(241, 0);
            this.uc_RecordPayment1.Name = "uc_RecordPayment1";
            this.uc_RecordPayment1.Size = new System.Drawing.Size(1327, 884);
            this.uc_RecordPayment1.TabIndex = 6;
            // 
            // Transaction_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1705, 966);
            this.Controls.Add(this.uc_RecordStatistics1);
            this.Controls.Add(this.uc_RecordLoan1);
            this.Controls.Add(this.uc_RecordFine1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_RecordReturn1);
            this.Controls.Add(this.uc_RecordPayment1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transaction_record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trans_record";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Transaction_record_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button bt_payment_record;
        private Button bt_member_list;
        private Button bt_loan_re;
        private Label lb1;
        private Button bt_fine_record;
        private uc_RecordFine uc_RecordFine1;
        private uc_RecordLoan uc_RecordLoan1;
        private uc_RecordPayment uc_RecordPayment1;
        private uc_RecordReturn uc_RecordReturn1;
        private Button bt_Statistics;
        private uc_RecordStatistics uc_RecordStatistics1;
    }
}