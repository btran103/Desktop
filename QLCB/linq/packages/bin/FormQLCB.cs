using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCB
{
    public partial class FormQLCB : Form
    {
        QLCanBoDataContext db = new QLCanBoDataContext();

        public FormQLCB()
        {
            InitializeComponent();
            thongKeLuongToolStripMenuItem.Click += thongKeLuongToolStripMenuItem_Click;
        }

        private void FormQLCB_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadGioiTinh();
        }

        private void LoadData()
        {
            var query = from cb in db.CanBos
                        join tl in db.TienLuongs on cb.MaCB equals tl.MaCB
                        join cv in db.CongTacs on tl.MaCV equals cv.MaCV
                        select new
                        {
                            cb.MaCB,
                            cb.HoTen,
                            cb.NgaySinh,
                            cb.GioiTinh,
                            tl.MaCV,
                            cv.TenCV,
                            cb.HeSoLuong
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void LoadGioiTinh()
        {
            cbbGioiTinh.Items.Clear();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
        }

        private void thongKeLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thống kê lương đang phát triển...", "Thông báo");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCB.Text != "")
            {
                CanBo cb = new CanBo
                {
                    MaCB = txtMaCB.Text,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dtpGioiTinh.Value,
                    GioiTinh = cbbGioiTinh.Text,
                    HeSoLuong = float.Parse(txtHSL.Text)
                };

                db.CanBos.InsertOnSubmit(cb);
                db.SubmitChanges();

                TienLuong tl = new TienLuong
                {
                    MaCB = txtMaCB.Text,
                    MaCV = txtMaCV.Text,
                    SoNgayCong = 26
                };

                if (db.CongTacs.SingleOrDefault(c => c.MaCV == txtMaCV.Text) == null)
                {
                    CongTac cv = new CongTac
                    {
                        MaCV = txtMaCV.Text,
                        TenCV = txtTenCV.Text,
                        TienLuong = 1000000
                    };
                    db.CongTacs.InsertOnSubmit(cv);
                    db.SubmitChanges();
                }

                db.TienLuongs.InsertOnSubmit(tl);
                db.SubmitChanges();

                LoadData();
                MessageBox.Show("Đã thêm cán bộ.");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var macb = txtMaCB.Text;
            var cb = db.CanBos.SingleOrDefault(c => c.MaCB == macb);
            if (cb != null)
            {
                var tl = db.TienLuongs.Where(t => t.MaCB == macb);
                db.TienLuongs.DeleteAllOnSubmit(tl);
                db.CanBos.DeleteOnSubmit(cb);
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Đã xóa cán bộ.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cb = db.CanBos.SingleOrDefault(c => c.MaCB == txtMaCB.Text);
            if (cb != null)
            {
                cb.HoTen = txtHoTen.Text;
                cb.GioiTinh = cbbGioiTinh.Text;
                cb.NgaySinh = dtpGioiTinh.Value;
                cb.HeSoLuong = float.Parse(txtHSL.Text);
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Đã cập nhật.");
            }
        }
    }
}
