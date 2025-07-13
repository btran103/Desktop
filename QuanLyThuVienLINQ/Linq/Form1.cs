using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        // Khởi tạo đối tượng DataContext (sau khi kéo bảng vào file .dbml)
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();

        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện
            btnDangNhap.Click += BtnDangNhap_Click;
            btnThoat.Click += (s, e) => Application.Exit();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string matKhau = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo");
                return;
            }

            // Kiểm tra tài khoản trong bảng TAIKHOAN
            var taiKhoan = db.TAIKHOANs
                .FirstOrDefault(t => t.TenDangNhap == tenDN && t.MatKhau == matKhau);

            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                // Mở form quản lý sách sau khi đăng nhập thành công
                FormSach frm = new FormSach();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Cảnh báo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc viết gì đó nếu cần
        }
    }
}
