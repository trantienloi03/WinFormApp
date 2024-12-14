using QuanLySinhVienDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDB.DAL.Service
{
    public interface INganhDaoTao
    {
        public List<NganhDaoTao> GetAll();
    }
}
