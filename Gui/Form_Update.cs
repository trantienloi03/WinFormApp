using QuanLySinhVienDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVienDB.Gui
{
    public partial class Form_Update : Form
    {
        public SinhVien result { get; private set; }
        public Form_Update(SinhVien sv)
        {
            InitializeComponent();
            txtMaSinhVien.Text = sv.MaSinhVien.ToString();
            txtHoDem.Text = sv.HoDem.ToString();
            txtTen.Text = sv.Ten.ToString();
            txtGhiChu.Text = sv.GhiChu.ToString();
            NgaySinh.Value = sv.NgaySinh;
            if (sv.MaNganhDaoTao.Equals("102"))
                MaNganh.SelectedItem = "Công nghệ thông tin";
            else
            {
                MaNganh.SelectedItem = "Điện tử viễn thông";
            }
        }

        private void btn_Luu_click(object sender, EventArgs e)
        {
            var SinhVien = new SinhVien();
            SinhVien.MaSinhVien = txtMaSinhVien.Text;
            SinhVien.HoDem = txtHoDem.Text;
            SinhVien.Ten = txtTen.Text;  
            if (gtNam.Checked)
            {
                SinhVien.GioiTinh = true;
            }
            else
            {
                SinhVien.GioiTinh = false;
            }
            SinhVien.NgaySinh = NgaySinh.Value;
            SinhVien.GhiChu = txtGhiChu.Text;
            if (MaNganh.SelectedItem.ToString().Equals("Công nghệ thông tin"))
                SinhVien.MaNganhDaoTao = "102";
            else
            {
                SinhVien.MaNganhDaoTao = "101";
            }

            result = SinhVien;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btn_Huy_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
