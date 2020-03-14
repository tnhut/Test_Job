using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Test_Job.DbContent
{
    public class CommandDb
    {
        Connection sq = new Connection();
        SqlCommand le = new SqlCommand();
        public int ExecuteScalar(string name)
        {

           le = new SqlCommand(name, sq.Connect());
           le.CommandType = CommandType.StoredProcedure;
            sq.Connect().Open();
            int n = (int)le.ExecuteScalar();
            sq.Connect().Close();
           
            return n;
        }

        public async void ExecuteNonQueryAsync(string name)
        {
           var op= sq.Connect();
            op.Open();
            le = new SqlCommand(name, op);
            le.CommandType = CommandType.StoredProcedure;
           
            var rows = await le.ExecuteNonQueryAsync();

           // return rows;
        }


    }
}