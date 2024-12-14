namespace QuanLySinhVienDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btn_NapDanhSach = new ToolStripButton();
            btn_Them = new ToolStripButton();
            btn_Xoa = new ToolStripButton();
            btn_Dem = new ToolStripButton();
            txtTuKhoa = new ToolStripTextBox();
            toolStripButton1 = new ToolStripLabel();
            btn_ChinhSua = new ToolStripButton();
            GridView = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColHoDem = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewCheckBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colTenNganh = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            colMaNganhDaoTao = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblKetQua = new ToolStripStatusLabel();
            bsSinhVien = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            GridViewNganhDT = new DataGridView();
            colMaNganh = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            toolStrip2 = new ToolStrip();
            btn_NapDS_Nganh = new ToolStripButton();
            bsNganh = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridView).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsSinhVien).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewNganhDT).BeginInit();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsNganh).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_NapDanhSach, btn_Them, btn_Xoa, btn_Dem, txtTuKhoa, toolStripButton1, btn_ChinhSua });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(857, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_NapDanhSach
            // 
            btn_NapDanhSach.Image = (Image)resources.GetObject("btn_NapDanhSach.Image");
            btn_NapDanhSach.ImageTransparentColor = Color.Magenta;
            btn_NapDanhSach.Name = "btn_NapDanhSach";
            btn_NapDanhSach.Size = new Size(131, 24);
            btn_NapDanhSach.Text = "Nạp danh sách";
            btn_NapDanhSach.Click += btn_NapDanhSach_clcik;
            // 
            // btn_Them
            // 
            btn_Them.Image = (Image)resources.GetObject("btn_Them.Image");
            btn_Them.ImageTransparentColor = Color.Magenta;
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(70, 24);
            btn_Them.Text = "Thêm";
            btn_Them.Click += btn_Them_click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Image = (Image)resources.GetObject("btn_Xoa.Image");
            btn_Xoa.ImageTransparentColor = Color.Magenta;
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(59, 24);
            btn_Xoa.Text = "Xoa";
            btn_Xoa.Click += btn_Xoa_click;
            // 
            // btn_Dem
            // 
            btn_Dem.Alignment = ToolStripItemAlignment.Right;
            btn_Dem.Image = (Image)resources.GetObject("btn_Dem.Image");
            btn_Dem.ImageAlign = ContentAlignment.TopRight;
            btn_Dem.ImageTransparentColor = Color.Magenta;
            btn_Dem.Name = "btn_Dem";
            btn_Dem.Size = new Size(65, 24);
            btn_Dem.Text = "Dem";
            btn_Dem.Click += btn_Dem_click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Alignment = ToolStripItemAlignment.Right;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(200, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(32, 24);
            toolStripButton1.Text = "Ten";
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Image = (Image)resources.GetObject("btn_ChinhSua.Image");
            btn_ChinhSua.ImageTransparentColor = Color.Magenta;
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(95, 24);
            btn_ChinhSua.Text = "ChinhSưa";
            btn_ChinhSua.Click += btn_ChinhSua_click;
            // 
            // GridView
            // 
            GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView.Columns.AddRange(new DataGridViewColumn[] { ColID, ColHoDem, colTen, colGioiTinh, colNgaySinh, colTenNganh, colGhiChu, colMaNganhDaoTao });
            GridView.Location = new Point(3, 19);
            GridView.Name = "GridView";
            GridView.RowHeadersWidth = 51;
            GridView.Size = new Size(1008, 308);
            GridView.TabIndex = 1;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "MaSinhVien";
            ColID.HeaderText = "Mã sinh viên";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.Width = 125;
            // 
            // ColHoDem
            // 
            ColHoDem.DataPropertyName = "HoDem";
            ColHoDem.HeaderText = "Họ đệm";
            ColHoDem.MinimumWidth = 6;
            ColHoDem.Name = "ColHoDem";
            ColHoDem.Width = 125;
            // 
            // colTen
            // 
            colTen.DataPropertyName = "Ten";
            colTen.HeaderText = "Tên";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            colTen.Width = 125;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.Resizable = DataGridViewTriState.True;
            colGioiTinh.SortMode = DataGridViewColumnSortMode.Automatic;
            colGioiTinh.Width = 80;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.Width = 125;
            // 
            // colTenNganh
            // 
            colTenNganh.DataPropertyName = "TenNganhDaoTao";
            colTenNganh.HeaderText = "Tên ngành";
            colTenNganh.MinimumWidth = 6;
            colTenNganh.Name = "colTenNganh";
            colTenNganh.Width = 125;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            colGhiChu.Width = 125;
            // 
            // colMaNganhDaoTao
            // 
            colMaNganhDaoTao.DataPropertyName = "MaNganhDaoTao";
            colMaNganhDaoTao.HeaderText = "Mã Ngành";
            colMaNganhDaoTao.MinimumWidth = 6;
            colMaNganhDaoTao.Name = "colMaNganhDaoTao";
            colMaNganhDaoTao.Visible = false;
            colMaNganhDaoTao.Width = 125;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblKetQua });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(857, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblKetQua
            // 
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(63, 20);
            lblKetQua.Text = "Kết quả:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(857, 397);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(GridView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(849, 364);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách sinh viên";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GridViewNganhDT);
            tabPage2.Controls.Add(toolStrip2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(849, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ngành đào tạo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridViewNganhDT
            // 
            GridViewNganhDT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewNganhDT.Columns.AddRange(new DataGridViewColumn[] { colMaNganh, dataGridViewTextBoxColumn1, colSoLuong });
            GridViewNganhDT.Location = new Point(8, 33);
            GridViewNganhDT.Name = "GridViewNganhDT";
            GridViewNganhDT.RowHeadersWidth = 51;
            GridViewNganhDT.Size = new Size(841, 268);
            GridViewNganhDT.TabIndex = 3;
            // 
            // colMaNganh
            // 
            colMaNganh.DataPropertyName = "MaNganhDaoTao";
            colMaNganh.HeaderText = "Mã ngành";
            colMaNganh.MinimumWidth = 6;
            colMaNganh.Name = "colMaNganh";
            colMaNganh.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "TenNganhDaoTao";
            dataGridViewTextBoxColumn1.HeaderText = "Tên ngành";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng sinh viên";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btn_NapDS_Nganh });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(843, 27);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            toolStrip2.Click += btn_NapDS_Nganh_click;
            // 
            // btn_NapDS_Nganh
            // 
            btn_NapDS_Nganh.Image = (Image)resources.GetObject("btn_NapDS_Nganh.Image");
            btn_NapDS_Nganh.ImageTransparentColor = Color.Magenta;
            btn_NapDS_Nganh.Name = "btn_NapDS_Nganh";
            btn_NapDS_Nganh.Size = new Size(80, 24);
            btn_NapDS_Nganh.Text = "NapDS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 450);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridView).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsSinhVien).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewNganhDT).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_NapDanhSach;
        private ToolStripButton btn_Them;
        private ToolStripButton btn_Xoa;
        private DataGridView GridView;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblKetQua;
        private ToolStripLabel toolStripButton1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btn_Dem;
        private BindingSource bsSinhVien;
        private ToolStripButton btn_ChinhSua;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColHoDem;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewCheckBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colTenNganh;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colMaNganhDaoTao;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView GridViewNganhDT;
        private ToolStrip toolStrip2;
        private ToolStripButton btn_NapDS_Nganh;
        private BindingSource bsNganh;
        private DataGridViewTextBoxColumn colMaNganh;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colSoLuong;
    }
}
