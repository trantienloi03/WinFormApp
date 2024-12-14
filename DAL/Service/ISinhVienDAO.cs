using QuanLySinhVienDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDB.DAL.Service
{
    public interface ISinhVienDAO
    {
        public List<SinhVien> selectAll();
        public int deleteByID(String id);
        public int insert(SinhVien entity);
        public int updateByID(SinhVien sv);
        public int countByName(String name);
        public string getMaxID();
    }
}
