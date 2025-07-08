using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLiSV
{
    public partial class Form4 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLiSinhVien;Integrated Security=True";
            conn = new SqlConnection(connStr);

            // Gắn sự kiện
            btnThemMH.Click += btnThemMH_Click;
            btnSuaMH.Click += btnSuaMH_Click;
            btnXoaMH.Click += btnXoaMH_Click;
            btnTaiLaiMH.Click += btnTaiLaiMH_Click;
            dataGridView3.CellClick += dataGridView3_CellClick;

            LoadData();
        }

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM MONHOC", conn);

            if (dt != null)
                dt.Clear();

            dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO MONHOC VALUES (@MaMH, @TenMH)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE MONHOC SET TenMH=@TenMH WHERE MaMH=@MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM MONHOC WHERE MaMH=@MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Xoá thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnTaiLaiMH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaMH.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
                txtTenMH.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            }
        }
    }
}
