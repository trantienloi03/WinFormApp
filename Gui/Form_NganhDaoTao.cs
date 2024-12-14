using QuanLySinhVienDB.DAL.Service;
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
    public partial class Form_NganhDaoTao : Form
    {
        private INganhDaoTao NganhDaoTaoDAO;
        public Form_NganhDaoTao()
        {
            InitializeComponent();
            NganhDaoTaoDAO = Program.GetNganhDaoTaoDAO();

        }

        private void btn_NapDS_Nganh_click(object sender, EventArgs e)
        {
            var lst = NganhDaoTaoDAO.GetAll();
            bsNganh.DataSource = lst;
            GridViewNganhDT.DataSource = bsNganh;
        }
    }
}
