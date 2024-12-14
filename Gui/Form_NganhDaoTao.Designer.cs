namespace QuanLySinhVienDB.Gui
{
    partial class Form_NganhDaoTao
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NganhDaoTao));
            toolStrip1 = new ToolStrip();
            btn_NapDS_Nganh = new ToolStripButton();
            GridViewNganhDT = new DataGridView();
            colMaNganh = new DataGridViewTextBoxColumn();
            colTenNganh = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            bsNganh = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewNganhDT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNganh).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_NapDS_Nganh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_NapDS_Nganh
            // 
            btn_NapDS_Nganh.Image = (Image)resources.GetObject("btn_NapDS_Nganh.Image");
            btn_NapDS_Nganh.ImageTransparentColor = Color.Magenta;
            btn_NapDS_Nganh.Name = "btn_NapDS_Nganh";
            btn_NapDS_Nganh.Size = new Size(80, 24);
            btn_NapDS_Nganh.Text = "NapDS";
            btn_NapDS_Nganh.Click += btn_NapDS_Nganh_click;
            // 
            // GridViewNganhDT
            // 
            GridViewNganhDT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewNganhDT.Columns.AddRange(new DataGridViewColumn[] { colMaNganh, colTenNganh, colSoLuong });
            GridViewNganhDT.Location = new Point(24, 28);
            GridViewNganhDT.Name = "GridViewNganhDT";
            GridViewNganhDT.RowHeadersWidth = 51;
            GridViewNganhDT.Size = new Size(740, 268);
            GridViewNganhDT.TabIndex = 1;
            // 
            // colMaNganh
            // 
            colMaNganh.DataPropertyName = "MaNganhDaoTao";
            colMaNganh.HeaderText = "Mã ngành";
            colMaNganh.MinimumWidth = 6;
            colMaNganh.Name = "colMaNganh";
            colMaNganh.Width = 125;
            // 
            // colTenNganh
            // 
            colTenNganh.DataPropertyName = "TenNganhDaoTao";
            colTenNganh.HeaderText = "Tên ngành";
            colTenNganh.MinimumWidth = 6;
            colTenNganh.Name = "colTenNganh";
            colTenNganh.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng sinh viên";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // Form_NganhDaoTao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridViewNganhDT);
            Controls.Add(toolStrip1);
            Name = "Form_NganhDaoTao";
            Text = "Form_NganhDaoTao";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewNganhDT).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_NapDS_Nganh;
        private DataGridView GridViewNganhDT;
        private DataGridViewTextBoxColumn colMaNganh;
        private DataGridViewTextBoxColumn colTenNganh;
        private DataGridViewTextBoxColumn colSoLuong;
        private BindingSource bsNganh;
    }
}