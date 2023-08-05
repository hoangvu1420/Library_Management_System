using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class Member_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_management));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_query = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_member_list = new System.Windows.Forms.Button();
            this.bt_insert_member = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.uc_MemberInsert1 = new Form_LMS.uc_MemberInsert();
            this.uc_MemberList1 = new Form_LMS.uc_MemberList();
            this.uc_MemberQuery1 = new Form_LMS.uc_MemberQuery();
            this.uc_MemberUpdate1 = new Form_LMS.uc_MemberUpdate();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_query);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bt_member_list);
            this.panel1.Controls.Add(this.bt_insert_member);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 966);
            this.panel1.TabIndex = 1;
            // 
            // bt_update
            // 
            this.bt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_update.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_update.Location = new System.Drawing.Point(10, 265);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(196, 57);
            this.bt_update.TabIndex = 2;
            this.bt_update.Text = "Update Information";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_query
            // 
            this.bt_query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_query.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_query.Location = new System.Drawing.Point(10, 328);
            this.bt_query.Name = "bt_query";
            this.bt_query.Size = new System.Drawing.Size(196, 57);
            this.bt_query.TabIndex = 3;
            this.bt_query.Text = "Query";
            this.bt_query.UseVisualStyleBackColor = true;
            this.bt_query.Click += new System.EventHandler(this.bt_query_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form_LMS.Properties.Resources.LMS1;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // bt_member_list
            // 
            this.bt_member_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_member_list.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_member_list.Location = new System.Drawing.Point(10, 202);
            this.bt_member_list.Name = "bt_member_list";
            this.bt_member_list.Size = new System.Drawing.Size(196, 57);
            this.bt_member_list.TabIndex = 1;
            this.bt_member_list.Text = "Member List";
            this.bt_member_list.UseVisualStyleBackColor = true;
            this.bt_member_list.Click += new System.EventHandler(this.bt_member_list_Click);
            // 
            // bt_insert_member
            // 
            this.bt_insert_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_insert_member.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.bt_insert_member.Location = new System.Drawing.Point(10, 139);
            this.bt_insert_member.Name = "bt_insert_member";
            this.bt_insert_member.Size = new System.Drawing.Size(196, 57);
            this.bt_insert_member.TabIndex = 0;
            this.bt_insert_member.Text = "Insert new Member";
            this.bt_insert_member.UseVisualStyleBackColor = true;
            this.bt_insert_member.Click += new System.EventHandler(this.bt_insert_member_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(744, 41);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(374, 78);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Member Management";
            // 
            // uc_MemberInsert1
            // 
            this.uc_MemberInsert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_MemberInsert1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_MemberInsert1.Location = new System.Drawing.Point(225, 0);
            this.uc_MemberInsert1.Name = "uc_MemberInsert1";
            this.uc_MemberInsert1.Size = new System.Drawing.Size(882, 559);
            this.uc_MemberInsert1.TabIndex = 7;
            // 
            // uc_MemberList1
            // 
            this.uc_MemberList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_MemberList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_MemberList1.Location = new System.Drawing.Point(225, 0);
            this.uc_MemberList1.Name = "uc_MemberList1";
            this.uc_MemberList1.Size = new System.Drawing.Size(1467, 966);
            this.uc_MemberList1.TabIndex = 8;
            // 
            // uc_MemberQuery1
            // 
            this.uc_MemberQuery1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_MemberQuery1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_MemberQuery1.Location = new System.Drawing.Point(225, 0);
            this.uc_MemberQuery1.Name = "uc_MemberQuery1";
            this.uc_MemberQuery1.Size = new System.Drawing.Size(1152, 702);
            this.uc_MemberQuery1.TabIndex = 9;
            // 
            // uc_MemberUpdate1
            // 
            this.uc_MemberUpdate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.uc_MemberUpdate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_MemberUpdate1.Location = new System.Drawing.Point(225, 0);
            this.uc_MemberUpdate1.Name = "uc_MemberUpdate1";
            this.uc_MemberUpdate1.Size = new System.Drawing.Size(943, 966);
            this.uc_MemberUpdate1.TabIndex = 10;
            // 
            // Member_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1691, 966);
            this.Controls.Add(this.uc_MemberList1);
            this.Controls.Add(this.uc_MemberUpdate1);
            this.Controls.Add(this.uc_MemberQuery1);
            this.Controls.Add(this.uc_MemberInsert1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Member_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member_management";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Member_management_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lb1;
        private Button bt_insert_member;
        private Button bt_member_list;
        private PictureBox pictureBox2;
        private Button bt_query;
        private Button bt_update;
        private uc_MemberInsert uc_MemberInsert1;
        private uc_MemberList uc_MemberList1;
        private uc_MemberQuery uc_MemberQuery1;
        private uc_MemberUpdate uc_MemberUpdate1;
    }
}