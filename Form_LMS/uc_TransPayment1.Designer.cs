using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_TransPayment1
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
            this.cB_pay_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cB_pay_method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_month_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_pay_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_memID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bT_save
            // 
            this.bT_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bT_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bT_save.Font = new System.Drawing.Font("Yeseva One", 14F);
            this.bT_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bT_save.Location = new System.Drawing.Point(338, 507);
            this.bT_save.Name = "bT_save";
            this.bT_save.Size = new System.Drawing.Size(158, 47);
            this.bT_save.TabIndex = 75;
            this.bT_save.Text = "SAVE";
            this.bT_save.UseVisualStyleBackColor = false;
            this.bT_save.Click += new System.EventHandler(this.bT_save_Click);
            // 
            // cB_pay_type
            // 
            this.cB_pay_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cB_pay_type.Font = new System.Drawing.Font("Lora", 10F);
            this.cB_pay_type.FormattingEnabled = true;
            this.cB_pay_type.Items.AddRange(new object[] {
            "Membership fee payment",
            "Fine payment"});
            this.cB_pay_type.Location = new System.Drawing.Point(320, 218);
            this.cB_pay_type.Name = "cB_pay_type";
            this.cB_pay_type.Size = new System.Drawing.Size(384, 33);
            this.cB_pay_type.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 12F);
            this.label5.Location = new System.Drawing.Point(167, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 71;
            this.label5.Text = "Payment type:";
            // 
            // cB_pay_method
            // 
            this.cB_pay_method.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cB_pay_method.Font = new System.Drawing.Font("Lora", 10F);
            this.cB_pay_method.FormattingEnabled = true;
            this.cB_pay_method.Items.AddRange(new object[] {
            "Cash",
            "Credit card"});
            this.cB_pay_method.Location = new System.Drawing.Point(320, 364);
            this.cB_pay_method.Name = "cB_pay_method";
            this.cB_pay_method.Size = new System.Drawing.Size(384, 33);
            this.cB_pay_method.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 12F);
            this.label2.Location = new System.Drawing.Point(136, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 72;
            this.label2.Text = "Payment method:";
            // 
            // tB_month_num
            // 
            this.tB_month_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_month_num.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_month_num.Location = new System.Drawing.Point(320, 268);
            this.tB_month_num.Name = "tB_month_num";
            this.tB_month_num.Size = new System.Drawing.Size(384, 29);
            this.tB_month_num.TabIndex = 68;
            this.tB_month_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_month_num_KeyDown);
            this.tB_month_num.Leave += new System.EventHandler(this.tB_month_num_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.Location = new System.Drawing.Point(82, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 25);
            this.label7.TabIndex = 64;
            this.label7.Text = "Number of renewal months:";
            // 
            // tB_pay_amount
            // 
            this.tB_pay_amount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_pay_amount.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_pay_amount.Location = new System.Drawing.Point(320, 314);
            this.tB_pay_amount.Name = "tB_pay_amount";
            this.tB_pay_amount.Size = new System.Drawing.Size(384, 29);
            this.tB_pay_amount.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 12F);
            this.label4.Location = new System.Drawing.Point(137, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 30);
            this.label4.TabIndex = 65;
            this.label4.Text = "Payment amount:";
            // 
            // tB_memID
            // 
            this.tB_memID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_memID.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_memID.Location = new System.Drawing.Point(320, 171);
            this.tB_memID.Name = "tB_memID";
            this.tB_memID.Size = new System.Drawing.Size(384, 29);
            this.tB_memID.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 12F);
            this.label3.Location = new System.Drawing.Point(190, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 66;
            this.label3.Text = "Member ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(333, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 78);
            this.label1.TabIndex = 62;
            this.label1.Text = "Payment";
            // 
            // dTP_paymentDate
            // 
            this.dTP_paymentDate.Font = new System.Drawing.Font("Play", 10F);
            this.dTP_paymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_paymentDate.Location = new System.Drawing.Point(320, 415);
            this.dTP_paymentDate.Name = "dTP_paymentDate";
            this.dTP_paymentDate.Size = new System.Drawing.Size(384, 27);
            this.dTP_paymentDate.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 12F);
            this.label8.Location = new System.Drawing.Point(167, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 30);
            this.label8.TabIndex = 76;
            this.label8.Text = "Payment date:";
            // 
            // uc_TransPayment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.dTP_paymentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bT_save);
            this.Controls.Add(this.cB_pay_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cB_pay_method);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_month_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tB_pay_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_memID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "uc_TransPayment1";
            this.Size = new System.Drawing.Size(833, 696);
            this.Load += new System.EventHandler(this.uc_TransPayment1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bT_save;
        private ComboBox cB_pay_type;
        private Label label5;
        private ComboBox cB_pay_method;
        private Label label2;
        private Label label6;
        private TextBox tB_month_num;
        private Label label7;
        private TextBox tB_pay_amount;
        private Label label4;
        private TextBox tB_memID;
        private Label label3;
        private Label label1;
        private DateTimePicker dTP_paymentDate;
        private Label label8;
    }
}
