using System;
using System.Linq;
using System.Windows.Forms;
using QLCB; 


namespace QLCB
{
    public partial class FormDN : Form
    {
        // Khởi tạo DataContext để kết nối LINQ
        QLCanBoDataContext db = new QLCanBoDataContext();

        public FormDN()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra thông tin tài khoản
            var tk = db.TaiKhoans
                       .FirstOrDefault(t => t.TenDN == tenDN && t.MatKhau == matKhau);

            if (tk != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Mở form chính sau đăng nhập
                FormQLCB f = new FormQLCB();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDN.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
