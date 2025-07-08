using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class Form4 : Form
    {
        private readonly string _cnnStr =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        //  Tên món → (Mã, Đơn giá)
        private readonly Dictionary<string, (string Ma, decimal Gia)> _menu =
            new Dictionary<string, (string, decimal)>();

        private readonly CultureInfo _vi = CultureInfo.GetCultureInfo("vi-VN");

        public Form4()
        {
            InitializeComponent();

            InitDataGridView();

            
            Load += Form4_Load;
            btnGoiMon.Click += btnGoiMon_Click;
            btnXoaMon.Click += btnXoaMon_Click;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;     
            btnHienThi.Click += btnHienThi_Click;

            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = 100;
        }

        private void InitDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TenMon", "Món ăn");
            dataGridView1.Columns.Add("SoLuong", "SL");
            dataGridView1.Columns.Add("DonGia", "Đơn giá");
            dataGridView1.Columns.Add("ThanhTien", "Thành tiền");

            dataGridView1.Columns["SoLuong"].Width = 50;
            dataGridView1.Columns["DonGia"].Width = 90;
            dataGridView1.Columns["ThanhTien"].Width = 110;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                using (var cnn = new SqlConnection(_cnnStr))
                using (var cmd = new SqlCommand(
                    "SELECT MaMon, TenMon, DonGia FROM MonAn", cnn))
                {
                    cnn.Open();
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string ma = rd["MaMon"].ToString();
                            string ten = rd["TenMon"].ToString();
                            decimal gia = rd["DonGia"] == DBNull.Value
                                          ? 0
                                          : (decimal)rd["DonGia"];

                            if (gia == 0)
                                MessageBox.Show($"Món ăn '{ten}' chưa có đơn giá! " +
                                                "Mặc định sẽ là 0 VND.",
                                                "Cảnh báo",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);

                            _menu[ten] = (ma, gia);
                            cboMonAn.Items.Add(ten);
                        }
                    }
                }
                if (cboMonAn.Items.Count > 0) cboMonAn.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thực đơn: " + ex.Message);
            }

            CapNhatTongTien();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            if (cboMonAn.SelectedItem == null) return;

            string ten = cboMonAn.SelectedItem.ToString();
            int sl = (int)nudSoLuong.Value;
            var info = _menu[ten];
            decimal gia = info.Gia;
            decimal tt = gia * sl;

            // Kiểm tra trùng món → cộng SL
            var row = dataGridView1.Rows
                                   .Cast<DataGridViewRow>()
                                   .FirstOrDefault(r => r.Cells["TenMon"].Value?.ToString() == ten);
            if (row != null)
            {
                int slCu = Convert.ToInt32(row.Cells["SoLuong"].Value);
                row.Cells["SoLuong"].Value = slCu + sl;

                decimal ttCu = decimal.Parse(row.Cells["ThanhTien"].Value.ToString(), _vi);
                row.Cells["ThanhTien"].Value = (ttCu + tt).ToString("N0", _vi);
            }
            else
            {
                // thêm dòng mới
                dataGridView1.Rows.Add(ten,
                                       sl,
                                       gia.ToString("N0", _vi),
                                       tt.ToString("N0", _vi));
            }

            CapNhatTongTien();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tong = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Where(r => r.Cells["ThanhTien"].Value != null)
                            .Sum(r => decimal.Parse(r.Cells["ThanhTien"].Value.ToString(), _vi));

            lblTongTien.Text = $"Tổng Tiền: {tong:N0} VND";
        }


        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món nào!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var hd = "=== HOÁ ĐƠN ===\n";
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                hd += $"{r.Cells["TenMon"].Value} × " +
                      $"{r.Cells["SoLuong"].Value} = " +
                      $"{r.Cells["ThanhTien"].Value}\n";
            }
            hd += "\n" + lblTongTien.Text;

            MessageBox.Show(hd,
                            "Hoá đơn",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            
        }

  
        private void btnHienThi_Click(object sender, EventArgs e)
        {
   
            var menuText = string.Join("\n",
                          _menu.Select(kv => $"{kv.Key} – {kv.Value.Gia:N0} VND"));
            MessageBox.Show(menuText,
                            "Thực đơn",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
