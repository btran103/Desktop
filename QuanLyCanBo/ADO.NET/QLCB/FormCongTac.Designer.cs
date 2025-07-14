namespace QuanLyCanBo
{
    partial class FormCongTac
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
            this.lblMaCV = new System.Windows.Forms.Label();
            this.lblTenCV = new System.Windows.Forms.Label();
            this.lblTienLuong = new System.Windows.Forms.Label();
            this.txtTienLuong = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnFormTienLuong = new System.Windows.Forms.Button();
            this.dgvCongTac = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaCV
            // 
            this.lblMaCV.AutoSize = true;
            this.lblMaCV.Location = new System.Drawing.Point(41, 214);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(50, 16);
            this.lblMaCV.TabIndex = 0;
            this.lblMaCV.Text = "Mã CV:";
            // 
            // lblTenCV
            // 
            this.lblTenCV.AutoSize = true;
            this.lblTenCV.Location = new System.Drawing.Point(41, 270);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(55, 16);
            this.lblTenCV.TabIndex = 1;
            this.lblTenCV.Text = "Tên CV:";
            // 
            // lblTienLuong
            // 
            this.lblTienLuong.AutoSize = true;
            this.lblTienLuong.Location = new System.Drawing.Point(41, 331);
            this.lblTienLuong.Name = "lblTienLuong";
            this.lblTienLuong.Size = new System.Drawing.Size(77, 16);
            this.lblTienLuong.TabIndex = 2;
            this.lblTienLuong.Text = "Tiền Lương:";
            // 
            // txtTienLuong
            // 
            this.txtTienLuong.Location = new System.Drawing.Point(137, 328);
            this.txtTienLuong.Name = "txtTienLuong";
            this.txtTienLuong.Size = new System.Drawing.Size(192, 22);
            this.txtTienLuong.TabIndex = 4;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(137, 264);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(192, 22);
            this.txtTenCV.TabIndex = 5;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(137, 208);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(192, 22);
            this.txtMaCV.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(399, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(522, 198);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(399, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(522, 263);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 10;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnFormTienLuong
            // 
            this.btnFormTienLuong.Location = new System.Drawing.Point(460, 313);
            this.btnFormTienLuong.Name = "btnFormTienLuong";
            this.btnFormTienLuong.Size = new System.Drawing.Size(106, 23);
            this.btnFormTienLuong.TabIndex = 11;
            this.btnFormTienLuong.Text = "FormLuong";
            this.btnFormTienLuong.UseVisualStyleBackColor = true;
            // 
            // dgvCongTac
            // 
            this.dgvCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.TienLuong});
            this.dgvCongTac.Location = new System.Drawing.Point(12, 12);
            this.dgvCongTac.Name = "dgvCongTac";
            this.dgvCongTac.RowHeadersWidth = 51;
            this.dgvCongTac.RowTemplate.Height = 24;
            this.dgvCongTac.Size = new System.Drawing.Size(613, 150);
            this.dgvCongTac.TabIndex = 12;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Công tác";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.Width = 125;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.Width = 125;
            // 
            // TienLuong
            // 
            this.TienLuong.DataPropertyName = "TienLuong";
            this.TienLuong.HeaderText = "Tiền Lương";
            this.TienLuong.MinimumWidth = 6;
            this.TienLuong.Name = "TienLuong";
            this.TienLuong.Width = 125;
            // 
            // FormCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(637, 382);
            this.Controls.Add(this.dgvCongTac);
            this.Controls.Add(this.btnFormTienLuong);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtTienLuong);
            this.Controls.Add(this.lblTienLuong);
            this.Controls.Add(this.lblTenCV);
            this.Controls.Add(this.lblMaCV);
            this.Name = "FormCongTac";
            this.Text = "FormCongTac";
            this.Load += new System.EventHandler(this.FormCongTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCV;
        private System.Windows.Forms.Label lblTenCV;
        private System.Windows.Forms.Label lblTienLuong;
        private System.Windows.Forms.TextBox txtTienLuong;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnFormTienLuong;
        private System.Windows.Forms.DataGridView dgvCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
    }
}