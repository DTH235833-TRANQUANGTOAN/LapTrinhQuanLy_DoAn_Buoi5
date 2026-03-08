namespace QuanLyTienGui
{
    partial class frmRutTien
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
            txtDiaChi = new TextBox();
            panel2 = new Panel();
            rdbNu = new RadioButton();
            txtHoKH = new TextBox();
            rdbNam = new RadioButton();
            txtTenKH = new TextBox();
            label5 = new Label();
            txtCCCD = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            txtSDT = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            btnRut = new Button();
            btnHuy = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(356, 75);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(182, 31);
            txtDiaChi.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnRut);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 101);
            panel2.TabIndex = 14;
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
            // txtHoKH
            // 
            txtHoKH.Location = new Point(107, 25);
            txtHoKH.Name = "txtHoKH";
            txtHoKH.Size = new Size(182, 31);
            txtHoKH.TabIndex = 0;
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
            // txtTenKH
            // 
            txtTenKH.Location = new Point(356, 28);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(182, 31);
            txtTenKH.TabIndex = 1;
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
            // txtCCCD
            // 
            txtCCCD.Location = new Point(615, 25);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(207, 31);
            txtCCCD.TabIndex = 3;
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
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSDT);
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
            panel1.Size = new Size(887, 162);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(544, 83);
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
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 241);
            panel3.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(887, 241);
            dataGridView1.TabIndex = 0;
            // 
            // btnRut
            // 
            btnRut.Location = new Point(125, 42);
            btnRut.Name = "btnRut";
            btnRut.Size = new Size(112, 34);
            btnRut.TabIndex = 0;
            btnRut.Text = "Rút tiền";
            btnRut.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(356, 42);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(580, 42);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmRutTien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 504);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRutTien";
            Text = "frmRutTien";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDiaChi;
        private Panel panel2;
        private RadioButton rdbNu;
        private TextBox txtHoKH;
        private RadioButton rdbNam;
        private TextBox txtTenKH;
        private Label label5;
        private TextBox txtCCCD;
        private Label label4;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label8;
        private TextBox txtSDT;
        private Panel panel3;
        private Button button3;
        private Button btnHuy;
        private Button btnRut;
        private DataGridView dataGridView1;
    }
}