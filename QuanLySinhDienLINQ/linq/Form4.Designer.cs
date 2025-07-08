namespace QuanLySinhVien
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMakhoa = new System.Windows.Forms.Label();
            this.lblTenkhoa = new System.Windows.Forms.Label();
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnThemkhoa = new System.Windows.Forms.Button();
            this.btnSuakhoa = new System.Windows.Forms.Button();
            this.btnXoakhoa = new System.Windows.Forms.Button();
            this.btnTailaiKhoa = new System.Windows.Forms.Button();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMakhoa
            // 
            this.lblMakhoa.AutoSize = true;
            this.lblMakhoa.Location = new System.Drawing.Point(31, 132);
            this.lblMakhoa.Name = "lblMakhoa";
            this.lblMakhoa.Size = new System.Drawing.Size(62, 16);
            this.lblMakhoa.TabIndex = 0;
            this.lblMakhoa.Text = "Mã khoa:";
            // 
            // lblTenkhoa
            // 
            this.lblTenkhoa.AutoSize = true;
            this.lblTenkhoa.Location = new System.Drawing.Point(26, 167);
            this.lblTenkhoa.Name = "lblTenkhoa";
            this.lblTenkhoa.Size = new System.Drawing.Size(67, 16);
            this.lblTenkhoa.TabIndex = 1;
            this.lblTenkhoa.Text = "Tên khoa:";
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Location = new System.Drawing.Point(99, 126);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(192, 22);
            this.txtMakhoa.TabIndex = 2;
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Location = new System.Drawing.Point(99, 164);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(192, 22);
            this.txtTenkhoa.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dataGridView2.Location = new System.Drawing.Point(15, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(426, 84);
            this.dataGridView2.TabIndex = 4;
            // 
            // btnThemkhoa
            // 
            this.btnThemkhoa.Location = new System.Drawing.Point(18, 221);
            this.btnThemkhoa.Name = "btnThemkhoa";
            this.btnThemkhoa.Size = new System.Drawing.Size(75, 23);
            this.btnThemkhoa.TabIndex = 5;
            this.btnThemkhoa.Text = "Thêm";
            this.btnThemkhoa.UseVisualStyleBackColor = true;
            // 
            // btnSuakhoa
            // 
            this.btnSuakhoa.Location = new System.Drawing.Point(133, 221);
            this.btnSuakhoa.Name = "btnSuakhoa";
            this.btnSuakhoa.Size = new System.Drawing.Size(75, 23);
            this.btnSuakhoa.TabIndex = 6;
            this.btnSuakhoa.Text = "Sửa";
            this.btnSuakhoa.UseVisualStyleBackColor = true;
            // 
            // btnXoakhoa
            // 
            this.btnXoakhoa.Location = new System.Drawing.Point(247, 221);
            this.btnXoakhoa.Name = "btnXoakhoa";
            this.btnXoakhoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoakhoa.TabIndex = 7;
            this.btnXoakhoa.Text = "Xóa";
            this.btnXoakhoa.UseVisualStyleBackColor = true;
            // 
            // btnTailaiKhoa
            // 
            this.btnTailaiKhoa.Location = new System.Drawing.Point(366, 221);
            this.btnTailaiKhoa.Name = "btnTailaiKhoa";
            this.btnTailaiKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTailaiKhoa.TabIndex = 8;
            this.btnTailaiKhoa.Text = "Tải lại";
            this.btnTailaiKhoa.UseVisualStyleBackColor = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "MAKHOA";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 125;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "TENKHOA";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.btnTailaiKhoa);
            this.Controls.Add(this.btnXoakhoa);
            this.Controls.Add(this.btnSuakhoa);
            this.Controls.Add(this.btnThemkhoa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtTenkhoa);
            this.Controls.Add(this.txtMakhoa);
            this.Controls.Add(this.lblTenkhoa);
            this.Controls.Add(this.lblMakhoa);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakhoa;
        private System.Windows.Forms.Label lblTenkhoa;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnThemkhoa;
        private System.Windows.Forms.Button btnSuakhoa;
        private System.Windows.Forms.Button btnXoakhoa;
        private System.Windows.Forms.Button btnTailaiKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    }
}