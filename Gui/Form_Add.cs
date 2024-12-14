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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLySinhVienDB.Gui
{
    public partial class Form_Add : Form
    {
        public SinhVien resutt { get; private set; }

        public Form_Add(string id)
        {
            InitializeComponent();
            txtMaSinhVien.Text = id;
        }

        private void btn_Huy_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_click(object sender, EventArgs e)
        {
            var sv = new SinhVien();
            sv.MaSinhVien = txtMaSinhVien.Text;
            sv.HoDem = txtHoDem.Text;
            sv.Ten = txtTen.Text;

            if (gtNam.Checked)
            {
                sv.GioiTinh = true;
            }
            else
            {
                sv.GioiTinh = false;
            }
            sv.NgaySinh = NgaySinh.Value;
            sv.GhiChu = txtGhiChu.Text;
            if (MaNganh.SelectedItem.ToString().Equals("Công nghệ thông tin"))
                sv.MaNganhDaoTao = "102";
            else
            {
                sv.MaNganhDaoTao = "101";
            }
            
            resutt = sv;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
