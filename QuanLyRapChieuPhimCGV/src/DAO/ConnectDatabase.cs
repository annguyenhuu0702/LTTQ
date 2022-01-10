using System.Data.SqlClient;

namespace QuanLyRapChieuPhimCGV.src.DAO
{
    public class ConnectDatabase
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source=TOPXOAN\SQLEXPRESS;Initial Catalog=QLRapChieuPhimCGV;User ID=sa;Password=0384974745");
    }
}
