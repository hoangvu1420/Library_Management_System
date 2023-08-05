using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_MemberList
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
            this.gB_list = new System.Windows.Forms.GroupBox();
            this.dGV_member = new System.Windows.Forms.DataGridView();
            this.gB_detail = new System.Windows.Forms.GroupBox();
            this.tB_memDate = new System.Windows.Forms.TextBox();
            this.tB_mem_status = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_birthday = new System.Windows.Forms.TextBox();
            this.tB_addTime = new System.Windows.Forms.TextBox();
            this.tB_membership = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_sex = new System.Windows.Forms.TextBox();
            this.tB_updateTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_memFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.tB_searchName = new System.Windows.Forms.TextBox();
            this.tB_searchMembership = new System.Windows.Forms.TextBox();
            this.tB_searchSex = new System.Windows.Forms.TextBox();
            this.tB_searchBirthday = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tB_searchMemberID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gB_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_member)).BeginInit();
            this.gB_detail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(610, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 78);
            this.label1.TabIndex = 11;
            this.label1.Text = "Member List";
            // 
            // gB_list
            // 
            this.gB_list.Controls.Add(this.dGV_member);
            this.gB_list.Font = new System.Drawing.Font("Lora", 10F);
            this.gB_list.ForeColor = System.Drawing.Color.Black;
            this.gB_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gB_list.Location = new System.Drawing.Point(14, 178);
            this.gB_list.Name = "gB_list";
            this.gB_list.Size = new System.Drawing.Size(1440, 544);
            this.gB_list.TabIndex = 16;
            this.gB_list.TabStop = false;
            this.gB_list.Text = "List";
            // 
            // dGV_member
            // 
            this.dGV_member.AllowUserToAddRows = false;
            this.dGV_member.AllowUserToDeleteRows = false;
            this.dGV_member.AllowUserToOrderColumns = true;
            this.dGV_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_member.Location = new System.Drawing.Point(6, 26);
            this.dGV_member.Name = "dGV_member";
            this.dGV_member.RowHeadersWidth = 51;
            this.dGV_member.RowTemplate.Height = 29;
            this.dGV_member.Size = new System.Drawing.Size(1428, 512);
            this.dGV_member.TabIndex = 13;
            this.dGV_member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_member_CellContentClick);
            // 
            // gB_detail
            // 
            this.gB_detail.Controls.Add(this.tB_memDate);
            this.gB_detail.Controls.Add(this.tB_mem_status);
            this.gB_detail.Controls.Add(this.tB_phone);
            this.gB_detail.Controls.Add(this.label12);
            this.gB_detail.Controls.Add(this.label10);
            this.gB_detail.Controls.Add(this.label4);
            this.gB_detail.Controls.Add(this.tB_birthday);
            this.gB_detail.Controls.Add(this.tB_addTime);
            this.gB_detail.Controls.Add(this.tB_membership);
            this.gB_detail.Controls.Add(this.label9);
            this.gB_detail.Controls.Add(this.label7);
            this.gB_detail.Controls.Add(this.label5);
            this.gB_detail.Controls.Add(this.tB_sex);
            this.gB_detail.Controls.Add(this.tB_updateTime);
            this.gB_detail.Controls.Add(this.label6);
            this.gB_detail.Controls.Add(this.label8);
            this.gB_detail.Controls.Add(this.tB_memFee);
            this.gB_detail.Controls.Add(this.label2);
            this.gB_detail.Controls.Add(this.tB_ID);
            this.gB_detail.Controls.Add(this.label11);
            this.gB_detail.Controls.Add(this.tB_name);
            this.gB_detail.Controls.Add(this.label3);
            this.gB_detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gB_detail.Font = new System.Drawing.Font("Lora", 10F);
            this.gB_detail.ForeColor = System.Drawing.Color.Black;
            this.gB_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gB_detail.Location = new System.Drawing.Point(0, 742);
            this.gB_detail.Name = "gB_detail";
            this.gB_detail.Size = new System.Drawing.Size(1467, 228);
            this.gB_detail.TabIndex = 17;
            this.gB_detail.TabStop = false;
            this.gB_detail.Text = "Detail";
            // 
            // tB_memDate
            // 
            this.tB_memDate.Location = new System.Drawing.Point(205, 184);
            this.tB_memDate.Name = "tB_memDate";
            this.tB_memDate.Size = new System.Drawing.Size(315, 29);
            this.tB_memDate.TabIndex = 12;
            // 
            // tB_mem_status
            // 
            this.tB_mem_status.Location = new System.Drawing.Point(466, 122);
            this.tB_mem_status.Name = "tB_mem_status";
            this.tB_mem_status.Size = new System.Drawing.Size(224, 29);
            this.tB_mem_status.TabIndex = 12;
            // 
            // tB_phone
            // 
            this.tB_phone.Location = new System.Drawing.Point(205, 122);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(224, 29);
            this.tB_phone.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lora", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(466, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Member status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lora", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(205, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Membership expiry date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(205, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // tB_birthday
            // 
            this.tB_birthday.Location = new System.Drawing.Point(729, 58);
            this.tB_birthday.Name = "tB_birthday";
            this.tB_birthday.Size = new System.Drawing.Size(224, 29);
            this.tB_birthday.TabIndex = 12;
            // 
            // tB_addTime
            // 
            this.tB_addTime.Location = new System.Drawing.Point(553, 184);
            this.tB_addTime.Name = "tB_addTime";
            this.tB_addTime.Size = new System.Drawing.Size(315, 29);
            this.tB_addTime.TabIndex = 12;
            // 
            // tB_membership
            // 
            this.tB_membership.Location = new System.Drawing.Point(729, 122);
            this.tB_membership.Name = "tB_membership";
            this.tB_membership.Size = new System.Drawing.Size(224, 29);
            this.tB_membership.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lora", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(553, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Added time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lora", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(729, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(729, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Membership:";
            // 
            // tB_sex
            // 
            this.tB_sex.Location = new System.Drawing.Point(993, 58);
            this.tB_sex.Name = "tB_sex";
            this.tB_sex.Size = new System.Drawing.Size(224, 29);
            this.tB_sex.TabIndex = 12;
            // 
            // tB_updateTime
            // 
            this.tB_updateTime.Location = new System.Drawing.Point(902, 184);
            this.tB_updateTime.Name = "tB_updateTime";
            this.tB_updateTime.Size = new System.Drawing.Size(315, 29);
            this.tB_updateTime.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(993, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sex:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lora", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(902, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Latest updated time:";
            // 
            // tB_memFee
            // 
            this.tB_memFee.Location = new System.Drawing.Point(993, 122);
            this.tB_memFee.Name = "tB_memFee";
            this.tB_memFee.Size = new System.Drawing.Size(224, 29);
            this.tB_memFee.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(993, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Membership fee:";
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(205, 58);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(224, 29);
            this.tB_ID.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lora", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(205, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "ID:";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(466, 58);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(224, 29);
            this.tB_name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lora", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(466, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_go);
            this.groupBox1.Controls.Add(this.tB_searchName);
            this.groupBox1.Controls.Add(this.tB_searchMembership);
            this.groupBox1.Controls.Add(this.tB_searchSex);
            this.groupBox1.Controls.Add(this.tB_searchBirthday);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tB_searchMemberID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1440, 94);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // bt_go
            // 
            this.bt_go.Location = new System.Drawing.Point(9, 50);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(45, 32);
            this.bt_go.TabIndex = 14;
            this.bt_go.Text = "Go";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // tB_searchName
            // 
            this.tB_searchName.Location = new System.Drawing.Point(161, 52);
            this.tB_searchName.Name = "tB_searchName";
            this.tB_searchName.Size = new System.Drawing.Size(300, 29);
            this.tB_searchName.TabIndex = 13;
            // 
            // tB_searchMembership
            // 
            this.tB_searchMembership.Location = new System.Drawing.Point(1097, 52);
            this.tB_searchMembership.Name = "tB_searchMembership";
            this.tB_searchMembership.Size = new System.Drawing.Size(161, 29);
            this.tB_searchMembership.TabIndex = 13;
            // 
            // tB_searchSex
            // 
            this.tB_searchSex.Location = new System.Drawing.Point(628, 51);
            this.tB_searchSex.Name = "tB_searchSex";
            this.tB_searchSex.Size = new System.Drawing.Size(147, 29);
            this.tB_searchSex.TabIndex = 13;
            // 
            // tB_searchBirthday
            // 
            this.tB_searchBirthday.Location = new System.Drawing.Point(465, 52);
            this.tB_searchBirthday.Name = "tB_searchBirthday";
            this.tB_searchBirthday.Size = new System.Drawing.Size(158, 29);
            this.tB_searchBirthday.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lora", 8F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(54, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "Member ID:";
            // 
            // tB_searchMemberID
            // 
            this.tB_searchMemberID.Location = new System.Drawing.Point(58, 52);
            this.tB_searchMemberID.Name = "tB_searchMemberID";
            this.tB_searchMemberID.Size = new System.Drawing.Size(99, 29);
            this.tB_searchMemberID.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lora", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(624, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Sex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lora", 8F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(461, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 21);
            this.label15.TabIndex = 11;
            this.label15.Text = "Birthday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lora", 8F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(157, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lora", 8F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(1093, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 21);
            this.label18.TabIndex = 11;
            this.label18.Text = "Membership:";
            // 
            // uc_MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB_list);
            this.Controls.Add(this.gB_detail);
            this.Controls.Add(this.label1);
            this.Name = "uc_MemberList";
            this.Size = new System.Drawing.Size(1467, 970);
            this.Load += new System.EventHandler(this.uc_MemberList_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_MemberList_VisibleChanged);
            this.gB_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_member)).EndInit();
            this.gB_detail.ResumeLayout(false);
            this.gB_detail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private GroupBox gB_list;
        private DataGridView dGV_member;
        private GroupBox gB_detail;
        private TextBox tB_phone;
        private Label label4;
        private TextBox tB_membership;
        private Label label5;
        private TextBox tB_memFee;
        private Label label2;
        private TextBox tB_name;
        private Label label3;
        private TextBox tB_memDate;
        private Label label10;
        private TextBox tB_birthday;
        private TextBox tB_addTime;
        private Label label9;
        private Label label7;
        private TextBox tB_sex;
        private TextBox tB_updateTime;
        private Label label6;
        private Label label8;
        private TextBox tB_ID;
        private Label label11;
        private TextBox tB_mem_status;
        private Label label12;
        private GroupBox groupBox1;
        private Button bt_go;
        private TextBox tB_searchName;
        private TextBox tB_searchMembership;
        private TextBox tB_searchSex;
        private TextBox tB_searchBirthday;
        private Label label14;
        private TextBox tB_searchMemberID;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label13;
    }
}
