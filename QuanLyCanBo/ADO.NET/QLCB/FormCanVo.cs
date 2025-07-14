using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCanBo;

namespace QLCANBO
{
    public partial class FormCanBo : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLCANBO;Integrated Security=True";

        public FormCanBo()
        {
            InitializeComponent();
        }

        private void FormCanBo_Load(object sender, EventArgs e)
        {
            LoadData();
            cbbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM CanBo";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCanBo.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CanBo (MaCB, HoTen, NgaySinh, GioiTinh, HeSoLuong) " +
                               "VALUES (@MaCB, @HoTen, @NgaySinh, @GioiTinh, @HeSoLuong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCB", txtMaCB.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@HeSoLuong", float.Parse(txtHeSoLuong.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CanBo SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, HeSoLuong=@HeSoLuong " +
                               "WHERE MaCB=@MaCB";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCB", txtMaCB.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@HeSoLuong", float.Parse(txtHeSoLuong.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CanBo WHERE MaCB=@MaCB";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCB", txtMaCB.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaCB.Text = dgvCanBo.Rows[e.RowIndex].Cells["MaCB"].Value.ToString();
                txtHoTen.Text = dgvCanBo.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dgvCanBo.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                cbbGioiTinh.Text = dgvCanBo.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtHeSoLuong.Text = dgvCanBo.Rows[e.RowIndex].Cells["HeSoLuong"].Value.ToString();
            }
        }

        private void thôngTinCôngTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCongTac f = new FormCongTac();
            f.Show();
        }

        private void thôngTinTiênLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTienLuong f = new FormTienLuong();
            f.Show();
        }
    }
}
