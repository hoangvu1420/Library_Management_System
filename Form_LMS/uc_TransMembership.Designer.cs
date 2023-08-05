using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_TransMembership
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
            this.cB_mem_type = new System.Windows.Forms.ComboBox();
            this.bT_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_memID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_mem_fee = new System.Windows.Forms.TextBox();
            this.tB_max_book = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_max_day = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_memName = new System.Windows.Forms.TextBox();
            this.dTP_addedDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_current_mem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(301, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 78);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Membership";
            // 
            // cB_mem_type
            // 
            this.cB_mem_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cB_mem_type.Font = new System.Drawing.Font("Lora", 10F);
            this.cB_mem_type.FormattingEnabled = true;
            this.cB_mem_type.Items.AddRange(new object[] {
            "Membership fee payment",
            "Fine payment"});
            this.cB_mem_type.Location = new System.Drawing.Point(343, 291);
            this.cB_mem_type.Name = "cB_mem_type";
            this.cB_mem_type.Size = new System.Drawing.Size(384, 33);
            this.cB_mem_type.TabIndex = 56;
            this.cB_mem_type.SelectedIndexChanged += new System.EventHandler(this.cB_mem_type_SelectedIndexChanged);
            // 
            // bT_save
            // 
            this.bT_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bT_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bT_save.Font = new System.Drawing.Font("Yeseva One", 14F);
            this.bT_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bT_save.Location = new System.Drawing.Point(366, 561);
            this.bT_save.Name = "bT_save";
            this.bT_save.Size = new System.Drawing.Size(158, 47);
            this.bT_save.TabIndex = 55;
            this.bT_save.Text = "SAVE";
            this.bT_save.UseVisualStyleBackColor = false;
            this.bT_save.Click += new System.EventHandler(this.bT_save_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 12F);
            this.label2.Location = new System.Drawing.Point(154, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 30);
            this.label2.TabIndex = 49;
            this.label2.Text = "Membership type:";
            // 
            // tB_memID
            // 
            this.tB_memID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID.Location = new System.Drawing.Point(343, 157);
            this.tB_memID.Name = "tB_memID";
            this.tB_memID.Size = new System.Drawing.Size(384, 29);
            this.tB_memID.TabIndex = 48;
            this.tB_memID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_memID_KeyDown);
            this.tB_memID.Leave += new System.EventHandler(this.tB_memID_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 12F);
            this.label3.Location = new System.Drawing.Point(213, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "Member ID:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 12F);
            this.label4.Location = new System.Drawing.Point(167, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 49;
            this.label4.Text = "Membership fee:";
            // 
            // tB_mem_fee
            // 
            this.tB_mem_fee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_mem_fee.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_mem_fee.Location = new System.Drawing.Point(343, 338);
            this.tB_mem_fee.Name = "tB_mem_fee";
            this.tB_mem_fee.ReadOnly = true;
            this.tB_mem_fee.Size = new System.Drawing.Size(384, 29);
            this.tB_mem_fee.TabIndex = 48;
            // 
            // tB_max_book
            // 
            this.tB_max_book.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_max_book.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_max_book.Location = new System.Drawing.Point(343, 384);
            this.tB_max_book.Name = "tB_max_book";
            this.tB_max_book.ReadOnly = true;
            this.tB_max_book.Size = new System.Drawing.Size(384, 29);
            this.tB_max_book.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.Location = new System.Drawing.Point(106, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Maximum number of books:";
            // 
            // tB_max_day
            // 
            this.tB_max_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_max_day.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_max_day.Location = new System.Drawing.Point(343, 431);
            this.tB_max_day.Name = "tB_max_day";
            this.tB_max_day.ReadOnly = true;
            this.tB_max_day.Size = new System.Drawing.Size(384, 29);
            this.tB_max_day.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 10F);
            this.label6.Location = new System.Drawing.Point(117, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Maximum number of days:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 12F);
            this.label8.Location = new System.Drawing.Point(184, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 30);
            this.label8.TabIndex = 47;
            this.label8.Text = "Member name:";
            // 
            // tB_memName
            // 
            this.tB_memName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memName.Enabled = false;
            this.tB_memName.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memName.Location = new System.Drawing.Point(343, 202);
            this.tB_memName.Name = "tB_memName";
            this.tB_memName.Size = new System.Drawing.Size(384, 29);
            this.tB_memName.TabIndex = 48;
            // 
            // dTP_addedDate
            // 
            this.dTP_addedDate.Font = new System.Drawing.Font("Play", 10F);
            this.dTP_addedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_addedDate.Location = new System.Drawing.Point(343, 480);
            this.dTP_addedDate.Name = "dTP_addedDate";
            this.dTP_addedDate.Size = new System.Drawing.Size(384, 27);
            this.dTP_addedDate.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 12F);
            this.label7.Location = new System.Drawing.Point(236, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 49;
            this.label7.Text = "Add date:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lora", 12F);
            this.label9.Location = new System.Drawing.Point(121, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 30);
            this.label9.TabIndex = 47;
            this.label9.Text = "Current membership:";
            // 
            // tB_current_mem
            // 
            this.tB_current_mem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_current_mem.Enabled = false;
            this.tB_current_mem.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_current_mem.Location = new System.Drawing.Point(343, 247);
            this.tB_current_mem.Name = "tB_current_mem";
            this.tB_current_mem.ReadOnly = true;
            this.tB_current_mem.Size = new System.Drawing.Size(384, 29);
            this.tB_current_mem.TabIndex = 48;
            // 
            // uc_TransMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.dTP_addedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cB_mem_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bT_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_max_day);
            this.Controls.Add(this.tB_max_book);
            this.Controls.Add(this.tB_mem_fee);
            this.Controls.Add(this.tB_current_mem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tB_memName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_memID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "uc_TransMembership";
            this.Size = new System.Drawing.Size(886, 696);
            this.Load += new System.EventHandler(this.uc_TransMembership_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_TransMembership_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cB_mem_type;
        private Button bT_save;
        private Label label2;
        private TextBox tB_memID;
        private Label label3;
        private Label label4;
        private TextBox tB_mem_fee;
        private TextBox tB_max_book;
        private Label label5;
        private TextBox tB_max_day;
        private Label label6;
        private Label label8;
        private TextBox tB_memName;
        private DateTimePicker dTP_addedDate;
        private Label label7;
        private Label label9;
        private TextBox tB_current_mem;
    }
}
