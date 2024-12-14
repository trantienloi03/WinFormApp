namespace QuanLySinhVienDB.Gui
{
    partial class Form_Add
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
            btn_Them = new Button();
            btn_Huy = new Button();
            labelMaSV = new Label();
            txtMaSinhVien = new TextBox();
            txtHoDem = new TextBox();
            labelHoDem = new Label();
            txtTen = new TextBox();
            labelTen = new Label();
            labelGT = new Label();
            labelNgaySinh = new Label();
            label5 = new Label();
            txtGhiChu = new TextBox();
            NgaySinh = new DateTimePicker();
            label1 = new Label();
            gtNam = new CheckBox();
            gtNu = new CheckBox();
            MaNganh = new ComboBox();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(522, 387);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(105, 27);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_click;
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(650, 387);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(105, 27);
            btn_Huy.TabIndex = 1;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_click;
            // 
            // labelMaSV
            // 
            labelMaSV.AutoSize = true;
            labelMaSV.Location = new Point(136, 38);
            labelMaSV.Name = "labelMaSV";
            labelMaSV.Size = new Size(91, 20);
            labelMaSV.TabIndex = 2;
            labelMaSV.Text = "Mã sinh viên";
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(249, 35);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.ReadOnly = true;
            txtMaSinhVien.Size = new Size(362, 27);
            txtMaSinhVien.TabIndex = 3;
            // 
            // txtHoDem
            // 
            txtHoDem.Location = new Point(249, 87);
            txtHoDem.Name = "txtHoDem";
            txtHoDem.Size = new Size(149, 27);
            txtHoDem.TabIndex = 5;
            // 
            // labelHoDem
            // 
            labelHoDem.AutoSize = true;
            labelHoDem.Location = new Point(136, 90);
            labelHoDem.Name = "labelHoDem";
            labelHoDem.Size = new Size(63, 20);
            labelHoDem.TabIndex = 4;
            labelHoDem.Text = "Họ đệm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(465, 87);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(146, 27);
            txtTen.TabIndex = 7;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(427, 90);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(32, 20);
            labelTen.TabIndex = 6;
            labelTen.Text = "Tên";
            // 
            // labelGT
            // 
            labelGT.AutoSize = true;
            labelGT.Location = new Point(136, 138);
            labelGT.Name = "labelGT";
            labelGT.Size = new Size(65, 20);
            labelGT.TabIndex = 8;
            labelGT.Text = "Giới tính";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(136, 195);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(76, 20);
            labelNgaySinh.TabIndex = 10;
            labelNgaySinh.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 248);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(249, 249);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(360, 27);
            txtGhiChu.TabIndex = 13;
            // 
            // NgaySinh
            // 
            NgaySinh.Location = new Point(249, 190);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new Size(360, 27);
            NgaySinh.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 295);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 14;
            label1.Text = "Mã ngành";
            // 
            // gtNam
            // 
            gtNam.AutoSize = true;
            gtNam.Location = new Point(249, 138);
            gtNam.Name = "gtNam";
            gtNam.Size = new Size(63, 24);
            gtNam.TabIndex = 18;
            gtNam.Text = "Nam";
            gtNam.UseVisualStyleBackColor = true;
            // 
            // gtNu
            // 
            gtNu.AutoSize = true;
            gtNu.Location = new Point(335, 138);
            gtNu.Name = "gtNu";
            gtNu.Size = new Size(51, 24);
            gtNu.TabIndex = 19;
            gtNu.Text = "Nữ";
            gtNu.UseVisualStyleBackColor = true;
            // 
            // MaNganh
            // 
            MaNganh.FormattingEnabled = true;
            MaNganh.Items.AddRange(new object[] { "Công nghệ thông tin", "Điện tử viễn thông", "Báo chí" });
            MaNganh.Location = new Point(249, 300);
            MaNganh.Name = "MaNganh";
            MaNganh.Size = new Size(360, 28);
            MaNganh.TabIndex = 20;
            // 
            // Form_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MaNganh);
            Controls.Add(gtNu);
            Controls.Add(gtNam);
            Controls.Add(NgaySinh);
            Controls.Add(label1);
            Controls.Add(txtGhiChu);
            Controls.Add(label5);
            Controls.Add(labelNgaySinh);
            Controls.Add(labelGT);
            Controls.Add(txtTen);
            Controls.Add(labelTen);
            Controls.Add(txtHoDem);
            Controls.Add(labelHoDem);
            Controls.Add(txtMaSinhVien);
            Controls.Add(labelMaSV);
            Controls.Add(btn_Huy);
            Controls.Add(btn_Them);
            Name = "Form_Add";
            Text = "Thêm mới sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Them;
        private Button btn_Huy;
        private Label labelMaSV;
        private TextBox txtMaSinhVien;
        private TextBox txtHoDem;
        private Label labelHoDem;
        private TextBox txtTen;
        private Label labelTen;
        private Label labelGT;
        private Label labelNgaySinh;
        private Label label5;
        private TextBox txtGhiChu;
        private DateTimePicker NgaySinh;
        private Label label1;
        private CheckBox gtNam;
        private CheckBox gtNu;
        private ComboBox MaNganh;
    }
}