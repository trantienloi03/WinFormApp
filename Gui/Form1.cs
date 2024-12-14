using QuanLySinhVienDB.DAL.Implementation;
using QuanLySinhVienDB.DAL.Service;
using QuanLySinhVienDB.Gui;
using QuanLySinhVienDB.Models;
using System.Data;
using System.Windows.Forms;

namespace QuanLySinhVienDB
{
    public partial class Form1 : Form
    {
        private ISinhVienDAO SinhVienDAO;
        private INganhDaoTao NganhDaoTaoDAO;

        public Form1()
        {
            InitializeComponent();
            SinhVienDAO = Program.GetSinhVienDAO();
            NganhDaoTaoDAO = Program.GetNganhDaoTaoDAO();
        }

        private void btn_NapDanhSach_clcik(object sender, EventArgs e)
        {
            var lst = SinhVienDAO.selectAll();

            bsSinhVien.DataSource = lst;
            GridView.DataSource = bsSinhVien;

            HienThiThongTinThongKe();
        }
        private void HienThiThongTinThongKe()
        {
            lblKetQua.Text = $"Danh sách có {bsSinhVien.Count} sinh viên";
        }

        private void btn_Them_click(object sender, EventArgs e)
        {
            String maSV = SinhVienDAO.getMaxID();
            var frm_Add = new Form_Add(maSV);
            frm_Add.StartPosition = FormStartPosition.CenterParent;
            //frm.Show();
            if (frm_Add.ShowDialog() == DialogResult.OK)
            {
                int n = SinhVienDAO.insert(frm_Add.resutt);
                if (n > 0)
                {
                    MessageBox.Show($"Đã thêm thành công ma sinh viên: {frm_Add.resutt.MaSinhVien}");
                    btn_NapDanhSach_clcik(null, null);
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên không thành công");
                }
            }

        }

        private void btn_Xoa_click(object sender, EventArgs e)
        {
            SinhVien sv = null;
            if (bsSinhVien.Current != null)
                sv = bsSinhVien.Current as SinhVien;
            int n = SinhVienDAO.deleteByID(sv.MaSinhVien);
            if (n > 0)
            {
                MessageBox.Show("Đã xoá thành công");
                btn_NapDanhSach_clcik(null, null);
            }
            else
            {
                MessageBox.Show("Không xoá được sinh viên nào");
            }

        }

        private void btn_Dem_click(object sender, EventArgs e)
        {
            var tuKhoa = txtTuKhoa.Text.Trim();
            int n = SinhVienDAO.countByName(tuKhoa);
            MessageBox.Show(this, "Số lượng sinh viên là " + n, "Thông báo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_NapDanhSach_clcik(null, null);
            btn_NapDS_Nganh_click(null, null);

        }

        private void btn_ChinhSua_click(object sender, EventArgs e)
        {
            var sv = bsSinhVien.Current as SinhVien;
            var frm = new Form_Update(sv);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int n = SinhVienDAO.updateByID(frm.result);
                if (n > 0)
                {
                    MessageBox.Show($"Đã sửa thành công ma sinh viên: {frm.result.MaSinhVien}");
                    btn_NapDanhSach_clcik(null, null);
                }
                else
                {
                    MessageBox.Show("Sửa sinh viên không thành công");
                }

            }
        }

        private void btn_ThongKe_click(object sender, EventArgs e)
        {
            var frm = new Form_NganhDaoTao();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NapDS_Nganh_click(object sender, EventArgs e)
        {
            var lst = NganhDaoTaoDAO.GetAll();
            bsNganh.DataSource = lst;
            GridViewNganhDT.DataSource = bsNganh;
        }
    }
}
