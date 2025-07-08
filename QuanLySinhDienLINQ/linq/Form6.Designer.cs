namespace QuanLySinhVien
{
    partial class Form6
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblMaso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTailaiMH = new System.Windows.Forms.Button();
            this.cbbMS = new System.Windows.Forms.ComboBox();
            this.txtTMH = new System.Windows.Forms.TextBox();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMH,
            this.MaMH});
            this.dataGridView3.Location = new System.Drawing.Point(12, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(452, 120);
            this.dataGridView3.TabIndex = 0;
            // 
            // lblMaso
            // 
            this.lblMaso.AutoSize = true;
            this.lblMaso.Location = new System.Drawing.Point(50, 166);
            this.lblMaso.Name = "lblMaso";
            this.lblMaso.Size = new System.Drawing.Size(47, 16);
            this.lblMaso.TabIndex = 1;
            this.lblMaso.Text = "Mã số:";
            this.lblMaso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn học:";
            // 
            // btnTailaiMH
            // 
            this.btnTailaiMH.Location = new System.Drawing.Point(320, 163);
            this.btnTailaiMH.Name = "btnTailaiMH";
            this.btnTailaiMH.Size = new System.Drawing.Size(144, 59);
            this.btnTailaiMH.TabIndex = 3;
            this.btnTailaiMH.Text = "Tải lại";
            this.btnTailaiMH.UseVisualStyleBackColor = true;
            // 
            // cbbMS
            // 
            this.cbbMS.FormattingEnabled = true;
            this.cbbMS.Location = new System.Drawing.Point(103, 163);
            this.cbbMS.Name = "cbbMS";
            this.cbbMS.Size = new System.Drawing.Size(177, 24);
            this.cbbMS.TabIndex = 4;
            // 
            // txtTMH
            // 
            this.txtTMH.Location = new System.Drawing.Point(103, 200);
            this.txtTMH.Name = "txtTMH";
            this.txtTMH.Size = new System.Drawing.Size(177, 22);
            this.txtTMH.TabIndex = 5;
            // 
            // TenMH
            // 
            this.TenMH.HeaderText = "TMH";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 125;
            // 
            // MaMH
            // 
            this.MaMH.HeaderText = "MMH";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 249);
            this.Controls.Add(this.txtTMH);
            this.Controls.Add(this.cbbMS);
            this.Controls.Add(this.btnTailaiMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaso);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblMaso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTailaiMH;
        private System.Windows.Forms.ComboBox cbbMS;
        private System.Windows.Forms.TextBox txtTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
    }
}