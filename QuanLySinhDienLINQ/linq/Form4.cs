using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form4 : Form
    {
        QLiSinhVienDataContext db = new QLiSinhVienDataContext();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadKhoa();
        }

        private void LoadKhoa()
        {
            var ds = from k in db.KHOAs
                     select new { k.MaKhoa, k.TenKhoa };
            dataGridView2.DataSource = ds;

            // Đặt tên cho cột để có thể truy cập bằng tên trong CellClick
            dataGridView2.Columns[0].Name = "MaKhoa";
            dataGridView2.Columns[1].Name = "TenKhoa";
        }

        private void btnThemkhoa_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "" || txtTenkhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            KHOA k = new KHOA();
            k.MaKhoa = txtMakhoa.Text;
            k.TenKhoa = txtTenkhoa.Text;

            db.KHOAs.InsertOnSubmit(k);
            db.SubmitChanges();
            LoadKhoa();
        }

        private void btnXoakhoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Khoa này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var k = db.KHOAs.FirstOrDefault(x => x.MaKhoa == txtMakhoa.Text);
                if (k != null)
                {
                    db.KHOAs.DeleteOnSubmit(k);
                    try
                    {
                        db.SubmitChanges();
                        LoadKhoa();
                    }
                    catch
                    {
                        MessageBox.Show("Xóa không thành công (có thể đang được liên kết với SinhVien)");
                    }
                }
            }
        }

        private void btnSuakhoa_Click(object sender, EventArgs e)
        {
            var k = db.KHOAs.FirstOrDefault(x => x.MaKhoa == txtMakhoa.Text);
            if (k != null)
            {
                k.TenKhoa = txtTenkhoa.Text;
                db.SubmitChanges();
                LoadKhoa();
            }
        }

        private void btnTailaiKhoa_Click(object sender, EventArgs e)
        {
            LoadKhoa();
            txtMakhoa.Clear();
            txtTenkhoa.Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMakhoa.Text = dataGridView2.Rows[index].Cells["MaKhoa"].Value.ToString();
                txtTenkhoa.Text = dataGridView2.Rows[index].Cells["TenKhoa"].Value.ToString();
            }
        }
    }
}