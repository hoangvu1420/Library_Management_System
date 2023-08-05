using System.Drawing;
using System.Windows.Forms;

namespace Form_LMS
{
    partial class uc_BookQuery
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
            this.lb1 = new System.Windows.Forms.Label();
            this.cB_query = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gB = new System.Windows.Forms.GroupBox();
            this.dGV_result = new System.Windows.Forms.DataGridView();
            this.gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_result)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(528, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(129, 78);
            this.lb1.TabIndex = 13;
            this.lb1.Text = "Query";
            // 
            // cB_query
            // 
            this.cB_query.Font = new System.Drawing.Font("Lora", 11F);
            this.cB_query.FormattingEnabled = true;
            this.cB_query.Items.AddRange(new object[] {
            "Author list",
            "Category list",
            "Unreturned books",
            "Number of loaned times of each books"});
            this.cB_query.Location = new System.Drawing.Point(177, 106);
            this.cB_query.Name = "cB_query";
            this.cB_query.Size = new System.Drawing.Size(414, 35);
            this.cB_query.TabIndex = 55;
            this.cB_query.SelectedIndexChanged += new System.EventHandler(this.cB_query_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lora", 11F);
            this.label14.Location = new System.Drawing.Point(33, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 29);
            this.label14.TabIndex = 54;
            this.label14.Text = "Choose query:";
            // 
            // gB
            // 
            this.gB.Controls.Add(this.dGV_result);
            this.gB.Font = new System.Drawing.Font("Lora", 10F, System.Drawing.FontStyle.Bold);
            this.gB.Location = new System.Drawing.Point(33, 165);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(1082, 513);
            this.gB.TabIndex = 56;
            this.gB.TabStop = false;
            this.gB.Text = "Result";
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
            // uc_BookQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.gB);
            this.Controls.Add(this.cB_query);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb1);
            this.Name = "uc_BookQuery";
            this.Size = new System.Drawing.Size(1152, 702);
            this.gB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private ComboBox cB_query;
        private Label label14;
        private GroupBox gB;
        private DataGridView dGV_result;
    }
}
