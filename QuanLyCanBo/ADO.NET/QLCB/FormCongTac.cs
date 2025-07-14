using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLCANBO;

namespace QuanLyCanBo
{
    public partial class FormCongTac : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLCANBO;Integrated Security=True";

        public FormCongTac()
        {
            InitializeComponent(); // ✅ Đã sửa bỏ ký tự dư
        }

        private void FormCongTac_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM CongTac";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCongTac.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtTienLuong.Text, out float tienLuong))
            {
                MessageBox.Show("Tiền lương không hợp lệ!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO CongTac (MaCV, TenCV, TienLuong) VALUES (@MaCV, @TenCV, @TienLuong)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenCV", txtTenCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TienLuong", tienLuong);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Thêm công tác thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtTienLuong.Text, out float tienLuong))
            {
                MessageBox.Show("Tiền lương không hợp lệ!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE CongTac SET TenCV=@TenCV, TienLuong=@TienLuong WHERE MaCV=@MaCV";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenCV", txtTenCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TienLuong", tienLuong);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM CongTac WHERE MaCV=@MaCV";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Xóa thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCongTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCongTac.Rows[e.RowIndex].Cells["MaCV"].Value != null)
            {
                txtMaCV.Text = dgvCongTac.Rows[e.RowIndex].Cells["MaCV"].Value.ToString();
                txtTenCV.Text = dgvCongTac.Rows[e.RowIndex].Cells["TenCV"].Value.ToString();
                txtTienLuong.Text = dgvCongTac.Rows[e.RowIndex].Cells["TienLuong"].Value.ToString();
            }
        }

        private void btnFormTienLuong_Click(object sender, EventArgs e)
        {
            FormTienLuong f = new FormTienLuong();
            f.ShowDialog();
        }
    }
}
