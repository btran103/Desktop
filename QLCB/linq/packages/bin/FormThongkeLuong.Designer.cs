namespace QLCB
{
    partial class FormThongkeLuong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoNgayCong,
            this.TienLuong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // SoNgayCong
            // 
            this.SoNgayCong.DataPropertyName = "SoNgayCong";
            this.SoNgayCong.HeaderText = "Ngày Công";
            this.SoNgayCong.MinimumWidth = 6;
            this.SoNgayCong.Name = "SoNgayCong";
            this.SoNgayCong.Width = 125;
            // 
            // TienLuong
            // 
            this.TienLuong.DataPropertyName = "TienLuong";
            this.TienLuong.HeaderText = "Tiền Lương";
            this.TienLuong.MinimumWidth = 6;
            this.TienLuong.Name = "TienLuong";
            this.TienLuong.Width = 125;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(300, 240);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(131, 32);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.AutoSize = true;
            this.lblTongLuong.Location = new System.Drawing.Point(43, 191);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(82, 16);
            this.lblTongLuong.TabIndex = 2;
            this.lblTongLuong.Text = "Tổng Lương:";
            // 
            // FormThongkeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 292);
            this.Controls.Add(this.lblTongLuong);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormThongkeLuong";
            this.Text = "FormThongkeLuong";
            this.Load += new System.EventHandler(this.FormThongkeLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
    }
}