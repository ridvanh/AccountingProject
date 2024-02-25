using Microsoft.Data.SqlClient;

namespace DataAccess.Concrete.SQLServer
{
    public class SQLBaseDal
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OtoGaleri;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public SqlConnection conn;
        public SQLBaseDal()
        {
            conn = new SqlConnection(connectionString);
        }
    }
}
