namespace QuanLySinhVien
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSachSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuTheoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachSinhVienToolStripMenuItem,
            this.danhSachKhoaToolStripMenuItem,
            this.danhSachMonHocToolStripMenuItem,
            this.traCuuTheoKhoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSachSinhVienToolStripMenuItem
            // 
            this.danhSachSinhVienToolStripMenuItem.Name = "danhSachSinhVienToolStripMenuItem";
            this.danhSachSinhVienToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.danhSachSinhVienToolStripMenuItem.Text = "Danh sách Sinh Viên";
            this.danhSachSinhVienToolStripMenuItem.Click += new System.EventHandler(this.danhSachSinhVienToolStripMenuItem_Click);
            // 
            // danhSachKhoaToolStripMenuItem
            // 
            this.danhSachKhoaToolStripMenuItem.Name = "danhSachKhoaToolStripMenuItem";
            this.danhSachKhoaToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.danhSachKhoaToolStripMenuItem.Text = "Danh sách Khoa";
            this.danhSachKhoaToolStripMenuItem.Click += new System.EventHandler(this.danhSachKhoaToolStripMenuItem_Click);
            // 
            // danhSachMonHocToolStripMenuItem
            // 
            this.danhSachMonHocToolStripMenuItem.Name = "danhSachMonHocToolStripMenuItem";
            this.danhSachMonHocToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.danhSachMonHocToolStripMenuItem.Text = "Danh sách Môn học";
            this.danhSachMonHocToolStripMenuItem.Click += new System.EventHandler(this.danhSachMonHocToolStripMenuItem_Click);
            // 
            // traCuuTheoKhoaToolStripMenuItem
            // 
            this.traCuuTheoKhoaToolStripMenuItem.Name = "traCuuTheoKhoaToolStripMenuItem";
            this.traCuuTheoKhoaToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.traCuuTheoKhoaToolStripMenuItem.Text = "Tra cứu theo Khoa";
            this.traCuuTheoKhoaToolStripMenuItem.Click += new System.EventHandler(this.traCuuTheoKhoaToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 270);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSachSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachMonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuTheoKhoaToolStripMenuItem;
    }
}
