using System.Data;
using System.Data.SqlClient;

namespace BooksManagement.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectStr = @"Data Source=ThanhLNP;Initial Catalog=BooksManagement;Integrated Security=True";
            con = new SqlConnection(connectStr);
        }
    }
}
