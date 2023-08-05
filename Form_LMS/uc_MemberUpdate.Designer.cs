using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_MemberUpdate
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
            this.bT_save = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_sex1 = new System.Windows.Forms.ComboBox();
            this.tB_name1 = new System.Windows.Forms.TextBox();
            this.dTP_birthday1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_phone1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gB = new System.Windows.Forms.GroupBox();
            this.dTP_birthday = new System.Windows.Forms.DateTimePicker();
            this.cB_sex = new System.Windows.Forms.ComboBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.tB_memberID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gB.SuspendLayout();
            this.SuspendLayout();
            // 
            // bT_save
            // 
            this.bT_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bT_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bT_save.Font = new System.Drawing.Font("Yeseva One", 14F);
            this.bT_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bT_save.Location = new System.Drawing.Point(391, 839);
            this.bT_save.Name = "bT_save";
            this.bT_save.Size = new System.Drawing.Size(158, 47);
            this.bT_save.TabIndex = 38;
            this.bT_save.Text = "SAVE";
            this.bT_save.UseVisualStyleBackColor = false;
            this.bT_save.Click += new System.EventHandler(this.bT_save_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(301, 38);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(340, 78);
            this.lb1.TabIndex = 37;
            this.lb1.Text = "Update Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_sex1);
            this.groupBox1.Controls.Add(this.tB_name1);
            this.groupBox1.Controls.Add(this.dTP_birthday1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tB_phone1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(91, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 280);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update properties";
            // 
            // cB_sex1
            // 
            this.cB_sex1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cB_sex1.Font = new System.Drawing.Font("Lora", 10F);
            this.cB_sex1.FormattingEnabled = true;
            this.cB_sex1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cB_sex1.Location = new System.Drawing.Point(210, 152);
            this.cB_sex1.Name = "cB_sex1";
            this.cB_sex1.Size = new System.Drawing.Size(445, 33);
            this.cB_sex1.TabIndex = 56;
            // 
            // tB_name1
            // 
            this.tB_name1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_name1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_name1.Location = new System.Drawing.Point(210, 61);
            this.tB_name1.Name = "tB_name1";
            this.tB_name1.Size = new System.Drawing.Size(445, 29);
            this.tB_name1.TabIndex = 53;
            // 
            // dTP_birthday1
            // 
            this.dTP_birthday1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTP_birthday1.CalendarFont = new System.Drawing.Font("Play", 10F);
            this.dTP_birthday1.Font = new System.Drawing.Font("Play", 10F);
            this.dTP_birthday1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_birthday1.Location = new System.Drawing.Point(210, 104);
            this.dTP_birthday1.Name = "dTP_birthday1";
            this.dTP_birthday1.Size = new System.Drawing.Size(445, 27);
            this.dTP_birthday1.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 12F);
            this.label8.Location = new System.Drawing.Point(149, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 30);
            this.label8.TabIndex = 52;
            this.label8.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 12F);
            this.label7.Location = new System.Drawing.Point(123, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 30);
            this.label7.TabIndex = 51;
            this.label7.Text = "Phone:";
            // 
            // tB_phone1
            // 
            this.tB_phone1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_phone1.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_phone1.Location = new System.Drawing.Point(210, 199);
            this.tB_phone1.Name = "tB_phone1";
            this.tB_phone1.Size = new System.Drawing.Size(445, 29);
            this.tB_phone1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 12F);
            this.label6.Location = new System.Drawing.Point(128, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 50;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 12F);
            this.label5.Location = new System.Drawing.Point(102, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "Birthday:";
            // 
            // gB
            // 
            this.gB.Controls.Add(this.dTP_birthday);
            this.gB.Controls.Add(this.cB_sex);
            this.gB.Controls.Add(this.tB_name);
            this.gB.Controls.Add(this.label1);
            this.gB.Controls.Add(this.label2);
            this.gB.Controls.Add(this.tB_phone);
            this.gB.Controls.Add(this.label3);
            this.gB.Controls.Add(this.label4);
            this.gB.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.gB.Location = new System.Drawing.Point(91, 175);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(761, 288);
            this.gB.TabIndex = 40;
            this.gB.TabStop = false;
            this.gB.Text = "Former properties";
            // 
            // dTP_birthday
            // 
            this.dTP_birthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTP_birthday.CalendarFont = new System.Drawing.Font("Play", 10F);
            this.dTP_birthday.Enabled = false;
            this.dTP_birthday.Font = new System.Drawing.Font("Play", 10F);
            this.dTP_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_birthday.Location = new System.Drawing.Point(210, 119);
            this.dTP_birthday.Name = "dTP_birthday";
            this.dTP_birthday.Size = new System.Drawing.Size(445, 27);
            this.dTP_birthday.TabIndex = 57;
            // 
            // cB_sex
            // 
            this.cB_sex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cB_sex.Enabled = false;
            this.cB_sex.Font = new System.Drawing.Font("Lora", 10F);
            this.cB_sex.FormattingEnabled = true;
            this.cB_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cB_sex.Location = new System.Drawing.Point(210, 165);
            this.cB_sex.Name = "cB_sex";
            this.cB_sex.Size = new System.Drawing.Size(445, 33);
            this.cB_sex.TabIndex = 48;
            // 
            // tB_name
            // 
            this.tB_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_name.Enabled = false;
            this.tB_name.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_name.Location = new System.Drawing.Point(210, 74);
            this.tB_name.Name = "tB_name";
            this.tB_name.ReadOnly = true;
            this.tB_name.Size = new System.Drawing.Size(445, 29);
            this.tB_name.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 12F);
            this.label1.Location = new System.Drawing.Point(149, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sex:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 12F);
            this.label2.Location = new System.Drawing.Point(123, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "Phone:";
            // 
            // tB_phone
            // 
            this.tB_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_phone.Enabled = false;
            this.tB_phone.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_phone.Location = new System.Drawing.Point(210, 212);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.ReadOnly = true;
            this.tB_phone.Size = new System.Drawing.Size(445, 29);
            this.tB_phone.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 12F);
            this.label3.Location = new System.Drawing.Point(128, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 12F);
            this.label4.Location = new System.Drawing.Point(102, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "Birthday:";
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Lora", 10F);
            this.bt_search.Location = new System.Drawing.Point(262, 138);
            this.bt_search.Margin = new System.Windows.Forms.Padding(0);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(33, 33);
            this.bt_search.TabIndex = 43;
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tB_memberID
            // 
            this.tB_memberID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memberID.Location = new System.Drawing.Point(91, 140);
            this.tB_memberID.Name = "tB_memberID";
            this.tB_memberID.Size = new System.Drawing.Size(168, 29);
            this.tB_memberID.TabIndex = 42;
            this.tB_memberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_memberID_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lora", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(91, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 22);
            this.label11.TabIndex = 41;
            this.label11.Text = "Enter member ID";
            // 
            // uc_MemberUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tB_memberID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.bT_save);
            this.Controls.Add(this.lb1);
            this.Name = "uc_MemberUpdate";
            this.Size = new System.Drawing.Size(943, 947);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bT_save;
        private Label lb1;
        private GroupBox groupBox1;
        private GroupBox gB;
        private ComboBox cB_sex1;
        private TextBox tB_name1;
        private DateTimePicker dTP_birthday1;
        private Label label8;
        private Label label7;
        private TextBox tB_phone1;
        private Label label6;
        private Label label5;
        private ComboBox cB_sex;
        private TextBox tB_name;
        private Label label1;
        private Label label2;
        private TextBox tB_phone;
        private Label label3;
        private Label label4;
        private Button bt_search;
        private TextBox tB_memberID;
        private Label label11;
        private DateTimePicker dTP_birthday;
    }
}
