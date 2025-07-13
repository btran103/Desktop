namespace QuanLyThuVien
{
    partial class FormSach
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
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblLocMaSach = new System.Windows.Forms.Label();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblTriGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTimMaSach = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txttimMaSach = new System.Windows.Forms.TextBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.dvgHienThi = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFormSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(7, 196);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(63, 16);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã Sách:";
            // 
            // lblLocMaSach
            // 
            this.lblLocMaSach.AutoSize = true;
            this.lblLocMaSach.Location = new System.Drawing.Point(367, 347);
            this.lblLocMaSach.Name = "lblLocMaSach";
            this.lblLocMaSach.Size = new System.Drawing.Size(88, 16);
            this.lblLocMaSach.TabIndex = 1;
            this.lblLocMaSach.Text = "Lọc Mã Sách:";
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(20, 374);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(55, 16);
            this.lblNXB.TabIndex = 2;
            this.lblNXB.Text = "Nhà XB:";
            // 
            // lblTriGia
            // 
            this.lblTriGia.AutoSize = true;
            this.lblTriGia.Location = new System.Drawing.Point(392, 242);
            this.lblTriGia.Name = "lblTriGia";
            this.lblTriGia.Size = new System.Drawing.Size(50, 16);
            this.lblTriGia.TabIndex = 3;
            this.lblTriGia.Text = "Trị Giá:";
            this.lblTriGia.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(7, 242);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(68, 16);
            this.lblTenSach.TabIndex = 4;
            this.lblTenSach.Text = "Tên Sách:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(17, 288);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(58, 16);
            this.lblTacGia.TabIndex = 5;
            this.lblTacGia.Text = "Tác Giả:";
            // 
            // lblTimMaSach
            // 
            this.lblTimMaSach.AutoSize = true;
            this.lblTimMaSach.Location = new System.Drawing.Point(366, 291);
            this.lblTimMaSach.Name = "lblTimMaSach";
            this.lblTimMaSach.Size = new System.Drawing.Size(89, 16);
            this.lblTimMaSach.TabIndex = 6;
            this.lblTimMaSach.Text = "Tìm Mã Sách:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(343, 196);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(111, 16);
            this.lblNgayNhap.TabIndex = 7;
            this.lblNgayNhap.Text = "Ngày Nhập sách:";
            // 
            // lblNamXB
            // 
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Location = new System.Drawing.Point(12, 326);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Size = new System.Drawing.Size(59, 16);
            this.lblNamXB.TabIndex = 8;
            this.lblNamXB.Text = "Năm XB:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(720, 168);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(720, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(720, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(720, 299);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(115, 23);
            this.btnTaiLai.TabIndex = 12;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(720, 344);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 23);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(460, 343);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(225, 24);
            this.cbbMaSach.TabIndex = 14;
            this.cbbMaSach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(87, 371);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(213, 22);
            this.txtNhaXB.TabIndex = 16;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(87, 326);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(213, 22);
            this.txtNamXB.TabIndex = 17;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(87, 285);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(213, 22);
            this.txtTacGia.TabIndex = 18;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(86, 242);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(214, 22);
            this.txtTenSach.TabIndex = 19;
            // 
            // txttimMaSach
            // 
            this.txttimMaSach.Location = new System.Drawing.Point(460, 285);
            this.txttimMaSach.Name = "txttimMaSach";
            this.txttimMaSach.Size = new System.Drawing.Size(225, 22);
            this.txttimMaSach.TabIndex = 20;
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(460, 239);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(225, 22);
            this.txtTriGia.TabIndex = 21;
            this.txtTriGia.TextChanged += new System.EventHandler(this.txtTriGia_TextChanged);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(87, 196);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(213, 22);
            this.txtMaSach.TabIndex = 22;
            // 
            // dvgHienThi
            // 
            this.dvgHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.Tacgia,
            this.Namxuatban,
            this.Nhaxuatban,
            this.Trigia,
            this.NgayNhap});
            this.dvgHienThi.Location = new System.Drawing.Point(10, 12);
            this.dvgHienThi.Name = "dvgHienThi";
            this.dvgHienThi.RowHeadersWidth = 51;
            this.dvgHienThi.RowTemplate.Height = 24;
            this.dvgHienThi.Size = new System.Drawing.Size(825, 138);
            this.dvgHienThi.TabIndex = 23;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "Tensach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // Tacgia
            // 
            this.Tacgia.DataPropertyName = "Tacgia";
            this.Tacgia.HeaderText = "Tác Giả";
            this.Tacgia.MinimumWidth = 6;
            this.Tacgia.Name = "Tacgia";
            this.Tacgia.Width = 125;
            // 
            // Namxuatban
            // 
            this.Namxuatban.DataPropertyName = "Namxuatban";
            this.Namxuatban.HeaderText = "Năm XB";
            this.Namxuatban.MinimumWidth = 6;
            this.Namxuatban.Name = "Namxuatban";
            this.Namxuatban.Width = 125;
            // 
            // Nhaxuatban
            // 
            this.Nhaxuatban.DataPropertyName = "Nhaxuatban";
            this.Nhaxuatban.HeaderText = "Nhà XB";
            this.Nhaxuatban.MinimumWidth = 6;
            this.Nhaxuatban.Name = "Nhaxuatban";
            this.Nhaxuatban.Width = 125;
            // 
            // Trigia
            // 
            this.Trigia.DataPropertyName = "Trigia";
            this.Trigia.HeaderText = "Trị Giá";
            this.Trigia.MinimumWidth = 6;
            this.Trigia.Name = "Trigia";
            this.Trigia.Width = 125;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 125;
            // 
            // btnFormSach
            // 
            this.btnFormSach.Location = new System.Drawing.Point(720, 384);
            this.btnFormSach.Name = "btnFormSach";
            this.btnFormSach.Size = new System.Drawing.Size(115, 23);
            this.btnFormSach.TabIndex = 24;
            this.btnFormSach.Text = "FormMuonSach";
            this.btnFormSach.UseVisualStyleBackColor = true;
            this.btnFormSach.Click += new System.EventHandler(this.btnFormSach_Click);
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(860, 419);
            this.Controls.Add(this.btnFormSach);
            this.Controls.Add(this.dvgHienThi);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtTriGia);
            this.Controls.Add(this.txttimMaSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.txtNhaXB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbMaSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNamXB);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblTimMaSach);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblTriGia);
            this.Controls.Add(this.lblNXB);
            this.Controls.Add(this.lblLocMaSach);
            this.Controls.Add(this.lblMaSach);
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblLocMaSach;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTriGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTimMaSach;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txttimMaSach;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.DataGridView dvgHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.Button btnFormSach;
    }
}