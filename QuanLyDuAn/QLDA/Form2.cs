using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class Form2 : Form
    {
        // Lưu tên đăng nhập để chào người dùng
        private readonly string _tenDangNhap;

        /// <summary>
        /// Constructor nhận tên đăng nhập từ Form1
        /// </summary>
        public Form2(string tenDangNhap)
        {
            InitializeComponent();
            _tenDangNhap = tenDangNhap;

            // Gắn sự kiện (trừ Thoát đã gắn sẵn trong Designer)
            thongTinToolStripMenuItem.Click += thongTinToolStripMenuItem_Click;
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            monAnToolStripMenuItem.Click += monAnToolStripMenuItem_Click;

            // Gắn sự kiện Form_Load
            this.Load += Form2_Load;
        }

        /// <summary>
        /// Hiển thị lời chào khi form chính mở ra
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            lblChao.Text = $"Xin chào, {_tenDangNhap}!";
        }

        /// <summary>
        /// Menu: Thông tin Project
        /// </summary>
        private void thongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Đồ án: Quản lý quán ăn nhanh\n" +
                "Thành viên: …\n" +
                "Giảng viên hướng dẫn: …",
                "Thông tin Project",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Menu: Nhân viên – mở form quản lý nhân viên
        /// </summary>
        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new Form3())
                {
                    f.ShowDialog(this);
                }
            }
            catch
            {
                MessageBox.Show("Chức năng quản lý nhân viên chưa được triển khai.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Menu: Món ăn – mở form gọi món / quản lý thực đơn
        /// </summary>
        private void monAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new Form4())
                {
                    f.ShowDialog(this);
                }
            }
            catch
            {
                MessageBox.Show("Chức năng quản lý món ăn chưa được triển khai.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Menu: Thoát ứng dụng
        /// (đã gắn trong Designer, nhưng viết lại ở đây để hoàn chỉnh)
        /// </summary>
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
