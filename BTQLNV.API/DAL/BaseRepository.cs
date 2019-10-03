using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=ThanhLNP;Initial Catalog=BTQLNV;Integrated Security=True";
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }
}
