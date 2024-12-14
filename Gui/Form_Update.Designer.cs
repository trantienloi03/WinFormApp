namespace QuanLySinhVienDB.Gui
{
    partial class Form_Update
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
            MaNganh = new ComboBox();
            gtNu = new CheckBox();
            gtNam = new CheckBox();
            NgaySinh = new DateTimePicker();
            label1 = new Label();
            txtGhiChu = new TextBox();
            label5 = new Label();
            labelNgaySinh = new Label();
            labelGT = new Label();
            txtTen = new TextBox();
            labelTen = new Label();
            txtHoDem = new TextBox();
            labelHoDem = new Label();
            txtMaSinhVien = new TextBox();
            labelMaSV = new Label();
            btn_Huy = new Button();
            btn_Luu = new Button();
            SuspendLayout();
            // 
            // MaNganh
            // 
            MaNganh.FormattingEnabled = true;
            MaNganh.Items.AddRange(new object[] { "Công nghệ thông tin", "Điện tử viễn thông", "Báo chí" });
            MaNganh.Location = new Point(204, 301);
            MaNganh.Name = "MaNganh";
            MaNganh.Size = new Size(360, 28);
            MaNganh.TabIndex = 37;
            // 
            // gtNu
            // 
            gtNu.AutoSize = true;
            gtNu.Location = new Point(290, 139);
            gtNu.Name = "gtNu";
            gtNu.Size = new Size(51, 24);
            gtNu.TabIndex = 36;
            gtNu.Text = "Nữ";
            gtNu.UseVisualStyleBackColor = true;
            // 
            // gtNam
            // 
            gtNam.AutoSize = true;
            gtNam.Location = new Point(204, 139);
            gtNam.Name = "gtNam";
            gtNam.Size = new Size(63, 24);
            gtNam.TabIndex = 35;
            gtNam.Text = "Nam";
            gtNam.UseVisualStyleBackColor = true;
            // 
            // NgaySinh
            // 
            NgaySinh.Location = new Point(204, 191);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new Size(360, 27);
            NgaySinh.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 296);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 33;
            label1.Text = "Mã ngành";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(204, 250);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(360, 27);
            txtGhiChu.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 249);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 31;
            label5.Text = "Ghi chú";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(91, 196);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(76, 20);
            labelNgaySinh.TabIndex = 30;
            labelNgaySinh.Text = "Ngày Sinh";
            // 
            // labelGT
            // 
            labelGT.AutoSize = true;
            labelGT.Location = new Point(91, 139);
            labelGT.Name = "labelGT";
            labelGT.Size = new Size(65, 20);
            labelGT.TabIndex = 29;
            labelGT.Text = "Giới tính";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(420, 88);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(146, 27);
            txtTen.TabIndex = 28;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(382, 91);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(32, 20);
            labelTen.TabIndex = 27;
            labelTen.Text = "Tên";
            // 
            // txtHoDem
            // 
            txtHoDem.Location = new Point(204, 88);
            txtHoDem.Name = "txtHoDem";
            txtHoDem.Size = new Size(149, 27);
            txtHoDem.TabIndex = 26;
            // 
            // labelHoDem
            // 
            labelHoDem.AutoSize = true;
            labelHoDem.Location = new Point(91, 91);
            labelHoDem.Name = "labelHoDem";
            labelHoDem.Size = new Size(63, 20);
            labelHoDem.TabIndex = 25;
            labelHoDem.Text = "Họ đệm";
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(204, 36);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.ReadOnly = true;
            txtMaSinhVien.Size = new Size(362, 27);
            txtMaSinhVien.TabIndex = 24;
            // 
            // labelMaSV
            // 
            labelMaSV.AutoSize = true;
            labelMaSV.Location = new Point(91, 39);
            labelMaSV.Name = "labelMaSV";
            labelMaSV.Size = new Size(91, 20);
            labelMaSV.TabIndex = 23;
            labelMaSV.Text = "Mã sinh viên";
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(605, 388);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(105, 27);
            btn_Huy.TabIndex = 22;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(477, 388);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(105, 27);
            btn_Luu.TabIndex = 21;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_click;
            // 
            // Form_Update
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
            Controls.Add(btn_Luu);
            Name = "Form_Update";
            Text = "Chỉnh sửa sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MaNganh;
        private CheckBox gtNu;
        private CheckBox gtNam;
        private DateTimePicker NgaySinh;
        private Label label1;
        private TextBox txtGhiChu;
        private Label label5;
        private Label labelNgaySinh;
        private Label labelGT;
        private TextBox txtTen;
        private Label labelTen;
        private TextBox txtHoDem;
        private Label labelHoDem;
        private TextBox txtMaSinhVien;
        private Label labelMaSV;
        private Button btn_Huy;
        private Button btn_Luu;
    }
}