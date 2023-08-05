using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_MemberInsert
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
            this.cB_sex = new System.Windows.Forms.ComboBox();
            this.dTP_birthday = new System.Windows.Forms.DateTimePicker();
            this.bT_save = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_sex
            // 
            this.cB_sex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cB_sex.Font = new System.Drawing.Font("Lora", 10F);
            this.cB_sex.FormattingEnabled = true;
            this.cB_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cB_sex.Location = new System.Drawing.Point(231, 282);
            this.cB_sex.Name = "cB_sex";
            this.cB_sex.Size = new System.Drawing.Size(445, 33);
            this.cB_sex.TabIndex = 39;
            // 
            // dTP_birthday
            // 
            this.dTP_birthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTP_birthday.CalendarFont = new System.Drawing.Font("Play", 10F);
            this.dTP_birthday.Font = new System.Drawing.Font("Play", 10F);
            this.dTP_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_birthday.Location = new System.Drawing.Point(231, 234);
            this.dTP_birthday.Name = "dTP_birthday";
            this.dTP_birthday.Size = new System.Drawing.Size(445, 27);
            this.dTP_birthday.TabIndex = 38;
            // 
            // bT_save
            // 
            this.bT_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bT_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bT_save.Font = new System.Drawing.Font("Yeseva One", 14F);
            this.bT_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bT_save.Location = new System.Drawing.Point(339, 418);
            this.bT_save.Name = "bT_save";
            this.bT_save.Size = new System.Drawing.Size(158, 47);
            this.bT_save.TabIndex = 37;
            this.bT_save.Text = "SAVE";
            this.bT_save.UseVisualStyleBackColor = false;
            this.bT_save.Click += new System.EventHandler(this.bT_save_Click);
            // 
            // tB_name
            // 
            this.tB_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_name.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_name.Location = new System.Drawing.Point(231, 191);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(445, 29);
            this.tB_name.TabIndex = 35;
            // 
            // tB_phone
            // 
            this.tB_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_phone.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_phone.Location = new System.Drawing.Point(231, 329);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(445, 29);
            this.tB_phone.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 12F);
            this.label4.Location = new System.Drawing.Point(123, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 12F);
            this.label3.Location = new System.Drawing.Point(149, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 12F);
            this.label2.Location = new System.Drawing.Point(144, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 12F);
            this.label1.Location = new System.Drawing.Point(170, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sex:";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(251, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(346, 78);
            this.lb1.TabIndex = 28;
            this.lb1.Text = "Insert New Member";
            // 
            // uc_MemberInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.cB_sex);
            this.Controls.Add(this.dTP_birthday);
            this.Controls.Add(this.bT_save);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.tB_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Name = "uc_MemberInsert";
            this.Size = new System.Drawing.Size(835, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cB_sex;
        private DateTimePicker dTP_birthday;
        private Button bT_save;
        private TextBox tB_name;
        private TextBox tB_phone;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lb1;
    }
}
