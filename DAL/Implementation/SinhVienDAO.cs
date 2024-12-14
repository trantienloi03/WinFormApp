using Dapper;
using QuanLySinhVienDB.DAL.Service;
using QuanLySinhVienDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDB.DAL.Implementation
{
    public class SinhVienDAO : ISinhVienDAO
    {
        DbConnection GetConnection()
        {
            var cnn = new Microsoft.Data.SqlClient.SqlConnection();
            cnn.ConnectionString = "Server=localhost;Database=ViDuDB;User Id=sa;Password=sa;TrustServerCertificate=True";
            cnn.Open();
            return cnn;
        }
        DbParameter AddParam(DbCommand cmd, string paramName, DbType type, object value)
        {
            DbParameter param = cmd.CreateParameter();
            param.DbType = type;
            param.ParameterName = paramName;
            param.Value = value;

            cmd.Parameters.Add(param);

            return param;
        }
        public int countByName(string name)
        {
            var cnn = GetConnection();

            var sql = "select count(*) from SinhVien where Ten = @PTen";
            var cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            AddParam(cmd,"@PTen", DbType.String, name);

            Object ketqua = cmd.ExecuteScalar();
            int n = (int)ketqua;
            cnn.Close();
            return n;
        }

        public int deleteByID(string id)
        {
            var cnn = GetConnection();
            var sql = "delete from SinhVien where MaSinhVien = @pMaSinhVien";
            var cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            AddParam(cmd, "@pMaSinhVien", DbType.String, id);

            Object ketqua = cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)ketqua;
        }

        public int insert(SinhVien entity)
        {

            var cnn = GetConnection();
            var sql = @"insert into SinhVien(MaSinhVien, HoDem, Ten, GioiTinh, NgaySinh, MaNganhDaoTao, GhiChu ) 
                        values(@MaSinhVien, @HoDem, @Ten, @GioiTinh, @NgaySinh, @MaNganhDaoTao, @GhiChu)";
            var cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            AddParam(cmd, "@MaSinhVien", DbType.String, entity.MaSinhVien);
            AddParam(cmd, "@HoDem", DbType.String, entity.HoDem);
            AddParam(cmd, "@Ten", DbType.String, entity.Ten);
            AddParam(cmd, "@GioiTinh", DbType.Boolean, entity.GioiTinh);
            AddParam(cmd, "@NgaySinh", DbType.DateTime, entity.NgaySinh);
            AddParam(cmd, "@MaNganhDaoTao", DbType.String, entity.MaNganhDaoTao);
            AddParam(cmd, "@GhiChu", DbType.String, entity.GhiChu);

            Object ketqua = cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)ketqua;

        }

        public List<SinhVien> selectAll()
        {
            var cnn = GetConnection();
            string sql = @"
            SELECT MaSinhVien, 
                    HoDem, 
                    Ten, 
                    GioiTinh, 
                    NgaySinh, 
                    GhiChu, 
                    sv.MaNganhDaoTao, 
                    TenNganhDaoTao
            FROM SinhVien sv
                INNER JOIN NganhDaoTao ndt ON ndt.MaNganhDaoTao = sv.MaNganhDaoTao";
            var lst = cnn.Query<SinhVien>(sql).ToList();
            return lst;
        }

        public int updateByID(SinhVien entity)
        {
            var cnn = GetConnection();
            var sql = @"update SinhVien
                        set HoDem = @HoDem,
                            Ten = @Ten,
                            GioiTinh = @GioiTinh,
                            NgaySinh = @NgaySinh,
                            MaNganhDaoTao = @MaNganhDaoTao,
                            GhiChu = @GhiChu
                        where MaSinhVien = @MaSinhVien";
            var cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            AddParam(cmd, "@MaSinhVien", DbType.String, entity.MaSinhVien);
            AddParam(cmd, "@HoDem", DbType.String, entity.HoDem);
            AddParam(cmd, "@Ten", DbType.String, entity.Ten);
            AddParam(cmd, "@GioiTinh", DbType.Boolean, entity.GioiTinh);
            AddParam(cmd, "@NgaySinh", DbType.DateTime, entity.NgaySinh);
            AddParam(cmd, "@MaNganhDaoTao", DbType.String, entity.MaNganhDaoTao);
            AddParam(cmd, "@GhiChu", DbType.String, entity.GhiChu);

            Object ketqua = cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)ketqua;
        }

        public string getMaxID()
        {
            int maxID = 0;
            List<SinhVien> lst = selectAll();
            foreach (SinhVien s in lst)
            {
                if (maxID < Int32.Parse(s.MaSinhVien.Substring(2)))
                {
                    maxID = Int32.Parse(s.MaSinhVien.Substring(2));
                }
            }
            maxID++;
            return "SV" + maxID;
        }
    }
}
