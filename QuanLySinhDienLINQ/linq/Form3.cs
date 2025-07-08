using System;
using System.Windows.Forms;
using System.Linq;

namespace QuanLySinhVien
{
    public partial class Form3 : Form
    {
        QLiSinhVienDataContext db = new QLiSinhVienDataContext();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void LoadSinhVien()
        {
            var ds = from sv in db.SINHVIENs
                     select new
                     {
                         sv.MaSV,
                         sv.HoTen,
                         sv.NgaySinh,
                         sv.GioiTinh,
                         sv.DiaChi,
                         sv.DienThoai,
                         sv.MaKhoa,
                         sv.KHOA.TenKhoa
                     };
            dataGridView1.DataSource = ds;
        }
    }
}