namespace QuanLyThuVien
{
    partial class FormMuonSach
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
            this.cbbMaPhieu = new System.Windows.Forms.ComboBox();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbbchonMaPhieu = new System.Windows.Forms.Label();
            this.lbbMaPhieu = new System.Windows.Forms.Label();
            this.dvgMuonSach = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaPhieu
            // 
            this.cbbMaPhieu.FormattingEnabled = true;
            this.cbbMaPhieu.Location = new System.Drawing.Point(401, 283);
            this.cbbMaPhieu.Name = "cbbMaPhieu";
            this.cbbMaPhieu.Size = new System.Drawing.Size(170, 24);
            this.cbbMaPhieu.TabIndex = 0;
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(401, 220);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(170, 24);
            this.cbbMaSach.TabIndex = 1;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(19, 257);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(79, 16);
            this.lblNgayMuon.TabIndex = 2;
            this.lblNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(332, 223);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(63, 16);
            this.lblMaSach.TabIndex = 3;
            this.lblMaSach.Text = "Mã Sách:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(32, 310);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(61, 16);
            this.lblNgayTra.TabIndex = 4;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(104, 257);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayMuon.TabIndex = 5;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(104, 310);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayTra.TabIndex = 6;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(104, 206);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhieu.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(620, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(620, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(620, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(620, 300);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 11;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(620, 338);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // lbbchonMaPhieu
            // 
            this.lbbchonMaPhieu.AutoSize = true;
            this.lbbchonMaPhieu.Location = new System.Drawing.Point(331, 286);
            this.lbbchonMaPhieu.Name = "lbbchonMaPhieu";
            this.lbbchonMaPhieu.Size = new System.Drawing.Size(64, 16);
            this.lbbchonMaPhieu.TabIndex = 13;
            this.lbbchonMaPhieu.Text = "Chọn MP:";
            // 
            // lbbMaPhieu
            // 
            this.lbbMaPhieu.AutoSize = true;
            this.lbbMaPhieu.Location = new System.Drawing.Point(32, 209);
            this.lbbMaPhieu.Name = "lbbMaPhieu";
            this.lbbMaPhieu.Size = new System.Drawing.Size(65, 16);
            this.lbbMaPhieu.TabIndex = 14;
            this.lbbMaPhieu.Text = "Mã phiếu:";
            // 
            // dvgMuonSach
            // 
            this.dvgMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.NgayMuon,
            this.NgayTra});
            this.dvgMuonSach.Location = new System.Drawing.Point(12, 12);
            this.dvgMuonSach.Name = "dvgMuonSach";
            this.dvgMuonSach.RowHeadersWidth = 51;
            this.dvgMuonSach.RowTemplate.Height = 24;
            this.dvgMuonSach.Size = new System.Drawing.Size(697, 150);
            this.dvgMuonSach.TabIndex = 15;
            this.dvgMuonSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMuonSach_CellContentClick);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.Width = 125;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 125;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 125;
            // 
            // FormMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(721, 376);
            this.Controls.Add(this.dvgMuonSach);
            this.Controls.Add(this.lbbMaPhieu);
            this.Controls.Add(this.lbbchonMaPhieu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.cbbMaSach);
            this.Controls.Add(this.cbbMaPhieu);
            this.Name = "FormMuonSach";
            this.Text = "FormMuonSach";
            this.Load += new System.EventHandler(this.FormMuonSach_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaPhieu;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbbchonMaPhieu;
        private System.Windows.Forms.Label lbbMaPhieu;
        private System.Windows.Forms.DataGridView dvgMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}