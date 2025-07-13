using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormSach : Form
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();

        public FormSach()
        {
            InitializeComponent();

            // Gán sự kiện cho các button sau khi InitializeComponent
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnTaiLai.Click += btnTaiLai_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dvgHienThi.CellClick += dvgHienThi_CellClick;
            cbbMaSach.SelectedIndexChanged += cbbMaSach_SelectedIndexChanged;
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void LoadData()
        {
            var ds = from s in db.SACHes
                     select s;
            dvgHienThi.DataSource = ds.ToList();
        }

        private void LoadComboBox()
        {
            cbbMaSach.DataSource = db.SACHes.Select(s => s.MaSach).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.SACHes.Any(s => s.MaSach == txtMaSach.Text))
                {
                    MessageBox.Show("Mã sách đã tồn tại!");
                    return;
                }

                SACH sachMoi = new SACH
                {
                    MaSach = txtMaSach.Text.Trim(),
                    Tensach = txtTenSach.Text.Trim(),
                    Tacgia = txtTacGia.Text.Trim(),
                    Namxuatban = int.Parse(txtNamXB.Text.Trim()),
                    Nhaxuatban = txtNhaXB.Text.Trim(),
                    Trigia = Convert.ToDouble(txtTriGia.Text.Trim()),
                    NgayNhap = dateTimePicker1.Value
                };
                db.SACHes.InsertOnSubmit(sachMoi);
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
                var sach = db.SACHes.FirstOrDefault(x => x.MaSach == txtMaSach.Text);
                if (sach != null)
                {
                    sach.Tensach = txtTenSach.Text.Trim();
                    sach.Tacgia = txtTacGia.Text.Trim();
                    sach.Namxuatban = int.Parse(txtNamXB.Text.Trim());
                    sach.Nhaxuatban = txtNhaXB.Text.Trim();
                    sach.Trigia = Convert.ToDouble(txtTriGia.Text.Trim());
                    sach.NgayNhap = dateTimePicker1.Value;
                    db.SubmitChanges();
                    LoadData();
                    LoadComboBox();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách để sửa!");
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
                var sach = db.SACHes.FirstOrDefault(x => x.MaSach == txtMaSach.Text);
                if (sach != null)
                {
                    db.SACHes.DeleteOnSubmit(sach);
                    db.SubmitChanges();
                    LoadData();
                    LoadComboBox();
                    MessageBox.Show("Xoá thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách để xoá!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXB.Clear();
            txtNhaXB.Clear();
            txtTriGia.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cbbMaSach.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var sach = db.SACHes.FirstOrDefault(s => s.MaSach == txttimMaSach.Text);
            if (sach != null)
            {
                txtMaSach.Text = sach.MaSach;
                txtTenSach.Text = sach.Tensach;
                txtTacGia.Text = sach.Tacgia;
                txtNamXB.Text = sach.Namxuatban.ToString();
                txtNhaXB.Text = sach.Nhaxuatban;
                txtTriGia.Text = sach.Trigia.ToString();
                dateTimePicker1.Value = sach.NgayNhap ?? DateTime.Now;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách!");
            }
        }

        private void dvgHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dvgHienThi.Rows.Count)
            {
                txtMaSach.Text = dvgHienThi.Rows[index].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dvgHienThi.Rows[index].Cells["Tensach"].Value.ToString();
                txtTacGia.Text = dvgHienThi.Rows[index].Cells["Tacgia"].Value.ToString();
                txtNamXB.Text = dvgHienThi.Rows[index].Cells["Namxuatban"].Value.ToString();
                txtNhaXB.Text = dvgHienThi.Rows[index].Cells["Nhaxuatban"].Value.ToString();
                txtTriGia.Text = dvgHienThi.Rows[index].Cells["Trigia"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dvgHienThi.Rows[index].Cells["NgayNhap"].Value);
            }
        }

        private void cbbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSach.SelectedIndex == -1) return;

            string ma = cbbMaSach.Text;
            var sach = db.SACHes.FirstOrDefault(s => s.MaSach == ma);
            if (sach != null)
            {
                txtMaSach.Text = sach.MaSach;
                txtTenSach.Text = sach.Tensach;
                txtTacGia.Text = sach.Tacgia;
                txtNamXB.Text = sach.Namxuatban.ToString();
                txtNhaXB.Text = sach.Nhaxuatban;
                txtTriGia.Text = sach.Trigia.ToString();
                dateTimePicker1.Value = sach.NgayNhap ?? DateTime.Now;
            }
        }

        private void ThongTinSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang Thông Tin Sách.");
        }

        private void ThongTinMuonSach_Click(object sender, EventArgs e)
        {
            FormMuonSach form = new FormMuonSach();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Dummy method to fix CS1061 error
        }

        private void txtTriGia_TextChanged(object sender, EventArgs e)
        {
            // Dummy method to fix CS1061 error
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dummy method to fix CS1061 error
        }

        private void btnFormSach_Click(object sender, EventArgs e)
        {
            FormMuonSach f = new FormMuonSach();  // Tạo đối tượng form
            f.ShowDialog(); // Mở form dưới dạng hộp thoại (modal), chặn form cũ cho tới khi đóng
                            // Nếu muốn mở song song thì dùng: f.Show();
        }

    }
}