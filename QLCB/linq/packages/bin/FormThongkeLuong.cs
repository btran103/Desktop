using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCB
{
    public partial class FormThongkeLuong : Form
    {
        QLCanBoDataContext db = new QLCanBoDataContext();

        public FormThongkeLuong()
        {
            InitializeComponent();
            btnThongKe.Click += btnThongKe_Click;
        }

        private void FormThongkeLuong_Load(object sender, EventArgs e)
        {
            // Có thể gọi thống kê luôn nếu muốn:
            // ThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void ThongKe()
        {
            var query = from tl in db.TienLuongs
                        join ct in db.CongTacs on tl.MaCV equals ct.MaCV
                        select new
                        {
                            tl.SoNgayCong,
                            TienLuong = tl.SoNgayCong * ct.TienLuong
                        };

            dataGridView1.DataSource = query.ToList();

            // Tính tổng lương
            double tongLuong = query.Sum(x => x.TienLuong) ?? 0;
            lblTongLuong.Text = "Tổng Lương: " + tongLuong.ToString("N0") + " VND";
        }
    }
}
