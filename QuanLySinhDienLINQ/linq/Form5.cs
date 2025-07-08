using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form5 : Form
    {
        QLiSinhVienDataContext db = new QLiSinhVienDataContext();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadMonHoc();
        }

        private void LoadComboBox()
        {
            var ds = db.MONHOCs.Select(m => m.MaMH).ToList();
            cbbMASO.DataSource = ds;
        }

        private void LoadMonHoc()
        {
            var ds = db.MONHOCs.Select(m => new { m.MaMH, m.TenMH }).ToList();
            dataGridView1.DataSource = ds;

            // Gán tên cho các cột để tránh bị lỗi khi truy xuất
            if (dataGridView1.Columns.Count >= 2)
            {
                dataGridView1.Columns[0].Name = "MaMH";
                dataGridView1.Columns[1].Name = "TenMH";
            }
        }

        private void cbbMASO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMASO.SelectedItem == null) return;

            string ma = cbbMASO.SelectedItem.ToString();
            var mon = db.MONHOCs.FirstOrDefault(m => m.MaMH == ma);
            txtTenMh.Text = mon?.TenMH ?? string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadMonHoc();
            txtTenMh.Clear();
        }
    }
}