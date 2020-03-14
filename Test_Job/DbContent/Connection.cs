using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Test_Job.DbContent
{
    public class Connection
    {
        public SqlConnection Connect()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CategoryConnection"].ConnectionString);
          //  connection.Open();
            return connection;
        }
        
    }
}