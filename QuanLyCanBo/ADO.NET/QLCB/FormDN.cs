using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLCANBO;
using System.Data.Entity;



namespace QuanLyCanBo
{
    public partial class FormDN : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLCANBO;Integrated Security=True";

        public FormDN()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDN = @user AND MatKhau = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        FormCanBo f = new FormCanBo();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
        private void FormDN_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc xử lý khởi tạo
        }

    }
}
