using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void danhSachSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void danhSachKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void danhSachMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(); // Form6 = Danh sách môn học
            f6.ShowDialog();
        }

        private void traCuuTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(); // Form5 = Tra cứu tên khoa theo mã số
            f5.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Có thể thêm xử lý khi form chính load
        }
    }
}
