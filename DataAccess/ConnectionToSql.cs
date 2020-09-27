using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection("Server=DESKTOP-5EU9LAC; DataBase=Bike_Store; integrated security=true");
        }
    }
}
