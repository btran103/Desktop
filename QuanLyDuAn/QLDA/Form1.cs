using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class Form1 : Form
    {
        /*-------------------------------------------------
         * 0. CHUỖI KẾT NỐI
         *------------------------------------------------*/
        private readonly string _cnnStr =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        // ‑ Nếu dùng SQL Login: Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;User ID=sa;Password=123

        public Form1()
        {
            InitializeComponent();

            /* Cho phép nhấn ENTER để login */
            this.AcceptButton = btnDangNhap;

            /* Gắn sự kiện (nếu chưa cắm trong Designer) */
            this.Load += Form1_Load;
            btnDangNhap.Click += BtnDangNhap_Click;
        }

        /*-------------------------------------------------
         * 1. FORM LOAD – Focus vào ô User
         *------------------------------------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        /*-------------------------------------------------
         * 2. NÚT ĐĂNG NHẬP
         *------------------------------------------------*/
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập Tên ĐN và Mật khẩu!",
                                "Thiếu dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cnn = new SqlConnection(_cnnStr))
                {
                    cnn.Open();
                    string sql = "SELECT COUNT(*) FROM Account WHERE UserName=@u AND Password=@p";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@u", user);
                        cmd.Parameters.AddWithValue("@p", pass);

                        int kq = (int)cmd.ExecuteScalar();
                        if (kq > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            /* Ẩn Form1 → mở Form2 (màn hình chính) */
                            this.Hide();
                            Form2 main = new Form2(user);       // cần constructor Form2(string user)
                            main.FormClosed += (s, ev) => this.Close(); // tắt app khi Form2 đóng
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai Tên ĐN hoặc Mật khẩu!",
                                            "Đăng nhập thất bại",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPass.Clear();
                            txtPass.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
