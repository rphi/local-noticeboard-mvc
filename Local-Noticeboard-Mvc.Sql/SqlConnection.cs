using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Noticeboard_Mvc.Sql
{
    public class SqlConnectionBuilder
    {
        public void Main()
        {
            
            var connstring = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost"
            };

            var client = new SqlConnection(connstring.ToString());

        }

        public void SqlCallback(IAsyncResult result)
        {
            var state = result.AsyncState;
        }
        
    }
}
