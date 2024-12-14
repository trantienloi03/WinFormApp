using QuanLySinhVienDB.DAL.Implementation;
using QuanLySinhVienDB.DAL.Service;

namespace QuanLySinhVienDB.Gui
{
    internal static class Program
    {
        public static ISinhVienDAO GetSinhVienDAO()
        {
            return new SinhVienDAO();
            
        }
        public static INganhDaoTao GetNganhDaoTaoDAO()
        {
            return new NganhDaoTaoDAO();

        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}