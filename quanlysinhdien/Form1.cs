using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLiSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnDangNhap.Click += BtnDangNhap_Click; // Gán sự kiện nếu chưa gán trong Designer
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLiSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txtUser.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");

                        // Mở Form chính ở đây (ví dụ: FormMain)
                        Form2 frm = new Form2(); // Nhớ tạo FormMain trước
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
        }
    }
}
