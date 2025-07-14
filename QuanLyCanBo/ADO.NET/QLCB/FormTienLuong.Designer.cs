namespace QLCANBO
{
    partial class FormTienLuong
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
            this.lblMaCB = new System.Windows.Forms.Label();
            this.lblMaCV = new System.Windows.Forms.Label();
            this.lblSoNgayCong = new System.Windows.Forms.Label();
            this.txtSoNgayCong = new System.Windows.Forms.TextBox();
            this.cbbMaCB = new System.Windows.Forms.ComboBox();
            this.cbbMaCV = new System.Windows.Forms.ComboBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLocLuongCao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaCB
            // 
            this.lblMaCB.AutoSize = true;
            this.lblMaCB.Location = new System.Drawing.Point(38, 190);
            this.lblMaCB.Name = "lblMaCB";
            this.lblMaCB.Size = new System.Drawing.Size(50, 16);
            this.lblMaCB.TabIndex = 0;
            this.lblMaCB.Text = "Mã CB:";
            // 
            // lblMaCV
            // 
            this.lblMaCV.AutoSize = true;
            this.lblMaCV.Location = new System.Drawing.Point(38, 230);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(50, 16);
            this.lblMaCV.TabIndex = 1;
            this.lblMaCV.Text = "Mã CV:";
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.AutoSize = true;
            this.lblSoNgayCong.Location = new System.Drawing.Point(12, 270);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(93, 16);
            this.lblSoNgayCong.TabIndex = 2;
            this.lblSoNgayCong.Text = "Số ngày công:";
            // 
            // txtSoNgayCong
            // 
            this.txtSoNgayCong.Location = new System.Drawing.Point(111, 264);
            this.txtSoNgayCong.Name = "txtSoNgayCong";
            this.txtSoNgayCong.Size = new System.Drawing.Size(255, 22);
            this.txtSoNgayCong.TabIndex = 3;
            // 
            // cbbMaCB
            // 
            this.cbbMaCB.FormattingEnabled = true;
            this.cbbMaCB.Location = new System.Drawing.Point(111, 182);
            this.cbbMaCB.Name = "cbbMaCB";
            this.cbbMaCB.Size = new System.Drawing.Size(255, 24);
            this.cbbMaCB.TabIndex = 4;
            // 
            // cbbMaCV
            // 
            this.cbbMaCV.FormattingEnabled = true;
            this.cbbMaCV.Location = new System.Drawing.Point(111, 222);
            this.cbbMaCV.Name = "cbbMaCV";
            this.cbbMaCV.Size = new System.Drawing.Size(255, 24);
            this.cbbMaCV.TabIndex = 5;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(435, 182);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(118, 23);
            this.btnTinhLuong.TabIndex = 6;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(435, 227);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(118, 23);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "Hiển Thị DS";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnLocLuongCao
            // 
            this.btnLocLuongCao.Location = new System.Drawing.Point(435, 270);
            this.btnLocLuongCao.Name = "btnLocLuongCao";
            this.btnLocLuongCao.Size = new System.Drawing.Size(122, 25);
            this.btnLocLuongCao.TabIndex = 8;
            this.btnLocLuongCao.Text = "Lộc Lương Cao";
            this.btnLocLuongCao.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCB,
            this.MaCV,
            this.SoNgayCong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaCB
            // 
            this.MaCB.DataPropertyName = "MaCB";
            this.MaCB.HeaderText = "Mã CB";
            this.MaCB.MinimumWidth = 6;
            this.MaCB.Name = "MaCB";
            this.MaCB.Width = 125;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã CV";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.Width = 125;
            // 
            // SoNgayCong
            // 
            this.SoNgayCong.DataPropertyName = "SoNgayCong";
            this.SoNgayCong.HeaderText = "Số ngày công";
            this.SoNgayCong.MinimumWidth = 6;
            this.SoNgayCong.Name = "SoNgayCong";
            this.SoNgayCong.Width = 125;
            // 
            // FormTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(625, 323);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLocLuongCao);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.cbbMaCV);
            this.Controls.Add(this.cbbMaCB);
            this.Controls.Add(this.txtSoNgayCong);
            this.Controls.Add(this.lblSoNgayCong);
            this.Controls.Add(this.lblMaCV);
            this.Controls.Add(this.lblMaCB);
            this.KeyPreview = true;
            this.Name = "FormTienLuong";
            this.Text = "FormTienLuong";
            this.Load += new System.EventHandler(this.FormTienLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCB;
        private System.Windows.Forms.Label lblMaCV;
        private System.Windows.Forms.Label lblSoNgayCong;
        private System.Windows.Forms.TextBox txtSoNgayCong;
        private System.Windows.Forms.ComboBox cbbMaCB;
        private System.Windows.Forms.ComboBox cbbMaCV;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnLocLuongCao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayCong;
    }
}