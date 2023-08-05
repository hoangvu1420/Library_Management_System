using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_RecordReturn
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_returnStatus = new System.Windows.Forms.TextBox();
            this.tB_returnDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_loanID = new System.Windows.Forms.TextBox();
            this.tB_memID = new System.Windows.Forms.TextBox();
            this.tB_returnQuantity = new System.Windows.Forms.TextBox();
            this.tB_loanQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_returnID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dGV_return_list = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_book_list = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_return_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book_list)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_returnStatus);
            this.groupBox3.Controls.Add(this.tB_returnDate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tB_loanID);
            this.groupBox3.Controls.Add(this.tB_memID);
            this.groupBox3.Controls.Add(this.tB_returnQuantity);
            this.groupBox3.Controls.Add(this.tB_loanQuantity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tB_returnID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(38, 560);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 301);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Return detail";
            // 
            // tB_returnStatus
            // 
            this.tB_returnStatus.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_returnStatus.Location = new System.Drawing.Point(135, 236);
            this.tB_returnStatus.Name = "tB_returnStatus";
            this.tB_returnStatus.Size = new System.Drawing.Size(434, 29);
            this.tB_returnStatus.TabIndex = 50;
            // 
            // tB_returnDate
            // 
            this.tB_returnDate.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_returnDate.Location = new System.Drawing.Point(382, 103);
            this.tB_returnDate.Name = "tB_returnDate";
            this.tB_returnDate.Size = new System.Drawing.Size(187, 29);
            this.tB_returnDate.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.Location = new System.Drawing.Point(6, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Return status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 10F);
            this.label3.Location = new System.Drawing.Point(269, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Return date:";
            // 
            // tB_loanID
            // 
            this.tB_loanID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_loanID.Location = new System.Drawing.Point(353, 62);
            this.tB_loanID.Name = "tB_loanID";
            this.tB_loanID.Size = new System.Drawing.Size(216, 29);
            this.tB_loanID.TabIndex = 50;
            // 
            // tB_memID
            // 
            this.tB_memID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID.Location = new System.Drawing.Point(117, 102);
            this.tB_memID.Name = "tB_memID";
            this.tB_memID.Size = new System.Drawing.Size(146, 29);
            this.tB_memID.TabIndex = 50;
            // 
            // tB_returnQuantity
            // 
            this.tB_returnQuantity.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_returnQuantity.Location = new System.Drawing.Point(153, 193);
            this.tB_returnQuantity.Name = "tB_returnQuantity";
            this.tB_returnQuantity.Size = new System.Drawing.Size(416, 29);
            this.tB_returnQuantity.TabIndex = 50;
            // 
            // tB_loanQuantity
            // 
            this.tB_loanQuantity.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_loanQuantity.Location = new System.Drawing.Point(138, 146);
            this.tB_loanQuantity.Name = "tB_loanQuantity";
            this.tB_loanQuantity.Size = new System.Drawing.Size(431, 29);
            this.tB_loanQuantity.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Return quantity:";
            // 
            // tB_returnID
            // 
            this.tB_returnID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_returnID.Location = new System.Drawing.Point(105, 62);
            this.tB_returnID.Name = "tB_returnID";
            this.tB_returnID.Size = new System.Drawing.Size(158, 29);
            this.tB_returnID.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Loan quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 10F);
            this.label1.Location = new System.Drawing.Point(269, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Loan ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 10F);
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Member ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Return ID:";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(547, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(261, 78);
            this.lb1.TabIndex = 60;
            this.lb1.Text = "Return Record";
            // 
            // dGV_return_list
            // 
            this.dGV_return_list.AllowUserToAddRows = false;
            this.dGV_return_list.AllowUserToDeleteRows = false;
            this.dGV_return_list.AllowUserToResizeRows = false;
            this.dGV_return_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_return_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_return_list.Location = new System.Drawing.Point(20, 28);
            this.dGV_return_list.Name = "dGV_return_list";
            this.dGV_return_list.ReadOnly = true;
            this.dGV_return_list.RowHeadersWidth = 51;
            this.dGV_return_list.RowTemplate.Height = 29;
            this.dGV_return_list.Size = new System.Drawing.Size(1209, 389);
            this.dGV_return_list.TabIndex = 0;
            this.dGV_return_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_return_list_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGV_book_list);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(654, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 301);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book list";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_return_list);
            this.groupBox2.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(38, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1251, 437);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return record";
            // 
            // uc_RecordReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "uc_RecordReturn";
            this.Size = new System.Drawing.Size(1327, 884);
            this.Load += new System.EventHandler(this.uc_RecordReturn_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_return_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_book_list)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private TextBox tB_returnStatus;
        private TextBox tB_returnDate;
        private Label label8;
        private Label label3;
        private TextBox tB_memID;
        private TextBox tB_returnQuantity;
        private TextBox tB_loanQuantity;
        private Label label5;
        private TextBox tB_returnID;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox tB_loanID;
        private Label label7;
        private Label lb1;
        private DataGridView dGV_return_list;
        private GroupBox groupBox1;
        private DataGridView dGV_book_list;
        private GroupBox groupBox2;
    }
}
