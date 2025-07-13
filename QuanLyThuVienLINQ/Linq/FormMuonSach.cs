using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormMuonSach : Form
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();

        public FormMuonSach()
        {
            InitializeComponent();
        }

        private void FormMuonSach_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void LoadData()
        {
            var muon = from pm in db.PHIEUMUONSACHes
                       join ct in db.THONGTINMUONSACHes on pm.MaPhieuMuon equals ct.MaPhieuMuon
                       join s in db.SACHes on ct.MaSach equals s.MaSach
                       select new
                       {
                           pm.MaPhieuMuon,
                           pm.NgayMuon,
                           pm.NgayTra,
                           ct.MaSach,
                           s.Tensach
                       };
            dvgMuonSach.DataSource = muon.ToList();
        }

        private void LoadComboBox()
        {
            cbbMaPhieu.DataSource = db.PHIEUMUONSACHes.Select(m => m.MaPhieuMuon).ToList();
            cbbMaSach.DataSource = db.SACHes.Select(s => s.MaSach).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || cbbMaSach.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Thêm vào bảng PHIEUMUONSACH
                PHIEUMUONSACH pms = new PHIEUMUONSACH
                {
                    MaPhieuMuon = txtMaPhieu.Text,
                    NgayMuon = dtpNgayMuon.Value,
                    NgayTra = dtpNgayTra.Value
                };
                db.PHIEUMUONSACHes.InsertOnSubmit(pms);

                // Thêm vào bảng THONGTINMUONSACH
                THONGTINMUONSACH ct = new THONGTINMUONSACH
                {
                    MaPhieuMuon = txtMaPhieu.Text,
                    MaSach = cbbMaSach.Text
                };
                db.THONGTINMUONSACHes.InsertOnSubmit(ct);

                db.SubmitChanges();
                LoadData();
                LoadComboBox();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var pms = db.PHIEUMUONSACHes.FirstOrDefault(m => m.MaPhieuMuon == txtMaPhieu.Text);
                var ct = db.THONGTINMUONSACHes.FirstOrDefault(c => c.MaPhieuMuon == txtMaPhieu.Text);

                if (pms != null && ct != null)
                {
                    pms.NgayMuon = dtpNgayMuon.Value;
                    pms.NgayTra = dtpNgayTra.Value;
                    ct.MaSach = cbbMaSach.Text;

                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var ct = db.THONGTINMUONSACHes.FirstOrDefault(c => c.MaPhieuMuon == txtMaPhieu.Text);
                var pms = db.PHIEUMUONSACHes.FirstOrDefault(m => m.MaPhieuMuon == txtMaPhieu.Text);

                if (ct != null) db.THONGTINMUONSACHes.DeleteOnSubmit(ct);
                if (pms != null) db.PHIEUMUONSACHes.DeleteOnSubmit(pms);

                db.SubmitChanges();
                LoadData();
                LoadComboBox();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
            txtMaPhieu.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var ms = (from pm in db.PHIEUMUONSACHes
                      join ct in db.THONGTINMUONSACHes on pm.MaPhieuMuon equals ct.MaPhieuMuon
                      where pm.MaPhieuMuon == cbbMaPhieu.Text
                      select new { pm, ct }).FirstOrDefault();

            if (ms != null)
            {
                txtMaPhieu.Text = ms.pm.MaPhieuMuon;
                dtpNgayMuon.Value = ms.pm.NgayMuon ?? DateTime.Now;
                dtpNgayTra.Value = ms.pm.NgayTra ?? DateTime.Now;
                cbbMaSach.Text = ms.ct.MaSach;
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu mượn!");
            }
        }

        private void dvgMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPhieu.Text = dvgMuonSach.Rows[index].Cells["MaPhieuMuon"].Value?.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(dvgMuonSach.Rows[index].Cells["NgayMuon"].Value);
                dtpNgayTra.Value = Convert.ToDateTime(dvgMuonSach.Rows[index].Cells["NgayTra"].Value);
                cbbMaSach.Text = dvgMuonSach.Rows[index].Cells["MaSach"].Value?.ToString();
            }
        }

        private void dvgMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý nếu chưa có gì
        }
    }
}
