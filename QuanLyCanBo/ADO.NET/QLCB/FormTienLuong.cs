using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity;


namespace QLCANBO
{
    public partial class FormTienLuong : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLCANBO;Integrated Security=True";

        public FormTienLuong()
        {
            InitializeComponent();
        }

        private void FormTienLuong_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load MaCB
                SqlCommand cmd1 = new SqlCommand("SELECT MaCB FROM CanBo", conn);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    cbbMaCB.Items.Add(rd1["MaCB"].ToString());
                }
                rd1.Close();

                // Load MaCV
                SqlCommand cmd2 = new SqlCommand("SELECT MaCV FROM CongTac", conn);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    cbbMaCV.Items.Add(rd2["MaCV"].ToString());
                }

                conn.Close();
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            string macb = cbbMaCB.Text;
            string macv = cbbMaCV.Text;
            int soNgay = int.Parse(txtSoNgayCong.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO TienLuong(MaCB, MaCV, SoNgayCong) VALUES (@MaCB, @MaCV, @SoNgayCong)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaCB", macb);
                cmd.Parameters.AddWithValue("@MaCV", macv);
                cmd.Parameters.AddWithValue("@SoNgayCong", soNgay);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Tính lương thành công!");
                HienThi();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT 
                    cb.MaCB,
                    ct.MaCV,
                    tl.SoNgayCong,
                    ROUND(cb.HeSoLuong * ct.TienLuong * (tl.SoNgayCong / 26.0), 0) AS Luong
                FROM CanBo cb
                JOIN TienLuong tl ON cb.MaCB = tl.MaCB
                JOIN CongTac ct ON tl.MaCV = ct.MaCV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnLocLuongCao_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT 
                    cb.MaCB,
                    ct.MaCV,
                    tl.SoNgayCong,
                    ROUND(cb.HeSoLuong * ct.TienLuong * (tl.SoNgayCong / 26.0), 0) AS Luong
                FROM CanBo cb
                JOIN TienLuong tl ON cb.MaCB = tl.MaCB
                JOIN CongTac ct ON tl.MaCV = ct.MaCV
                WHERE cb.HeSoLuong * ct.TienLuong * (tl.SoNgayCong / 26.0) > 2500000";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Có thể để trống nếu không cần xử lý khi click vào ô
        }

    }

}
