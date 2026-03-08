namespace QuanLyTienGui
{
    partial class frmTaoHopDong
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
            txtHoKH = new TextBox();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtCCCD = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            txtSoTien = new TextBox();
            cboLoaiTien = new ComboBox();
            btnTraCuu = new Button();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboKyHan = new ComboBox();
            btnTaoHD = new Button();
            label8 = new Label();
            txtSDT = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtHoKH
            // 
            txtHoKH.Location = new Point(107, 25);
            txtHoKH.Name = "txtHoKH";
            txtHoKH.Size = new Size(162, 31);
            txtHoKH.TabIndex = 0;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(356, 28);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(182, 31);
            txtTenKH.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(356, 77);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(182, 31);
            txtDiaChi.TabIndex = 2;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(615, 25);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(207, 31);
            txtCCCD.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 4;
            label1.Text = "Họ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 77);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 6;
            label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 31);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 7;
            label4.Text = "Tên";
           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 31);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 8;
            label5.Text = "CCCD";
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(107, 77);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 29);
            rdbNam.TabIndex = 9;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(190, 77);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(61, 29);
            rdbNu.TabIndex = 10;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(btnTaoHD);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cboKyHan);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnTraCuu);
            panel1.Controls.Add(cboLoaiTien);
            panel1.Controls.Add(txtSoTien);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(rdbNu);
            panel1.Controls.Add(txtHoKH);
            panel1.Controls.Add(rdbNam);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 256);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 256);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 339);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(890, 339);
            dataGridView1.TabIndex = 0;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(107, 142);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(150, 31);
            txtSoTien.TabIndex = 11;
            // 
            // cboLoaiTien
            // 
            cboLoaiTien.FormattingEnabled = true;
            cboLoaiTien.Location = new Point(356, 139);
            cboLoaiTien.Name = "cboLoaiTien";
            cboLoaiTien.Size = new Size(100, 33);
            cboLoaiTien.TabIndex = 12;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(710, 140);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(112, 34);
            btnTraCuu.TabIndex = 13;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 147);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 14;
            label2.Text = "Số tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 145);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 15;
            label6.Text = "Loại tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 142);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 17;
            label7.Text = "Kỳ hạn";
            // 
            // cboKyHan
            // 
            cboKyHan.FormattingEnabled = true;
            cboKyHan.Location = new Point(557, 137);
            cboKyHan.Name = "cboKyHan";
            cboKyHan.Size = new Size(126, 33);
            cboKyHan.TabIndex = 16;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Location = new Point(373, 196);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(165, 41);
            btnTaoHD.TabIndex = 18;
            btnTaoHD.Text = "Tạo Hợp Đồng";
            btnTaoHD.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(544, 81);
            label8.Name = "label8";
            label8.Size = new Size(43, 25);
            label8.TabIndex = 20;
            label8.Text = "SDT";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(615, 77);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(207, 31);
            txtSDT.TabIndex = 19;
            // 
            // frmTaoHopDong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 595);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTaoHopDong";
            Text = "frmTaoHopDong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtHoKH;
        private TextBox txtTenKH;
        private TextBox txtDiaChi;
        private TextBox txtCCCD;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnTaoHD;
        private Label label7;
        private ComboBox cboKyHan;
        private Label label6;
        private Label label2;
        private Button btnTraCuu;
        private ComboBox cboLoaiTien;
        private TextBox txtSoTien;
        private Label label8;
        private TextBox txtSDT;
    }
}