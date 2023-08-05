using System.Drawing;
using System.Windows.Forms;
using System;

namespace Form_LMS
{
    partial class Add_transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_transaction));
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_loan = new System.Windows.Forms.Button();
            this.bt_add_membership = new System.Windows.Forms.Button();
            this.bt_payment = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uc_TransLoan1 = new Form_LMS.uc_TransLoan();
            this.uc_TransMembership1 = new Form_LMS.uc_TransMembership();
            this.uc_TransPayment1 = new Form_LMS.uc_TransPayment();
            this.uc_TransReturn1 = new Form_LMS.uc_TransReturn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(679, 30);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(217, 78);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Transaction";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_return);
            this.panel1.Controls.Add(this.bt_loan);
            this.panel1.Controls.Add(this.bt_add_membership);
            this.panel1.Controls.Add(this.bt_payment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 695);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form_LMS.Properties.Resources.LMS1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bt_return
            // 
            this.bt_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_return.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_return.Location = new System.Drawing.Point(10, 322);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(196, 57);
            this.bt_return.TabIndex = 6;
            this.bt_return.Text = "Return";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_loan
            // 
            this.bt_loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_loan.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_loan.Location = new System.Drawing.Point(10, 259);
            this.bt_loan.Name = "bt_loan";
            this.bt_loan.Size = new System.Drawing.Size(196, 57);
            this.bt_loan.TabIndex = 6;
            this.bt_loan.Text = "Loan";
            this.bt_loan.UseVisualStyleBackColor = true;
            this.bt_loan.Click += new System.EventHandler(this.bt_loan_Click);
            // 
            // bt_add_membership
            // 
            this.bt_add_membership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_membership.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_add_membership.Location = new System.Drawing.Point(10, 133);
            this.bt_add_membership.Name = "bt_add_membership";
            this.bt_add_membership.Size = new System.Drawing.Size(196, 57);
            this.bt_add_membership.TabIndex = 6;
            this.bt_add_membership.Text = "Add Membership";
            this.bt_add_membership.UseVisualStyleBackColor = true;
            this.bt_add_membership.Click += new System.EventHandler(this.bt_add_membership_Click);
            // 
            // bt_payment
            // 
            this.bt_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_payment.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_payment.Location = new System.Drawing.Point(10, 196);
            this.bt_payment.Name = "bt_payment";
            this.bt_payment.Size = new System.Drawing.Size(196, 57);
            this.bt_payment.TabIndex = 6;
            this.bt_payment.Text = "Payment";
            this.bt_payment.UseVisualStyleBackColor = true;
            this.bt_payment.Click += new System.EventHandler(this.bt_payment_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form_LMS.Properties.Resources.LMS1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // uc_TransLoan1
            // 
            this.uc_TransLoan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_TransLoan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_TransLoan1.Date = new System.DateTime(((long)(0)));
            this.uc_TransLoan1.Location = new System.Drawing.Point(225, 0);
            this.uc_TransLoan1.MemID = null;
            this.uc_TransLoan1.Name = "uc_TransLoan1";
            this.uc_TransLoan1.ReLoanList = null;
            this.uc_TransLoan1.Size = new System.Drawing.Size(1130, 696);
            this.uc_TransLoan1.TabIndex = 10;
            // 
            // uc_TransMembership1
            // 
            this.uc_TransMembership1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_TransMembership1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_TransMembership1.Location = new System.Drawing.Point(225, 0);
            this.uc_TransMembership1.Name = "uc_TransMembership1";
            this.uc_TransMembership1.Size = new System.Drawing.Size(886, 696);
            this.uc_TransMembership1.TabIndex = 9;
            // 
            // uc_TransPayment1
            // 
            this.uc_TransPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_TransPayment1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_TransPayment1.Location = new System.Drawing.Point(225, 0);
            this.uc_TransPayment1.Name = "uc_TransPayment1";
            this.uc_TransPayment1.Size = new System.Drawing.Size(833, 696);
            this.uc_TransPayment1.TabIndex = 11;
            // 
            // uc_TransReturn1
            // 
            this.uc_TransReturn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_TransReturn1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_TransReturn1.Location = new System.Drawing.Point(225, 0);
            this.uc_TransReturn1.Name = "uc_TransReturn1";
            this.uc_TransReturn1.Size = new System.Drawing.Size(1130, 696);
            this.uc_TransReturn1.TabIndex = 12;
            // 
            // Add_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1351, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uc_TransLoan1);
            this.Controls.Add(this.uc_TransMembership1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.uc_TransReturn1);
            this.Controls.Add(this.uc_TransPayment1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Add_transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_trans";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Add_trans_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox2;
        private Label lb1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button bt_return;
        private Button bt_loan;
        private Button bt_add_membership;
        private Button bt_payment;
        private uc_TransMembership uc_TransMembership1;
        private uc_TransLoan uc_TransLoan1;
        private uc_TransPayment uc_TransPayment1;
        private uc_TransReturn uc_TransReturn1;
    }
}