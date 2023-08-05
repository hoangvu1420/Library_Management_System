using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_RecordFine
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_fine_list = new System.Windows.Forms.DataGridView();
            this.tB_fineStatus = new System.Windows.Forms.TextBox();
            this.tB_payID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_memID = new System.Windows.Forms.TextBox();
            this.tB_fineAmount = new System.Windows.Forms.TextBox();
            this.tB_fineDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.tB_fineType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_fineID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_memName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_fine_list)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_fine_list);
            this.groupBox2.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(38, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1251, 556);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fine record";
            // 
            // dGV_fine_list
            // 
            this.dGV_fine_list.AllowUserToAddRows = false;
            this.dGV_fine_list.AllowUserToDeleteRows = false;
            this.dGV_fine_list.AllowUserToResizeRows = false;
            this.dGV_fine_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_fine_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_fine_list.Location = new System.Drawing.Point(20, 28);
            this.dGV_fine_list.Name = "dGV_fine_list";
            this.dGV_fine_list.ReadOnly = true;
            this.dGV_fine_list.RowHeadersWidth = 51;
            this.dGV_fine_list.RowTemplate.Height = 29;
            this.dGV_fine_list.Size = new System.Drawing.Size(1209, 508);
            this.dGV_fine_list.TabIndex = 0;
            this.dGV_fine_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_fine_list_CellContentClick);
            // 
            // tB_fineStatus
            // 
            this.tB_fineStatus.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_fineStatus.Location = new System.Drawing.Point(114, 121);
            this.tB_fineStatus.Name = "tB_fineStatus";
            this.tB_fineStatus.Size = new System.Drawing.Size(453, 29);
            this.tB_fineStatus.TabIndex = 50;
            // 
            // tB_payID
            // 
            this.tB_payID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_payID.Location = new System.Drawing.Point(719, 118);
            this.tB_payID.Name = "tB_payID";
            this.tB_payID.Size = new System.Drawing.Size(499, 29);
            this.tB_payID.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Fine status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 10F);
            this.label3.Location = new System.Drawing.Point(599, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Payment ID:";
            // 
            // tB_memID
            // 
            this.tB_memID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID.Location = new System.Drawing.Point(398, 36);
            this.tB_memID.Name = "tB_memID";
            this.tB_memID.Size = new System.Drawing.Size(169, 29);
            this.tB_memID.TabIndex = 50;
            // 
            // tB_fineAmount
            // 
            this.tB_fineAmount.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_fineAmount.Location = new System.Drawing.Point(719, 77);
            this.tB_fineAmount.Name = "tB_fineAmount";
            this.tB_fineAmount.Size = new System.Drawing.Size(192, 29);
            this.tB_fineAmount.TabIndex = 50;
            // 
            // tB_fineDate
            // 
            this.tB_fineDate.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_fineDate.Location = new System.Drawing.Point(1014, 77);
            this.tB_fineDate.Name = "tB_fineDate";
            this.tB_fineDate.Size = new System.Drawing.Size(204, 29);
            this.tB_fineDate.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.Location = new System.Drawing.Point(599, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fine amount:";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(547, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(223, 78);
            this.lb1.TabIndex = 64;
            this.lb1.Text = "Fine Record";
            // 
            // tB_fineType
            // 
            this.tB_fineType.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_fineType.Location = new System.Drawing.Point(693, 35);
            this.tB_fineType.Name = "tB_fineType";
            this.tB_fineType.Size = new System.Drawing.Size(525, 29);
            this.tB_fineType.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.Location = new System.Drawing.Point(920, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Fine date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 10F);
            this.label6.Location = new System.Drawing.Point(599, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fine type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 10F);
            this.label1.Location = new System.Drawing.Point(287, 38);
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
            // tB_fineID
            // 
            this.tB_fineID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_fineID.Location = new System.Drawing.Point(82, 36);
            this.tB_fineID.Name = "tB_fineID";
            this.tB_fineID.Size = new System.Drawing.Size(191, 29);
            this.tB_fineID.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.Location = new System.Drawing.Point(4, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Fine ID:";
            // 
            // tB_memName
            // 
            this.tB_memName.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memName.Location = new System.Drawing.Point(139, 77);
            this.tB_memName.Name = "tB_memName";
            this.tB_memName.Size = new System.Drawing.Size(428, 29);
            this.tB_memName.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_fineStatus);
            this.groupBox3.Controls.Add(this.tB_payID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tB_memID);
            this.groupBox3.Controls.Add(this.tB_fineAmount);
            this.groupBox3.Controls.Add(this.tB_fineDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tB_fineType);
            this.groupBox3.Controls.Add(this.tB_memName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tB_fineID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(38, 679);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1251, 182);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fine detail";
            // 
            // uc_RecordFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.groupBox3);
            this.Name = "uc_RecordFine";
            this.Size = new System.Drawing.Size(1327, 884);
            this.Load += new System.EventHandler(this.uc_RecordFine_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_fine_list)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dGV_fine_list;
        private TextBox tB_fineStatus;
        private TextBox tB_payID;
        private Label label8;
        private Label label3;
        private TextBox tB_memID;
        private TextBox tB_fineAmount;
        private TextBox tB_fineDate;
        private Label label5;
        private Label lb1;
        private TextBox tB_fineType;
        private Label label4;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox tB_fineID;
        private Label label7;
        private TextBox tB_memName;
        private GroupBox groupBox3;
        private Label label9;
    }
}
