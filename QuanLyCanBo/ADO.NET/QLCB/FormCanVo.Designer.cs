namespace QLCANBO
{
    partial class FormCanBo
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblHeSoLuong = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvCanBo = new System.Windows.Forms.DataGridView();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.menuCanbo = new System.Windows.Forms.MenuStrip();
            this.thôngTinCôngTacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTiênLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanBo)).BeginInit();
            this.menuCanbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaCB
            // 
            this.lblMaCB.AutoSize = true;
            this.lblMaCB.Location = new System.Drawing.Point(14, 238);
            this.lblMaCB.Name = "lblMaCB";
            this.lblMaCB.Size = new System.Drawing.Size(73, 16);
            this.lblMaCB.TabIndex = 0;
            this.lblMaCB.Text = "Mã cán bộ:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 278);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.AutoSize = true;
            this.lblHeSoLuong.Location = new System.Drawing.Point(9, 323);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(82, 16);
            this.lblHeSoLuong.TabIndex = 2;
            this.lblHeSoLuong.Text = "Hệ số lương:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(359, 284);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính;";
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(93, 235);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(196, 22);
            this.txtMaCB.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(93, 278);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(196, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(422, 241);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(204, 22);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(422, 284);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(196, 24);
            this.cbbGioiTinh.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(660, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(660, 271);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(660, 316);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(660, 357);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 13;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // dgvCanBo
            // 
            this.dgvCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCB,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.HeSoLuong});
            this.dgvCanBo.Location = new System.Drawing.Point(12, 44);
            this.dgvCanBo.Name = "dgvCanBo";
            this.dgvCanBo.RowHeadersWidth = 51;
            this.dgvCanBo.RowTemplate.Height = 24;
            this.dgvCanBo.Size = new System.Drawing.Size(723, 159);
            this.dgvCanBo.TabIndex = 14;
            // 
            // MaCB
            // 
            this.MaCB.DataPropertyName = "MaCB";
            this.MaCB.HeaderText = "Mã Cán Bộ";
            this.MaCB.MinimumWidth = 6;
            this.MaCB.Name = "MaCB";
            this.MaCB.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và Tên CB";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày/Tháng/Năm sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "HSL";
            this.HeSoLuong.MinimumWidth = 6;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Width = 125;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(93, 323);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(196, 22);
            this.txtHeSoLuong.TabIndex = 16;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(346, 241);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 17;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // menuCanbo
            // 
            this.menuCanbo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCanbo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCôngTacToolStripMenuItem,
            this.thôngTinTiênLươngToolStripMenuItem});
            this.menuCanbo.Location = new System.Drawing.Point(0, 0);
            this.menuCanbo.Name = "menuCanbo";
            this.menuCanbo.Size = new System.Drawing.Size(760, 28);
            this.menuCanbo.TabIndex = 18;
            this.menuCanbo.Text = "menuStrip1";
            // 
            // thôngTinCôngTacToolStripMenuItem
            // 
            this.thôngTinCôngTacToolStripMenuItem.Name = "thôngTinCôngTacToolStripMenuItem";
            this.thôngTinCôngTacToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.thôngTinCôngTacToolStripMenuItem.Text = "Thông tin công tác";
            // 
            // thôngTinTiênLươngToolStripMenuItem
            // 
            this.thôngTinTiênLươngToolStripMenuItem.Name = "thôngTinTiênLươngToolStripMenuItem";
            this.thôngTinTiênLươngToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.thôngTinTiênLươngToolStripMenuItem.Text = "Thông tin tiền lương";
            // 
            // FormCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(760, 391);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.dgvCanBo);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHeSoLuong);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaCB);
            this.Controls.Add(this.menuCanbo);
            this.MainMenuStrip = this.menuCanbo;
            this.Name = "FormCanBo";
            this.Text = "FormCanBo";
            this.Load += new System.EventHandler(this.FormCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanBo)).EndInit();
            this.menuCanbo.ResumeLayout(false);
            this.menuCanbo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCB;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView dgvCanBo;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.MenuStrip menuCanbo;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCôngTacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTiênLươngToolStripMenuItem;
    }
}