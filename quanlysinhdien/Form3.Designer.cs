namespace QLiSV
{
    partial class Form3
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
            this.lblMAKHOA = new System.Windows.Forms.Label();
            this.lblTENKHOA = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnThemK = new System.Windows.Forms.Button();
            this.btnSuaK = new System.Windows.Forms.Button();
            this.btnXoaK = new System.Windows.Forms.Button();
            this.btnTaiLaiK = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnForm4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMAKHOA
            // 
            this.lblMAKHOA.AutoSize = true;
            this.lblMAKHOA.Location = new System.Drawing.Point(43, 136);
            this.lblMAKHOA.Name = "lblMAKHOA";
            this.lblMAKHOA.Size = new System.Drawing.Size(62, 16);
            this.lblMAKHOA.TabIndex = 0;
            this.lblMAKHOA.Text = "Mã khoa:";
            // 
            // lblTENKHOA
            // 
            this.lblTENKHOA.AutoSize = true;
            this.lblTENKHOA.Location = new System.Drawing.Point(43, 166);
            this.lblTENKHOA.Name = "lblTENKHOA";
            this.lblTENKHOA.Size = new System.Drawing.Size(67, 16);
            this.lblTENKHOA.TabIndex = 1;
            this.lblTENKHOA.Text = "Tên khoa:";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(113, 166);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(153, 22);
            this.txtTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(113, 133);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(153, 22);
            this.txtMK.TabIndex = 3;
            // 
            // btnThemK
            // 
            this.btnThemK.Location = new System.Drawing.Point(15, 217);
            this.btnThemK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemK.Name = "btnThemK";
            this.btnThemK.Size = new System.Drawing.Size(75, 23);
            this.btnThemK.TabIndex = 4;
            this.btnThemK.Text = "Thêm";
            this.btnThemK.UseVisualStyleBackColor = true;
            // 
            // btnSuaK
            // 
            this.btnSuaK.Location = new System.Drawing.Point(95, 217);
            this.btnSuaK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaK.Name = "btnSuaK";
            this.btnSuaK.Size = new System.Drawing.Size(75, 23);
            this.btnSuaK.TabIndex = 5;
            this.btnSuaK.Text = "Sửa";
            this.btnSuaK.UseVisualStyleBackColor = true;
            // 
            // btnXoaK
            // 
            this.btnXoaK.Location = new System.Drawing.Point(175, 217);
            this.btnXoaK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaK.Name = "btnXoaK";
            this.btnXoaK.Size = new System.Drawing.Size(75, 23);
            this.btnXoaK.TabIndex = 6;
            this.btnXoaK.Text = "Xóa";
            this.btnXoaK.UseVisualStyleBackColor = true;
            // 
            // btnTaiLaiK
            // 
            this.btnTaiLaiK.Location = new System.Drawing.Point(255, 217);
            this.btnTaiLaiK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiLaiK.Name = "btnTaiLaiK";
            this.btnTaiLaiK.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiK.TabIndex = 7;
            this.btnTaiLaiK.Text = "Tải Lại";
            this.btnTaiLaiK.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dataGridView2.Location = new System.Drawing.Point(28, 12);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(349, 102);
            this.dataGridView2.TabIndex = 8;
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "MK";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 125;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "TK";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 125;
            // 
            // btnForm4
            // 
            this.btnForm4.Location = new System.Drawing.Point(337, 217);
            this.btnForm4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(80, 25);
            this.btnForm4.TabIndex = 9;
            this.btnForm4.Text = "Form4";
            this.btnForm4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 266);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTaiLaiK);
            this.Controls.Add(this.btnXoaK);
            this.Controls.Add(this.btnSuaK);
            this.Controls.Add(this.btnThemK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lblTENKHOA);
            this.Controls.Add(this.lblMAKHOA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMAKHOA;
        private System.Windows.Forms.Label lblTENKHOA;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnThemK;
        private System.Windows.Forms.Button btnSuaK;
        private System.Windows.Forms.Button btnXoaK;
        private System.Windows.Forms.Button btnTaiLaiK;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.Button btnForm4;
    }
}