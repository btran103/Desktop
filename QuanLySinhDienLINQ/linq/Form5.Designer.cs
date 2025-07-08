namespace QuanLySinhVien
{
    partial class Form5
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
            this.cbbMASO = new System.Windows.Forms.ComboBox();
            this.btnTailaiTracuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbbMASO = new System.Windows.Forms.Label();
            this.lblTENMH = new System.Windows.Forms.Label();
            this.lblSoTiet = new System.Windows.Forms.Label();
            this.txtTenMh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMASO
            // 
            this.cbbMASO.FormattingEnabled = true;
            this.cbbMASO.Location = new System.Drawing.Point(97, 147);
            this.cbbMASO.Name = "cbbMASO";
            this.cbbMASO.Size = new System.Drawing.Size(166, 24);
            this.cbbMASO.TabIndex = 0;
            this.cbbMASO.SelectedIndexChanged += new System.EventHandler(this.cbbMASO_SelectedIndexChanged);
            // 
            // btnTailaiTracuu
            // 
            this.btnTailaiTracuu.Location = new System.Drawing.Point(329, 147);
            this.btnTailaiTracuu.Name = "btnTailaiTracuu";
            this.btnTailaiTracuu.Size = new System.Drawing.Size(137, 73);
            this.btnTailaiTracuu.TabIndex = 1;
            this.btnTailaiTracuu.Text = "Tải lại";
            this.btnTailaiTracuu.UseVisualStyleBackColor = true;
            this.btnTailaiTracuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhoa,
            this.TENMH});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 91);
            this.dataGridView1.TabIndex = 2;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "TENKHOA";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 125;
            // 
            // TENMH
            // 
            this.TENMH.HeaderText = "TENMONHOC";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.Width = 125;
            // 
            // lbbMASO
            // 
            this.lbbMASO.AutoSize = true;
            this.lbbMASO.Location = new System.Drawing.Point(38, 150);
            this.lbbMASO.Name = "lbbMASO";
            this.lbbMASO.Size = new System.Drawing.Size(47, 16);
            this.lbbMASO.TabIndex = 3;
            this.lbbMASO.Text = "Mã số:";
            // 
            // lblTENMH
            // 
            this.lblTENMH.AutoSize = true;
            this.lblTENMH.Location = new System.Drawing.Point(9, 183);
            this.lblTENMH.Name = "lblTENMH";
            this.lblTENMH.Size = new System.Drawing.Size(88, 16);
            this.lblTENMH.TabIndex = 4;
            this.lblTENMH.Text = "Tên môn học:";
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.AutoSize = true;
            this.lblSoTiet.Location = new System.Drawing.Point(38, 217);
            this.lblSoTiet.Name = "lblSoTiet";
            this.lblSoTiet.Size = new System.Drawing.Size(0, 16);
            this.lblSoTiet.TabIndex = 5;
            // 
            // txtTenMh
            // 
            this.txtTenMh.Location = new System.Drawing.Point(97, 180);
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.Size = new System.Drawing.Size(166, 22);
            this.txtTenMh.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(this.txtTenMh);
            this.Controls.Add(this.lblSoTiet);
            this.Controls.Add(this.lblTENMH);
            this.Controls.Add(this.lbbMASO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTailaiTracuu);
            this.Controls.Add(this.cbbMASO);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMASO;
        private System.Windows.Forms.Button btnTailaiTracuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbbMASO;
        private System.Windows.Forms.Label lblTENMH;
        private System.Windows.Forms.Label lblSoTiet;
        private System.Windows.Forms.TextBox txtTenMh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
    }
}