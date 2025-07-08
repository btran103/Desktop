using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLiSV
{
    public partial class Form2 : Form
    {
        string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLiSinhVien;Integrated Security=True";
        SqlConnection conn;

        public Form2()
        {
            InitializeComponent();

            // Gán sự kiện click cho nút Form3 đã có trong Designer
            btnForm3.Click += BtnForm3_Click;
        }

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            // Mở Form3 khi nhấn nút
            Form3 f3 = new Form3();
            f3.Show(); // hoặc ShowDialog() nếu bạn muốn chặn Form2 trong lúc Form3 mở
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cbbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            FormatTextBoxes();
            LoadData();
        }

        private void FormatTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.BackColor = System.Drawing.Color.White;
                    tb.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa FROM SINHVIEN";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO SINHVIEN VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @MaKhoa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE SINHVIEN SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, DienThoai=@DienThoai, MaKhoa=@MaKhoa WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM SINHVIEN WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Xoá thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtMaKhoa.Text = row.Cells["MaKhoa"].Value?.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // có thể bỏ trống nếu không cần xử lý
        }
    }
}
