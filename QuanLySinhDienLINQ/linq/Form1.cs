using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnDangNhap_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Admin" && txtMatKhau.Text == "123456")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo");
            }
        }

    }
}
