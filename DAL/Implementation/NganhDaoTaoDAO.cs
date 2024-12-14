using Dapper;
using QuanLySinhVienDB.DAL.Service;
using QuanLySinhVienDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDB.DAL.Implementation
{
    public class NganhDaoTaoDAO : INganhDaoTao
    {
        DbConnection GetConnection()
        {
            var cnn = new Microsoft.Data.SqlClient.SqlConnection();
            cnn.ConnectionString = "Server=localhost;Database=ViDuDB;User Id=sa;Password=sa;TrustServerCertificate=True";
            cnn.Open();
            return cnn;
        }
        public List<NganhDaoTao> GetAll()
        {
            var cnn = GetConnection();
            string sql = @"  select ndt.[MaNganhDaoTao],[TenNganhDaoTao], count([MaSinhVien]) as 'SoLuong'
                              from [dbo].[NganhDaoTao] ndt left join [dbo].[SinhVien] sv on ndt.MaNganhDaoTao = sv.MaNganhDaoTao
                              group by ndt.MaNganhDaoTao, TenNganhDaoTao";
            var lst = cnn.Query<NganhDaoTao>(sql).ToList();
            cnn.Close();
            return lst;
        }
    }
}
