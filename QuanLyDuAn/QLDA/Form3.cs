using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class Form3 : Form
    {
        /*-------------------------------------------------
         * 0. Chuỗi kết nối
         *------------------------------------------------*/
        private readonly string _cnnStr =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();

            /* gắn sự kiện */
            Load += Form3_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        /*-------------------------------------------------
         * 1. LOAD DỮ LIỆU
         *------------------------------------------------*/
        private void Form3_Load(object sender, EventArgs e) => LoadNhanVien();

        private void LoadNhanVien(string kw = "")
        {
            string sql = kw == "" ? "SELECT * FROM NhanVien"
                                  : "SELECT * FROM NhanVien WHERE HoTen LIKE @kw";

            using (SqlConnection cnn = new SqlConnection(_cnnStr))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn))
            {
                if (kw != "") da.SelectCommand.Parameters.AddWithValue("@kw", "%" + kw + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        /*-------------------------------------------------
         * 2. ĐỌC INPUT
         *------------------------------------------------*/
        private string Inp_MaNV => textBox3.Text.Trim();
        private string Inp_TenNV => textBox4.Text.Trim();
        private DateTime Inp_NgaySinh => dateTimePicker1.Value;
        private string Inp_SDT => textBox1.Text.Trim();
        private string Inp_DiaChi => textBox2.Text.Trim();

        private bool IsMissing()
        {
            if (Inp_MaNV == "" || Inp_TenNV == "")
            {
                MessageBox.Show("Nhập Mã NV & Tên NV!", "Thiếu dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /*-------------------------------------------------
         * 3. THÊM
         *------------------------------------------------*/
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsMissing()) return;

            Exec(@"INSERT INTO NhanVien VALUES(@Ma,@Ten,@NS,@DC,@DT)",
                 ("@Ma", Inp_MaNV), ("@Ten", Inp_TenNV), ("@NS", Inp_NgaySinh),
                 ("@DC", Inp_DiaChi), ("@DT", Inp_SDT),
                 dupMsg: "Mã NV đã tồn tại!");
        }

        /*-------------------------------------------------
         * 4. SỬA
         *------------------------------------------------*/
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || IsMissing()) return;

            Exec(@"UPDATE NhanVien SET HoTen=@Ten, NgaySinh=@NS, DiaChi=@DC,
                   DienThoai=@DT WHERE MaNV=@Ma",
                 ("@Ma", Inp_MaNV), ("@Ten", Inp_TenNV), ("@NS", Inp_NgaySinh),
                 ("@DC", Inp_DiaChi), ("@DT", Inp_SDT));
        }

        /*-------------------------------------------------
         * 5. XOÁ
         *------------------------------------------------*/
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Xoá nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Exec("DELETE FROM NhanVien WHERE MaNV=@Ma", ("@Ma", Inp_MaNV));
        }

    
        private void btnLamMoi_Click(object sender, EventArgs e)
        { ClearInputs(); LoadNhanVien(); }

        private void ClearInputs()
        {
            textBox3.Clear(); textBox4.Clear();
            textBox2.Clear(); textBox1.Clear();
            dateTimePicker1.Value = DateTime.Today;
            textBox3.Focus();
        }

   
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
            textBox3.Text = r.Cells["MaNV"].Value?.ToString();
            textBox4.Text = r.Cells["HoTen"].Value?.ToString();
            textBox2.Text = r.Cells["DiaChi"].Value?.ToString();
            textBox1.Text = r.Cells["DienThoai"].Value?.ToString();
            DateTime ns;
            if (DateTime.TryParse(r.Cells["NgaySinh"].Value?.ToString(), out ns))
                dateTimePicker1.Value = ns;
        }

        /*-------------------------------------------------
         * 9. HÀM EXEC CHUNG
         *------------------------------------------------*/
        private void Exec(string sql, (string, object) p1,
                          (string, object)? p2 = null, (string, object)? p3 = null,
                          (string, object)? p4 = null, (string, object)? p5 = null,
                          string dupMsg = "Trùng khoá!", string okMsg = "Thành công!")
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cnnStr))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        Add(cmd, p1);
                        if (p2 != null) Add(cmd, p2.Value);
                        if (p3 != null) Add(cmd, p3.Value);
                        if (p4 != null) Add(cmd, p4.Value);
                        if (p5 != null) Add(cmd, p5.Value);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(okMsg);
                LoadNhanVien();
                ClearInputs();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            { MessageBox.Show(dupMsg); }
            catch (Exception ex)
            { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private static void Add(SqlCommand cmd, (string, object) p) =>
            cmd.Parameters.AddWithValue(p.Item1, p.Item2 ?? DBNull.Value);

        /*-------------------------------------------------
         * 10. Handler trống cho Designer
         *------------------------------------------------*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { /* không dùng – có thể xoá handler trong Designer */ }
    }
}
