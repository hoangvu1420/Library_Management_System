using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_MemberQuery
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
            this.dGV_result = new System.Windows.Forms.DataGridView();
            this.cB_query = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_result);
            this.groupBox2.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(35, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 513);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // dGV_result
            // 
            this.dGV_result.AllowUserToAddRows = false;
            this.dGV_result.AllowUserToDeleteRows = false;
            this.dGV_result.AllowUserToResizeRows = false;
            this.dGV_result.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dGV_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_result.Location = new System.Drawing.Point(14, 28);
            this.dGV_result.Name = "dGV_result";
            this.dGV_result.ReadOnly = true;
            this.dGV_result.RowHeadersWidth = 51;
            this.dGV_result.RowTemplate.Height = 29;
            this.dGV_result.Size = new System.Drawing.Size(1052, 468);
            this.dGV_result.TabIndex = 0;
            // 
            // cB_query
            // 
            this.cB_query.Font = new System.Drawing.Font("Lora", 11F);
            this.cB_query.FormattingEnabled = true;
            this.cB_query.Items.AddRange(new object[] {
            "Number of loans by each member",
            "Membership that about to expire",
            "Number of fines by each member",
            "Payment statistics of each member"});
            this.cB_query.Location = new System.Drawing.Point(179, 106);
            this.cB_query.Name = "cB_query";
            this.cB_query.Size = new System.Drawing.Size(414, 35);
            this.cB_query.TabIndex = 59;
            this.cB_query.SelectedIndexChanged += new System.EventHandler(this.cB_query_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lora", 11F);
            this.label14.Location = new System.Drawing.Point(35, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 29);
            this.label14.TabIndex = 58;
            this.label14.Text = "Choose query:";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(530, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(129, 78);
            this.lb1.TabIndex = 57;
            this.lb1.Text = "Query";
            // 
            // uc_MemberQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cB_query);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb1);
            this.Name = "uc_MemberQuery";
            this.Size = new System.Drawing.Size(1152, 702);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dGV_result;
        private ComboBox cB_query;
        private Label label14;
        private Label lb1;
    }
}
