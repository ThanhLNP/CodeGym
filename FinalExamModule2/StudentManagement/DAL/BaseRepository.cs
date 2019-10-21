using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectStr = @"Data Source=ThanhLNP;Initial Catalog=StudentManagement;Integrated Security=True";
            con = new SqlConnection(connectStr);
        }
    }
}
