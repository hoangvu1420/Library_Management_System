using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_BookInsert
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
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_num_cop = new System.Windows.Forms.TextBox();
            this.tB_pubYear = new System.Windows.Forms.TextBox();
            this.tB_category = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bT_save
            // 
            this.bT_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bT_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bT_save.Font = new System.Drawing.Font("Yeseva One", 14F);
            this.bT_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bT_save.Location = new System.Drawing.Point(338, 422);
            this.bT_save.Name = "bT_save";
            this.bT_save.Size = new System.Drawing.Size(158, 47);
            this.bT_save.TabIndex = 25;
            this.bT_save.Text = "SAVE";
            this.bT_save.UseVisualStyleBackColor = false;
            this.bT_save.Click += new System.EventHandler(this.bT_save_Click);
            // 
            // tB_title
            // 
            this.tB_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_title.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_title.Location = new System.Drawing.Point(293, 162);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(436, 29);
            this.tB_title.TabIndex = 20;
            // 
            // tB_num_cop
            // 
            this.tB_num_cop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_num_cop.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_num_cop.Location = new System.Drawing.Point(293, 343);
            this.tB_num_cop.Name = "tB_num_cop";
            this.tB_num_cop.Size = new System.Drawing.Size(436, 29);
            this.tB_num_cop.TabIndex = 24;
            // 
            // tB_pubYear
            // 
            this.tB_pubYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_pubYear.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_pubYear.Location = new System.Drawing.Point(293, 295);
            this.tB_pubYear.Name = "tB_pubYear";
            this.tB_pubYear.Size = new System.Drawing.Size(436, 29);
            this.tB_pubYear.TabIndex = 23;
            // 
            // tB_category
            // 
            this.tB_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_category.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_category.Location = new System.Drawing.Point(293, 252);
            this.tB_category.Name = "tB_category";
            this.tB_category.Size = new System.Drawing.Size(436, 29);
            this.tB_category.TabIndex = 22;
            // 
            // tB_author
            // 
            this.tB_author.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_author.Font = new System.Drawing.Font("Lora", 10F);
            this.tB_author.Location = new System.Drawing.Point(293, 206);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(436, 29);
            this.tB_author.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 12F);
            this.label4.Location = new System.Drawing.Point(170, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Author(s):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 12F);
            this.label5.Location = new System.Drawing.Point(89, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of copies:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 12F);
            this.label3.Location = new System.Drawing.Point(213, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 12F);
            this.label2.Location = new System.Drawing.Point(103, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Publication Year:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora", 12F);
            this.label1.Location = new System.Drawing.Point(150, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Category(s):";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(278, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(296, 78);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "Insert New Book";
            // 
            // uc_BookInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.bT_save);
            this.Controls.Add(this.tB_title);
            this.Controls.Add(this.tB_num_cop);
            this.Controls.Add(this.tB_pubYear);
            this.Controls.Add(this.tB_category);
            this.Controls.Add(this.tB_author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Name = "uc_BookInsert";
            this.Size = new System.Drawing.Size(835, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bT_save;
        private TextBox tB_title;
        private TextBox tB_num_cop;
        private TextBox tB_pubYear;
        private TextBox tB_category;
        private TextBox tB_author;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lb1;
    }
}
