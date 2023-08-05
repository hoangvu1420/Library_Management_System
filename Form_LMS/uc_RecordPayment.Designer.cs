using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_RecordPayment
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
            this.tB_paymentType = new System.Windows.Forms.TextBox();
            this.tB_memName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_paymentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_payment_list = new System.Windows.Forms.DataGridView();
            this.tB_paymentMethod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_memID = new System.Windows.Forms.TextBox();
            this.tB_paymentAmount = new System.Windows.Forms.TextBox();
            this.tB_paymentDate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_payment_list)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_paymentType
            // 
            this.tB_paymentType.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_paymentType.Location = new System.Drawing.Point(729, 35);
            this.tB_paymentType.Name = "tB_paymentType";
            this.tB_paymentType.Size = new System.Drawing.Size(489, 29);
            this.tB_paymentType.TabIndex = 50;
            // 
            // tB_memName
            // 
            this.tB_memName.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memName.Location = new System.Drawing.Point(139, 77);
            this.tB_memName.Name = "tB_memName";
            this.tB_memName.Size = new System.Drawing.Size(428, 29);
            this.tB_memName.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.Location = new System.Drawing.Point(599, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Payment date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 10F);
            this.label6.Location = new System.Drawing.Point(599, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Payment type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 10F);
            this.label1.Location = new System.Drawing.Point(298, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Member ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 10F);
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Member name:";
            // 
            // tB_paymentID
            // 
            this.tB_paymentID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_paymentID.Location = new System.Drawing.Point(118, 36);
            this.tB_paymentID.Name = "tB_paymentID";
            this.tB_paymentID.Size = new System.Drawing.Size(170, 29);
            this.tB_paymentID.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.Location = new System.Drawing.Point(4, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Payment ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_payment_list);
            this.groupBox2.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(38, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1251, 556);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment record";
            // 
            // dGV_payment_list
            // 
            this.dGV_payment_list.AllowUserToAddRows = false;
            this.dGV_payment_list.AllowUserToDeleteRows = false;
            this.dGV_payment_list.AllowUserToResizeRows = false;
            this.dGV_payment_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_payment_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_payment_list.Location = new System.Drawing.Point(20, 28);
            this.dGV_payment_list.Name = "dGV_payment_list";
            this.dGV_payment_list.ReadOnly = true;
            this.dGV_payment_list.RowHeadersWidth = 51;
            this.dGV_payment_list.RowTemplate.Height = 29;
            this.dGV_payment_list.Size = new System.Drawing.Size(1209, 508);
            this.dGV_payment_list.TabIndex = 0;
            this.dGV_payment_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_payment_list_CellContentClick);
            // 
            // tB_paymentMethod
            // 
            this.tB_paymentMethod.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_paymentMethod.Location = new System.Drawing.Point(162, 122);
            this.tB_paymentMethod.Name = "tB_paymentMethod";
            this.tB_paymentMethod.Size = new System.Drawing.Size(405, 29);
            this.tB_paymentMethod.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Payment method:";
            // 
            // tB_memID
            // 
            this.tB_memID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID.Location = new System.Drawing.Point(409, 36);
            this.tB_memID.Name = "tB_memID";
            this.tB_memID.Size = new System.Drawing.Size(158, 29);
            this.tB_memID.TabIndex = 50;
            // 
            // tB_paymentAmount
            // 
            this.tB_paymentAmount.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_paymentAmount.Location = new System.Drawing.Point(755, 77);
            this.tB_paymentAmount.Name = "tB_paymentAmount";
            this.tB_paymentAmount.Size = new System.Drawing.Size(463, 29);
            this.tB_paymentAmount.TabIndex = 50;
            // 
            // tB_paymentDate
            // 
            this.tB_paymentDate.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_paymentDate.Location = new System.Drawing.Point(729, 120);
            this.tB_paymentDate.Name = "tB_paymentDate";
            this.tB_paymentDate.Size = new System.Drawing.Size(489, 29);
            this.tB_paymentDate.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_paymentMethod);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tB_memID);
            this.groupBox3.Controls.Add(this.tB_paymentAmount);
            this.groupBox3.Controls.Add(this.tB_paymentDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tB_paymentType);
            this.groupBox3.Controls.Add(this.tB_memName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tB_paymentID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(38, 679);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1251, 182);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.Location = new System.Drawing.Point(599, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Payment amount:";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(529, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(288, 78);
            this.lb1.TabIndex = 67;
            this.lb1.Text = "Payment Record";
            // 
            // uc_RecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb1);
            this.Name = "uc_RecordPayment";
            this.Size = new System.Drawing.Size(1327, 884);
            this.Load += new System.EventHandler(this.uc_RecordPayment_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_payment_list)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tB_paymentType;
        private TextBox tB_memName;
        private Label label4;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox tB_paymentID;
        private Label label7;
        private GroupBox groupBox2;
        private DataGridView dGV_payment_list;
        private TextBox tB_paymentMethod;
        private Label label8;
        private TextBox tB_memID;
        private TextBox tB_paymentAmount;
        private TextBox tB_paymentDate;
        private GroupBox groupBox3;
        private Label label5;
        private Label lb1;
    }
}
