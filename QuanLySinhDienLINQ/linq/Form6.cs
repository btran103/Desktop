using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form6 : Form
    {
        QLiSinhVienDataContext db = new QLiSinhVienDataContext();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadMonHoc();
        }

        private void LoadComboBox()
        {
            var dsMaSo = db.SINHVIENs.Select(sv => sv.MaSV).Distinct().ToList();
            cbbMS.DataSource = dsMaSo;
        }

        private void LoadMonHoc()
        {
            var dsMonHoc = db.MONHOCs.Select(mh => new { MaMH = mh.MaMH, TenMH = mh.TenMH }).ToList();
            dataGridView3.DataSource = dsMonHoc;

            // Gán tên cho các cột nếu cần thiết
            if (dataGridView3.Columns.Count >= 2)
            {
                dataGridView3.Columns[0].Name = "MaMH";
                dataGridView3.Columns[1].Name = "TenMH";
            }
        }

        private void btnTailaiMH_Click(object sender, EventArgs e)
        {
            LoadMonHoc();
            txtTMH.Clear();
        }

        private void cbbMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMS.SelectedItem == null) return;

            string maSo = cbbMS.SelectedItem.ToString();

            // Ví dụ: chỉ lấy môn học đầu tiên cho minh họa, vì không có quan hệ giữa SINHVIEN và MONHOC
            var mon = db.MONHOCs.FirstOrDefault();
            txtTMH.Text = mon?.TenMH ?? string.Empty;
        }
    }
}