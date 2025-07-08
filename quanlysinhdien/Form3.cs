using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLiSV
{
    public partial class Form3 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;

        public Form3()
        {
            InitializeComponent();

            // Gán sự kiện cho nút mở Form4
            btnForm4.Click += BtnForm4_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLiSinhVien;Integrated Security=True";
            conn = new SqlConnection(connStr);

            // Gán sự kiện các nút
            btnThemK.Click += btnThemK_Click;
            btnSuaK.Click += btnSuaK_Click;
            btnXoaK.Click += btnXoaK_Click;
            btnTaiLaiK.Click += btnTaiLaiK_Click;
            dataGridView2.CellClick += dataGridView2_CellClick;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM KHOA", conn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = null;
                dataGridView2.Columns.Clear();
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void btnThemK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO KHOA VALUES (@MaKhoa, @TenKhoa)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMK.Text);
                cmd.Parameters.AddWithValue("@TenKhoa", txtTK.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnSuaK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE KHOA SET TenKhoa=@TenKhoa WHERE MaKhoa=@MaKhoa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMK.Text);
                cmd.Parameters.AddWithValue("@TenKhoa", txtTK.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnXoaK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM KHOA WHERE MaKhoa=@MaKhoa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMK.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Xoá thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnTaiLaiK_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dataGridView2.Rows[i].Cells["MaKhoa"].Value != null)
            {
                txtMK.Text = dataGridView2.Rows[i].Cells["MaKhoa"].Value.ToString();
                txtTK.Text = dataGridView2.Rows[i].Cells["TenKhoa"].Value.ToString();
            }
        }

        private void BtnForm4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show(); // hoặc f4.ShowDialog();
        }
    }
}
